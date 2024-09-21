namespace Sdc1KnowledgeCheck2
{
    public class Child : Base  // Assuming Child inherits from Base
    {
        public bool KittenFood { get; set; }  // Adding this property

        public override string ToString()
        {
            return $"{Name}, {Description}, {Price}, {Quantity}, KittenFood: {KittenFood}";
        }
    }
}
