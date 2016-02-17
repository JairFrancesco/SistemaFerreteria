using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaFerreteria_VENTAS_ALMACEN.Datos
{
    public class ConexionBaseDatos
    {
        public SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=SistemaFerreteria;Integrated Security=SSPI");
        public void ObtenerConexion()
        {
            Conn.Open();
        }
        public void CerrarConexion()
        {
            Conn.Close();
        }
    }
}
