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
    public class datInmueble
    {
        #region singleton
        private static datInmueble _instancia = new datInmueble();
        public static datInmueble Instancia
        {
            get { return datInmueble._instancia; }
        }
        #endregion singleton

        public Boolean registrarInmueble(entInmueble inm)
        {

            SqlCommand cmd = null;
            Boolean registrar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_RegistrarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSector", inm.SectorID);
                cmd.Parameters.AddWithValue("@idPropietario", inm.idPropietario);
                cmd.Parameters.AddWithValue("@direccion", inm.direccion);
                cmd.Parameters.AddWithValue("@precio", inm.precio);
                cmd.Parameters.AddWithValue("@precioMinimo", inm.precioMinimo);
                cmd.Parameters.AddWithValue("@nRegistrosPublicos", inm.nRegistroPublico);
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

        public Boolean modificarInmueble(entInmueble inm)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID", inm.InmuebleID);
                cmd.Parameters.AddWithValue("@precio", inm.precio);
                cmd.Parameters.AddWithValue("@precioMinimo", inm.precioMinimo);
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

        public Boolean VenderInmueble(int idInm)
        {
            SqlCommand cmd = null;
            Boolean vendido = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spVenderInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID", idInm);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    vendido = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return vendido;

        }
        public Boolean InhabilitarInmueble(entInmueble idInm)
        {
            SqlCommand cmd = null;
            Boolean inhabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InhabilitarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID", idInm.InmuebleID);
                cmd.Parameters.AddWithValue("@Habilitado", idInm.habilitado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilitado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inhabilitado;
        }

        public List<entInmueble> ListarInmuebleCasa()
        {
            SqlCommand cmd = null;
            List<entInmueble> lista = new List<entInmueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarinmuebleCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInmueble inmueble = new entInmueble();
                    inmueble.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    inmueble.SectorID = Convert.ToInt32(dr["SectorID"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["PropietarioID"]);
                    inmueble.direccion = dr["Direccion"].ToString();
                    inmueble.precio = (float)Convert.ToDouble((dr["Precio"]));
                    inmueble.precioMinimo = (float)Convert.ToDouble((dr["Preciominimo"]));
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["Nregistrospublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["Vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);
                    lista.Add(inmueble);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public List<entInmueble> ListarInmuebleDepartamento()
        {
            SqlCommand cmd = null;
            List<entInmueble> lista = new List<entInmueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarinmuebleDepartamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInmueble inmueble = new entInmueble();
                    inmueble.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    inmueble.SectorID = Convert.ToInt32(dr["SectorID"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["PropietarioID"]);
                    inmueble.direccion = dr["Direccion"].ToString();
                    inmueble.precio = (float)Convert.ToDouble((dr["Precio"]));
                    inmueble.precioMinimo = (float)Convert.ToDouble((dr["Preciominimo"]));
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["Nregistrospublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["Vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);
                    lista.Add(inmueble);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public List<entInmueble> ListarInmuebleTerreno()
        {
            SqlCommand cmd = null;
            List<entInmueble> lista = new List<entInmueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarinmuebleTerreno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInmueble inmueble = new entInmueble();
                    inmueble.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    inmueble.SectorID = Convert.ToInt32(dr["SectorID"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["PropietarioID"]);
                    inmueble.direccion = dr["Direccion"].ToString();
                    inmueble.precio = (float)Convert.ToDouble((dr["Precio"]));
                    inmueble.precioMinimo = (float)Convert.ToDouble((dr["Preciominimo"]));
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["Nregistrospublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["Vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);
                    lista.Add(inmueble);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean BuscarInmueble(int InmuebleID)
        {
            SqlCommand cmd = null;
            Boolean encontrado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID", InmuebleID);
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

        public entInmueble BuscarNRegistroPublico(int nRegistro)
        {
            entInmueble inmueble = new entInmueble();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarInmuebleNRegistro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nRegistrosPublicos", nRegistro);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inmueble.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["PropietarioID"]);
                    inmueble.SectorID = Convert.ToInt32(dr["SectorID"]);
                    inmueble.direccion = dr["Direccion"].ToString();
                    inmueble.precio = (float)Convert.ToDouble((dr["Precio"]));
                    inmueble.precioMinimo = (float)Convert.ToDouble((dr["Preciominimo"]));
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["Nregistrospublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["Vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inmueble;
        }

        public entInmueble DatosInmueble(int InmuebleID)
        {
            entInmueble inmueble = new entInmueble();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID", InmuebleID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inmueble.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["PropietarioID"]);
                    inmueble.SectorID = Convert.ToInt32(dr["SectorID"]);
                    inmueble.direccion = dr["Direccion"].ToString();
                    inmueble.precio = (float)Convert.ToDouble((dr["Precio"]));
                    inmueble.precioMinimo = (float)Convert.ToDouble((dr["Preciominimo"]));
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["Nregistrospublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["Vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inmueble;
        }
        public Boolean ExisteNRegistrosPublicos(int NRegistro)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteNRegistrosPublicos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nregistrospublicos", NRegistro);
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
