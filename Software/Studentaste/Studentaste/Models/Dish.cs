using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentaste.Models
{
    internal class Dish
    {
        public int IdDish { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public ReviewManager ReviewManager { get; set; }
    }
}
