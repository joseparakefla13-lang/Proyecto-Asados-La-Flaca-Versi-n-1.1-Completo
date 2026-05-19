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
            panel1 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            IdInventario = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            button15 = new Button();
            textBox2 = new TextBox();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1756, 1158);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Goldenrod;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1756, 98);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 26);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(332, 43);
            label6.TabIndex = 2;
            label6.Text = "Asados La Flaca";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(7429, -80);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 30);
            label7.TabIndex = 1;
            label7.Text = "Guillermina ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Goldenrod;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdInventario, IdProducto, Cantidad });
            dataGridView1.Location = new Point(108, 542);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1541, 474);
            dataGridView1.TabIndex = 19;
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
            button15.Location = new Point(1129, 144);
            button15.Margin = new Padding(6);
            button15.Name = "button15";
            button15.Size = new Size(69, 64);
            button15.TabIndex = 18;
            button15.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(681, 144);
            textBox2.Margin = new Padding(6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 64);
            textBox2.TabIndex = 17;
            textBox2.Text = "    Buscar Producto...";
            // 
            // button13
            // 
            button13.BackColor = Color.Goldenrod;
            button13.FlatAppearance.BorderSize = 0;
            button13.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(1435, 296);
            button13.Margin = new Padding(6);
            button13.Name = "button13";
            button13.Size = new Size(214, 85);
            button13.TabIndex = 16;
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
            button12.Location = new Point(795, 286);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(167, 85);
            button12.TabIndex = 15;
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
            button11.Location = new Point(108, 296);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(167, 85);
            button11.TabIndex = 14;
            button11.Text = "Nuevo";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 1158);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label6;
        private Label label7;
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