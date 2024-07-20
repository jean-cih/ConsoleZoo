using System.Runtime.CompilerServices;

namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(200, 49);
            Console.SetCursorPosition(0, 1);
            Instruction instruction = new Instruction();
            instruction.Caption();
            Console.Write("\t\u001b[31mThe Name of your Zoo: \u001b[30m");
            string? nameZoo = Console.ReadLine();
            Zoo myZoo = new Zoo(nameZoo);
            Console.Write($"\t\u001b[31mHow much types of enclosures will be in {nameZoo}: \u001b[30m");
            int quantity = int.Parse(Console.ReadLine());
            for (int w = 0; w < quantity; w++)
            {
                Console.Write($"\t\u001b[31mThe Name of {w + 1}. Enclosure: \u001b[30m");
                string enclosure = Console.ReadLine();
                Console.Write("\t\u001b[31mInput width and length of the enclosure: \u001b[30m");
                string widthAndHeight = Console.ReadLine();
                string[] size = widthAndHeight.Split(' ');
                instruction.PrintTableType();
                Console.Write("\t\u001b[31mEnter the Type: \u001b[30m");
                string type = Console.ReadLine();

                Enclosure Enclosure = new Enclosure(enclosure, int.Parse(size[0]), int.Parse(size[1]), type);

                
                instruction.PrintTypeAnimals();
                Console.Write("\t\u001b[31mSelect all the species you want: \u001b[30m");
                string? speciesQuantity = Console.ReadLine();
                string[] quantityAnimals = speciesQuantity.Split(' ');
                foreach (var singleQuantity in quantityAnimals) 
                {
                    Console.Write($"\n\t\u001b[31mHow much {instruction.Animals[int.Parse(singleQuantity) - 1]} you want in the enclosure: \u001b[30m");
                    int quantityBeast = int.Parse(Console.ReadLine());

                    for (int y = 0; y < quantityBeast; y++)
                    {
                        Console.Write($"\t\u001b[31mGive the {y + 1}. {instruction.Animals[int.Parse(singleQuantity) - 1]} a name: \u001b[30m");
                        string? name = Console.ReadLine();
                        Console.Write("\t\u001b[31mHow old is they: \u001b[30m");
                        int old = int.Parse(Console.ReadLine());
                        Console.Write("\t\u001b[31mWhat gender is they male/female: \u001b[30m");
                        string? gender = Console.ReadLine();
                        Console.Write("\t\u001b[31mWhere does they live: \u001b[30m");
                        string? placeLive = Console.ReadLine();
                        Console.Write("\t\u001b[31mWhat the type of food does they eats: \u001b[30m");
                        string? food = Console.ReadLine();
                        Console.Write("\t\u001b[31mIs they dangerous yes/no: \u001b[30m");
                        string? answer = Console.ReadLine();

                        Animal animal = new Animal(instruction.Animals[int.Parse(singleQuantity) - 1], name, old, gender, placeLive, food, answer);
                        Enclosure.AddAnimal(animal);

                    }
                }
                Console.ReadLine();
                Console.Clear();
                instruction.PrintTypePlants();
                Console.Write("\t\u001b[31mSelect all the plants you want: \u001b[30m");
                string? quantityTypes = Console.ReadLine();
                string[] quantityPlants = quantityTypes.Split(' ');
                foreach (var singleQuantity in quantityPlants)
                {
                    Console.Write($"\n\t\u001b[31mHow much {instruction.Plants[int.Parse(singleQuantity) - 1]} you want in the enclosure: \u001b[30m");
                    int quantityGreen = int.Parse(Console.ReadLine());

                    for (int y = 0; y < quantityGreen; y++)
                    {
                        Console.Write("\t\u001b[31mSize of the plant: \u001b[30m");
                        string widthAndHeightPlant = Console.ReadLine();
                        string[] sizePlant = widthAndHeightPlant.Split(' ');
                        Console.Write("\t\u001b[31mAge of the plant: \u001b[30m");
                        int age = int.Parse(Console.ReadLine());

                        Plant plant = new Plant(instruction.Plants[int.Parse(singleQuantity) - 1], age);
                        TypePlant typePlant = new TypePlant(instruction.Plants[int.Parse(singleQuantity) - 1], int.Parse(sizePlant[0]), int.Parse(sizePlant[1]), age);
                        Enclosure.AddPlant(typePlant);
                    }
                }
                Console.ReadLine();
                Console.Clear();
                myZoo.AddEnclosure(Enclosure);

                Enclosure.PrintAnimalsList();
                Enclosure.FillEnclosure();
                for (int q = 0; q < myZoo.Enclosures[w].Plants.Count; q++)
                    Enclosure.PrintPlants(myZoo.Enclosures[w].Plants[q].Symbol);
                Enclosure.PrintAnimal();

                Console.WriteLine("\t\u001b[31mTap to continue");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(4, 5);
            }

            Console.CursorVisible = false;
            Console.Clear();

            ConsoleKeyInfo key;
            int i = 0;
            while (true)
            {
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("\u001b[31mTap Left and Right to go next enclosure");
                key = Console.ReadKey();
                Console.Clear();
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
                    Console.WriteLine("\u001b[31mYou've left the program");
                    break;
                }
                else if (key.Key == ConsoleKey.M)
                {
                    Console.WriteLine("\t\t\u001b[31mMenu");
                    for(int l = 0; l < myZoo.Enclosures[i].Animals.Count; l++)
                        Console.Write($" {l + 1} {myZoo.Enclosures[i].Animals[l].Species}");

                    int sound;
                    while (true)
                    {
                        sound = int.Parse(Console.ReadLine());
                        if (sound < 1 || sound > myZoo.Enclosures[i].Animals.Count)
                        {
                            Console.WriteLine("\u001b[31mYou've left the sound menu");
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