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
    public class datCiudad
    {

        #region singleton
        private static datCiudad _instancia = new datCiudad();

        public static datCiudad Instancia
        {
            get { return datCiudad._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarCiudad(entCiudad Ciudad)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombrCiudad", Ciudad.nombrCiudad);
                cmd.Parameters.AddWithValue("@referenciasCiudad", Ciudad.referenciasCiudad);
                cmd.Parameters.AddWithValue("@postalCiudad", Ciudad.postalCiudad);
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
        public List<entCiudad> ListarCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> lista = new List<entCiudad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCiudad ciudad = new entCiudad();
                    ciudad.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    ciudad.nombrCiudad = dr["Nombrciudad"].ToString();
                    ciudad.referenciasCiudad = dr["referenciasCiudad"].ToString();
                    ciudad.postalCiudad = Convert.ToInt32(dr["postalCiudad"]);
                    lista.Add(ciudad);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean BuscaCiudad(entCiudad ciudad)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", ciudad.CiudadID);
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
        public entCiudad DatosCiudad(int CiudadID)
        {
            entCiudad ciudad = new entCiudad();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", CiudadID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ciudad.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    ciudad.nombrCiudad = dr["nombrCiudad"].ToString();
                    ciudad.referenciasCiudad = dr["referenciasCiudad"].ToString();
                    ciudad.postalCiudad = Convert.ToInt32(dr["postalCiudad"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return ciudad;
        }
        public Boolean ModificarCiudad(entCiudad ciudad)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", ciudad.CiudadID);
                cmd.Parameters.AddWithValue("@nombrCiudad", ciudad.nombrCiudad);
                cmd.Parameters.AddWithValue("@referenciasCiudad", ciudad.referenciasCiudad);
                cmd.Parameters.AddWithValue("@postalCiudad", ciudad.postalCiudad);
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
        public Boolean ExisteDatosCiudadNombre(entCiudad ciudad)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosCiudadNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombrCiudad", ciudad.nombrCiudad);
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