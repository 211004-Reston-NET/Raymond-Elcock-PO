namespace Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int CustomerId { get; set; }
        public Review Reviews { get; set; }

        public override string ToString()
        {
            return $"Rating: {Rating}";
        }
    }
}