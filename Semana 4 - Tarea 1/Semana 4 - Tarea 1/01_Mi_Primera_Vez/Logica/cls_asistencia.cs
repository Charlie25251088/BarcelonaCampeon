using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _01_Mi_Primera_Vez.Logica
{
    class cls_asistencia
    {
        private Datos.conexion cn = new Datos.conexion();

        public bool insertar(Datos.dto_asistecia dto_Asistecia) {

            
            var cls_personal = new cls_personal();
            var existencia =  cls_personal.duplicadoCedula(dto_Asistecia.Cedula);

            if (!existencia) {
                MessageBox.Show("No exite el usuario en la base de datos");
                return false;
            }
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "insert into Asistencia(IdPersonal, Cedula) values(@IdPersonal, @Cedula)";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@IdPersonal", dto_Asistecia.IdPersonal);
                    comando.Parameters.AddWithValue("@Cedula", dto_Asistecia.Cedula);
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
