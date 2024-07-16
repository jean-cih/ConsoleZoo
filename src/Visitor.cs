using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator
{
    public class Visitor
    {
        public string? name;
        public int age;
        public Ticket? ticket;

        public Visitor(string? name, int age, Ticket? ticket)
        {
            this.name = name;
            this.age = age;
            this.ticket = ticket;
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
