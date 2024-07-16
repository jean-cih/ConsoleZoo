namespace ZooSimulator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo("Wild Zoo");
            Enclosure Enclosure = new Enclosure("Natural Zone", 20, 50, "Open");

            Animal lionOne = new Animal("Lion", "Simba", 5, "Male", "Savanna", "Beef", true);
            Animal lionTwo = new Animal("Lion", "Killa", 6, "Female", "Savanna", "Beef", true);
            Animal lionThree = new Animal("Lion", "Appa", 2, "Male", "Savanna", "Beef", true);

            Animal zebraOne = new Animal("Zebra", "Amapola", 2, "Female", "Savanna", "Grass", false);
            Animal zebraTwo = new Animal("Zebra", "Polio", 1, "Male", "Savanna", "Grass", false);

            Plant bushOne = new Plant("Bush", 2, 3, 1);
            Plant bushTwo = new Plant("Bush", 3, 1, 1);
            Plant bushThree = new Plant("Bush", 3, 4, 1);
            Plant bushFour = new Plant("Bush", 2, 2, 1);
            Plant bushFive = new Plant("Bush", 2, 3, 1);
            Plant bushSix = new Plant("Bush", 1, 1, 1);
            Plant bushSeven = new Plant("Bush", 1, 1, 1);
            Plant bushEight = new Plant("Bush", 1, 1, 1);

            Enclosure.AddAnimal(lionOne);
            Enclosure.AddAnimal(lionTwo);
            Enclosure.AddAnimal(lionThree);

            Enclosure.AddAnimal(zebraOne);
            Enclosure.AddAnimal(zebraTwo);

            Enclosure.AddPlant(bushOne);
            Enclosure.AddPlant(bushTwo);
            Enclosure.AddPlant(bushThree);
            Enclosure.AddPlant(bushFour);
            Enclosure.AddPlant(bushFive);
            Enclosure.AddPlant(bushSix);
            Enclosure.AddPlant(bushSeven);
            Enclosure.AddPlant(bushEight);

            myZoo.AddEnclosure(Enclosure);

            Enclosure.FillEnclosure();

            Enclosure.PrintAnimalsList();

            Console.SetWindowSize(200, 49);
            Console.CursorVisible = false;

            Console.ReadLine();
        }

    }
}
