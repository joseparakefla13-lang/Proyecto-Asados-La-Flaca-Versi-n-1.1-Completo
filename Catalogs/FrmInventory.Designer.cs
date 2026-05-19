namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmInventory
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            IdInventario = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            button15 = new Button();
            textBox2 = new TextBox();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Maroon;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button15);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button13);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button11);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1756, 1158);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Goldenrod;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdInventario, IdProducto, Cantidad });
            dataGridView1.Location = new Point(100, 503);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1541, 320);
            dataGridView1.TabIndex = 7;
            // 
            // IdInventario
            // 
            IdInventario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdInventario.HeaderText = "IdInventario";
            IdInventario.MinimumWidth = 10;
            IdInventario.Name = "IdInventario";
            // 
            // IdProducto
            // 
            IdProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 10;
            IdProducto.Name = "IdProducto";
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(1572, 263);
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
            textBox2.Location = new Point(1116, 263);
            textBox2.Margin = new Padding(6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 64);
            textBox2.TabIndex = 4;
            textBox2.Text = "    Buscar Producto...";
            // 
            // button13
            // 
            button13.BackColor = Color.Goldenrod;
            button13.FlatAppearance.BorderSize = 0;
            button13.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(769, 257);
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
            button12.Location = new Point(444, 257);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(167, 85);
            button12.TabIndex = 1;
            button12.Text = "Editar";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Green;
            button11.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(100, 257);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(167, 85);
            button11.TabIndex = 0;
            button11.Text = "Nuevo";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 1158);
            Controls.Add(groupBox1);
            Name = "FrmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInventory";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdInventario;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private Button button15;
        private TextBox textBox2;
        private Button button13;
        private Button button12;
        private Button button11;
    }
}