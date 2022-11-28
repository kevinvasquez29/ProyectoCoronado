using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int ClienteID { get; set; }
        public int dnicliente { get; set; }
        public string nombrecliente { get; set; }
        public string apelcliente { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public int celcliente { get; set; }
        public Boolean estadocliente { get; set; }
    }
}
