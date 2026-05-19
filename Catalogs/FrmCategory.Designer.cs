namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmCategory
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
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            IDCategoria = new DataGridViewTextBoxColumn();
            NombreCategoria = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            button14 = new Button();
            button15 = new Button();
            textBox2 = new TextBox();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(button14);
            panel4.Controls.Add(button15);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(button13);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(1756, 1158);
            panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCategoria, NombreCategoria, Estado });
            dataGridView1.Location = new Point(119, 522);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1519, 549);
            dataGridView1.TabIndex = 9;
            // 
            // IDCategoria
            // 
            IDCategoria.HeaderText = "IDCategoria";
            IDCategoria.MinimumWidth = 10;
            IDCategoria.Name = "IDCategoria";
            IDCategoria.ReadOnly = true;
            // 
            // NombreCategoria
            // 
            NombreCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            NombreCategoria.HeaderText = "NombreCategoria";
            NombreCategoria.MinimumWidth = 10;
            NombreCategoria.Name = "NombreCategoria";
            NombreCategoria.ReadOnly = true;
            NombreCategoria.Width = 249;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // button14
            // 
            button14.BackColor = Color.Gray;
            button14.FlatAppearance.BorderSize = 0;
            button14.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button14.ForeColor = Color.White;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(570, 314);
            button14.Margin = new Padding(6);
            button14.Name = "button14";
            button14.Size = new Size(199, 85);
            button14.TabIndex = 8;
            button14.Text = "Eliminar";
            button14.TextAlign = ContentAlignment.MiddleRight;
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(1120, 153);
            button15.Margin = new Padding(6);
            button15.Name = "button15";
            button15.Size = new Size(69, 64);
            button15.TabIndex = 7;
            button15.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(681, 158);
            textBox2.Margin = new Padding(6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 59);
            textBox2.TabIndex = 6;
            textBox2.Text = "    Buscar Producto...";
            // 
            // button13
            // 
            button13.BackColor = Color.Goldenrod;
            button13.FlatAppearance.BorderSize = 0;
            button13.Font = new Font("Georgia", 8F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(1424, 314);
            button13.Margin = new Padding(6);
            button13.Name = "button13";
            button13.Size = new Size(214, 85);
            button13.TabIndex = 3;
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
            button12.Location = new Point(1022, 314);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(167, 85);
            button12.TabIndex = 2;
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
            button11.Location = new Point(152, 314);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(167, 85);
            button11.TabIndex = 1;
            button11.Text = "Nuevo";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(191, 38);
            label3.TabIndex = 0;
            label3.Text = "Categorias";
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
            panel3.TabIndex = 11;
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
            label7.Location = new Point(5847, -79);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 30);
            label7.TabIndex = 1;
            label7.Text = "Guillermina ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 1158);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "FrmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategory";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDCategoria;
        private DataGridViewTextBoxColumn NombreCategoria;
        private DataGridViewTextBoxColumn Estado;
        private Button button14;
        private Button button15;
        private TextBox textBox2;
        private Button button13;
        private Button button12;
        private Button button11;
        private Label label3;
        private Panel panel3;
        private Label label6;
        private Label label7;
    }
}