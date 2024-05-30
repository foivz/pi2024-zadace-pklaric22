using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentaste.Models
{
    internal class Orders
    {
        public int IdOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }
        public Student Student { get; set; }

    }
}
