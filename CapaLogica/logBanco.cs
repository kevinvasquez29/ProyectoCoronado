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
    public class logBanco
    {
        #region singleton
        private static readonly logBanco _instancia = new logBanco();
        public static logBanco Instancia
        {
            get { return logBanco._instancia; }
        }
        #endregion singleton



        public void RegistrarBanco(entBanco banco)
        {
            datBanco.Instancia.RegistrarBanco(banco);
        }
        public List<entBanco> ListarBancos()
        {
            return datBanco.Instancia.ListarBancos();
        }
        public Boolean BuscarBanco(entBanco banco)
        {
            return datBanco.Instancia.BuscarBanco(banco);
        }
        public entBanco DatosBanco(int BancoID)
        {
            return datBanco.Instancia.DatosBanco(BancoID);
        }
        public void EditarBanco(entBanco banco)
        {
            datBanco.Instancia.EditarBanco(banco);
        }
        public void DeshabilitarBanco(entBanco banco)
        {
            datBanco.Instancia.DeshabilitarBanco(banco);
        }
        public Boolean ExisteDatosBancoNombre(entBanco banco)
        {
            return datBanco.Instancia.ExisteDatosBancoNombre(banco);
        }
    }
}