using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Parcial.WindowsForm
{
    static class AccesoDatos
    {
        static SqlCommand command;
        static SqlConnection connection;
        static string connectionString;

        static AccesoDatos()
        {

            connectionString = $"Server={server};Port=3307; Database={db}; User ID=root; Password=; SslMode=none;";

            connectionString = new MySqlConnection(connectionString);
            using (var conexion = connection)
            {
                conexion.Open();
                string query = "SELECT * FROM barcos";
                command = new MySqlCommand(query, conexion);//paso una instancia de una conexion activa (comando que quiero ejecutar y la conexión activa)


            }
        }
        static void Guardar(Barco nuevoBarco)
        {
            using (var conexion = connection)
            {
                conexion.Open();
                string query = "INSERT INTO barcos(nombre,mensaje,alumno)" +
                    $"VALUES(@nombre,@mensaje,@alumno)";
                command = new MySqlCommand(query, conexion);
                //aca se configuran los parametros, todavia no se ejecutan
                command.Parameters.AddWithValue("@nombre", nuevoBarco.Nombre);  //hay q decirle cuales son los parametros q voy a encapsular
                command.Parameters.AddWithValue("@mensaje", nuevoBarco.Mensaje);
                command.Parameters.AddWithValue("@alumno", nuevoBarco.Alumno);

                command.ExecuteNonQuery();
            }
    

        }

    }
}
