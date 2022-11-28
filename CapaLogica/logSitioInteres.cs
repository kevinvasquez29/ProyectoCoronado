using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;
using System;

namespace CapaLogica
{
    public class logSitioInteres
    {
        #region singleton
        private static readonly logSitioInteres _instancia = new logSitioInteres();
        public static logSitioInteres Instancia
        {
            get { return logSitioInteres._instancia; }
        }
        #endregion singleton
        public List<entSitioInteres> ListarSitioInteres()
        {
            return datSitioInteres.Instancia.ListarSitioInteres();
        }
        public void RegistrarSI(entSitioInteres Sitio)
        {
            datSitioInteres.Instancia.RegistrarSitioInteres(Sitio);
        }
        public void ModificarSI(entSitioInteres Sitio)
        {
            datSitioInteres.Instancia.ModificarSitioInteres(Sitio);
        }
        public Boolean BuscarSitioInteres(entSitioInteres Sitio)
        {
            return datSitioInteres.Instancia.BuscarSitioInteres(Sitio);
        }
        public entSitioInteres DatosSitioInteres(int SitiodeinteresID)
        {
            return datSitioInteres.Instancia.DatosSitioInteres(SitiodeinteresID);
        }
        public void DeshabilitarSitioInteres(entSitioInteres Sitio)
        {
            datSitioInteres.Instancia.DeshabilitarSitioInteres(Sitio);
        }
        public Boolean ExisteDatosSitioInteresNombre(entSitioInteres sitio)
        {
            return datSitioInteres.Instancia.ExisteDatosSitioInteresNombre(sitio);
        }
        public Boolean ExisteDatosSitioInteresDireccion(entSitioInteres sitio)
        {
            return datSitioInteres.Instancia.ExisteDatosSitioInteresDireccion(sitio);
        }
    }
}
