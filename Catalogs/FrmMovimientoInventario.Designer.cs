namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmMovimientoInventario
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
            GbxMovimiento = new GroupBox();
            CmbxIngredientes = new ComboBox();
            CmbxTipo = new ComboBox();
            TxtCantidad = new TextBox();
            BtnCerrar = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            BtnAgregar = new Button();
            ChebxEstado = new CheckBox();
            LblDisponibleCliente = new Label();
            LblCantidad = new Label();
            LblIngredientes = new Label();
            LblProducto = new Label();
            TxtObservacion = new TextBox();
            LblFecha = new Label();
            DtmFecha = new DateTimePicker();
            LblObservaciones = new Label();
            DtgMovimiento = new DataGridView();
            Ingredientes = new DataGridViewTextBoxColumn();
            TipoMovimiento = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMovimiento).BeginInit();
            SuspendLayout();
            // 
            // GbxMovimiento
            // 
            GbxMovimiento.BackColor = Color.FromArgb(243, 231, 211);
            GbxMovimiento.Controls.Add(LblObservaciones);
            GbxMovimiento.Controls.Add(DtmFecha);
            GbxMovimiento.Controls.Add(TxtObservacion);
            GbxMovimiento.Controls.Add(LblFecha);
            GbxMovimiento.Controls.Add(CmbxIngredientes);
            GbxMovimiento.Controls.Add(CmbxTipo);
            GbxMovimiento.Controls.Add(TxtCantidad);
            GbxMovimiento.Controls.Add(BtnCerrar);
            GbxMovimiento.Controls.Add(BtnLimpiar);
            GbxMovimiento.Controls.Add(BtnEliminar);
            GbxMovimiento.Controls.Add(BtnGuardar);
            GbxMovimiento.Controls.Add(BtnAgregar);
            GbxMovimiento.Controls.Add(ChebxEstado);
            GbxMovimiento.Controls.Add(LblDisponibleCliente);
            GbxMovimiento.Controls.Add(LblCantidad);
            GbxMovimiento.Controls.Add(LblIngredientes);
            GbxMovimiento.Controls.Add(LblProducto);
            GbxMovimiento.Cursor = Cursors.Hand;
            GbxMovimiento.Dock = DockStyle.Top;
            GbxMovimiento.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxMovimiento.ForeColor = Color.FromArgb(45, 45, 45);
            GbxMovimiento.Location = new Point(0, 0);
            GbxMovimiento.Name = "GbxMovimiento";
            GbxMovimiento.Size = new Size(1481, 684);
            GbxMovimiento.TabIndex = 5;
            GbxMovimiento.TabStop = false;
            GbxMovimiento.Text = "Movimiento de inventario";
            // 
            // CmbxIngredientes
            // 
            CmbxIngredientes.FlatStyle = FlatStyle.Flat;
            CmbxIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxIngredientes.FormattingEnabled = true;
            CmbxIngredientes.Location = new Point(356, 90);
            CmbxIngredientes.Name = "CmbxIngredientes";
            CmbxIngredientes.Size = new Size(365, 53);
            CmbxIngredientes.TabIndex = 33;
            CmbxIngredientes.Text = "Selecciona Ingrediente";
            // 
            // CmbxTipo
            // 
            CmbxTipo.FlatStyle = FlatStyle.Flat;
            CmbxTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxTipo.FormattingEnabled = true;
            CmbxTipo.Items.AddRange(new object[] { "Entrada", "Salida" });
            CmbxTipo.Location = new Point(356, 179);
            CmbxTipo.Name = "CmbxTipo";
            CmbxTipo.Size = new Size(365, 53);
            CmbxTipo.TabIndex = 32;
            CmbxTipo.Text = "Selecciona Movimiento";
            // 
            // TxtCantidad
            // 
            TxtCantidad.BorderStyle = BorderStyle.None;
            TxtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCantidad.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCantidad.Location = new Point(356, 259);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(365, 43);
            TxtCantidad.TabIndex = 27;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrar.Image = Properties.Resources.cerrar_ventana;
            BtnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrar.Location = new Point(1251, 587);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(201, 70);
            BtnCerrar.TabIndex = 24;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.TextAlign = ContentAlignment.MiddleRight;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.Image = Properties.Resources.escoba;
            BtnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimpiar.Location = new Point(1022, 587);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(201, 70);
            BtnLimpiar.TabIndex = 23;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Image = Properties.Resources.basura;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(794, 587);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(201, 70);
            BtnEliminar.TabIndex = 22;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.Image = Properties.Resources.abajo;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(570, 587);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(201, 70);
            BtnGuardar.TabIndex = 21;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.Image = Properties.Resources.agregar_producto__1_;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(341, 587);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(201, 70);
            BtnAgregar.TabIndex = 20;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // ChebxEstado
            // 
            ChebxEstado.AutoSize = true;
            ChebxEstado.FlatStyle = FlatStyle.Flat;
            ChebxEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChebxEstado.Location = new Point(356, 485);
            ChebxEstado.Name = "ChebxEstado";
            ChebxEstado.Size = new Size(136, 49);
            ChebxEstado.TabIndex = 9;
            ChebxEstado.Text = "Activo";
            ChebxEstado.UseVisualStyleBackColor = true;
            // 
            // LblDisponibleCliente
            // 
            LblDisponibleCliente.AutoSize = true;
            LblDisponibleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDisponibleCliente.Location = new Point(31, 489);
            LblDisponibleCliente.Name = "LblDisponibleCliente";
            LblDisponibleCliente.Size = new Size(190, 45);
            LblDisponibleCliente.TabIndex = 4;
            LblDisponibleCliente.Text = "Disponible:";
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCantidad.Location = new Point(31, 259);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(163, 45);
            LblCantidad.TabIndex = 2;
            LblCantidad.Text = "Cantidad:";
            // 
            // LblIngredientes
            // 
            LblIngredientes.AutoSize = true;
            LblIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIngredientes.Location = new Point(31, 90);
            LblIngredientes.Name = "LblIngredientes";
            LblIngredientes.Size = new Size(216, 45);
            LblIngredientes.TabIndex = 1;
            LblIngredientes.Text = "Ingredientes:";
            // 
            // LblProducto
            // 
            LblProducto.AutoSize = true;
            LblProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProducto.Location = new Point(31, 179);
            LblProducto.Name = "LblProducto";
            LblProducto.Size = new Size(212, 45);
            LblProducto.TabIndex = 0;
            LblProducto.Text = "Tipo Movim:";
            // 
            // TxtObservacion
            // 
            TxtObservacion.BorderStyle = BorderStyle.None;
            TxtObservacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtObservacion.ForeColor = Color.FromArgb(45, 45, 45);
            TxtObservacion.Location = new Point(356, 416);
            TxtObservacion.Name = "TxtObservacion";
            TxtObservacion.Size = new Size(365, 43);
            TxtObservacion.TabIndex = 35;
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecha.Location = new Point(31, 332);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(114, 45);
            LblFecha.TabIndex = 34;
            LblFecha.Text = "Fecha:";
            // 
            // DtmFecha
            // 
            DtmFecha.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.CalendarForeColor = Color.FromArgb(45, 45, 45);
            DtmFecha.CalendarMonthBackground = Color.FromArgb(109, 15, 15);
            DtmFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.Location = new Point(356, 332);
            DtmFecha.MinDate = new DateTime(2026, 6, 5, 0, 0, 0, 0);
            DtmFecha.Name = "DtmFecha";
            DtmFecha.Size = new Size(365, 50);
            DtmFecha.TabIndex = 36;
            // 
            // LblObservaciones
            // 
            LblObservaciones.AutoSize = true;
            LblObservaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblObservaciones.Location = new Point(31, 416);
            LblObservaciones.Name = "LblObservaciones";
            LblObservaciones.Size = new Size(215, 45);
            LblObservaciones.TabIndex = 37;
            LblObservaciones.Text = "Observación:";
            // 
            // DtgMovimiento
            // 
            DtgMovimiento.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgMovimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgMovimiento.Columns.AddRange(new DataGridViewColumn[] { Ingredientes, TipoMovimiento, Cantidad, Fecha, Observaciones, Estado });
            DtgMovimiento.Dock = DockStyle.Top;
            DtgMovimiento.Location = new Point(0, 684);
            DtgMovimiento.Name = "DtgMovimiento";
            DtgMovimiento.RowHeadersWidth = 82;
            DtgMovimiento.Size = new Size(1481, 385);
            DtgMovimiento.TabIndex = 6;
            // 
            // Ingredientes
            // 
            Ingredientes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ingredientes.HeaderText = "Ingredientes";
            Ingredientes.MinimumWidth = 10;
            Ingredientes.Name = "Ingredientes";
            // 
            // TipoMovimiento
            // 
            TipoMovimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoMovimiento.HeaderText = "Tipo";
            TipoMovimiento.MinimumWidth = 10;
            TipoMovimiento.Name = "TipoMovimiento";
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 10;
            Fecha.Name = "Fecha";
            // 
            // Observaciones
            // 
            Observaciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Observaciones.HeaderText = "Observaciones";
            Observaciones.MinimumWidth = 10;
            Observaciones.Name = "Observaciones";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estados";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // FrmMovimientoInventario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1481, 1129);
            Controls.Add(DtgMovimiento);
            Controls.Add(GbxMovimiento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMovimientoInventario";
            Text = "FrmMovimientoInventario";
            GbxMovimiento.ResumeLayout(false);
            GbxMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMovimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxMovimiento;
        private ComboBox CmbxIngredientes;
        private ComboBox CmbxTipo;
        private TextBox TxtCantidad;
        private Button BtnCerrar;
        private Button BtnLimpiar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Button BtnAgregar;
        private CheckBox ChebxEstado;
        private Label LblDisponibleCliente;
        private Label LblCantidad;
        private Label LblIngredientes;
        private Label LblProducto;
        private TextBox TxtObservacion;
        private Label LblFecha;
        private Label LblObservaciones;
        private DateTimePicker DtmFecha;
        private DataGridView DtgMovimiento;
        private DataGridViewTextBoxColumn Ingredientes;
        private DataGridViewTextBoxColumn TipoMovimiento;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn Estado;
    }
}