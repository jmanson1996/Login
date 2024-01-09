using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Buy
    {
        public int Id_buy { get; set; }
        public Users oId_users { get; set; }
        public Suppliers oId_suppliers { get; set; }
        public string Type_documentation { get; set; }
        public string Identification_card { get; set; }
        public decimal Monto_total { get; set; }
        public List <Detail_buy> oDetail_buy { get; set; }
        public string Registration_date { get; set; }
    }
}
