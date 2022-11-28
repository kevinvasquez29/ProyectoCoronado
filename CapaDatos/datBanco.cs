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
    public class datBanco
    {
        #region singleton
        private static datBanco _instancia = new datBanco();

        public static datBanco Instancia
        {
            get { return datBanco._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarBanco(entBanco banco)
        {
            Boolean registro = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RegistroBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", banco.Nombre);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registro = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return registro;
        }

        public List<entBanco> ListarBancos()
        {
            SqlCommand cmd = null;
            List<entBanco> lista = new List<entBanco>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entBanco banco = new entBanco();
                    banco.estadoBanco = Convert.ToBoolean(dr["estadoBanco"]);
                    banco.BancoID = Convert.ToInt32(dr["BancoID"]);
                    banco.Nombre = dr["Nombre"].ToString();
                    lista.Add(banco);
                }
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean EditarBanco(entBanco banco)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BancoID", banco.BancoID);
                cmd.Parameters.AddWithValue("@Nombre", banco.Nombre);
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

        public Boolean BuscarBanco(entBanco banco)
        {
            Boolean encontrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BancoID", banco.BancoID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    encontrar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return encontrar;
        }

        public entBanco DatosBanco(int BancoID)
        {
            entBanco banco = new entBanco();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DatosBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BancoID", BancoID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    banco.BancoID = Convert.ToInt32(dr["BancoID"]);
                    banco.Nombre = dr["Nombre"].ToString();
                    banco.estadoBanco = Convert.ToBoolean(dr["estadoBanco"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return banco;
        }
        public Boolean DeshabilitarBanco(entBanco banco)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BancoID", banco.BancoID);
                cmd.Parameters.AddWithValue("@estadoBanco", banco.estadoBanco);
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
        public Boolean ExisteDatosBancoNombre(entBanco banco)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosBancoNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", banco.Nombre);
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
