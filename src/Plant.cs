namespace ZooSimulator
{
    public class Plant
    {
        public string Type {  get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Plant(string type, int width, int height, int age)
        {
            Type = type;
            Width = width;
            Height = height;
            Age = age;
        }
    }

    public class TypePlant : Plant
    {
        public char Symbol {  get; set; }
        public TypePlant(string type, int width, int height, int age) : base(type, width, height, age)
        {
            if (type == "Little Bush" || type == "Middle Bush" || type == "Big Bush")
                Symbol = 'o';
            else if (type == "Grass")
                Symbol = '*';
            else
                Symbol = '^';
        }
    }

}
