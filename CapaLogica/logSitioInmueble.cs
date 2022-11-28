using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class logSitioInmueble
    {
        #region singleton
        private static readonly logSitioInmueble _instancia = new logSitioInmueble();
        public static logSitioInmueble Instancia
        {
            get { return logSitioInmueble._instancia; }
        }
        #endregion singleton
        public void RegistrarSitioInmueble(entSitioInmueble sitioInmueble)
        {
            datSitioInmueble.Instancia.RegistrarSitioInmueble(sitioInmueble);
        }
        public List<entSitioInmueble> ListarSitiosInmuebles()
        {
            return datSitioInmueble.Instancia.ListarSitioInmueble();
        }
        public Boolean ExisteSitioInmueble(entSitioInmueble sitioInmueble)
        {
            return datSitioInmueble.Instancia.ExisteSitioInmueble(sitioInmueble);
        }
    }
}

