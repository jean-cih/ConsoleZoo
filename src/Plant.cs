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
}
