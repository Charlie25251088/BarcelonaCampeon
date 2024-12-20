using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_Primera_Vez.Datos
{
    public class dto_personal
    {
        public int IdPersonal { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string cargo{ get; set; }
        public decimal sueldo { get; set; }
        public int idPais { get; set; }
        public string Detalle { get; set; } = null;
        //public string? Detalle { get; set; }
    }
}
