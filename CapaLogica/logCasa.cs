using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System;

namespace CapaLogica
{
    public class logCasa
    {
        #region singleton
        private static readonly logCasa _instancia = new logCasa();
        public static logCasa Instancia
        {
            get { return logCasa._instancia; }
        }
        #endregion singleton

        public void RegistrarInmuebleCasa(entCasa casa)
        {
            datCasa.Instancia.RegistrarCasa(casa);
        }

        public List<entCasa> ListarInmuebleCasa()
        {
            return datCasa.Instancia.ListarInmuebleCasas();
        }

        public entCasa DatosCasa(int idCasa)
        {
            return datCasa.Instancia.DatosCasa(idCasa);
        }

        public void ModifcarCasa(entCasa casa)
        {
            datCasa.Instancia.ModifcarCasa(casa);
        }

        public Boolean BuscarCasa(entCasa casa)
        {
            return datCasa.Instancia.BuscarCasa(casa);
        }
    }
}
