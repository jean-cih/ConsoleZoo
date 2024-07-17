using System.Threading.Channels;

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

                Instruction instruction = new Instruction();
                instruction.PrintTypeAnimals();
                Console.Write("\t\tSelect all the species you want: ");
                string? speciesQuantity = Console.ReadLine();
                string[] quantityAnimals = speciesQuantity.Split(' ');
                foreach (var singleQuantity in quantityAnimals) 
                {
                    Console.Write($"\tHow much {instruction.Animals[int.Parse(singleQuantity) - 1]} you want in the enclosure: ");
                    int quantityBeast = int.Parse(Console.ReadLine());

                    for (int y = 0; y < quantityBeast; y++)
                    {
                        Console.Write($"\tGive the {y + 1}. {instruction.Animals[int.Parse(singleQuantity) - 1]} a name: ");
                        string? name = Console.ReadLine();
                        Console.Write("\tHow old is they: ");
                        int old = int.Parse(Console.ReadLine());
                        Console.Write("\tWhat gender is they: ");
                        string? gender = Console.ReadLine();
                        Console.Write("\tWhere does they live: ");
                        string? placeLive = Console.ReadLine();
                        Console.Write("\tWhat the type of food does they eats: ");
                        string? food = Console.ReadLine();
                        Console.Write("\tIs they dangerous: ");
                        string? answer = Console.ReadLine();

                        bool isDangerous = false;
                        if (answer.ToLower() == "yes" || answer.ToLower() == "yeah" || answer.ToLower() == "yep")
                            isDangerous = true;

                        Animal animal = new Animal(instruction.Animals[int.Parse(singleQuantity) - 1], name, old, gender, placeLive, food, isDangerous);

                        Enclosure.AddAnimal(animal);

                    }
                }
                        Plant bushOne = new Plant("Bush", 2, 3, 1);
                        Plant bushTwo = new Plant("Bush", 3, 1, 1);
                        Enclosure.AddPlant(bushOne);
                        Enclosure.AddPlant(bushTwo);

                myZoo.AddEnclosure(Enclosure);

                Enclosure.FillEnclosure();

                Enclosure.PrintAnimalsList();
            }

            //Plant bushOne = new Plant("Bush", 2, 3, 1);
            //Plant bushTwo = new Plant("Bush", 3, 1, 1);
            Plant bushThree = new Plant("Bush", 3, 4, 1);
            Plant bushFour = new Plant("Bush", 2, 2, 1);
            Plant bushFive = new Plant("Bush", 2, 3, 1);
            Plant bushSix = new Plant("Bush", 1, 1, 1);
            Plant bushSeven = new Plant("Bush", 1, 1, 1);
            Plant bushEight = new Plant("Bush", 1, 1, 1);

            /*

            Enclosure.AddPlant(bushOne);
            Enclosure.AddPlant(bushTwo); 
            Enclosure.AddPlant(bushThree);
            Enclosure.AddPlant(bushFour);
            Enclosure.AddPlant(bushFive);
            Enclosure.AddPlant(bushSix);
            Enclosure.AddPlant(bushSeven);
            Enclosure.AddPlant(bushEight);
            */


            Console.SetWindowSize(200, 49);
            Console.CursorVisible = false;

            Console.ReadLine();
            Console.ResetColor();
            Console.SetCursorPosition(0, 40);
        }
    }
}
