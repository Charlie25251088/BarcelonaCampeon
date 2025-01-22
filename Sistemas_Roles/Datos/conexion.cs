using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistemas_Roles.Datos
{
    public class conexion
    {
        private readonly string cadenaConexion =
            "Server = (local);database = Sistemasroles; Trusted_Connection=True";

        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
