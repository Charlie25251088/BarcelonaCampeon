using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _01_Mi_Primera_Vez.Datos;
using System.Globalization;

namespace _01_Mi_Primera_Vez.Logica
{
    public class cls_usuarios
    {
        private readonly conexion _conexion = new conexion();

        // Método para insertar un nuevo usuario
        public string Insertar(dto_usuarios nombreUsuario)
        {
            using (var connection = _conexion.obtenerConexion())
    {
        try
        {
            connection.Open();
            var query = "INSERT INTO Usuarios (NombreUsuario) VALUES (@NombreUsuario)";
            var command = new SqlCommand(query, connection);

            // Asegúrate de que el parámetro sea agregado correctamente
            command.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario.NombreUsuario;

            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0 ? "ok" : "error";
        }
        catch (Exception ex)
        {
            return "error: " + ex.Message;
        }
    }
        }

        // Método para leer usuarios
        public DataTable Leer(string filtro = "")
        {
            var tabla = new DataTable();
            try
            {
                using (var conexion = _conexion.obtenerConexion())  // Usamos la conexión de la clase 'conexion'
                {
                    conexion.Open();
                    string query = "SELECT IdUsuario, NombreUsuario FROM Usuarios";
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " WHERE NombreUsuario LIKE @Filtro";
                    }
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            comando.Parameters.AddWithValue("@Filtro", $"%{filtro}%");
                        }
                        using (var adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Manejo opcional de errores
            }
            return tabla;
        }

        // Método para actualizar un usuario
        public string Actualizar(int idUsuario, string nombreUsuario)
        {
            try
            {
                using (var conexion = _conexion.obtenerConexion())  // Usamos la conexión de la clase 'conexion'
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET NombreUsuario = @NombreUsuario WHERE IdUsuario = @IdUsuario";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para eliminar un usuario
        public string Eliminar(int idUsuario)
        {
            try
            {
                using (var conexion = _conexion.obtenerConexion())  // Usamos la conexión de la clase 'conexion'
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
