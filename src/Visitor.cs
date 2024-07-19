using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("Incorrect age");
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

        }

        public void VisitEnclosure(Enclosure enclosure)
        {

        }

        public void ExitZoo()
        {

        }
    }
}
