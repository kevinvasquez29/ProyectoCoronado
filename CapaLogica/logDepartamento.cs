using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class logDepartamento
    {
        #region singleton
        private static readonly logDepartamento _instancia = new logDepartamento();
        public static logDepartamento Instancia
        {
            get { return logDepartamento._instancia; }
        }
        #endregion singleton

        public void RegistrarInmuebleDepartamento(entDepartamento departamento)
        {
            datDepartamento.Instancia.RegistrarDepartamento(departamento);
        }

        public List<entDepartamento> ListarInmuebleDepartamento()
        {
            return datDepartamento.Instancia.ListarInmuebleDepartamento();
        }

        public entDepartamento DatosDepartamento(int idDepartamento)
        {
            return datDepartamento.Instancia.DatosDepartamento(idDepartamento);
        }

        public void ModifcarDepatarmento(entDepartamento departamento)
        {
            datDepartamento.Instancia.ModifcarDepartamento(departamento);
        }
    }

}
