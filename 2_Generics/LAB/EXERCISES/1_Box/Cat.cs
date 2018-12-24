
namespace _1_Box
{
    class Cat : ICat
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"I'm a Cat {Name}";
        }
    }
}

