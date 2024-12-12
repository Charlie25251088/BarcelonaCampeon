using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _02_Mi_Segunda_Vez.Datos
{
    public class conexion
    {
        private readonly string varconexion =
            "Server = (local);database = Prueba3; Trusted_Connection=True";

        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(varconexion);
        }
    }
}
