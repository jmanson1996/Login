using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detail_buy
    {
        public int Id_detail_buy { get; set; }
        public Products oId_products { get; set; }
        public decimal Price_buy { get; set; }
        public decimal Price_sales { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
        public string Registration_date { get; set; }
    }
}
