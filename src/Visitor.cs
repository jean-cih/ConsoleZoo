namespace ZooSimulator
{
    public class Visitor
    {
        private string name;
        private int age;
        private Ticket ticket;

        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if(value > 0)
                    age = value;
                else
                    Console.WriteLine("\t\u001b[31mIncorrect age");
            }
        }

        public Ticket Ticket { get; set; }

        public Visitor(string name, int age, Ticket ticket)
        {
            Name = name;
            Age = age;
            Ticket = ticket;
        }

        public void EnterZoo()
        {
            Console.WriteLine($"\t\u001b[31m{Name} entered the enclosure");
        }

        public void VisitEnclosure(Enclosure enclosure)
        {
            Console.WriteLine($"\t\u001b[31m{Name} visited the enclosure");
        }

        public void ExitZoo()
        {
            Console.WriteLine($"\t\u001b[31m {Name} left the enclosure");
        }
    }
}
