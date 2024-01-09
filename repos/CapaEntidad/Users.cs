using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Users
    {
        public int Id_user { get; set; }
        public string Identification_card { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Rol oId_rol { get; set; }
        public bool State_ { get; set; }
        public string Registration_date { get; set; }
    }
}
