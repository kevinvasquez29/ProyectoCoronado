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
    public class datAgente
    {
        #region singleton
        private static datAgente _instancia = new datAgente();

        public static datAgente Instancia
        {
            get { return datAgente._instancia; }
        }
        #endregion singleton
        public Boolean IngresoAgente(entAgente Agente)
        {
            SqlCommand cmd = null;
            Boolean existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spIngresarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@contraseña", Agente.contraseña);
                cn.Open();
                SqlDataReader da = cmd.ExecuteReader();
                if (da.Read())
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
        public Boolean RegistrarAgente(entAgente Agente)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", Agente.nombre);
                cmd.Parameters.AddWithValue("@apellido", Agente.apellido);
                cmd.Parameters.AddWithValue("@Fechanacimiento", Agente.Fechanacimiento);
                cmd.Parameters.AddWithValue("@celular", Agente.celular);
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@contraseña", Agente.contraseña);
                cmd.Parameters.AddWithValue("@estado", Agente.estado);
                cmd.Parameters.AddWithValue("@dni", Agente.dni);
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
        public Boolean ExisteDatosAgenteDNI(entAgente Agente)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosAgenteDNI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Agente.dni);
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
        public Boolean ExisteDatosAgenteCorreo(entAgente Agente)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosAgenteCorreo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
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
        public Boolean ExisteDatosAgenteCelular(entAgente Agente)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosAgenteCelular", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@celular", Agente.celular);
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

        public List<entAgente> ListarAgentes()
        {
            SqlCommand cmd = null;
            List<entAgente> lista = new List<entAgente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarAgentes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAgente Age = new entAgente();
                    Age.estado = Convert.ToBoolean(dr["estado"]);
                    Age.AgenteID = Convert.ToInt32(dr["AgenteID"]);
                    Age.dni = Convert.ToInt32(dr["dni"]);
                    Age.nombre = dr["nombre"].ToString();
                    Age.apellido = dr["apellido"].ToString();
                    Age.Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"]);
                    Age.celular = Convert.ToInt32(dr["celular"]);
                    Age.correo = dr["correo"].ToString();
                    Age.contraseña = dr["contraseña"].ToString();
                    lista.Add(Age);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean ModificarAgente(entAgente Agente)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AgenteID", Agente.AgenteID);
                cmd.Parameters.AddWithValue("@nombre", Agente.nombre);
                cmd.Parameters.AddWithValue("@apellido", Agente.apellido);
                cmd.Parameters.AddWithValue("@celular", Agente.celular);
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@contraseña", Agente.contraseña);
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
        public Boolean BuscaAgente(entAgente Agente)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Agente.dni);
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
        public entAgente DatosAgente(int dni)
        {
            entAgente Age = new entAgente();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Age.AgenteID = Convert.ToInt32(dr["AgenteID"]);
                    Age.dni = Convert.ToInt32(dr["dni"]);
                    Age.nombre = dr["nombre"].ToString();
                    Age.apellido = dr["apellido"].ToString();
                    Age.Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"]);
                    Age.celular = Convert.ToInt32(dr["celular"]);
                    Age.correo = dr["correo"].ToString();
                    Age.contraseña = dr["contraseña"].ToString();
                    Age.estado = Convert.ToBoolean(dr["estado"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Age;
        }
        public Boolean DeshabilitarAgente(entAgente Agente)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AgenteID", Agente.AgenteID);
                cmd.Parameters.AddWithValue("@estado", Agente.estado);
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
    }
}