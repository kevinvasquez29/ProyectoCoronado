using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entContrato
    {
        public DateTime Fechacontrato { get; set; }
        public Boolean Finalizado { get; set; }
        public float Porcentajecomision { get; set; }
        public int ContratoID { get; set; }
        public int InmuebleID { get; set; }
        public int PropietarioID { get; set; }
    }
}
