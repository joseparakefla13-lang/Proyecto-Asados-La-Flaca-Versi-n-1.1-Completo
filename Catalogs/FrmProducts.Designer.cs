namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            IdPedido = new DataGridViewTextBoxColumn();
            Nombreproducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            button15 = new Button();
            textBox2 = new TextBox();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Goldenrod;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPedido, Nombreproducto, Cantidad, Precio, Descripcion });
            dataGridView1.Location = new Point(41, 448);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1668, 585);
            dataGridView1.TabIndex = 8;
            // 
            // IdPedido
            // 
            IdPedido.FillWeight = 110F;
            IdPedido.HeaderText = "Id";
            IdPedido.MinimumWidth = 10;
            IdPedido.Name = "IdPedido";
            IdPedido.ReadOnly = true;
            // 
            // Nombreproducto
            // 
            Nombreproducto.FillWeight = 110F;
            Nombreproducto.HeaderText = "Nombre";
            Nombreproducto.MinimumWidth = 10;
            Nombreproducto.Name = "Nombreproducto";
            Nombreproducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 110F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.FillWeight = 110F;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 10;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(1640, 237);
            button15.Margin = new Padding(6);
            button15.Name = "button15";
            button15.Size = new Size(69, 64);
            button15.TabIndex = 5;
            button15.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(1218, 242);
            textBox2.Margin = new Padding(6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(388, 59);
            textBox2.TabIndex = 4;
            textBox2.Text = "    Buscar Producto...";
            // 
            // button14
            // 
            button14.BackColor = Color.Brown;
            button14.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button14.ForeColor = Color.Black;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(598, 219);
            button14.Margin = new Padding(6);
            button14.Name = "button14";
            button14.Size = new Size(204, 85);
            button14.TabIndex = 3;
            button14.Text = "Eliminar";
            button14.TextAlign = ContentAlignment.MiddleRight;
            button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Goldenrod;
            button13.FlatAppearance.BorderSize = 0;
            button13.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(908, 216);
            button13.Margin = new Padding(6);
            button13.Name = "button13";
            button13.Size = new Size(214, 85);
            button13.TabIndex = 2;
            button13.Text = "Actualizar";
            button13.TextAlign = ContentAlignment.MiddleRight;
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkGoldenrod;
            button12.FlatAppearance.BorderSize = 0;
            button12.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(318, 219);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(180, 85);
            button12.TabIndex = 1;
            button12.Text = "Editar";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Green;
            button11.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button11.ForeColor = SystemColors.ActiveCaptionText;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(41, 219);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(180, 85);
            button11.TabIndex = 0;
            button11.Text = "Nuevo";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1756, 1158);
            panel1.TabIndex = 2;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1756, 1158);
            Controls.Add(panel1);
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducts";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdPedido;
        private DataGridViewTextBoxColumn Nombreproducto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private Button button15;
        private TextBox textBox2;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Panel panel1;
    }
}