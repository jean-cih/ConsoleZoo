namespace ZooSimulator
{
    public class Enclosure
    {
        public string? Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Type { get; set; }
        public List<Animal>? Animals { get; set; }
        public List<Plant> Plants { get; set; }

        public Enclosure(string name, int width, int height, string type)
        {
            if (type.ToLower() == "open" || type.ToLower() == "close" || type.ToLower() == "aquarium")
            {
                Name = name;
                Width = width;
                Height = height;
                Type = type;
                Animals = new List<Animal>();
                Plants = new List<Plant>();
            }
            else
                Console.WriteLine("This type doesn't exist");
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine($"The {animal.Species} is added to {Name}");
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
            Console.WriteLine($"The Animal {animal.Species} is removed to {Name}");
        }
        public void AddPlant(Plant plant)
        {
            Plants.Add(plant);
            Console.WriteLine($"The {plant.Type} is added to {Name}");
        }

        public void RemovePlant(Plant plant)
        {
            Plants.Remove(plant);
            Console.WriteLine($"The {plant.Type} is removed to {Name}");
        }

        public void PrintAnimalsList() 
        {
            Console.SetCursorPosition(55, 52);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("There are animals at the Zoo now:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.SetCursorPosition(64, 54 + i);
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
            PrintPlants();
            PrintAnimal();
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


        public void PrintPlants()
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
                        Console.SetCursorPosition(j + positionY, i + positionX + 6 * Animals.Count + 4 * Plants.Count + 20);
                        Console.Write('o');
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

                Console.SetCursorPosition(positionY, positionX + 6 * Animals.Count + 4 * Plants.Count + 20);
                Console.Write(Animals[k].Species[0]);
            }
        }
    }
}
