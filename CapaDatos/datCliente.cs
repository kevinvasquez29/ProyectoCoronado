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
    public class datCliente
    {

        #region singleton
        private static datCliente _instancia = new datCliente();

        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarCliente(entCliente Cliente)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dnicliente", Cliente.dnicliente);
                cmd.Parameters.AddWithValue("@nombrecliente", Cliente.nombrecliente);
                cmd.Parameters.AddWithValue("@apelcliente", Cliente.apelcliente);
                cmd.Parameters.AddWithValue("@Fechanacimiento", Cliente.Fechanacimiento);
                cmd.Parameters.AddWithValue("@celcliente", Cliente.celcliente);
                cmd.Parameters.AddWithValue("@estadocliente", Cliente.estadocliente);
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

        public Boolean ExisteDatosClienteDNI(entCliente Cliente)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosClienteDNI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dnicliente", Cliente.dnicliente);
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
        public Boolean ExisteDatosClienteCelular(entCliente Cliente)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosClienteCelular", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@celcliente", Cliente.celcliente);
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

        public List<entCliente> ListarClientes()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.estadocliente = Convert.ToBoolean(dr["estadocliente"]);
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.dnicliente = Convert.ToInt32(dr["dnicliente"]);
                    Cli.nombrecliente = dr["nombrecliente"].ToString();
                    Cli.apelcliente = dr["apelcliente"].ToString();
                    Cli.Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"]);
                    Cli.celcliente = Convert.ToInt32(dr["celcliente"]);
                    lista.Add(Cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean ModificarCliente(entCliente Cliente)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cliente.ClienteID);
                cmd.Parameters.AddWithValue("@dnicliente", Cliente.dnicliente);
                cmd.Parameters.AddWithValue("@nombrecliente", Cliente.nombrecliente);
                cmd.Parameters.AddWithValue("@apelcliente", Cliente.apelcliente);
                cmd.Parameters.AddWithValue("@celcliente", Cliente.celcliente);
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

        public Boolean BuscarCliente(entCliente Cliente)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dnicliente", Cliente.dnicliente);
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

        public entCliente DatosCliente(int dnicliente)
        {
            entCliente Cli = new entCliente();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dnicliente", dnicliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.dnicliente = Convert.ToInt32(dr["dnicliente"]);
                    Cli.nombrecliente = dr["nombrecliente"].ToString();
                    Cli.apelcliente = dr["apelcliente"].ToString();
                    Cli.Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"]);
                    Cli.celcliente = Convert.ToInt32(dr["celcliente"]);
                    Cli.estadocliente = Convert.ToBoolean(dr["estadocliente"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Cli;
        }

        public Boolean DeshabilitarCliente(entCliente Cliente)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cliente.ClienteID);
                cmd.Parameters.AddWithValue("@estadocliente", Cliente.estadocliente);
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