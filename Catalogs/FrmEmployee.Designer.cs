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
            TxtSearch = new TextBox();
            LblErrorPhone = new Label();
            LbErrorCode = new Label();
            TxtPhone = new TextBox();
            LblTeléfono = new Label();
            BtnCerrarEmpl = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnSave = new Button();
            BtnSearch = new Button();
            CbAvailable = new CheckBox();
            CbPosition = new ComboBox();
            TxtSurname = new TextBox();
            TxtName = new TextBox();
            TxtCode = new TextBox();
            LblDisponible = new Label();
            LblCargo = new Label();
            LblApellidos = new Label();
            LblNombre = new Label();
            LblCodigo = new Label();
            DtgEmployee = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEmployee).BeginInit();
            SuspendLayout();
            // 
            // GbxEmpleado
            // 
            GbxEmpleado.BackColor = Color.FromArgb(243, 231, 211);
            GbxEmpleado.Controls.Add(TxtSearch);
            GbxEmpleado.Controls.Add(LblErrorPhone);
            GbxEmpleado.Controls.Add(LbErrorCode);
            GbxEmpleado.Controls.Add(TxtPhone);
            GbxEmpleado.Controls.Add(LblTeléfono);
            GbxEmpleado.Controls.Add(BtnCerrarEmpl);
            GbxEmpleado.Controls.Add(BtnUpdate);
            GbxEmpleado.Controls.Add(BtnDelete);
            GbxEmpleado.Controls.Add(BtnSave);
            GbxEmpleado.Controls.Add(BtnSearch);
            GbxEmpleado.Controls.Add(CbAvailable);
            GbxEmpleado.Controls.Add(CbPosition);
            GbxEmpleado.Controls.Add(TxtSurname);
            GbxEmpleado.Controls.Add(TxtName);
            GbxEmpleado.Controls.Add(TxtCode);
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
            GbxEmpleado.Size = new Size(1748, 784);
            GbxEmpleado.TabIndex = 0;
            GbxEmpleado.TabStop = false;
            GbxEmpleado.Text = "Registrar Empleado";
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.FromArgb(246, 246, 247);
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSearch.ForeColor = Color.FromArgb(45, 45, 45);
            TxtSearch.Location = new Point(29, 692);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(365, 43);
            TxtSearch.TabIndex = 32;
            // 
            // LblErrorPhone
            // 
            LblErrorPhone.AutoSize = true;
            LblErrorPhone.BackColor = Color.Transparent;
            LblErrorPhone.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorPhone.ForeColor = Color.Red;
            LblErrorPhone.Location = new Point(1117, 417);
            LblErrorPhone.Name = "LblErrorPhone";
            LblErrorPhone.Size = new Size(368, 37);
            LblErrorPhone.TabIndex = 31;
            LblErrorPhone.Text = "El digisto permitido es de 8";
            LblErrorPhone.Visible = false;
            // 
            // LbErrorCode
            // 
            LbErrorCode.AutoSize = true;
            LbErrorCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbErrorCode.ForeColor = Color.Red;
            LbErrorCode.Location = new Point(142, 267);
            LbErrorCode.Name = "LbErrorCode";
            LbErrorCode.Size = new Size(601, 37);
            LbErrorCode.TabIndex = 30;
            LbErrorCode.Text = "El codigo debe de tener el formato \"EMP001\"";
            LbErrorCode.Visible = false;
            // 
            // TxtPhone
            // 
            TxtPhone.BackColor = Color.FromArgb(246, 246, 247);
            TxtPhone.BorderStyle = BorderStyle.None;
            TxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPhone.ForeColor = Color.FromArgb(45, 45, 45);
            TxtPhone.Location = new Point(1091, 334);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(431, 43);
            TxtPhone.TabIndex = 29;
            TxtPhone.TextChanged += TxtPhone_TextChanged;
            TxtPhone.Validating += TxtPhone_Validating;
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
            // BtnUpdate
            // 
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpdate.Image = Properties.Resources.escoba;
            BtnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUpdate.Location = new Point(1194, 681);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(201, 70);
            BtnUpdate.TabIndex = 23;
            BtnUpdate.Text = "Limpiar";
            BtnUpdate.TextAlign = ContentAlignment.MiddleRight;
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.Image = Properties.Resources.basura;
            BtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDelete.Location = new Point(912, 681);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(201, 70);
            BtnDelete.TabIndex = 22;
            BtnDelete.Text = "Eliminar";
            BtnDelete.TextAlign = ContentAlignment.MiddleRight;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSave
            // 
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.Image = Properties.Resources.abajo;
            BtnSave.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSave.Location = new Point(688, 681);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(201, 70);
            BtnSave.TabIndex = 21;
            BtnSave.Text = "Guardar";
            BtnSave.TextAlign = ContentAlignment.MiddleRight;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSearch.Image = Properties.Resources.agregar_producto__1_;
            BtnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearch.Location = new Point(431, 681);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(201, 70);
            BtnSearch.TabIndex = 20;
            BtnSearch.Text = "Buscar";
            BtnSearch.TextAlign = ContentAlignment.MiddleRight;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click_1;
            // 
            // CbAvailable
            // 
            CbAvailable.AutoSize = true;
            CbAvailable.FlatStyle = FlatStyle.Flat;
            CbAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbAvailable.Location = new Point(1229, 497);
            CbAvailable.Name = "CbAvailable";
            CbAvailable.Size = new Size(136, 49);
            CbAvailable.TabIndex = 9;
            CbAvailable.Text = "Activo";
            CbAvailable.UseVisualStyleBackColor = true;
            // 
            // CbPosition
            // 
            CbPosition.BackColor = Color.FromArgb(246, 246, 247);
            CbPosition.FlatStyle = FlatStyle.Flat;
            CbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbPosition.ForeColor = Color.FromArgb(45, 45, 45);
            CbPosition.FormattingEnabled = true;
            CbPosition.Location = new Point(1091, 189);
            CbPosition.Name = "CbPosition";
            CbPosition.Size = new Size(431, 53);
            CbPosition.TabIndex = 8;
            CbPosition.Text = "Seleccione Cargo";
            // 
            // TxtSurname
            // 
            TxtSurname.BackColor = Color.FromArgb(246, 246, 247);
            TxtSurname.BorderStyle = BorderStyle.None;
            TxtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSurname.ForeColor = Color.FromArgb(45, 45, 45);
            TxtSurname.Location = new Point(259, 497);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(365, 43);
            TxtSurname.TabIndex = 7;
            // 
            // TxtName
            // 
            TxtName.BackColor = Color.FromArgb(246, 246, 247);
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtName.ForeColor = Color.FromArgb(45, 45, 45);
            TxtName.Location = new Point(259, 336);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(373, 43);
            TxtName.TabIndex = 6;
            // 
            // TxtCode
            // 
            TxtCode.BackColor = Color.FromArgb(246, 246, 247);
            TxtCode.BorderStyle = BorderStyle.None;
            TxtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCode.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCode.Location = new Point(265, 194);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(367, 43);
            TxtCode.TabIndex = 5;
            TxtCode.Validating += TxtCode_Validating;
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
            // DtgEmployee
            // 
            DtgEmployee.AccessibleName = "";
            DtgEmployee.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgEmployee.BorderStyle = BorderStyle.None;
            DtgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgEmployee.Columns.AddRange(new DataGridViewColumn[] { Codigo, Teléfono, Nombres, Apellido, Cargo, Estado });
            DtgEmployee.Dock = DockStyle.Top;
            DtgEmployee.Location = new Point(0, 784);
            DtgEmployee.Name = "DtgEmployee";
            DtgEmployee.RowHeadersWidth = 82;
            DtgEmployee.Size = new Size(1748, 708);
            DtgEmployee.TabIndex = 1;
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
            Controls.Add(DtgEmployee);
            Controls.Add(GbxEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmpleado";
            Load += FrmEmployee_Load;
            GbxEmpleado.ResumeLayout(false);
            GbxEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEmployee).EndInit();
            ResumeLayout(false);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private GroupBox GbxEmpleado;
        private Label LblCargo;
        private Label LblApellidos;
        private Label LblNombre;
        private Label LblCodigo;
        private Label LblDisponible;
        private CheckBox CbAvailable;
        private ComboBox CbPosition;
        private TextBox TxtSurname;
        private TextBox TxtName;
        private TextBox TxtCode;
        private Button BtnCerrarEmpl;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnSave;
        private Button BtnSearch;
        private DataGridView DtgEmployee;
        private TextBox TxtPhone;
        private Label LblTeléfono;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Estado;
        private Label LblErrorPhone;
        private Label LbErrorCode;
        private TextBox TxtSearch;
    }
}