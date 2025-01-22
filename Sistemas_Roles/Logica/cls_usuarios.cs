using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemas_Roles.Datos;

namespace Sistemas_Roles.Logica
{
    public class cls_usuarios
    {
        public bool InsertarUsuario(string username, string password, char disponibilidad, int roles_id)
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "INSERT INTO Usuarios (Username, Password, Disponibilidad, createAt, updateAt, Roles_id) " +
                                   "VALUES (@username, @password, @disponibilidad, GETDATE(), GETDATE(), @roles_id)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad);
                        cmd.Parameters.AddWithValue("@roles_id", roles_id);

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

        public bool ActualizarUsuario(int id, string username, string password, char disponibilidad, int roles_id)
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "UPDATE Usuarios SET Username = @username, Password = @password, " +
                                   "Disponibilidad = @disponibilidad, updateAt = GETDATE(), Roles_id = @roles_id " +
                                   "WHERE Id_User = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@disponibilidad", disponibilidad);
                        cmd.Parameters.AddWithValue("@roles_id", roles_id);

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

        public bool EliminarUsuario(int id)
        {
            try
            {
                conexion con = new conexion();
                using (SqlConnection connection = con.obtenerConexion())
                {
                    connection.Open();
                    string query = "DELETE FROM Usuarios WHERE Id_User = @id";

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
