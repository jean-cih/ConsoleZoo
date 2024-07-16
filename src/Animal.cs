namespace ZooSimulator
{
    public class Animal
    {
        public string Species {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Habitat { get; set; }
        public string Food { get; set; }
        public bool IsDangerous { get; set; }

        public Animal(string species, string name, int age, string gender, string habitat, string food, bool isDangerous)
        {
            Species = species;
            Name = name;
            Age = age;
            Gender = gender;
            Habitat = habitat;
            Food = food;
            IsDangerous = isDangerous;
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
