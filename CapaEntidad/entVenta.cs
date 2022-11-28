using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int Escriturapublica { get; set; }
        public float Precio { get; set; }
        public DateTime Fechaventa { get; set; }
        public int VentaID { get; set; }
        public int BancoID { get; set; }
        public int CitaID { get; set; }
        public int ContratoID { get; set; }
    }
}