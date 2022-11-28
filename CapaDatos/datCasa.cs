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
    public class datCasa
    {
        #region singleton
        private static datCasa _instancia = new datCasa();
        public static datCasa Instancia
        {
            get { return datCasa._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarCasa(entCasa casa)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarInmuebleCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInmueble1", casa.InmuebleID1);
                cmd.Parameters.AddWithValue("@cantPisos", casa.cantPisos);
                cmd.Parameters.AddWithValue("@cantBao", casa.cantBaños);
                cmd.Parameters.AddWithValue("@cantHabitaciones", casa.cantHabitaciones);
                cmd.Parameters.AddWithValue("@piscina", casa.piscina);
                cmd.Parameters.AddWithValue("@jardine", casa.jardin);
                cmd.Parameters.AddWithValue("@areaM2", casa.areaM2);
                cmd.Parameters.AddWithValue("@fechaConstruccion", casa.fechaConstruccion);
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

        public List<entCasa> ListarInmuebleCasas()
        {
            List<entCasa> lista = new List<entCasa>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCasa casa = new entCasa();
                    casa.InmuebleID1 = Convert.ToInt32(dr["InmuebleID1"]);
                    casa.cantPisos = Convert.ToInt32(dr["Cantpisos"]);
                    casa.cantBaños = Convert.ToInt32(dr["Cantbao"]);
                    casa.cantHabitaciones = Convert.ToInt32(dr["Canthabitaciones"]);
                    casa.piscina = Convert.ToBoolean(dr["Piscina"]);
                    casa.jardin = Convert.ToBoolean(dr["Jardine"]);
                    casa.areaM2 = (float)Convert.ToDouble(dr["Aream2"]);
                    casa.fechaConstruccion = Convert.ToDateTime(dr["Fechaconstruccion"]);

                    lista.Add(casa);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public entCasa DatosCasa(int idCasa)
        {
            entCasa casa = new entCasa();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID1", idCasa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    casa.InmuebleID1 = Convert.ToInt32(dr["InmuebleID1"]);
                    casa.cantPisos = Convert.ToInt32(dr["Cantpisos"]);
                    casa.cantBaños = Convert.ToInt32(dr["Cantbao"]);
                    casa.cantHabitaciones = Convert.ToInt32(dr["Canthabitaciones"]);
                    casa.piscina = Convert.ToBoolean(dr["Piscina"]);
                    casa.jardin = Convert.ToBoolean(dr["Jardine"]);
                    casa.areaM2 = (float)Convert.ToDouble(dr["Aream2"]);
                    casa.fechaConstruccion = Convert.ToDateTime(dr["Fechaconstruccion"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return casa;
        }
        public void ModifcarCasa(entCasa casa)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID1", casa.InmuebleID1);
                cmd.Parameters.AddWithValue("@CantPisos", casa.cantPisos);
                cmd.Parameters.AddWithValue("@cantBao", casa.cantBaños);
                cmd.Parameters.AddWithValue("@Canthabitaciones", casa.cantHabitaciones);
                cmd.Parameters.AddWithValue("@areaM2", casa.areaM2);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }
        public Boolean BuscarCasa(entCasa casa)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarcasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID1", casa.InmuebleID1);
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

    }
}
