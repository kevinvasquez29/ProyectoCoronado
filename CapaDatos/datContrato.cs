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
    public class datContrato
    {
        #region singleton
        private static datContrato _instancia = new datContrato();

        public static datContrato Instancia
        {
            get { return datContrato._instancia; }
        }
        #endregion singleton
        public entContrato DatosContrato()
        {
            entContrato contrato = new entContrato();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DatosContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    contrato.ContratoID = Convert.ToInt32(dr["ContratoID"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return contrato;
        }
    }
}
