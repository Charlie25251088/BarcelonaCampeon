using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Vehiculos.Datos
{
    public class dto_alquileres
    {
        public int Id_Alquiler { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Vehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
