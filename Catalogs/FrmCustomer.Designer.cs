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
            DtmFecha = new DateTimePicker();
            TxtTipoCliente = new TextBox();
            TxtTelefono = new TextBox();
            TxtNombre = new TextBox();
            LblFecha = new Label();
            BtnCerrarClient = new Button();
            BtnLimpiarClient = new Button();
            BtnEliminarClient = new Button();
            BtnGuardarClient = new Button();
            BtnAgregarClient = new Button();
            ChebxEstadoCliente = new CheckBox();
            TxtCodigoCliente = new TextBox();
            LblDisponibleCliente = new Label();
            LblTipoDeCliente = new Label();
            LblTeléfono = new Label();
            LblNombreCliente = new Label();
            LblCodigoCliente = new Label();
            DtgCliente = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            TipoCliente = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgCliente).BeginInit();
            SuspendLayout();
            // 
            // GbxCliente
            // 
            GbxCliente.BackColor = Color.FromArgb(243, 231, 211);
            GbxCliente.Controls.Add(DtmFecha);
            GbxCliente.Controls.Add(TxtTipoCliente);
            GbxCliente.Controls.Add(TxtTelefono);
            GbxCliente.Controls.Add(TxtNombre);
            GbxCliente.Controls.Add(LblFecha);
            GbxCliente.Controls.Add(BtnCerrarClient);
            GbxCliente.Controls.Add(BtnLimpiarClient);
            GbxCliente.Controls.Add(BtnEliminarClient);
            GbxCliente.Controls.Add(BtnGuardarClient);
            GbxCliente.Controls.Add(BtnAgregarClient);
            GbxCliente.Controls.Add(ChebxEstadoCliente);
            GbxCliente.Controls.Add(TxtCodigoCliente);
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
            GbxCliente.Size = new Size(1748, 851);
            GbxCliente.TabIndex = 1;
            GbxCliente.TabStop = false;
            GbxCliente.Text = "Registro de Cliente";
            // 
            // DtmFecha
            // 
            DtmFecha.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.CalendarForeColor = Color.FromArgb(45, 45, 45);
            DtmFecha.CalendarMonthBackground = Color.FromArgb(109, 15, 15);
            DtmFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.Location = new Point(363, 510);
            DtmFecha.MinDate = new DateTime(2026, 6, 5, 0, 0, 0, 0);
            DtmFecha.Name = "DtmFecha";
            DtmFecha.Size = new Size(547, 50);
            DtmFecha.TabIndex = 29;
            DtmFecha.ValueChanged += DtmFecha_ValueChanged;
            // 
            // TxtTipoCliente
            // 
            TxtTipoCliente.BackColor = Color.FromArgb(246, 246, 247);
            TxtTipoCliente.BorderStyle = BorderStyle.None;
            TxtTipoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTipoCliente.ForeColor = Color.FromArgb(45, 45, 45);
            TxtTipoCliente.Location = new Point(1233, 330);
            TxtTipoCliente.Name = "TxtTipoCliente";
            TxtTipoCliente.Size = new Size(365, 43);
            TxtTipoCliente.TabIndex = 28;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.FromArgb(246, 246, 247);
            TxtTelefono.BorderStyle = BorderStyle.None;
            TxtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTelefono.ForeColor = Color.FromArgb(45, 45, 45);
            TxtTelefono.Location = new Point(458, 330);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(365, 43);
            TxtTelefono.TabIndex = 27;
            TxtTelefono.TextChanged += textBox3_TextChanged;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.FromArgb(246, 246, 247);
            TxtNombre.BorderStyle = BorderStyle.None;
            TxtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.ForeColor = Color.FromArgb(45, 45, 45);
            TxtNombre.Location = new Point(1233, 150);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(365, 43);
            TxtNombre.TabIndex = 26;
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
            // BtnGuardarClient
            // 
            BtnGuardarClient.FlatAppearance.BorderSize = 0;
            BtnGuardarClient.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnGuardarClient.FlatStyle = FlatStyle.Flat;
            BtnGuardarClient.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardarClient.Image = Properties.Resources.abajo;
            BtnGuardarClient.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardarClient.Location = new Point(554, 670);
            BtnGuardarClient.Name = "BtnGuardarClient";
            BtnGuardarClient.Size = new Size(201, 70);
            BtnGuardarClient.TabIndex = 21;
            BtnGuardarClient.Text = "Guardar";
            BtnGuardarClient.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardarClient.UseVisualStyleBackColor = true;
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
            // ChebxEstadoCliente
            // 
            ChebxEstadoCliente.AutoSize = true;
            ChebxEstadoCliente.FlatStyle = FlatStyle.Flat;
            ChebxEstadoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChebxEstadoCliente.Location = new Point(1334, 510);
            ChebxEstadoCliente.Name = "ChebxEstadoCliente";
            ChebxEstadoCliente.Size = new Size(136, 49);
            ChebxEstadoCliente.TabIndex = 9;
            ChebxEstadoCliente.Text = "Activo";
            ChebxEstadoCliente.UseVisualStyleBackColor = true;
            // 
            // TxtCodigoCliente
            // 
            TxtCodigoCliente.BackColor = Color.FromArgb(246, 246, 247);
            TxtCodigoCliente.BorderStyle = BorderStyle.None;
            TxtCodigoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCodigoCliente.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCodigoCliente.Location = new Point(500, 150);
            TxtCodigoCliente.Name = "TxtCodigoCliente";
            TxtCodigoCliente.Size = new Size(278, 43);
            TxtCodigoCliente.TabIndex = 5;
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
            // DtgCliente
            // 
            DtgCliente.AccessibleName = "";
            DtgCliente.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgCliente.BorderStyle = BorderStyle.None;
            DtgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgCliente.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombres, Teléfono, TipoCliente, FechaRegistro, Estado });
            DtgCliente.Dock = DockStyle.Top;
            DtgCliente.Location = new Point(0, 851);
            DtgCliente.Name = "DtgCliente";
            DtgCliente.RowHeadersWidth = 82;
            DtgCliente.Size = new Size(1748, 703);
            DtgCliente.TabIndex = 2;
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
            Controls.Add(DtgCliente);
            Controls.Add(GbxCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            GbxCliente.ResumeLayout(false);
            GbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxCliente;
        private Button BtnCerrarClient;
        private Button BtnLimpiarClient;
        private Button BtnEliminarClient;
        private Button BtnGuardarClient;
        private Button BtnAgregarClient;
        private CheckBox ChebxEstadoCliente;
        private TextBox TxtCodigoCliente;
        private Label LblDisponibleCliente;
        private Label LblTipoDeCliente;
        private Label LblTeléfono;
        private Label LblNombreCliente;
        private Label LblCodigoCliente;
        private TextBox TxtTipoCliente;
        private TextBox TxtTelefono;
        private TextBox TxtNombre;
        private Label LblFecha;
        private DataGridView DtgCliente;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn TipoCliente;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estado;
        private DateTimePicker DtmFecha;
    }
}