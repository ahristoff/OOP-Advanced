using System.Text;

namespace _6_Strategy_Pattern
{
    public class Person
    {

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Name} {Age}");

            return sb.ToString().Trim();
        }
    }
}

