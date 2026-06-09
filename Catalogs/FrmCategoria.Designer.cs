namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmCategoria
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
            GbxCategoria = new GroupBox();
            TxtDescripcion = new TextBox();
            TxtCategoria = new TextBox();
            BtnCerrar = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            BtnAgregar = new Button();
            ChebxEstado = new CheckBox();
            TxtCodigo = new TextBox();
            LblDisponibleCliente = new Label();
            LblDescripcion = new Label();
            LblCategoria = new Label();
            LblCodig0 = new Label();
            DtgCategoria = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgCategoria).BeginInit();
            SuspendLayout();
            // 
            // GbxCategoria
            // 
            GbxCategoria.BackColor = Color.FromArgb(243, 231, 211);
            GbxCategoria.Controls.Add(TxtDescripcion);
            GbxCategoria.Controls.Add(TxtCategoria);
            GbxCategoria.Controls.Add(BtnCerrar);
            GbxCategoria.Controls.Add(BtnLimpiar);
            GbxCategoria.Controls.Add(BtnEliminar);
            GbxCategoria.Controls.Add(BtnGuardar);
            GbxCategoria.Controls.Add(BtnAgregar);
            GbxCategoria.Controls.Add(ChebxEstado);
            GbxCategoria.Controls.Add(TxtCodigo);
            GbxCategoria.Controls.Add(LblDisponibleCliente);
            GbxCategoria.Controls.Add(LblDescripcion);
            GbxCategoria.Controls.Add(LblCategoria);
            GbxCategoria.Controls.Add(LblCodig0);
            GbxCategoria.Cursor = Cursors.Hand;
            GbxCategoria.Dock = DockStyle.Top;
            GbxCategoria.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxCategoria.ForeColor = Color.FromArgb(45, 45, 45);
            GbxCategoria.Location = new Point(0, 0);
            GbxCategoria.Name = "GbxCategoria";
            GbxCategoria.Size = new Size(1481, 684);
            GbxCategoria.TabIndex = 2;
            GbxCategoria.TabStop = false;
            GbxCategoria.Text = "Categoria de Productos";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BackColor = Color.FromArgb(246, 246, 247);
            TxtDescripcion.BorderStyle = BorderStyle.None;
            TxtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescripcion.ForeColor = Color.FromArgb(45, 45, 45);
            TxtDescripcion.Location = new Point(324, 259);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(365, 133);
            TxtDescripcion.TabIndex = 27;
            // 
            // TxtCategoria
            // 
            TxtCategoria.BackColor = Color.FromArgb(246, 246, 247);
            TxtCategoria.BorderStyle = BorderStyle.None;
            TxtCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCategoria.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCategoria.Location = new Point(324, 177);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(365, 43);
            TxtCategoria.TabIndex = 26;
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
            ChebxEstado.Location = new Point(324, 421);
            ChebxEstado.Name = "ChebxEstado";
            ChebxEstado.Size = new Size(136, 49);
            ChebxEstado.TabIndex = 9;
            ChebxEstado.Text = "Activo";
            ChebxEstado.UseVisualStyleBackColor = true;
            // 
            // TxtCodigo
            // 
            TxtCodigo.BackColor = Color.FromArgb(246, 246, 247);
            TxtCodigo.BorderStyle = BorderStyle.None;
            TxtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCodigo.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCodigo.Location = new Point(324, 79);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(278, 43);
            TxtCodigo.TabIndex = 5;
            // 
            // LblDisponibleCliente
            // 
            LblDisponibleCliente.AutoSize = true;
            LblDisponibleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDisponibleCliente.Location = new Point(31, 421);
            LblDisponibleCliente.Name = "LblDisponibleCliente";
            LblDisponibleCliente.Size = new Size(190, 45);
            LblDisponibleCliente.TabIndex = 4;
            LblDisponibleCliente.Text = "Disponible:";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescripcion.Location = new Point(31, 259);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(204, 45);
            LblDescripcion.TabIndex = 2;
            LblDescripcion.Text = "Descripcion:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(31, 177);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(174, 45);
            LblCategoria.TabIndex = 1;
            LblCategoria.Text = "Categoria:";
            // 
            // LblCodig0
            // 
            LblCodig0.AutoSize = true;
            LblCodig0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodig0.Location = new Point(31, 79);
            LblCodig0.Name = "LblCodig0";
            LblCodig0.Size = new Size(138, 45);
            LblCodig0.TabIndex = 0;
            LblCodig0.Text = "Código:";
            // 
            // DtgCategoria
            // 
            DtgCategoria.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgCategoria.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, Descripcion, Estado });
            DtgCategoria.Dock = DockStyle.Top;
            DtgCategoria.Location = new Point(0, 684);
            DtgCategoria.Name = "DtgCategoria";
            DtgCategoria.RowHeadersWidth = 82;
            DtgCategoria.Size = new Size(1481, 382);
            DtgCategoria.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 10;
            Codigo.Name = "Codigo";
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 10;
            Categoria.Name = "Categoria";
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 10;
            Descripcion.Name = "Descripcion";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1481, 1129);
            Controls.Add(DtgCategoria);
            Controls.Add(GbxCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            GbxCategoria.ResumeLayout(false);
            GbxCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxCategoria;
        private TextBox TxtDescripcion;
        private TextBox TxtCategoria;
        private Button BtnCerrar;
        private Button BtnLimpiar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Button BtnAgregar;
        private CheckBox ChebxEstado;
        private TextBox TxtCodigo;
        private Label LblDisponibleCliente;
        private Label LblDescripcion;
        private Label LblCategoria;
        private Label LblCodig0;
        private DataGridView DtgCategoria;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
    }
}