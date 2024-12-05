namespace Student_Project
{
    class studentClass
    {
        private string name;
        private int age;

        public studentClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value>=1)
                {
                    age = value;
                }
                else
                {
                    Console.Write(" #********# the age should be upper than the 1 year #********# ");
                }
            }
        }


        public void Introduce()
        {
            Console.WriteLine($"Hello , my name is {Name} and I am {Age} years old");
        }
    }
}
