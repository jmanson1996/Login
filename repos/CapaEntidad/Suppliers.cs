using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Suppliers
    {
        public int Id_suppliers { get; set;  }
  public string Identification_card {  get; set; }  
        public string Razon_social { get; set; }    
        public string Email {  get; set; }
        public string Phone { get; set; }
        public bool State_ {  get; set; }
        public string Registration_date { get; set; }
    }
}
