using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAgente
    {
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int AgenteID { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public int celular { get; set; }
        public Boolean estado { get; set; }
        public int dni { get; set; }
    }
}