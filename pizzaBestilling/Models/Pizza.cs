namespace pizzaBestilling.Models
{
    public class Pizza
    {
        public PizzaType PizzaType { get; set; }
        public string PizzaTrykkelse { get; set; }
        public int Pris { get; set; }

    }

    public class PizzaType
    {
        public string Type { get; set; }
        public int Pris { get; set; }
        public PizzaType(string Type, int Pris)
        {
            this.Type = Type;
            this.Pris = Pris;
        }
    }
}