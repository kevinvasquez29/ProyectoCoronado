using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datSitioInmueble
    {
        #region singleton
        private static datSitioInmueble _instancia = new datSitioInmueble();

        public static datSitioInmueble Instancia
        {
            get { return datSitioInmueble._instancia; }
        }
        #endregion singleton
        public Boolean RegistrarSitioInmueble(entSitioInmueble sitioInmueble)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarSitioInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InmuebleID", sitioInmueble.InmuebleID);
                cmd.Parameters.AddWithValue("@SitiodeinteresID", sitioInmueble.SitiodeinteresID);
                cmd.Parameters.AddWithValue("@Distancia", sitioInmueble.Distancia);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return registrar;
        }
        public List<entSitioInmueble> ListarSitioInmueble()
        {
            SqlCommand cmd = null;
            List<entSitioInmueble> lista = new List<entSitioInmueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarSitioInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSitioInmueble sitioInmueble = new entSitioInmueble();
                    sitioInmueble.Distancia = Convert.ToInt32(dr["Distancia"]);
                    sitioInmueble.SitiodeinteresID = Convert.ToInt32(dr["SitiodeinteresID"]);
                    sitioInmueble.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    lista.Add(sitioInmueble);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean ExisteSitioInmueble(entSitioInmueble sitioInmueble)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteSitioInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID", sitioInmueble.InmuebleID);
                cmd.Parameters.AddWithValue("@SitiodeinteresID", sitioInmueble.SitiodeinteresID);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    existe = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }


            return existe;
        }
    }
}