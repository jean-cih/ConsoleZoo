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
                    Console.WriteLine("\t\u001b[31mToo little width of the enclosure");
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
                    Console.WriteLine("\t\u001b[31mToo little height of the enclosure");
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
                    Console.WriteLine("\t\u001b[31mIncorrect type of the enclosure");
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
            Console.WriteLine($"\t\u001b[31mThe {animal.Species} is added to {Name}\n");
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
            Console.WriteLine($"\t\u001b[31mThe Animal {animal.Species} is removed to {Name}\n");
        }
        public void AddPlant(TypePlant plant)
        {
            Plants.Add(plant);
            Console.WriteLine($"\t\u001b[31mThe {plant.Type} is added to {Name}\n");
        }

        public void RemovePlant(TypePlant plant)
        {
            Plants.Remove(plant);
            Console.WriteLine($"\t\u001b[31mThe {plant.Type} is removed to {Name}\n");
        }

        public void PrintAnimalsList() 
        {
            Console.SetCursorPosition(Width + 5, Height);
            Console.WriteLine("\u001b[31mThere are animals at the Zoo now:");
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.SetCursorPosition(Width + 15, Height + 2 + i);
                Console.WriteLine($"\u001b[31m{i + 1}. {Animals[i].Species} - {Animals[i].Name}");
            }
        }

        public void FillEnclosure()
        {
            char[,] enclosure = new char[Height, Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Height - 1)
                        enclosure[i, j] = '#';
                    else if (j == 0 || j == Width - 1)
                        enclosure[i, j] = '#';
                    else
                        enclosure[i, j] = ' ';
                }
            }

            PrintEnclosure(enclosure);  
        }

        public void PrintEnclosure(char[,] enclosure)
        {
            Console.SetCursorPosition(2 + Width / 2, Height - 1);
            Console.WriteLine($"\u001b[31m{Name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {

                    Console.SetCursorPosition(4 + j, Height + i);
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

                for (int i = 0; i < Plants[k].Height; i++)
                {
                    for (int j = 0; j < Plants[k].Width; j++)
                    {
                        Console.SetCursorPosition(j + positionX + 4, i + positionY + Height);
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int k = 0; k < Animals.Count; k++)
            {
                Random rand = new Random();
                int positionX = rand.Next(1, Width - 1);
                int positionY = rand.Next(1, Height - 1);


                Console.SetCursorPosition(positionX + 4, positionY + Height);
                Console.Write(Animals[k].Species[0]);
            }

            Console.SetCursorPosition(8, 2 * Height);
        }
    }
}