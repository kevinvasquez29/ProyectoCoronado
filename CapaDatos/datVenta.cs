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
    public class datVenta
    {
        #region singleton
        private static datVenta _instancia = new datVenta();

        public static datVenta Instancia
        {
            get { return datVenta._instancia; }
        }
        #endregion singleton
        public Boolean RegistrarVenta(entVenta Venta)
        {
            SqlCommand cmd = null;
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BancoID", Venta.BancoID);
                cmd.Parameters.AddWithValue("@CitaID", Venta.CitaID);
                cmd.Parameters.AddWithValue("@ContratoID", Venta.ContratoID);
                cmd.Parameters.AddWithValue("@Escriturapublica", Venta.Escriturapublica);
                cmd.Parameters.AddWithValue("@Precio", Venta.Precio);
                cmd.Parameters.AddWithValue("@Fechaventa", Venta.Fechaventa);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registra = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return registra;
        }
        public List<entVenta> ListarVenta()
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVenta venta = new entVenta();
                    venta.VentaID = Convert.ToInt32(dr["VentaID"]);
                    venta.BancoID = Convert.ToInt32(dr["BancoID"]);
                    venta.CitaID = Convert.ToInt32(dr["CitaID"]);
                    venta.ContratoID = Convert.ToInt32(dr["ContratoID"]);
                    venta.Escriturapublica = Convert.ToInt32(dr["Escriturapublica"]);
                    venta.Precio = (float)Convert.ToDouble((dr["Precio"]));
                    venta.Fechaventa = Convert.ToDateTime(dr["Fechaventa"]);
                    lista.Add(venta);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean ExisteNEscrituraPublica(int NEscritura)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteNEscrituraPublica", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Escriturapublica", NEscritura);
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