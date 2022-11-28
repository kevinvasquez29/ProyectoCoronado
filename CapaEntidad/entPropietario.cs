using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPropietario
    {
        public int PropietarioID { get; set; }
        public int Dnipropietario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public int celular { get; set; }
        public string direccion { get; set; }
        public Boolean estadoPropietario { get; set; }

    }
}