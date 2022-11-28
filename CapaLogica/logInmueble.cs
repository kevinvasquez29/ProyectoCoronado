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
    public class logInmueble
    {
        #region singleton
        private static readonly logInmueble _instancia = new logInmueble();
        public static logInmueble Instancia
        {
            get { return logInmueble._instancia; }
        }
        #endregion singleton

        public void RegistrarInmueble(entInmueble inmueble)
        {
            datInmueble.Instancia.registrarInmueble(inmueble);
        }

        public void ModificarInmueble(entInmueble inmueble)
        {
            datInmueble.Instancia.modificarInmueble(inmueble);
        }
        public Boolean BuscarInmueble(int inmueble)
        {
            return datInmueble.Instancia.BuscarInmueble(inmueble);
        }
        public void DeshabilitarInmueble(entInmueble idInm)
        {
            datInmueble.Instancia.InhabilitarInmueble(idInm);
        }
        public List<entInmueble> ListarInmuebleCasa()
        {
            return datInmueble.Instancia.ListarInmuebleCasa();
        }

        public List<entInmueble> ListarInmuebleDepartamento()
        {
            return datInmueble.Instancia.ListarInmuebleDepartamento();
        }

        public List<entInmueble> ListarInmuebleTerreno()
        {
            return datInmueble.Instancia.ListarInmuebleTerreno();
        }

        public entInmueble BuscarNRegistroPublico(int nRegistro)
        {
            return datInmueble.Instancia.BuscarNRegistroPublico(nRegistro);
        }

        public void VenderInmueble(int InmuebleID)
        {
            datInmueble.Instancia.VenderInmueble(InmuebleID);
        }
        public entInmueble DatosInmueble(int InmuebleID)
        {
            return datInmueble.Instancia.DatosInmueble(InmuebleID);
        }
        public Boolean ExisteNRegistros(int NRegistros)
        {
            return datInmueble.Instancia.ExisteNRegistrosPublicos(NRegistros);
        }
    }
}
