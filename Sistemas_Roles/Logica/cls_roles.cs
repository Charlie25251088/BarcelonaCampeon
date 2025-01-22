using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemas_Roles.Datos;

namespace Sistemas_Roles.Logica
{
    public class cls_roles
    {
        public bool InsertarRol(string detalle)
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "INSERT INTO Roles (Detalle) VALUES (@detalle)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@detalle", detalle);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarRol(int id, string detalle)
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "UPDATE Roles SET Detalle = @detalle WHERE Rol_Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@detalle", detalle);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool EliminarRol(int id)
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "DELETE FROM Roles WHERE Rol_Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
