namespace ZooSimulator
{
    public class TypePlant : Plant
    {
        private int width;
        private int height;
        private char symbol;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("Incorrect the width of the plant");
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    Console.WriteLine("Incorrect the height of the plant");
            }
        }

        public char Symbol => symbol;

        public TypePlant(string type, int width, int height, int age) : base(type, age)
        {
            Width = width;
            Height = height;

            if (type == "Little Bush" || type == "Middle Bush" || type == "Big Bush")
                symbol = 'o';
            else if (type == "Grass")
                symbol = '*';
            else
                symbol = '^';
        }
    }
}
