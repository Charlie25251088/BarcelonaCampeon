using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_Primera_Vez.Datos
{
    class dto_asistecia
    {
       public int? IdAsistecia { get; set; }
        public int IdPersonal { get; set; }
        public string Cedula { get; set; }
        public DateTime? fecharegsitro { get; set; }
    }
}
