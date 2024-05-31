namespace Studentaste.Models
{
    public class OrderItems
    {
        public int IdOrderItem { get; set; }
        public int Quantity { get; set; }
        public Orders Order { get; set; }
        public Dish Dish { get; set; }

    }
}
