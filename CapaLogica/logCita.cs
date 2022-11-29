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
    public class logCita
    {
        #region singleton
        private static readonly logCita _instancia = new logCita();
        public static logCita Instancia
        {
            get { return logCita._instancia; }
        }
        #endregion singleton
        public void RegistrarCita(entCita cita)
        {
            datCita.Instancia.RegistrarCita(cita);
        }
        public List<entCita> ListarCita()
        {
            return datCita.Instancia.ListarCita();
        }
        public Boolean ExisteCita(entCita cita)
        {
            return datCita.Instancia.ExisteCita(cita);
        }
        public Boolean BuscarCita(entCita cita)
        {
            return datCita.Instancia.BuscarCita(cita);
        }
        public entCita DatosCita(int CitaID)
        {
            return datCita.Instancia.DatosCita(CitaID);
        }
        public void ModifcarCita(entCita cita)
        {
            datCita.Instancia.ModificarCita(cita);
        }
        public void DeshabilitarCita(entCita cita)
        {
            datCita.Instancia.DeshabilitarCita(cita);
        }
        public void CitaRealizada(entCita cita)
        {
            datCita.Instancia.CitaRealizada(cita);
        }
        public List<entCita> ListarCitasVenta()
        {
            return datCita.Instancia.ListarCitasVenta();
        }
    }
}

