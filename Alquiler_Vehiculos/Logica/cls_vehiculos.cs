using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alquiler_Vehiculos.Datos;
using Alquiler_Vehiculos.Logica;

namespace Alquiler_Vehiculos.Logica
{
    public class cls_vehiculos
    {
        private readonly conexion conexionDB = new conexion();

        // Obtener todos los vehículos
        public List<dto_vehiculos> ObtenerVehiculos()
        {
            List<dto_vehiculos> listaVehiculos = new List<dto_vehiculos>();

            try
            {
                using (SqlConnection con = conexionDB.obtenerConexion())
                {
                    con.Open();
                    string query = "SELECT * FROM Vehiculos";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listaVehiculos.Add(new dto_vehiculos
                            {
                                Id_Vehiculo = Convert.ToInt32(reader["Id_Vehiculo"]),
                                Marca = reader["Marca"].ToString(),
                                Modelo = reader["Modelo"].ToString(),
                                Anio = Convert.ToInt32(reader["Anio"]),
                                Precio = Convert.ToDecimal(reader["Precio_Dia"]),
                                Estado = reader["Estado"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return listaVehiculos;
        }

        // Insertar un vehículo
        public bool InsertarVehiculo(string marca, string modelo, int anio, decimal precio, string estado)
        {
            try
            {
                using (SqlConnection con = conexionDB.obtenerConexion())
                {
                    con.Open();
                    string query = "INSERT INTO Vehiculos (Marca, Modelo, Anio, Precio_Dia, Estado) VALUES (@Marca, @Modelo, @Anio, @Precio, @Estado)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Marca", marca);
                        cmd.Parameters.AddWithValue("@Modelo", modelo);
                        cmd.Parameters.AddWithValue("@Anio", anio);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar vehículo: {ex.Message}");
                return false;
            }
        }

        // Actualizar un vehículo
        public bool ActualizarVehiculo(int Id_Vehiculo, string Marca, string Modelo, int Anio, decimal Precio, string Estado)
        {
            using (SqlConnection con = conexionDB.obtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Vehiculos SET Marca = @Marca, Modelo = @Modelo, Anio = @Anio, Precio_Dia = @Precio_Dia, Estado = @Estado WHERE Id_Vehiculo = @IdVehiculo";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdVehiculo", Id_Vehiculo);
                        cmd.Parameters.AddWithValue("@Marca", Marca);
                        cmd.Parameters.AddWithValue("@Modelo", Modelo);
                        cmd.Parameters.AddWithValue("@Anio", Anio);
                        cmd.Parameters.AddWithValue("@Precio_Dia", Precio);
                        cmd.Parameters.AddWithValue("@Estado", Estado);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar vehículo: {ex.Message}");
                    return false;
                }
            }
        }

        // Eliminar un vehículo
        public bool EliminarVehiculo(int idVehiculo)
        {
            using (SqlConnection con = conexionDB.obtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Vehiculos WHERE Id_Vehiculo = @IdVehiculo";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar vehículo: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
