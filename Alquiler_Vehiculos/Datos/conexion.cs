using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alquiler_Vehiculos.Datos
{
    public class conexion
    {
        private readonly string varconexion =
           "Server = (local);database = Sistema_Vehiculos; Trusted_Connection=True";

        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(varconexion);
        }
    }
}
