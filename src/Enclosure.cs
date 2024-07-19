namespace ZooSimulator
{
    public class Enclosure
    {
        private string name;
        private int width;
        private int height;
        private string type;

        public string Name { get; set; }
        public int Width
        {
            get { return width; }
            set
            {
                if(value >= 10)
                    width = value;
                else
                    Console.WriteLine("Too little width of the enclosure");
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value >= 10)
                    height = value;
                else
                    Console.WriteLine("Too little height of the enclosure");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if(value.ToLower() == "open" || value.ToLower() == "close" || value.ToLower() == "aquarium")
                    type = value;
                else
                    Console.WriteLine("Incorrect type of the enclosure");
            }
        }
        public List<Animal>? Animals { get; set; }
        public List<TypePlant> Plants { get; set; }

        public Enclosure(string name, int width, int height, string type)
        {
            Name = name;
            Width = width;
            Height = height;
            Type = type;
            Animals = new List<Animal>();
            Plants = new List<TypePlant>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine($"\tThe {animal.Species} is added to {Name}");
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
            Console.WriteLine($"\tThe Animal {animal.Species} is removed to {Name}");
        }
        public void AddPlant(TypePlant plant)
        {
            Plants.Add(plant);
            Console.WriteLine($"\tThe {plant.Type} is added to {Name}");
        }

        public void RemovePlant(TypePlant plant)
        {
            Plants.Remove(plant);
            Console.WriteLine($"\tThe {plant.Type} is removed to {Name}");
        }

        public void PrintAnimalsList() 
        {
            Console.SetCursorPosition(55, Width + 5);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("There are animals at the Zoo now:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.SetCursorPosition(64, Width + 7 + i);
                Console.WriteLine($"{i + 1}. {Animals[i].Species} - {Animals[i].Name}");
            }
        }

        public void FillEnclosure()
        {
            char[,] enclosure = new char[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i == 0 || i == Width - 1)
                        enclosure[i, j] = '#';
                    else if (j == 0 || j == Height - 1)
                        enclosure[i, j] = '#';
                    else
                        enclosure[i, j] = ' ';
                }
            }

            PrintEnclosure(enclosure);  
        }

        public void PrintEnclosure(char[,] enclosure)
        {
            Console.WriteLine($"\t\t{Name}");
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (enclosure[i, j] == '#')
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    else
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(enclosure[i, j]);
                }
                Console.WriteLine();
            }
        }


        public void PrintPlants(char symbol)
        {
            for (int k = 0; k < Plants.Count; k++)
            {
                Random rand = new Random();
                int positionX = rand.Next(1, Width - Plants[k].Width);
                int positionY = rand.Next(1, Height - Plants[k].Height);

                Console.ForegroundColor = ConsoleColor.Green;

                for (int i = 0; i < Plants[k].Width; i++)
                {
                    for (int j = 0; j < Plants[k].Height; j++)
                    {
                        Console.SetCursorPosition(j + positionY, i + positionX + Animals.Count + Plants.Count);
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void PrintAnimal()
        {
            for (int k = 0; k < Animals.Count; k++)
            {
                Random rand = new Random();
                int positionX = rand.Next(1, Width - 1);
                int positionY = rand.Next(1, Height - 1);

                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(positionY, positionX + Animals.Count + Plants.Count);
                Console.Write(Animals[k].Species[0]);
            }
        }
    }
}
