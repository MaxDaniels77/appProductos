using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace appProductos
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            dgvCategorias.DataSource = cat.MostrarCategorias();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            string query = "INSERT INTO Categorias (nombreCategoria) VALUES (@nombreCategoria)";
            SqlCommand command = new SqlCommand(query, conectar.aplicarCadena());
            command.Parameters.AddWithValue("@nombreCategoria", textNombreCategoria.Text);

            try
            {
                command.ExecuteNonQuery();
                Categorias prod = new Categorias();
                dgvCategorias.DataSource = prod.MostrarCategorias();
                MessageBox.Show("Agregado Correctamente");

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.ToString());
            }
            conectar.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textIdCategoria.Text == "")
            {
                MessageBox.Show("Falta idCategoria");
            }
            else
            {
                Conexion conectar = new Conexion();
                string query = "DELETE FROM Categorias WHERE idCategoria = @id";
                SqlCommand command = new SqlCommand(query, conectar.aplicarCadena());
                command.Parameters.AddWithValue("@id", textIdCategoria.Text);

                command.ExecuteNonQuery();
                conectar.Close();
                Categorias prod = new Categorias();
                dgvCategorias.DataSource = prod.MostrarCategorias();
                MessageBox.Show("Eliminado Correctamente");
            }           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   if (textIdCategoria.Text == "" && textNombreCategoria.Text!="")
            {
                MessageBox.Show("El campo idCategoria no puede estar vacio");

            }

            else if(textIdCategoria.Text == "" && textNombreCategoria.Text == "")
            {
                
            }else
            {
                Conexion conectar = new Conexion();
                string query = "UPDATE Categorias SET nombreCategoria = @nombreCategoria WHERE idCategoria = @id";
                SqlCommand command = new SqlCommand(query, conectar.aplicarCadena());
                command.Parameters.AddWithValue("@nombreCategoria", textNombreCategoria.Text);
                command.Parameters.AddWithValue("@id", textIdCategoria.Text);
                command.ExecuteNonQuery();
                Categorias prod = new Categorias();
                dgvCategorias.DataSource = prod.MostrarCategorias();
                MessageBox.Show("Modificado Correctamente");
                conectar.Close();
            }

        }
    }
}
