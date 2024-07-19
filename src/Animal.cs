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
                if(value.ToLower() == "male" || value.ToLower() == "female")
                    gender = value;
                else
                    Console.WriteLine("Incorrect gender");
            }
        }
        public string Habitat { get; set; }
        public string Food { get; set; }
        public bool IsDangerous { get; set; } = false;

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
            else if(isDangerous == "no")
                IsDangerous = false;
            else
                Console.WriteLine("Incorrect status");
        }

        public void MakeSound()
        {
            /*
            using (FileStream fileIn = File.OpenRead(@"D:\Music\FuckSleep.mp3"))
            using (FileStream fileOut = File.Create(@"D:\Music\sound.gz"))
            using (GZipStream gz = new GZipStream(fileOut, CompressionLevel.Optimal))
                fileIn.CopyTo(gz);

            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.sound))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Play();
            */

            Console.WriteLine($"This is what a {Species} sounds like");
            SoundPlayer player = new SoundPlayer(@$"D:\Development\C#\ConsoleProjects\ConsoleZooSimulator\src\Resources\{Species}.wav");
            player.Play();
            Console.WriteLine("\nTap any button to stop this sound");
            Console.ReadLine();
            player.Stop();
        }


        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {Food}");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving around the enclosure");
        }
    }
}
