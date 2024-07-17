namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("\t\t\t\t--------------------------" +
                "\n\t------------------------|      Zoo Simulator     |-----------------------\n" +
                "\t\t\t\t--------------------------");

            Console.Write("\tThe Name of your Zoo: ");
            string? nameZoo = Console.ReadLine();
            Zoo myZoo = new Zoo(nameZoo);
            Console.Write($"\tHow much types of enclosures will be in {nameZoo}: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\tCreate Enclosures for animals");
            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"\tThe Name of {i}. Enclosure: ");
                string enclosure = Console.ReadLine();
                Console.Write("\tInput width and length of the enclosure: ");
                string widthAndHeight = Console.ReadLine();
                string[] size = widthAndHeight.Split(' ');
                Console.WriteLine("\n\tThe Type of the enclosure\n" +
                    "\t---------------------------" +
                    "\n\t| Open | Close | Aquarium |\n" +
                    "\t---------------------------");
                Console.Write("\tEnter the Type: ");
                string type = Console.ReadLine();

                Enclosure Enclosure = new Enclosure(enclosure, int.Parse(size[0]), int.Parse(size[1]), type);

                Instruction instructionAnimals = new Instruction();
                instructionAnimals.PrintTypeAnimals();
                Console.Write("\tSelect all the species you want: ");
                string? speciesQuantity = Console.ReadLine();
                string[] quantityAnimals = speciesQuantity.Split(' ');
                foreach (var singleQuantity in quantityAnimals) 
                {
                    Console.Write($"\tHow much {instructionAnimals.Animals[int.Parse(singleQuantity) - 1]} you want in the enclosure: ");
                    int quantityBeast = int.Parse(Console.ReadLine());

                    for (int y = 0; y < quantityBeast; y++)
                    {
                        Console.Write($"\tGive the {y + 1}. {instructionAnimals.Animals[int.Parse(singleQuantity) - 1]} a name: ");
                        string? name = Console.ReadLine();
                        Console.Write("\tHow old is they: ");
                        int old = int.Parse(Console.ReadLine());
                        Console.Write("\tWhat gender is they male/female: ");
                        string? gender = Console.ReadLine();
                        Console.Write("\tWhere does they live: ");
                        string? placeLive = Console.ReadLine();
                        Console.Write("\tWhat the type of food does they eats: ");
                        string? food = Console.ReadLine();
                        Console.Write("\tIs they dangerous yes/no: ");
                        string? answer = Console.ReadLine();

                        bool isDangerous = false;
                        if (answer.ToLower() == "yes")
                            isDangerous = true;

                        Animal animal = new Animal(instructionAnimals.Animals[int.Parse(singleQuantity) - 1], name, old, gender, placeLive, food, isDangerous);

                        Enclosure.AddAnimal(animal);

                    }
                }

                Instruction instructionPlants = new Instruction();
                instructionPlants.PrintTypePlants();
                Console.Write("\tSelect all the plants you want: ");
                string? quantityTypes = Console.ReadLine();
                string[] quantityPlants = quantityTypes.Split(' ');
                string symbolsPlants = "";
                foreach (var singleQuantity in quantityPlants)
                {
                    Console.Write($"\tHow much {instructionPlants.Plants[int.Parse(singleQuantity) - 1]} you want in the enclosure: ");
                    int quantityGreen = int.Parse(Console.ReadLine());

                    for (int y = 0; y < quantityGreen; y++)
                    {
                        Console.Write("\tSize of the plant: ");
                        string widthAndHeightPlant = Console.ReadLine();
                        string[] sizePlant = widthAndHeightPlant.Split(' ');
                        Console.Write("\tAge of the plant: ");
                        int age = int.Parse(Console.ReadLine());

                        Plant plant = new Plant(instructionPlants.Plants[int.Parse(singleQuantity) - 1], int.Parse(sizePlant[0]), int.Parse(sizePlant[1]), age);
                        TypePlant typePlant = new TypePlant(instructionPlants.Plants[int.Parse(singleQuantity) - 1], int.Parse(sizePlant[0]), int.Parse(sizePlant[1]), age);
                        symbolsPlants += typePlant.Symbol;
                        Enclosure.AddPlant(plant);
                    }
                }

                myZoo.AddEnclosure(Enclosure);

                Enclosure.FillEnclosure();
                for(int q = 0; q < symbolsPlants.Length; q++)
                    Enclosure.PrintPlants(symbolsPlants[q]);
                Enclosure.PrintAnimal();

                Enclosure.PrintAnimalsList();
            }

            Console.SetWindowSize(200, 49);
            Console.CursorVisible = false;

            Console.ReadLine();
            Console.ResetColor();
            Console.SetCursorPosition(0, 40);
        }
    }
}
