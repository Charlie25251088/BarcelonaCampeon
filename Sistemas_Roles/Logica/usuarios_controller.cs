using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemas_Roles.Datos;
using Sistemas_Roles.Modelos;

namespace Sistemas_Roles.Logica
{
    public class usuarios_controller
    {
        private usuario_model usuario_Model = new usuario_model();
        private readonly conexion cn = new conexion();
        public List<usuario_model> todos() { return null; }
        public usuario_model uno(int Id_User) { return null; }
        public string insertar(usuario_model usuario) { return "ok"; }
        public string actualizar(usuario_model usuario) { return "ok"; }
        public string eliminar(int Id_User) { return "ok"; }
    }
}
