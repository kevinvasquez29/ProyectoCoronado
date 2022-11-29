using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class logVenta
    {
        #region singleton
        private static readonly logVenta _instancia = new logVenta();
        public static logVenta Instancia
        {
            get { return logVenta._instancia; }
        }
        #endregion singleton
        public void RegistrarVenta(entVenta venta)
        {
            datVenta.Instancia.RegistrarVenta(venta);
        }
        public List<entVenta> ListarVenta()
        {
            return datVenta.Instancia.ListarVenta();
        }
        public Boolean ExisteNEscritura(int NEscritura)
        {
            return datVenta.Instancia.ExisteNEscrituraPublica(NEscritura);
        }
    }
}
