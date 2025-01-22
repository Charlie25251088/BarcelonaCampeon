using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_Roles.Modelos
{
    public class usuario_model
    {
        public int Id_User { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int Disponibilidad { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }
        public int Roles_id { get; set; }
        public string Detalle_Rol { get; set; } = null;
    }
}
