using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCasa
    {
        public int InmuebleID1 { get; set; }
        public int cantPisos { get; set; }
        public int cantBaños { get; set; }
        public int cantHabitaciones { get; set; }
        public Boolean piscina { get; set; }
        public Boolean jardin { get; set; }
        public float areaM2 { get; set; }
        public DateTime fechaConstruccion { get; set; }
    }
}