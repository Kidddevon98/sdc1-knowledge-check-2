namespace Sdc1KnowledgeCheck2
{
    public class Base
    {
        public string? Name { get; set; } // Nullable property
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; } // Nullable property

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
        }
    }
}
