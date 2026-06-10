namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmCustomer
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
            GbxCliente = new GroupBox();
            DtmRegistrationDate = new DateTimePicker();
            TxtTypeOfCustomer = new TextBox();
            TxtName = new TextBox();
            TxtPhone = new TextBox();
            LblFecha = new Label();
            BtnCerrarClient = new Button();
            BtnLimpiarClient = new Button();
            BtnEliminarClient = new Button();
            BtnSaveClient = new Button();
            BtnAgregarClient = new Button();
            ChbStateCustomer = new CheckBox();
            TxtCustomerCode = new TextBox();
            LblDisponibleCliente = new Label();
            LblTipoDeCliente = new Label();
            LblTeléfono = new Label();
            LblNombreCliente = new Label();
            LblCodigoCliente = new Label();
            DgvCustomer = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            TipoCliente = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // GbxCliente
            // 
            GbxCliente.BackColor = Color.FromArgb(243, 231, 211);
            GbxCliente.Controls.Add(DtmRegistrationDate);
            GbxCliente.Controls.Add(TxtTypeOfCustomer);
            GbxCliente.Controls.Add(TxtName);
            GbxCliente.Controls.Add(TxtPhone);
            GbxCliente.Controls.Add(LblFecha);
            GbxCliente.Controls.Add(BtnCerrarClient);
            GbxCliente.Controls.Add(BtnLimpiarClient);
            GbxCliente.Controls.Add(BtnEliminarClient);
            GbxCliente.Controls.Add(BtnSaveClient);
            GbxCliente.Controls.Add(BtnAgregarClient);
            GbxCliente.Controls.Add(ChbStateCustomer);
            GbxCliente.Controls.Add(TxtCustomerCode);
            GbxCliente.Controls.Add(LblDisponibleCliente);
            GbxCliente.Controls.Add(LblTipoDeCliente);
            GbxCliente.Controls.Add(LblTeléfono);
            GbxCliente.Controls.Add(LblNombreCliente);
            GbxCliente.Controls.Add(LblCodigoCliente);
            GbxCliente.Cursor = Cursors.Hand;
            GbxCliente.Dock = DockStyle.Top;
            GbxCliente.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxCliente.ForeColor = Color.FromArgb(45, 45, 45);
            GbxCliente.Location = new Point(0, 0);
            GbxCliente.Name = "GbxCliente";
            GbxCliente.Size = new Size(1748, 845);
            GbxCliente.TabIndex = 1;
            GbxCliente.TabStop = false;
            GbxCliente.Text = "Registro de Cliente";
            // 
            // DtmRegistrationDate
            // 
            DtmRegistrationDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmRegistrationDate.CalendarForeColor = Color.FromArgb(45, 45, 45);
            DtmRegistrationDate.CalendarMonthBackground = Color.FromArgb(109, 15, 15);
            DtmRegistrationDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmRegistrationDate.Location = new Point(363, 510);
            DtmRegistrationDate.MinDate = new DateTime(2026, 6, 5, 0, 0, 0, 0);
            DtmRegistrationDate.Name = "DtmRegistrationDate";
            DtmRegistrationDate.Size = new Size(547, 50);
            DtmRegistrationDate.TabIndex = 29;
            DtmRegistrationDate.ValueChanged += DtmFecha_ValueChanged;
            // 
            // TxtTypeOfCustomer
            // 
            TxtTypeOfCustomer.BackColor = Color.FromArgb(246, 246, 247);
            TxtTypeOfCustomer.BorderStyle = BorderStyle.None;
            TxtTypeOfCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTypeOfCustomer.ForeColor = Color.FromArgb(45, 45, 45);
            TxtTypeOfCustomer.Location = new Point(1233, 330);
            TxtTypeOfCustomer.Name = "TxtTypeOfCustomer";
            TxtTypeOfCustomer.Size = new Size(365, 43);
            TxtTypeOfCustomer.TabIndex = 28;
            // 
            // TxtName
            // 
            TxtName.BackColor = Color.FromArgb(246, 246, 247);
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtName.ForeColor = Color.FromArgb(45, 45, 45);
            TxtName.Location = new Point(458, 330);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(365, 43);
            TxtName.TabIndex = 27;
            TxtName.TextChanged += textBox3_TextChanged;
            // 
            // TxtPhone
            // 
            TxtPhone.BackColor = Color.FromArgb(246, 246, 247);
            TxtPhone.BorderStyle = BorderStyle.None;
            TxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPhone.ForeColor = Color.FromArgb(45, 45, 45);
            TxtPhone.Location = new Point(1233, 150);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(365, 43);
            TxtPhone.TabIndex = 26;
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecha.Location = new Point(40, 510);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(287, 45);
            LblFecha.TabIndex = 25;
            LblFecha.Text = "Fecha de registro:";
            // 
            // BtnCerrarClient
            // 
            BtnCerrarClient.FlatAppearance.BorderSize = 0;
            BtnCerrarClient.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrarClient.FlatStyle = FlatStyle.Flat;
            BtnCerrarClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarClient.Image = Properties.Resources.cerrar_ventana;
            BtnCerrarClient.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrarClient.Location = new Point(1370, 670);
            BtnCerrarClient.Name = "BtnCerrarClient";
            BtnCerrarClient.Size = new Size(201, 70);
            BtnCerrarClient.TabIndex = 24;
            BtnCerrarClient.Text = "Cerrar";
            BtnCerrarClient.TextAlign = ContentAlignment.MiddleRight;
            BtnCerrarClient.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarClient
            // 
            BtnLimpiarClient.FlatAppearance.BorderSize = 0;
            BtnLimpiarClient.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLimpiarClient.FlatStyle = FlatStyle.Flat;
            BtnLimpiarClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiarClient.Image = Properties.Resources.escoba;
            BtnLimpiarClient.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimpiarClient.Location = new Point(1107, 670);
            BtnLimpiarClient.Name = "BtnLimpiarClient";
            BtnLimpiarClient.Size = new Size(201, 70);
            BtnLimpiarClient.TabIndex = 23;
            BtnLimpiarClient.Text = "Limpiar";
            BtnLimpiarClient.TextAlign = ContentAlignment.MiddleRight;
            BtnLimpiarClient.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarClient
            // 
            BtnEliminarClient.FlatAppearance.BorderSize = 0;
            BtnEliminarClient.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnEliminarClient.FlatStyle = FlatStyle.Flat;
            BtnEliminarClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminarClient.Image = Properties.Resources.basura;
            BtnEliminarClient.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminarClient.Location = new Point(845, 670);
            BtnEliminarClient.Name = "BtnEliminarClient";
            BtnEliminarClient.Size = new Size(201, 70);
            BtnEliminarClient.TabIndex = 22;
            BtnEliminarClient.Text = "Eliminar";
            BtnEliminarClient.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminarClient.UseVisualStyleBackColor = true;
            // 
            // BtnSaveClient
            // 
            BtnSaveClient.FlatAppearance.BorderSize = 0;
            BtnSaveClient.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnSaveClient.FlatStyle = FlatStyle.Flat;
            BtnSaveClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSaveClient.Image = Properties.Resources.abajo;
            BtnSaveClient.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSaveClient.Location = new Point(554, 670);
            BtnSaveClient.Name = "BtnSaveClient";
            BtnSaveClient.Size = new Size(201, 70);
            BtnSaveClient.TabIndex = 21;
            BtnSaveClient.Text = "Guardar";
            BtnSaveClient.TextAlign = ContentAlignment.MiddleRight;
            BtnSaveClient.UseVisualStyleBackColor = true;
            BtnSaveClient.Click += BtnSaveClient_Click;
            // 
            // BtnAgregarClient
            // 
            BtnAgregarClient.FlatAppearance.BorderSize = 0;
            BtnAgregarClient.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnAgregarClient.FlatStyle = FlatStyle.Flat;
            BtnAgregarClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarClient.Image = Properties.Resources.agregar_producto__1_;
            BtnAgregarClient.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarClient.Location = new Point(249, 670);
            BtnAgregarClient.Name = "BtnAgregarClient";
            BtnAgregarClient.Size = new Size(201, 70);
            BtnAgregarClient.TabIndex = 20;
            BtnAgregarClient.Text = "Agregar";
            BtnAgregarClient.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarClient.UseVisualStyleBackColor = true;
            // 
            // ChbStateCustomer
            // 
            ChbStateCustomer.AutoSize = true;
            ChbStateCustomer.FlatStyle = FlatStyle.Flat;
            ChbStateCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChbStateCustomer.Location = new Point(1334, 510);
            ChbStateCustomer.Name = "ChbStateCustomer";
            ChbStateCustomer.Size = new Size(136, 49);
            ChbStateCustomer.TabIndex = 9;
            ChbStateCustomer.Text = "Activo";
            ChbStateCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerCode
            // 
            TxtCustomerCode.BackColor = Color.FromArgb(246, 246, 247);
            TxtCustomerCode.BorderStyle = BorderStyle.None;
            TxtCustomerCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCustomerCode.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCustomerCode.Location = new Point(500, 150);
            TxtCustomerCode.Name = "TxtCustomerCode";
            TxtCustomerCode.Size = new Size(278, 43);
            TxtCustomerCode.TabIndex = 5;
            // 
            // LblDisponibleCliente
            // 
            LblDisponibleCliente.AutoSize = true;
            LblDisponibleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDisponibleCliente.Location = new Point(1037, 510);
            LblDisponibleCliente.Name = "LblDisponibleCliente";
            LblDisponibleCliente.Size = new Size(190, 45);
            LblDisponibleCliente.TabIndex = 4;
            LblDisponibleCliente.Text = "Disponible:";
            // 
            // LblTipoDeCliente
            // 
            LblTipoDeCliente.AutoSize = true;
            LblTipoDeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTipoDeCliente.Location = new Point(977, 330);
            LblTipoDeCliente.Name = "LblTipoDeCliente";
            LblTipoDeCliente.Size = new Size(250, 45);
            LblTipoDeCliente.TabIndex = 3;
            LblTipoDeCliente.Text = "Tipo de cliente:";
            // 
            // LblTeléfono
            // 
            LblTeléfono.AutoSize = true;
            LblTeléfono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTeléfono.Location = new Point(1037, 150);
            LblTeléfono.Name = "LblTeléfono";
            LblTeléfono.Size = new Size(159, 45);
            LblTeléfono.TabIndex = 2;
            LblTeléfono.Text = "Teléfono:";
            // 
            // LblNombreCliente
            // 
            LblNombreCliente.AutoSize = true;
            LblNombreCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombreCliente.Location = new Point(174, 330);
            LblNombreCliente.Name = "LblNombreCliente";
            LblNombreCliente.Size = new Size(153, 45);
            LblNombreCliente.TabIndex = 1;
            LblNombreCliente.Text = "Nombre:";
            // 
            // LblCodigoCliente
            // 
            LblCodigoCliente.AutoSize = true;
            LblCodigoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigoCliente.Location = new Point(77, 150);
            LblCodigoCliente.Name = "LblCodigoCliente";
            LblCodigoCliente.Size = new Size(250, 45);
            LblCodigoCliente.TabIndex = 0;
            LblCodigoCliente.Text = "Código Cliente:";
            // 
            // DgvCustomer
            // 
            DgvCustomer.AccessibleName = "";
            DgvCustomer.BackgroundColor = Color.FromArgb(243, 231, 211);
            DgvCustomer.BorderStyle = BorderStyle.None;
            DgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombres, Teléfono, TipoCliente, FechaRegistro, Estado });
            DgvCustomer.Dock = DockStyle.Top;
            DgvCustomer.Location = new Point(0, 845);
            DgvCustomer.Name = "DgvCustomer";
            DgvCustomer.RowHeadersWidth = 82;
            DgvCustomer.Size = new Size(1748, 541);
            DgvCustomer.TabIndex = 2;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 10;
            Codigo.Name = "Codigo";
            // 
            // Nombres
            // 
            Nombres.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 10;
            Nombres.Name = "Nombres";
            // 
            // Teléfono
            // 
            Teléfono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 10;
            Teléfono.Name = "Teléfono";
            // 
            // TipoCliente
            // 
            TipoCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoCliente.HeaderText = "TipoCliente";
            TipoCliente.MinimumWidth = 10;
            TipoCliente.Name = "TipoCliente";
            // 
            // FechaRegistro
            // 
            FechaRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.MinimumWidth = 10;
            FechaRegistro.Name = "FechaRegistro";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1748, 1386);
            Controls.Add(DgvCustomer);
            Controls.Add(GbxCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmCustomer_Load;
            GbxCliente.ResumeLayout(false);
            GbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxCliente;
        private Button BtnCerrarClient;
        private Button BtnLimpiarClient;
        private Button BtnEliminarClient;
        private Button BtnSaveClient;
        private Button BtnAgregarClient;
        private CheckBox ChbStateCustomer;
        private TextBox TxtCustomerCode;
        private Label LblDisponibleCliente;
        private Label LblTipoDeCliente;
        private Label LblTeléfono;
        private Label LblNombreCliente;
        private Label LblCodigoCliente;
        private TextBox TxtTypeOfCustomer;
        private TextBox TxtName;
        private TextBox TxtPhone;
        private Label LblFecha;
        private DataGridView DgvCustomer;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn TipoCliente;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estado;
        private DateTimePicker DtmRegistrationDate;
    }
}