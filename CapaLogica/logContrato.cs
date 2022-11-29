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
    public class logContrato
    {
        #region singleton
        private static readonly logContrato _instancia = new logContrato();
        public static logContrato Instancia
        {
            get { return logContrato._instancia; }
        }
        #endregion singleton
        public entContrato DatosContrato()
        {
            return datContrato.Instancia.DatosContrato();
        }
    }
}
