using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logSector
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logSector _instancia = new logSector();

        public static logSector Instancia
        {
            get { return logSector._instancia; }
        }

        #endregion singleton

        public List<entSector> ListarSector()

        {
            return datSector.Instancia.ListarSector();
        }

        public void RegistrarSector(entSector sector)
        {
            datSector.Instancia.RegistrarSector(sector);
        }
        public void ModificarSector(entSector sector)
        {
            datSector.Instancia.ModificarSector(sector);
        }
        public Boolean BuscaSector(entSector sector)
        {
            return datSector.Instancia.BuscaSector(sector);
        }
        public entSector DatosSector(int SectorID)
        {
            return datSector.Instancia.DatosSector(SectorID);
        }
        public Boolean ExisteDatosSector(string sector)
        {
            return datSector.Instancia.ExisteDatosSector(sector);
        }

    }
}
