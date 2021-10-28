namespace Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int customerId { get; set; }
        public Customers Customers { get; set; }

        public override string ToString()
        {
            return $"Rating: {Rating}";
        }
    }
}