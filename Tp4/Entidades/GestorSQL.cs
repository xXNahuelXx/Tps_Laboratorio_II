using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    /// <summary>
    /// Clase que utilizo para traer los datos de los no clientes y o borrarolos, que es solamente telefono, de la base de datos.
    /// </summary>
    public static class GestorSQL
    {

        private static string cadenaConexion;

        static GestorSQL()
        {
            GestorSQL.cadenaConexion = "Server=.;Database=llamadas_noClientes;Trusted_Connection=True;";
        }

        /// <summary>
        /// Metodo que trae todos los numeros de telefono de la tabla NO_CLIENTES de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<string> LeerDatos()
        {

            List<string> telefonos = new List<string>();

            string query = "select * from NO_CLIENTES";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection); 
                connection.Open(); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    string telefono = reader.GetString(0);
                    telefonos.Add(telefono);
                }
            }
            return telefonos;
        }

        /// <summary>
        /// Metodo que borra un numero de telefono de la base de datos.
        /// </summary>
        /// <param name="celular"></param>
        public static void BorrarTelefonoNoCliente(string celular)
        {
            string query = "delete from NO_CLIENTES where celular=@celular";

            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("celular", celular);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
