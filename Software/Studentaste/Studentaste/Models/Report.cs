using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentaste.Models
{
    public class Report
    {
        public int IdReport { get; set; }
        public DateTime CreationDate { get; set; }
        public string   DishLowestName { get; set; }
        public float LowestRating { get; set; }
        public float HighestRating  { get; set; }
        public ReviewManager ReviewManager { get; set; }

    }
}
