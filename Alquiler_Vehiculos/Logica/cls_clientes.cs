using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler_Vehiculos.Datos;

namespace Alquiler_Vehiculos.Logica
{
    public class cls_clientes
    {
        private readonly conexion conexionDB = new conexion();

        public List<dto_clientes> ObtenerClientes()
        {
            List<dto_clientes> listaClientes = new List<dto_clientes>();

            try
            {
                using (SqlConnection con = conexionDB.obtenerConexion())
                {
                    con.Open();
                    string query = "SELECT * FROM Clientes";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listaClientes.Add(new dto_clientes
                            {
                                Id_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Cedula = reader["Cedula"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Email = reader["Email"].ToString(),
                                Direccion = reader["Direccion"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return listaClientes;
        }

        public bool InsertarCliente(string nombre, string apellido, string cedula, string telefono, string email, string direccion)
        {
            // Crear una instancia de la clase conexion
            conexion conexionDB = new conexion();

            using (SqlConnection con = conexionDB.obtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Clientes (Nombre, Apellido, Cedula, Telefono, Email, Direccion) " +
                                   "VALUES (@Nombre, @Apellido, @Cedula, @Telefono, @Email, @Direccion)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Retorna true si se insertó el cliente
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine($"Error al insertar cliente: {ex.Message}");
                    return false;
                }
            }
        }

        public bool ActualizarCliente(int idCliente, string nombre, string apellido, string cedula, string telefono, string email, string direccion)
        {
            using (SqlConnection con = new conexion().obtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, " +
                                   "Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE Id_Cliente = @IdCliente";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar cliente: {ex.Message}");
                    return false;
                }
            }
        }

        public bool EliminarCliente(int idCliente)
        {
            using (SqlConnection con = new conexion().obtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Clientes WHERE Id_Cliente = @IdCliente";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine($"Error al eliminar cliente: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
