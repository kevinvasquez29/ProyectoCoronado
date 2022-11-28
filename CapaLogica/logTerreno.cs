using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;



namespace CapaLogica
{
    public class logTerreno
    {
        #region singleton
        private static readonly logTerreno _instancia = new logTerreno();
        public static logTerreno Instancia
        {
            get { return logTerreno._instancia; }
        }
        #endregion singleton

        public void RegistrarInmuebleTerreno(entTerreno terreno)
        {
            datTerreno.Instancia.RegistrarTerreno(terreno);
        }

        public List<entTerreno> ListarInmuebleTerreno()
        {
            return datTerreno.Instancia.ListarInmuebleTerreno();
        }

        public entTerreno DatosTerreno(int idTerreno)
        {
            return datTerreno.Instancia.DatosTerreno(idTerreno);
        }
        public void ModifcarTerreno(entTerreno terreno)
        {
            datTerreno.Instancia.ModifcarTerreno(terreno);
        }
    }
}

