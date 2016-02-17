using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaFerreteria_VENTAS_ALMACEN.Datos
{
    public class Usuario:ConexionBaseDatos
    {
        public int VerificarUsuario(string nombreusuario, string claveusuario)
        {
            SqlCommand comando = new SqlCommand("VERIFICARUSUARIO", Conn);
            comando.Parameters.AddWithValue("@Nombre_usuario", nombreusuario);
            comando.Parameters.AddWithValue("@Contrasenia_usuario", claveusuario);
            ObtenerConexion();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            return reader.GetInt32(0); 
        }
    }
}
