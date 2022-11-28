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
    public class logCliente
    {
        #region singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }
        #endregion singleton

        public void RegistrarCliente(entCliente Cliente)
        {
            datCliente.Instancia.RegistrarCliente(Cliente);
        }
        public Boolean ExisteDatosClienteDNI(entCliente Cliente)
        {
            return datCliente.Instancia.ExisteDatosClienteDNI(Cliente);
        }
        public Boolean ExisteDatosClienteCelular(entCliente Cliente)
        {
            return datCliente.Instancia.ExisteDatosClienteCelular(Cliente);
        }
        public List<entCliente> ListarClientes()
        {
            return datCliente.Instancia.ListarClientes();
        }
        public Boolean BuscarCliente(entCliente Cliente)
        {
            return datCliente.Instancia.BuscarCliente(Cliente);
        }
        public entCliente DatosCliente(int dni)
        {
            return datCliente.Instancia.DatosCliente(dni);
        }
        public void ModificarCliente(entCliente Cliente)
        {
            datCliente.Instancia.ModificarCliente(Cliente);
        }
        public void DeshabilitarCliente(entCliente Cliente)
        {
            datCliente.Instancia.DeshabilitarCliente(Cliente);
        }




    }
}
