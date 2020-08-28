using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace appProductos
{
    class Conexion : Form1 { // conexion toma un path del servidor creado en Form1, y obtiene el string
        // usando el metodo linkConexion(), seria mas explicito si lo hiciese desde un archivo de configuracion, pero 
        // no me deja crear uno, el visual y esto anda bien...

       public SqlConnection aplicarCadena()
        {   
            SqlConnection conectar = new SqlConnection(linkConexion());
            if(conectar.State == ConnectionState.Open) {
                conectar.Close();
            }
            else
            {
                conectar.Open();
            }
            return conectar;
        }
    }
}
