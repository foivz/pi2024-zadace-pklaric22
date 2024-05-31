using System;

namespace Studentaste.Models
{
    public class Reviews
    {
        public int IdReview { get; set; }
        public int TasteRating { get; set; }
        public int QuantityRating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public Student Student { get; set; }
        public Dish Dishes { get; set; }
        public Orders Orders { get; set; }
    }

}
