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
    public class logCiudad
    {
        #region singleton
        private static readonly logCiudad _instancia = new logCiudad();
        public static logCiudad Instancia
        {
            get { return logCiudad._instancia; }
        }
        #endregion singleton

        public void RegistrarCiudad(entCiudad Ciudad)
        {
            datCiudad.Instancia.RegistrarCiudad(Ciudad);
        }
        public List<entCiudad> ListarCiudad()
        {
            return datCiudad.Instancia.ListarCiudad();
        }
        public Boolean BuscaCiudad(entCiudad ciudad)
        {
            return datCiudad.Instancia.BuscaCiudad(ciudad);
        }
        public entCiudad DatosCiudad(int CiudadID)
        {
            return datCiudad.Instancia.DatosCiudad(CiudadID);
        }
        public void ModificarCiudad(entCiudad ciudad)
        {
            datCiudad.Instancia.ModificarCiudad(ciudad);
        }
        public Boolean ExisteDatosCiudadNombre(entCiudad ciudad)
        {
            return datCiudad.Instancia.ExisteDatosCiudadNombre(ciudad);
        }
    }
}
