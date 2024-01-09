using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        //damos click derecho en capa de datos /agregar ->references ->ensamblados->y ckeck en System Configuration
        // se  crea para el uso de las clases para
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString(); 
    }
}
