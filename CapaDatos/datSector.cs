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
    public class datSector
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly datSector _instancia = new datSector();
        public static datSector Instancia

        {
            get { return datSector._instancia; }
        }
        #endregion singleton
        public List<entSector> ListarSector()
        {
            SqlCommand cmd = null;
            List<entSector> lista = new List<entSector>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSector Sec = new entSector();
                    Sec.SectorID = Convert.ToInt32(dr["SectorID"]);
                    Sec.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    Sec.Nombresector = dr["Nombresector"].ToString();
                    Sec.Comentario = dr["Comentario"].ToString();

                    lista.Add(Sec);
                }
            }

            catch (Exception e)

            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean RegistrarSector(entSector sector)
        {
            SqlCommand cmd = null;
            Boolean registrar = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RegistrarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", sector.CiudadID);
                cmd.Parameters.AddWithValue("@Nombresector", sector.Nombresector);
                cmd.Parameters.AddWithValue("@Comentario", sector.Comentario);
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
        public Boolean ExisteDatosSector(string sector)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ExisteDatosSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombresector", sector);
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

        public Boolean ModificarSector(entSector sector)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SectorID", sector.SectorID);
                cmd.Parameters.AddWithValue("@Nombresector", sector.Nombresector);
                cmd.Parameters.AddWithValue("@Comentario", sector.Comentario);
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

        public Boolean BuscaSector(entSector sector)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SectorID", sector.SectorID);
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

        public entSector DatosSector(int SectorID)
        {
            entSector sec = new entSector();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DatosSector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SectorID", SectorID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sec.SectorID = Convert.ToInt32(dr["SectorID"]);
                    sec.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    sec.Nombresector = dr["Nombresector"].ToString();
                    sec.Comentario = dr["Comentario"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return sec;
        }





    }
}
