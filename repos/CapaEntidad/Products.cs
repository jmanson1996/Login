using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Products
    {
        public int Id_products { get; set; }
        public int Code { get; set; }
        public string Name_ { get; set; }
        public string Description_ { get; set; }
        public Categories oId_categories { get; set; }
        public int Stock { get; set; }
        public decimal Price_buy { get; set; }
        public decimal Price_sales { get; set; }
        public bool State_ { get; set; }
        public string Registration_date { get; set; }


    }
}
