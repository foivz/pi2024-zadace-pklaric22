namespace Studentaste.Models
{
    public class Dish
    {
        public int IdDish { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public ReviewManager ReviewManager { get; set; }
    }
}
