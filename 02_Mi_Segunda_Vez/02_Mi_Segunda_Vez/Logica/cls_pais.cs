using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Mi_Segunda_Vez.Datos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _02_Mi_Segunda_Vez.Logica
{
    public class cls_pais
    {
        private readonly conexion cn = new conexion();

        public List<dto_pais> leer()
        {
            var listapais = new List<dto_pais>();
            using (var varconexion = cn.obtenerConexion())

            {
                string cadena = "select * from Paises";
                using (var comando = new SqlCommand(cadena, varconexion))
                {
                    varconexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            
                            listapais.Add(new dto_pais()
                            {
                                idPais = Convert.ToInt32(lector["idPais"]),
                                Detalle = lector["Detalle"].ToString()
                            });
                        }
                    }
                }                
            }

            return listapais;
        }
    }
}
