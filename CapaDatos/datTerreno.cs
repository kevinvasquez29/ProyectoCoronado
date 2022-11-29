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
    public class datTerreno
    {
        #region singleton
        private static datTerreno _instancia = new datTerreno();
        public static datTerreno Instancia
        {
            get { return datTerreno._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarTerreno(entTerreno terreno)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarInmuebleTerreno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID3", terreno.InmuebleID3);
                cmd.Parameters.AddWithValue("@Luz", terreno.Luz);
                cmd.Parameters.AddWithValue("@Desague", terreno.Desague);
                cmd.Parameters.AddWithValue("@Aream2", terreno.Aream2);
                cmd.Parameters.AddWithValue("@Alcantarillado", terreno.Alcantarillado);
                cmd.Parameters.AddWithValue("@Agua", terreno.agua);
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

        public List<entTerreno> ListarInmuebleTerreno()
        {
            List<entTerreno> lista = new List<entTerreno>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarTerreno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTerreno terreno = new entTerreno();
                    terreno.InmuebleID3 = Convert.ToInt32(dr["InmuebleID3"]);
                    terreno.Luz = Convert.ToBoolean(dr["Luz"]);
                    terreno.Desague = Convert.ToBoolean(dr["Desague"]);
                    terreno.Aream2 = (float)Convert.ToDouble(dr["Aream2"]);
                    terreno.Alcantarillado = Convert.ToBoolean(dr["Alcantarillado"]);
                    terreno.agua = Convert.ToBoolean(dr["Agua"]);
                    lista.Add(terreno);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public entTerreno DatosTerreno(int idTerreno)
        {
            entTerreno terreno = new entTerreno();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosTerreno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID3", idTerreno);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    terreno.InmuebleID3 = Convert.ToInt32(dr["InmuebleID3"]);
                    terreno.Luz = Convert.ToBoolean(dr["Luz"]);
                    terreno.Desague = Convert.ToBoolean(dr["Desague"]);
                    terreno.Aream2 = (float)Convert.ToDouble(dr["Aream2"]);
                    terreno.Alcantarillado = Convert.ToBoolean(dr["Alcantarillado"]);
                    terreno.agua = Convert.ToBoolean(dr["Agua"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return terreno;
        }
        public void ModifcarTerreno(entTerreno terreno)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarTerreno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID3", terreno.InmuebleID3);
                cmd.Parameters.AddWithValue("@Aream2", terreno.Aream2);
                cmd.Parameters.AddWithValue("@Agua", terreno.agua);
                cmd.Parameters.AddWithValue("@Alcantarillado", terreno.Alcantarillado);
                cmd.Parameters.AddWithValue("@Desague", terreno.Desague);
                cmd.Parameters.AddWithValue("@Luz", terreno.Luz);
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

