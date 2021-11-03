namespace Models
{
    public class Replenish
    {
        public int Id { get; set; }
        public int Inventory { get; set; }
        public int InventoryId { get; set; }
       // public Replenish Replenish { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nRating: {Inventory}";
        }
    }
}