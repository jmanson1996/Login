using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuario
    //consullta de capa de usuario 
    {
        public List<Users> Listar()
        {
            List<Users> lista = new List<Users>();
            //conexion a la base de datos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                //peticion
                try
                {
                    string query = ("select  Id_user,identification_card,Full_name,Email,Password_,State_ from USERS");
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                   // ejecutar el comando
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    //leer el resultado de nuestro comando
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Users {
                            Id_user= Convert.ToInt32(dr["Id_user"]),
                                Identification_card= dr["Identification_card"].ToString(),
                                Full_name= dr["Full_name"].ToString(),
                                Email= dr["Email"].ToString(),
                                Password = dr["Password_"].ToString(),
                                State_= Convert.ToBoolean(dr["State_"])



                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Users>();

                }
            }
            return lista;
        }
    }
}
