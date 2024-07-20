namespace ZooSimulator
{
    public class Plant
    {
        private string type;
        private int age;
        public string Type 
        { 
            get { return type; } 
            set
            {
                if (value.Contains("Bush") || value.Contains("Tree") || value == "Grass")
                    type = value;
                else
                    Console.WriteLine("\t\u001b[31mThis Plant doesn't exist");
            } 
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("\t\u001b[31mIncorrect age");
            }
        }

        public Plant(string type, int age)
        {
            Type = type;
            Age = age;
        }
    }
}
