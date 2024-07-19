using System.Runtime.CompilerServices;

namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 49);
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
            for (int w = 0; w < quantity; w++)
            {
                Console.Write($"\tThe Name of {w + 1}. Enclosure: ");
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

                        Animal animal = new Animal(instructionAnimals.Animals[int.Parse(singleQuantity) - 1], name, old, gender, placeLive, food, answer);
                        Enclosure.AddAnimal(animal);
                        Console.Clear();
                        Console.SetCursorPosition(20, 20);
                    }
                }

                Instruction instructionPlants = new Instruction();
                instructionPlants.PrintTypePlants();
                Console.Write("\tSelect all the plants you want: ");
                string? quantityTypes = Console.ReadLine();
                string[] quantityPlants = quantityTypes.Split(' ');
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

                        Plant plant = new Plant(instructionPlants.Plants[int.Parse(singleQuantity) - 1], age);
                        TypePlant typePlant = new TypePlant(instructionPlants.Plants[int.Parse(singleQuantity) - 1], int.Parse(sizePlant[0]), int.Parse(sizePlant[1]), age);
                        Enclosure.AddPlant(typePlant);
                        Console.Clear();
                        Console.SetCursorPosition(20, 20);
                    }
                }

                myZoo.AddEnclosure(Enclosure);

                Enclosure.FillEnclosure();
                for (int q = 0; q < myZoo.Enclosures[w].Plants.Count; q++)
                    Enclosure.PrintPlants(myZoo.Enclosures[w].Plants[q].Symbol);
                Enclosure.PrintAnimal();

                Enclosure.PrintAnimalsList();

                Console.SetCursorPosition(40, 10);
                Console.WriteLine("Tap to continue");
                Console.ReadLine();
                Console.Clear();
            }

            Console.CursorVisible = false;
            Console.Clear();

            ConsoleKeyInfo key;
            int i = 0;
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("Tap Left and Right to go next enclosure");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    i++;
                    if (i > myZoo.Enclosures.Count - 1)
                        i = 0;

                    myZoo.Enclosures[i].FillEnclosure();
                    for (int q = 0; q < myZoo.Enclosures[i].Plants.Count; q++)
                    {
                        Console.SetCursorPosition(20, 20);
                        myZoo.Enclosures[i].PrintPlants(myZoo.Enclosures[i].Plants[q].Symbol);
                    }
                    Console.SetCursorPosition(20, 20);
                    myZoo.Enclosures[i].PrintAnimal();
                    Console.SetCursorPosition(20, 20);
                    myZoo.Enclosures[i].PrintAnimalsList();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    i--;
                    if (i < 0)
                        i = myZoo.Enclosures.Count - 1;

                    myZoo.Enclosures[i].FillEnclosure();
                    for (int q = 0; q < myZoo.Enclosures[i].Plants.Count; q++)
                        myZoo.Enclosures[i].PrintPlants(myZoo.Enclosures[i].Plants[q].Symbol);
                    myZoo.Enclosures[i].PrintAnimal();
                    myZoo.Enclosures[i].PrintAnimalsList();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("You've left the program");
                    break;
                }
                else if (key.Key == ConsoleKey.M)
                {
                    Console.WriteLine("\t\tMenu");
                    for(int l = 0; l < myZoo.Enclosures[i].Animals.Count; l++)
                        Console.Write($" {l + 1} {myZoo.Enclosures[i].Animals[l].Species}");

                    int sound;
                    while (true)
                    {
                        sound = int.Parse(Console.ReadLine());
                        if (sound < 1 || sound > myZoo.Enclosures[i].Animals.Count)
                        {
                            Console.WriteLine("You've left the sound menu");
                            break;
                        }
                        myZoo.Enclosures[i].Animals[sound - 1].MakeSound();
                        
                    }
                    
                }

            }

            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
