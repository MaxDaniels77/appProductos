using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace appProductos
{
    class Categorias
    {
        Conexion cn = new Conexion();      
        public DataTable MostrarCategorias()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarTablaCategorias", cn.aplicarCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
