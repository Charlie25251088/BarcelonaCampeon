using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using _02_Mi_Segunda_Vez.Datos;

namespace _02_Mi_Segunda_Vez.Logica
{
    public class cls_personal
    {
        private readonly conexion cn = new conexion();

        //private readonly Datos.conexion cn = new Datos.conexion();

        public string Insertar(dto_personal Personales)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena1 = "insert into Personales (Cedula ,Nombres, Cargo, Sueldo, idPais)values('" +
                    Personales.Cedula + "','" +
                    Personales.Nombres + "','" +
                    Personales.Cargo + "'," +
                    Personales.Sueldo + "," +
                    Personales.idPais + ")";

                using (var comando = new SqlCommand(cadena1, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                    
                }
            }
        }

    }
}
