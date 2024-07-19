using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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
                    Console.WriteLine("This Plant doesn't exist");
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
                    Console.WriteLine("Incorrect age");
            }
        }

        public Plant(string type, int age)
        {
            Type = type;
            Age = age;
        }
    }
}
