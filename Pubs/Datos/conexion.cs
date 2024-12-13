using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pubs.Datos
{
    public class conexion
    {
        private readonly string varconexion =
            "Server = (local);database = pubs; Trusted_Connection=True";

        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(varconexion);
        }
    }
}
