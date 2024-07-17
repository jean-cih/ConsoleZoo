using System.Xml;

namespace ZooSimulator
{
    public class Instruction
    {
        public string[] Animals = new string[] { "Lion", "Zebra", "Elephant", "Cheetah", "Tiger", "Platypus", "Bear", "Ape", "Shark", "Tuna", "Turtle", "Penguin" };
        public string[] Plants = new string[] { "Little Bush", "Middle Bush", "Big Bush", "Grass", "Little Tree", "Middle Tree", "Big Tree" };
        public void PrintTypeAnimals()
        {

            Console.Write("\n\t\t\tThe Species of Animals for the enclosure");

            for (int j = 1; j <= Animals.Length; j++)
            {
                if (j == Animals.Length / 2 + 1 || j == 1)
                {
                    Console.Write("\n\t");
                    for (int l = 0; l < 67; l++)
                        Console.Write('-');
                    Console.Write("\n\t");
                }
                Console.Write($" {j}. {Animals[j - 1]} ");
            }
            Console.Write("\n\t");
            for (int j = 0; j < 67; j++)
                Console.Write('-');
            Console.WriteLine();
        }

        public void PrintTypePlants()
        {
            Console.Write("\n\t\tThe Type of Plants for the enclosure");

            for (int j = 1; j <= Plants.Length; j++)
            {
                if (j == Plants.Length / 2 + 2 || j == 1)
                {
                    Console.Write("\n\t");
                    for (int l = 0; l < 55; l++)
                        Console.Write('-');
                    Console.Write("\n\t");
                }
                Console.Write($" {j}. {Plants[j - 1]} ");
            }
            Console.Write("\n\t");
            for (int j = 0; j < 55; j++)
                Console.Write('-');
            Console.WriteLine();
        }
    }
}
