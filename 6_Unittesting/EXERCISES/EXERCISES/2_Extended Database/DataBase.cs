using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Extended_Database
{   
    public class Database
    {
        private HashSet<IPerson> people;

        public Database()
        {
            this.people = new HashSet<IPerson>();
        }

        public Database(IEnumerable<IPerson> people)
            : this()
        {
            if (people != null)
            {
                foreach (var x in people)
                {
                    this.people.Add(x);
                }
            }
            //this.people = people.ToHashSet();
        }

        public int Count => this.people.Count;

        public void Add(IPerson person)
        {
            if (this.people.Any(p => p.Id == person.Id || p.Username == person.Username))
            {
                throw new InvalidOperationException();
            }

            this.people.Add(person);
        }

        public void Remove(IPerson person)
        {            
            this.people.Remove(person);
        }

        public IPerson FindId(long id)
        {

            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var foundPerson = this.people.FirstOrDefault(p => p.Id == id);
            if (foundPerson == null)
            {
                throw new InvalidOperationException();
            }

            return foundPerson;
        }

        public IPerson FindUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException();
            }

            var foundPerson = this.people.FirstOrDefault(p => p.Username == username);
            if (foundPerson == null)
            {
                throw new InvalidOperationException();
            }

            return foundPerson;
        }
    }
}
