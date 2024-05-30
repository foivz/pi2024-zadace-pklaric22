using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentaste.Models
{
    public class Orders
    {
        public int IdOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Student Student { get; set; }


        public string StudentUsername
        {
            get
            {
                return Student != null ? Student.Username : "N/A";
            }
        }
    }
}
