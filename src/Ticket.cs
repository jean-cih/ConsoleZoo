namespace ZooSimulator
{
    public class Ticket
    {
        public string type;
        public decimal price;

        public string Type
        {
            set
            {
                if (value.ToLower() == "children" || value.ToLower() == "adult" || value.ToLower() == "family")
                    type = value;
                else
                    Console.WriteLine("Incorrect type of the ticket");
            }
            get { return type; }
        }

        public Ticket(string type, decimal price)
        {
            Type = type;
            this.price = price;
        }
    }
}
