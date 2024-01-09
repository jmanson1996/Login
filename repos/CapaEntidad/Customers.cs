using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Customers
    {
        public int Id_customers { get; set; }
        public string Identification_card { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool State { get; set; }
        public string Registration_date { get; set; }
    }
}
