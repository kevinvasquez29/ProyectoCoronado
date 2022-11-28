using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCita
    {
        public int CitaID { get; set; }
        public Boolean Estadocita { get; set; }
        public DateTime Fechacita { get; set; }
        public int ClienteID { get; set; }
        public int AgenteID { get; set; }
        public int InmuebleID { get; set; }
        public Boolean Realizado { get; set; }
    }
}
