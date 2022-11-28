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
    public class datDepartamento
    {
        #region singleton
        private static datDepartamento _instancia = new datDepartamento();
        public static datDepartamento Instancia
        {
            get { return datDepartamento._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarDepartamento(entDepartamento departamento)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarInmuebleDepartamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID2", departamento.InmuebleID2);
                cmd.Parameters.AddWithValue("@Cantbao", departamento.CantBao);
                cmd.Parameters.AddWithValue("@Canthabitaciones", departamento.CantHabitacinoes);
                cmd.Parameters.AddWithValue("@Ubipisos", departamento.Ubipisos);
                cmd.Parameters.AddWithValue("@Aream2", departamento.Aream2);
                cmd.Parameters.AddWithValue("@Fechaconstruccion", departamento.Fechaconstruccion);
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

        public List<entDepartamento> ListarInmuebleDepartamento()
        {
            List<entDepartamento> lista = new List<entDepartamento>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarDepartamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDepartamento departamento = new entDepartamento();
                    departamento.InmuebleID2 = Convert.ToInt32(dr["InmuebleID2"]);
                    departamento.Ubipisos = Convert.ToInt32(dr["Ubipisos"]);
                    departamento.Fechaconstruccion = Convert.ToDateTime(dr["Fechaconstruccion"]);
                    departamento.CantHabitacinoes = Convert.ToInt32(dr["Canthabitaciones"]);
                    departamento.CantBao = Convert.ToInt32(dr["Cantbao"]);
                    departamento.Aream2 = (float)Convert.ToDouble(dr["Aream2"]);

                    lista.Add(departamento);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public entDepartamento DatosDepartamento(int idDepartamento)
        {
            entDepartamento departamento = new entDepartamento();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosDepartamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID2", idDepartamento);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    departamento.InmuebleID2 = Convert.ToInt32(dr["InmuebleID2"]);
                    departamento.Ubipisos = Convert.ToInt32(dr["Ubipisos"]);
                    departamento.Fechaconstruccion = Convert.ToDateTime(dr["Fechaconstruccion"]);
                    departamento.CantHabitacinoes = Convert.ToInt32(dr["Canthabitaciones"]);
                    departamento.CantBao = Convert.ToInt32(dr["Cantbao"]);
                    departamento.Aream2 = (float)Convert.ToDouble(dr["Aream2"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return departamento;
        }
        public void ModifcarDepartamento(entDepartamento departamento)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarDepartamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID2", departamento.InmuebleID2);
                cmd.Parameters.AddWithValue("@Cantbao", departamento.CantBao);
                cmd.Parameters.AddWithValue("@Canthabitaciones", departamento.CantHabitacinoes);
                cmd.Parameters.AddWithValue("@Ubipisos", departamento.Ubipisos);
                cmd.Parameters.AddWithValue("@Aream2", departamento.Aream2);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }
    }
}