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
    public class datPropietario
    {
        #region singleton
        private static datPropietario _instancia = new datPropietario();

        public static datPropietario Instancia
        {
            get { return datPropietario._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarPropietario(entPropietario Propietario)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Dnipropietario", Propietario.Dnipropietario);
                cmd.Parameters.AddWithValue("@nombre", Propietario.nombre);
                cmd.Parameters.AddWithValue("@apellido", Propietario.apellido);
                cmd.Parameters.AddWithValue("@Fechanacimiento", Propietario.Fechanacimiento);
                cmd.Parameters.AddWithValue("@celular", Propietario.celular);
                cmd.Parameters.AddWithValue("@direccion", Propietario.direccion);
                cmd.Parameters.AddWithValue("@estadoPropietario", Propietario.estadoPropietario);
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


        public Boolean ExisteDatosPropietario(entPropietario Propietario)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dnipropietario", Propietario.Dnipropietario);
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


        public List<entPropietario> ListarPropietario()
        {
            SqlCommand cmd = null;
            List<entPropietario> lista = new List<entPropietario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPropietario prop = new entPropietario();
                    prop.estadoPropietario = Convert.ToBoolean(dr["estadoPropietario"]);
                    prop.PropietarioID = Convert.ToInt32(dr["PropietarioID"]);
                    prop.Dnipropietario = Convert.ToInt32(dr["Dnipropietario"]);
                    prop.nombre = dr["nombre"].ToString();
                    prop.apellido = dr["apellido"].ToString();
                    prop.Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"]);
                    prop.celular = Convert.ToInt32(dr["celular"]);
                    prop.direccion = dr["direccion"].ToString();
                    lista.Add(prop);

                }
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { cmd.Connection.Close(); }
            return lista;
        }



        public Boolean ModificarPropietario(entPropietario Propietario)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PropietarioID", Propietario.PropietarioID);
                cmd.Parameters.AddWithValue("@Dnipropietario", Propietario.Dnipropietario);
                cmd.Parameters.AddWithValue("@nombre", Propietario.nombre);
                cmd.Parameters.AddWithValue("@apellido", Propietario.apellido);
                cmd.Parameters.AddWithValue("@celular", Propietario.celular);
                cmd.Parameters.AddWithValue("@Direccion", Propietario.direccion);
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


        public Boolean BuscaPropietario(entPropietario Propietario)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dnipropietario", Propietario.Dnipropietario);
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


        public entPropietario DatosPropietario(int Dnipropietario)
        {
            entPropietario prop = new entPropietario();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dnipropietario", Dnipropietario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prop.PropietarioID = Convert.ToInt32(dr["PropietarioID"]);
                    prop.Dnipropietario = Convert.ToInt32(dr["Dnipropietario"]);
                    prop.nombre = dr["nombre"].ToString();
                    prop.apellido = dr["apellido"].ToString();
                    prop.Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"]);
                    prop.celular = Convert.ToInt32(dr["celular"]);
                    prop.direccion = dr["direccion"].ToString();
                    prop.estadoPropietario = Convert.ToBoolean(dr["estadoPropietario"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return prop;
        }
        public Boolean DeshabilitarPropietario(entPropietario Propietario)
        {
            SqlCommand cmd = null;
            Boolean Habilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PropietarioID", Propietario.PropietarioID);
                cmd.Parameters.AddWithValue("@Dnipropietario", Propietario.Dnipropietario);
                cmd.Parameters.AddWithValue("@estadoPropietario", Propietario.estadoPropietario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Habilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Habilitar;
        }
    }
}