using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sales
    {
        public int Id_sales { get; set; }
        public Users oId_users { get; set; }
        public string type_docmuents { get; set; }
        public string Identification_card { get; set; }
        public string Identification_customers { get; set; }
        public string Full_name_customers { get; set; }
        public decimal Monto_pago { get; set; }
        public int Monto_change { get; set; }
        public decimal Monto_total { get; set; }
        public List<Detail_sales> oDetail_sales { get; set; }
        public string Registration_date { get; set; }
    }
}
