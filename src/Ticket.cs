namespace ZooSimulator
{
    public class Ticket
    {
        private string type;
        private decimal price;

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

        public decimal Price { get; set; }

        public Ticket(string type, decimal price)
        {
            Type = type;
            Price = price;
        }
    }
}
