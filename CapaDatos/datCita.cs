using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datCita
    {
        #region singleton
        private static datCita _instancia = new datCita();
        public static datCita Instancia
        {
            get { return datCita._instancia; }
        }
        #endregion singleton
        public Boolean RegistrarCita(entCita cita)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", cita.Fechacita);
                cmd.Parameters.AddWithValue("@id_Inmueble8", cita.InmuebleID);
                cmd.Parameters.AddWithValue("@ClienteID", cita.ClienteID);
                cmd.Parameters.AddWithValue("@AgenteID", cita.AgenteID);
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
        public List<entCita> ListarCita()
        {
            List<entCita> lista = new List<entCita>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCita cita = new entCita();
                    cita.Estadocita = Convert.ToBoolean(dr["Estadocita"]);
                    cita.CitaID = Convert.ToInt32(dr["CitaID"]);
                    cita.AgenteID = Convert.ToInt32(dr["AgenteID"]);
                    cita.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    cita.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    cita.Fechacita = Convert.ToDateTime(dr["Fechacita"]);
                    cita.Realizado = Convert.ToBoolean(dr["Realizado"]);
                    lista.Add(cita);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean ExisteCita(entCita cita)
        {
            SqlCommand cmd = null;
            Boolean existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Inmueble8", cita.InmuebleID);
                cmd.Parameters.AddWithValue("@ClienteID", cita.ClienteID);
                cmd.Parameters.AddWithValue("@AgenteID", cita.AgenteID);
                cmd.Parameters.AddWithValue("@fecha", cita.Fechacita);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return existe;
        }
        public Boolean BuscarCita(entCita cita)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CitaID", cita.CitaID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    encontrado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return encontrado;
        }
        public entCita DatosCita(int CitaID)
        {
            entCita Cita = new entCita();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DatosCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CitaID", CitaID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Cita.CitaID = Convert.ToInt32(dr["CitaID"]);
                    Cita.Fechacita = Convert.ToDateTime(dr["Fechacita"]);
                    Cita.Estadocita = Convert.ToBoolean(dr["Estadocita"]);
                    Cita.Realizado = Convert.ToBoolean(dr["Realizado"]);
                    Cita.AgenteID = Convert.ToInt32(dr["AgenteID"]);
                    Cita.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cita.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Cita;
        }
        public Boolean ModificarCita(entCita cita)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CitaID", cita.CitaID);
                cmd.Parameters.AddWithValue("@fecha", cita.Fechacita);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return modificar;
        }
        public Boolean DeshabilitarCita(entCita cita)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CitaID", cita.CitaID);
                cmd.Parameters.AddWithValue("@Estadocita", cita.Estadocita);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deshabilitar;
        }
        public Boolean CitaRealizada(entCita cita)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCitaRealizada", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CitaID", cita.CitaID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deshabilitar;
        }
        public List<entCita> ListarCitasVenta()
        {
            List<entCita> lista = new List<entCita>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCitasVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCita cita = new entCita();
                    cita.Estadocita = Convert.ToBoolean(dr["Estadocita"]);
                    cita.CitaID = Convert.ToInt32(dr["CitaID"]);
                    cita.AgenteID = Convert.ToInt32(dr["AgenteID"]);
                    cita.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    cita.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    cita.Fechacita = Convert.ToDateTime(dr["Fechacita"]);
                    cita.Realizado = Convert.ToBoolean(dr["Realizado"]);
                    lista.Add(cita);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}
