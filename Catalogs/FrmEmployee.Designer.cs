namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmEmployee
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
            GbxEmpleado = new GroupBox();
            TxtTelefono = new TextBox();
            LblTeléfono = new Label();
            BtnCerrarEmpl = new Button();
            BtnLimpiarEmpl = new Button();
            BtnEliminarEmpl = new Button();
            BtnGuardarEmpl = new Button();
            BtnAgregarEmpl = new Button();
            CbAvailable = new CheckBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            LblDisponible = new Label();
            LblCargo = new Label();
            LblApellidos = new Label();
            LblNombre = new Label();
            LblCodigo = new Label();
            DtgEmpleado = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEmpleado).BeginInit();
            SuspendLayout();
            // 
            // GbxEmpleado
            // 
            GbxEmpleado.BackColor = Color.FromArgb(243, 231, 211);
            GbxEmpleado.Controls.Add(TxtTelefono);
            GbxEmpleado.Controls.Add(LblTeléfono);
            GbxEmpleado.Controls.Add(BtnCerrarEmpl);
            GbxEmpleado.Controls.Add(BtnLimpiarEmpl);
            GbxEmpleado.Controls.Add(BtnEliminarEmpl);
            GbxEmpleado.Controls.Add(BtnGuardarEmpl);
            GbxEmpleado.Controls.Add(BtnAgregarEmpl);
            GbxEmpleado.Controls.Add(CbAvailable);
            GbxEmpleado.Controls.Add(comboBox1);
            GbxEmpleado.Controls.Add(textBox3);
            GbxEmpleado.Controls.Add(textBox2);
            GbxEmpleado.Controls.Add(textBox1);
            GbxEmpleado.Controls.Add(LblDisponible);
            GbxEmpleado.Controls.Add(LblCargo);
            GbxEmpleado.Controls.Add(LblApellidos);
            GbxEmpleado.Controls.Add(LblNombre);
            GbxEmpleado.Controls.Add(LblCodigo);
            GbxEmpleado.Cursor = Cursors.Hand;
            GbxEmpleado.Dock = DockStyle.Top;
            GbxEmpleado.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxEmpleado.ForeColor = Color.FromArgb(45, 45, 45);
            GbxEmpleado.Location = new Point(0, 0);
            GbxEmpleado.Name = "GbxEmpleado";
            GbxEmpleado.Size = new Size(1748, 848);
            GbxEmpleado.TabIndex = 0;
            GbxEmpleado.TabStop = false;
            GbxEmpleado.Text = "Registrar Empleado";
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.FromArgb(246, 246, 247);
            TxtTelefono.BorderStyle = BorderStyle.None;
            TxtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTelefono.ForeColor = Color.FromArgb(45, 45, 45);
            TxtTelefono.Location = new Point(1157, 336);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(365, 43);
            TxtTelefono.TabIndex = 29;
            // 
            // LblTeléfono
            // 
            LblTeléfono.AutoSize = true;
            LblTeléfono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTeléfono.Location = new Point(829, 334);
            LblTeléfono.Name = "LblTeléfono";
            LblTeléfono.Size = new Size(159, 45);
            LblTeléfono.TabIndex = 28;
            LblTeléfono.Text = "Teléfono:";
            // 
            // BtnCerrarEmpl
            // 
            BtnCerrarEmpl.FlatAppearance.BorderSize = 0;
            BtnCerrarEmpl.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrarEmpl.FlatStyle = FlatStyle.Flat;
            BtnCerrarEmpl.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarEmpl.Image = Properties.Resources.cerrar_ventana;
            BtnCerrarEmpl.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrarEmpl.Location = new Point(1450, 681);
            BtnCerrarEmpl.Name = "BtnCerrarEmpl";
            BtnCerrarEmpl.Size = new Size(201, 70);
            BtnCerrarEmpl.TabIndex = 24;
            BtnCerrarEmpl.Text = "Cerrar";
            BtnCerrarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnCerrarEmpl.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarEmpl
            // 
            BtnLimpiarEmpl.FlatAppearance.BorderSize = 0;
            BtnLimpiarEmpl.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLimpiarEmpl.FlatStyle = FlatStyle.Flat;
            BtnLimpiarEmpl.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiarEmpl.Image = Properties.Resources.escoba;
            BtnLimpiarEmpl.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimpiarEmpl.Location = new Point(1157, 681);
            BtnLimpiarEmpl.Name = "BtnLimpiarEmpl";
            BtnLimpiarEmpl.Size = new Size(201, 70);
            BtnLimpiarEmpl.TabIndex = 23;
            BtnLimpiarEmpl.Text = "Limpiar";
            BtnLimpiarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnLimpiarEmpl.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarEmpl
            // 
            BtnEliminarEmpl.FlatAppearance.BorderSize = 0;
            BtnEliminarEmpl.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnEliminarEmpl.FlatStyle = FlatStyle.Flat;
            BtnEliminarEmpl.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminarEmpl.Image = Properties.Resources.basura;
            BtnEliminarEmpl.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminarEmpl.Location = new Point(855, 681);
            BtnEliminarEmpl.Name = "BtnEliminarEmpl";
            BtnEliminarEmpl.Size = new Size(201, 70);
            BtnEliminarEmpl.TabIndex = 22;
            BtnEliminarEmpl.Text = "Eliminar";
            BtnEliminarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminarEmpl.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarEmpl
            // 
            BtnGuardarEmpl.FlatAppearance.BorderSize = 0;
            BtnGuardarEmpl.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnGuardarEmpl.FlatStyle = FlatStyle.Flat;
            BtnGuardarEmpl.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarEmpl.Image = Properties.Resources.abajo;
            BtnGuardarEmpl.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardarEmpl.Location = new Point(564, 681);
            BtnGuardarEmpl.Name = "BtnGuardarEmpl";
            BtnGuardarEmpl.Size = new Size(201, 70);
            BtnGuardarEmpl.TabIndex = 21;
            BtnGuardarEmpl.Text = "Guardar";
            BtnGuardarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardarEmpl.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarEmpl
            // 
            BtnAgregarEmpl.FlatAppearance.BorderSize = 0;
            BtnAgregarEmpl.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnAgregarEmpl.FlatStyle = FlatStyle.Flat;
            BtnAgregarEmpl.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarEmpl.Image = Properties.Resources.agregar_producto__1_;
            BtnAgregarEmpl.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarEmpl.Location = new Point(300, 681);
            BtnAgregarEmpl.Name = "BtnAgregarEmpl";
            BtnAgregarEmpl.Size = new Size(201, 70);
            BtnAgregarEmpl.TabIndex = 20;
            BtnAgregarEmpl.Text = "Agregar";
            BtnAgregarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarEmpl.UseVisualStyleBackColor = true;
            // 
            // CbAvailable
            // 
            CbAvailable.AutoSize = true;
            CbAvailable.FlatStyle = FlatStyle.Flat;
            CbAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbAvailable.Location = new Point(1279, 491);
            CbAvailable.Name = "CbAvailable";
            CbAvailable.Size = new Size(136, 49);
            CbAvailable.TabIndex = 9;
            CbAvailable.Text = "Activo";
            CbAvailable.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(246, 246, 247);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(45, 45, 45);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1157, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 53);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Seleccione Cargo";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(246, 246, 247);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(45, 45, 45);
            textBox3.Location = new Point(259, 497);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 43);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(246, 246, 247);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(45, 45, 45);
            textBox2.Location = new Point(259, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 43);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(246, 246, 247);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(45, 45, 45);
            textBox1.Location = new Point(265, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 43);
            textBox1.TabIndex = 5;
            // 
            // LblDisponible
            // 
            LblDisponible.AutoSize = true;
            LblDisponible.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDisponible.Location = new Point(798, 495);
            LblDisponible.Name = "LblDisponible";
            LblDisponible.Size = new Size(190, 45);
            LblDisponible.TabIndex = 4;
            LblDisponible.Text = "Disponible:";
            // 
            // LblCargo
            // 
            LblCargo.AutoSize = true;
            LblCargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCargo.Location = new Point(869, 192);
            LblCargo.Name = "LblCargo";
            LblCargo.Size = new Size(119, 45);
            LblCargo.TabIndex = 3;
            LblCargo.Text = "Cargo:";
            // 
            // LblApellidos
            // 
            LblApellidos.AutoSize = true;
            LblApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblApellidos.Location = new Point(44, 497);
            LblApellidos.Name = "LblApellidos";
            LblApellidos.Size = new Size(170, 45);
            LblApellidos.TabIndex = 2;
            LblApellidos.Text = "Apellidos:";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(44, 334);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(167, 45);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "Nombres:";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(73, 192);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(138, 45);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código:";
            // 
            // DtgEmpleado
            // 
            DtgEmpleado.AccessibleName = "";
            DtgEmpleado.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgEmpleado.BorderStyle = BorderStyle.None;
            DtgEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgEmpleado.Columns.AddRange(new DataGridViewColumn[] { Codigo, Teléfono, Nombres, Apellido, Cargo, Estado });
            DtgEmpleado.Dock = DockStyle.Top;
            DtgEmpleado.Location = new Point(0, 848);
            DtgEmpleado.Name = "DtgEmpleado";
            DtgEmpleado.RowHeadersWidth = 82;
            DtgEmpleado.Size = new Size(1748, 540);
            DtgEmpleado.TabIndex = 1;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 10;
            Codigo.Name = "Codigo";
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 10;
            Teléfono.Name = "Teléfono";
            Teléfono.Width = 200;
            // 
            // Nombres
            // 
            Nombres.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 10;
            Nombres.Name = "Nombres";
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.HeaderText = "Apellidos";
            Apellido.MinimumWidth = 10;
            Apellido.Name = "Apellido";
            // 
            // Cargo
            // 
            Cargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 10;
            Cargo.Name = "Cargo";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1748, 1386);
            Controls.Add(DtgEmpleado);
            Controls.Add(GbxEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmpleado";
            GbxEmpleado.ResumeLayout(false);
            GbxEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxEmpleado;
        private Label LblCargo;
        private Label LblApellidos;
        private Label LblNombre;
        private Label LblCodigo;
        private Label LblDisponible;
        private CheckBox CbAvailable;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button BtnCerrarEmpl;
        private Button BtnLimpiarEmpl;
        private Button BtnEliminarEmpl;
        private Button BtnGuardarEmpl;
        private Button BtnAgregarEmpl;
        private DataGridView DtgEmpleado;
        private TextBox TxtTelefono;
        private Label LblTeléfono;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Estado;
    }
}