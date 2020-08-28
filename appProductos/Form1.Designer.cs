namespace appProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textIdProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textIdCategoria = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(224, 9);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(183, 34);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chequear conexion:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(226, 116);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(376, 31);
            this.textNombre.TabIndex = 8;
            this.textNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(226, 165);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(376, 31);
            this.textPrecio.TabIndex = 9;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(226, 211);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(376, 31);
            this.textStock.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(670, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(-3, 404);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.Size = new System.Drawing.Size(816, 340);
            this.dgvProductos.TabIndex = 17;
            this.dgvProductos.Text = "dataGridView1";
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(296, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Registro de productos ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "idProducto: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textIdProducto
            // 
            this.textIdProducto.Location = new System.Drawing.Point(224, 255);
            this.textIdProducto.Name = "textIdProducto";
            this.textIdProducto.Size = new System.Drawing.Size(378, 31);
            this.textIdProducto.TabIndex = 22;
            this.textIdProducto.TextChanged += new System.EventHandler(this.textIdProducto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "idCategoria: ";
            // 
            // textIdCategoria
            // 
            this.textIdCategoria.Location = new System.Drawing.Point(226, 301);
            this.textIdCategoria.Name = "textIdCategoria";
            this.textIdCategoria.Size = new System.Drawing.Size(378, 31);
            this.textIdCategoria.TabIndex = 22;
            this.textIdCategoria.TextChanged += new System.EventHandler(this.textIdCategoria_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(670, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 34);
            this.button7.TabIndex = 23;
            this.button7.Text = "Actualizar base";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Location = new System.Drawing.Point(670, 14);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(112, 34);
            this.btnGestion.TabIndex = 24;
            this.btnGestion.Text = "Gestión";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, -173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, -163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Gestion Categorias: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 739);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textIdCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textIdProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Programa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIdProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textIdCategoria;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
    }
}

