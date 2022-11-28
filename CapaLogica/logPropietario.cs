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
    public class logPropietario
    {
        #region singleton
        private static readonly logPropietario _instancia = new logPropietario();
        public static logPropietario Instancia
        {
            get { return logPropietario._instancia; }
        }
        #endregion singleton


        public void RegistrarPropietario(entPropietario Propietario)
        {
            datPropietario.Instancia.RegistrarPropietario(Propietario);
        }


        public Boolean ExisteDatosPropietario(entPropietario Propietario)
        {
            return datPropietario.Instancia.ExisteDatosPropietario(Propietario);
        }


        public List<entPropietario> ListarPropietario()
        {
            return datPropietario.Instancia.ListarPropietario();
        }


        public Boolean BuscarPropietario(entPropietario Propietario)
        {
            return datPropietario.Instancia.BuscaPropietario(Propietario);
        }


        public entPropietario DatosPropietario(int Dnipropietario)
        {
            return datPropietario.Instancia.DatosPropietario(Dnipropietario);
        }


        public void ModificarPropietario(entPropietario Propietario)
        {
            datPropietario.Instancia.ModificarPropietario(Propietario);
        }


        public void HabilitarPropietario(entPropietario Propietario)
        {
            datPropietario.Instancia.DeshabilitarPropietario(Propietario);
        }
    }
}
