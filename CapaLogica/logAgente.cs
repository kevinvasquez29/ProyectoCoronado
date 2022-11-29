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
    public class logAgente
    {
        #region singleton
        private static readonly logAgente _instancia = new logAgente();
        public static logAgente Instancia
        {
            get { return logAgente._instancia; }
        }
        #endregion singleton
        public Boolean IngresarAgente(entAgente Agente)
        {
            return datAgente.Instancia.IngresoAgente(Agente);
        }

        public void RegistrarAgente(entAgente Agente)
        {
            datAgente.Instancia.RegistrarAgente(Agente);
        }
        public Boolean ExisteDatosAgenteDNI(entAgente Agente)
        {
            return datAgente.Instancia.ExisteDatosAgenteDNI(Agente);
        }
        public Boolean ExisteDatosAgenteCorreo(entAgente Agente)
        {
            return datAgente.Instancia.ExisteDatosAgenteCorreo(Agente);
        }
        public Boolean ExisteDatosAgenteCelular(entAgente Agente)
        {
            return datAgente.Instancia.ExisteDatosAgenteCelular(Agente);
        }
        public List<entAgente> ListarAgentes()
        {
            return datAgente.Instancia.ListarAgentes();
        }
        public Boolean BuscarAgente(entAgente Agente)
        {
            return datAgente.Instancia.BuscaAgente(Agente);
        }
        public entAgente DatosAgente(int dni)
        {
            return datAgente.Instancia.DatosAgente(dni);
        }
        public void ModificarAgente(entAgente Agente)
        {
            datAgente.Instancia.ModificarAgente(Agente);
        }
        public void DeshabilitarAgente(entAgente Agente)
        {
            datAgente.Instancia.DeshabilitarAgente(Agente);
        }
    }
}

