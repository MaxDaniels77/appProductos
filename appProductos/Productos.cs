using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace appProductos
{
    public class Productos
    {
        Conexion cn = new Conexion();
        public DataTable MostrarProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarTablaProductos",cn.aplicarCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
