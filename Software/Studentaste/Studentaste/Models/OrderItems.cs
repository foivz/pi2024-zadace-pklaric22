using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentaste.Models
{
    public class OrderItems
    {
        public int IdOrderItem { get; set; }
        public int Quantity { get; set; }
        public Orders Order {  get; set; }
        public Dish Dish { get; set; }

    }
}
