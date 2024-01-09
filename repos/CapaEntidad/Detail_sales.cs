using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detail_sales
    {
        public int Id_detail_sales { get; set; }
        public Products oId_products { get; set; }
        public decimal Price_sales { get; set; }
        public int Amount { get; set; }
        public decimal Subtotal { get; set; }
        public string Registration_date { get; set; }
    }
}
