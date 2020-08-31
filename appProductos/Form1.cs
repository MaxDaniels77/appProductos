using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appProductos
{       // conexion server = "Data Source = .\\sqlexpress;Initial Catalog = db_productos; Integrated Security=True";
    public partial class Form1 : Form
    {
        public string cadenaConexion = "Data Source = .\\sqlexpress;Initial Catalog = db_productos; Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }
        public string linkConexion()
        {
            return cadenaConexion;
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            //string cadenaConexion = "Data Source = .\\qlexpress;Initial Catalog = db_productos; Integrated Security=True";
            SqlConnection conectar = new SqlConnection(cadenaConexion);

            try
            {
                conectar.Open();
                MessageBox.Show("Se ha conectado correctamente \n");

            }
            catch (SqlException s)
            {
                MessageBox.Show("Se ha encontrado el siguiente problema: " + s.ToString());

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection tstStartCon = new SqlConnection(cadenaConexion);

            try
            {
                tstStartCon.Open();
                MessageBox.Show("Se ha conectado correctamente \n");

            }
            catch (SqlException s)
            {
                //Console.WriteLine(": {0}", s);
                MessageBox.Show("Se ha encontrado el siguiente problema: " + s.ToString());

            }




            Productos prod = new Productos();
            dgvProductos.DataSource = prod.MostrarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion conectar = new Conexion();
            string consulta = "SELECT Productos.nombreProducto,Productos.precioProducto,Categorias.nombreCategoria FROM Productos inner join Categorias on Categorias.idCategoria = Productos.idCategoria;";
            SqlCommand sql = new SqlCommand(consulta, conectar.aplicarCadena());
            SqlDataReader filas = sql.ExecuteReader();
            string textoEnPantalla = "Los datos son: \n";
            while (filas.Read())
            {
                textoEnPantalla += filas.GetValue(0).ToString() + " : "
                    + filas.GetValue(1).ToString() + " : "
                    + filas.GetValue(2).ToString() + "\n";

            }
            MessageBox.Show(textoEnPantalla);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /* Puede servir 
        private void button5_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            SqlCommand sql = new SqlCommand("SELECT * FROM Productos;", con.aplicarCadena());
            SqlDataReader filas = sql.ExecuteReader();
            string textoEnPantalla = "Los datos son: \n";
            while (filas.Read())
            {
                textoEnPantalla += filas.GetValue(0).ToString() + " : "
                    + filas.GetValue(1).ToString() + " : "
                    + filas.GetValue(2).ToString() + "\n";

            }
            MessageBox.Show(textoEnPantalla);
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            string query = "INSERT INTO Productos (nombreProducto,precioProducto,stockProducto,idCategoria) VALUES (@nombre,@precio,@stock,@categoria)";
            SqlCommand command = new SqlCommand(query, conectar.aplicarCadena());
            command.Parameters.AddWithValue("@nombre", textNombre.Text);
            command.Parameters.AddWithValue("@precio", textPrecio.Text);
            command.Parameters.AddWithValue("@stock", textStock.Text);
            command.Parameters.AddWithValue("@categoria", textIdCategoria.Text);
            
            try
            {
                command.ExecuteNonQuery();
                Productos prod = new Productos();
                dgvProductos.DataSource = prod.MostrarProductos();
                MessageBox.Show("Agregado Correctamente");

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.ToString());
            }
            // actualizamos la db

            conectar.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            if (textIdProducto.Text == "" && textIdCategoria.Text == "" && textNombre.Text == "" &&
                textPrecio.Text == "" && textStock.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacios");

            }
            else if (textIdProducto.Text == "" | textIdCategoria.Text == "" && textNombre.Text != "" &&
               textPrecio.Text != "" && textStock.Text != "")
            {
                MessageBox.Show("Los campos idProducto e idCategoria no deben estar vacios");

            }
            else if (textIdProducto.Text != "" && textIdCategoria.Text != "" && textNombre.Text != "" &&
               textPrecio.Text == "" && textStock.Text == "")
            {
                string query1 = "UPDATE Productos SET nombreProducto = @nombre," +
    "idCategoria=@categoria WHERE idProducto = @id";

                SqlCommand command1 = new SqlCommand(query1, conectar.aplicarCadena());
                command1.Parameters.AddWithValue("@nombre", textNombre.Text);
                command1.Parameters.AddWithValue("@categoria", textIdCategoria.Text);
                command1.Parameters.AddWithValue("@id", textIdProducto.Text);
                try
                {
                    command1.ExecuteNonQuery();
                }
                catch (SqlException s)
                {

                    MessageBox.Show(s.ToString());

                }
            }
            else if (textIdProducto.Text != "" && textIdCategoria.Text != "" && textNombre.Text == "" &&
          textPrecio.Text == "" && textStock.Text != "")
            {
                string query1 = "UPDATE Productos SET stockProducto = @stock," +
    "idCategoria=@categoria WHERE idProducto = @id";

                SqlCommand command1 = new SqlCommand(query1, conectar.aplicarCadena());
                command1.Parameters.AddWithValue("@stock", textStock.Text);
                command1.Parameters.AddWithValue("@categoria", textIdCategoria.Text);
                command1.Parameters.AddWithValue("@id", textIdProducto.Text);
                try
                {
                    command1.ExecuteNonQuery();
                }
                catch (SqlException s)
                {

                    MessageBox.Show(s.ToString());

                }
            }
            else if (textIdProducto.Text != "" && textIdCategoria.Text != "" && textNombre.Text == "" &&
         textPrecio.Text != "" && textStock.Text == "")
            {
                string query1 = "UPDATE Productos SET precioProducto = @precio," +
    "idCategoria=@categoria WHERE idProducto = @id";

                SqlCommand command1 = new SqlCommand(query1, conectar.aplicarCadena());
                command1.Parameters.AddWithValue("@precio", textPrecio.Text);
                command1.Parameters.AddWithValue("@categoria", textIdCategoria.Text);
                command1.Parameters.AddWithValue("@id", textIdProducto.Text);
                try
                {
                    command1.ExecuteNonQuery();
                }
                catch (SqlException s)
                {

                    MessageBox.Show(s.ToString());

                }
            }


            else
            {
                string query = "UPDATE Productos SET nombreProducto = @nombre, precioProducto = @precio," +
                "stockProducto = @stock,idCategoria=@categoria WHERE idProducto = @id";





                SqlCommand command = new SqlCommand(query, conectar.aplicarCadena());
                command.Parameters.AddWithValue("@nombre", textNombre.Text);
                command.Parameters.AddWithValue("@precio", textPrecio.Text);
                command.Parameters.AddWithValue("@stock", textStock.Text);
                command.Parameters.AddWithValue("@categoria", textIdCategoria.Text);
                command.Parameters.AddWithValue("@id", textIdProducto.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException s)
                {

                    MessageBox.Show(s.ToString());
                    MessageBox.Show("Inserte idProducto e idCategoria para realizar modificaciones");

                }
            }




            
            conectar.Close();
            Productos prod = new Productos();
            dgvProductos.DataSource = prod.MostrarProductos();
            //MessageBox.Show("Modificado Correctamente");



        }

        private void button4_Click(object sender, EventArgs e)
        {   if (textIdProducto.Text == "")
            {
                MessageBox.Show("Falta idProducto");
            }
            else
            {
                Conexion conectar = new Conexion();
                string query = "DELETE FROM Productos WHERE idProducto = @id";
                SqlCommand command = new SqlCommand(query, conectar.aplicarCadena());
                command.Parameters.AddWithValue("@id", textIdProducto.Text);

                command.ExecuteNonQuery();
                conectar.Close();
                Productos prod = new Productos();
                dgvProductos.DataSource = prod.MostrarProductos();
                MessageBox.Show("Eliminado Correctamente");
            }

        }

        private void textIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIdCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            dgvProductos.DataSource = prod.MostrarProductos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form21 form = new Form21();
            // con esto llamo al objeto de el form21 y lo pongo visible
            form.Visible = true;
            //ocultamos el formulario 1 de ser necesario, pero solo quiero llamarlo
            // Visible=false;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
