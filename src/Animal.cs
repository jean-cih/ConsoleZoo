namespace ZooSimulator
{
    public class Animal
    {
        private string species;
        private string name;
        private int age;
        private string gender;
        private string habitat;
        private string food;
        private bool isDangerous;
        public string Species {  get; set; }
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Incorrect age");
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if(value.ToLower() == "value" || value.ToLower() == "female")
                    gender = value;
                else
                    Console.WriteLine("Incorrect gender");
            }
        }
        public string Habitat { get; set; }
        public string Food { get; set; }
        public bool IsDangerous { get; set; }

        public Animal(string species, string name, int age, string gender, string habitat, string food, string isDangerous)
        {
            Species = species;
            Name = name;
            Age = age;
            Gender = gender;
            Habitat = habitat;
            Food = food;
            if(isDangerous == "yes")
                IsDangerous = true;
            else
                IsDangerous = false;
        }

        public void MakeSound()
        {

        }

        public void Eat()
        {

        }

        public void Move()
        {

        }
    }
}
