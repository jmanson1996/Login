using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int Id_permiso {  get; set; }    
        public Rol oRol  { get; set; } 
        public string Name_menu { get; set; }   
        public string Registration_date { get; set; }
    }
}
