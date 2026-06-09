namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmIngredientes
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
            GbxIngredientes = new GroupBox();
            TxtUnidad = new TextBox();
            BtnCerrar = new Button();
            BtnLimpiar = new Button();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            BtnAgregar = new Button();
            ChebxEstado = new CheckBox();
            TxtNombre = new TextBox();
            LblDisponibleCliente = new Label();
            LblExActual = new Label();
            LblUnidad = new Label();
            LblNombre = new Label();
            TxtExActual = new TextBox();
            TxtExMini = new TextBox();
            LblExminima = new Label();
            LblCosto = new Label();
            TxtCostoUnit = new TextBox();
            DtgIngredientes = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            ExActual = new DataGridViewTextBoxColumn();
            ExMinima = new DataGridViewTextBoxColumn();
            CostoUnitario = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxIngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgIngredientes).BeginInit();
            SuspendLayout();
            // 
            // GbxIngredientes
            // 
            GbxIngredientes.BackColor = Color.FromArgb(243, 231, 211);
            GbxIngredientes.Controls.Add(LblCosto);
            GbxIngredientes.Controls.Add(TxtCostoUnit);
            GbxIngredientes.Controls.Add(LblExminima);
            GbxIngredientes.Controls.Add(TxtExMini);
            GbxIngredientes.Controls.Add(TxtExActual);
            GbxIngredientes.Controls.Add(TxtUnidad);
            GbxIngredientes.Controls.Add(BtnCerrar);
            GbxIngredientes.Controls.Add(BtnLimpiar);
            GbxIngredientes.Controls.Add(BtnEliminar);
            GbxIngredientes.Controls.Add(BtnGuardar);
            GbxIngredientes.Controls.Add(BtnAgregar);
            GbxIngredientes.Controls.Add(ChebxEstado);
            GbxIngredientes.Controls.Add(TxtNombre);
            GbxIngredientes.Controls.Add(LblDisponibleCliente);
            GbxIngredientes.Controls.Add(LblExActual);
            GbxIngredientes.Controls.Add(LblUnidad);
            GbxIngredientes.Controls.Add(LblNombre);
            GbxIngredientes.Cursor = Cursors.Hand;
            GbxIngredientes.Dock = DockStyle.Top;
            GbxIngredientes.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxIngredientes.ForeColor = Color.FromArgb(45, 45, 45);
            GbxIngredientes.Location = new Point(0, 0);
            GbxIngredientes.Name = "GbxIngredientes";
            GbxIngredientes.Size = new Size(1481, 684);
            GbxIngredientes.TabIndex = 3;
            GbxIngredientes.TabStop = false;
            GbxIngredientes.Text = "Control de Ingredientes";
            GbxIngredientes.Enter += GbxIngredientes_Enter;
            // 
            // TxtUnidad
            // 
            TxtUnidad.BackColor = Color.FromArgb(246, 246, 247);
            TxtUnidad.BorderStyle = BorderStyle.None;
            TxtUnidad.Cursor = Cursors.Hand;
            TxtUnidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUnidad.ForeColor = Color.FromArgb(45, 45, 45);
            TxtUnidad.Location = new Point(356, 177);
            TxtUnidad.Name = "TxtUnidad";
            TxtUnidad.Size = new Size(365, 43);
            TxtUnidad.TabIndex = 26;
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
            ChebxEstado.Cursor = Cursors.Hand;
            ChebxEstado.FlatStyle = FlatStyle.Flat;
            ChebxEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChebxEstado.Location = new Point(356, 501);
            ChebxEstado.Name = "ChebxEstado";
            ChebxEstado.Size = new Size(136, 49);
            ChebxEstado.TabIndex = 9;
            ChebxEstado.Text = "Activo";
            ChebxEstado.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.FromArgb(246, 246, 247);
            TxtNombre.BorderStyle = BorderStyle.None;
            TxtNombre.Cursor = Cursors.Hand;
            TxtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.ForeColor = Color.FromArgb(45, 45, 45);
            TxtNombre.Location = new Point(356, 79);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(278, 43);
            TxtNombre.TabIndex = 5;
            // 
            // LblDisponibleCliente
            // 
            LblDisponibleCliente.AutoSize = true;
            LblDisponibleCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDisponibleCliente.Location = new Point(31, 501);
            LblDisponibleCliente.Name = "LblDisponibleCliente";
            LblDisponibleCliente.Size = new Size(190, 45);
            LblDisponibleCliente.TabIndex = 4;
            LblDisponibleCliente.Text = "Disponible:";
            // 
            // LblExActual
            // 
            LblExActual.AutoSize = true;
            LblExActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblExActual.Location = new Point(31, 259);
            LblExActual.Name = "LblExActual";
            LblExActual.Size = new Size(274, 45);
            LblExActual.TabIndex = 2;
            LblExActual.Text = "Existencia actual:";
            // 
            // LblUnidad
            // 
            LblUnidad.AutoSize = true;
            LblUnidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUnidad.Location = new Point(31, 177);
            LblUnidad.Name = "LblUnidad";
            LblUnidad.Size = new Size(304, 45);
            LblUnidad.TabIndex = 1;
            LblUnidad.Text = "Unidad de medida:";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(31, 79);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(153, 45);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "Nombre:";
            // 
            // TxtExActual
            // 
            TxtExActual.BackColor = Color.FromArgb(246, 246, 247);
            TxtExActual.BorderStyle = BorderStyle.None;
            TxtExActual.Cursor = Cursors.Hand;
            TxtExActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtExActual.ForeColor = Color.FromArgb(45, 45, 45);
            TxtExActual.Location = new Point(356, 259);
            TxtExActual.Name = "TxtExActual";
            TxtExActual.Size = new Size(365, 43);
            TxtExActual.TabIndex = 27;
            // 
            // TxtExMini
            // 
            TxtExMini.BackColor = Color.FromArgb(246, 246, 247);
            TxtExMini.BorderStyle = BorderStyle.None;
            TxtExMini.Cursor = Cursors.Hand;
            TxtExMini.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtExMini.ForeColor = Color.FromArgb(45, 45, 45);
            TxtExMini.Location = new Point(356, 344);
            TxtExMini.Name = "TxtExMini";
            TxtExMini.Size = new Size(365, 43);
            TxtExMini.TabIndex = 28;
            // 
            // LblExminima
            // 
            LblExminima.AutoSize = true;
            LblExminima.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblExminima.Location = new Point(31, 344);
            LblExminima.Name = "LblExminima";
            LblExminima.Size = new Size(297, 45);
            LblExminima.TabIndex = 29;
            LblExminima.Text = "Existencia minima:";
            // 
            // LblCosto
            // 
            LblCosto.AutoSize = true;
            LblCosto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCosto.Location = new Point(31, 424);
            LblCosto.Name = "LblCosto";
            LblCosto.Size = new Size(246, 45);
            LblCosto.TabIndex = 31;
            LblCosto.Text = "Costo Unitario:";
            // 
            // TxtCostoUnit
            // 
            TxtCostoUnit.BackColor = Color.FromArgb(246, 246, 247);
            TxtCostoUnit.BorderStyle = BorderStyle.None;
            TxtCostoUnit.Cursor = Cursors.Hand;
            TxtCostoUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCostoUnit.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCostoUnit.Location = new Point(356, 424);
            TxtCostoUnit.Name = "TxtCostoUnit";
            TxtCostoUnit.Size = new Size(365, 43);
            TxtCostoUnit.TabIndex = 30;
            // 
            // DtgIngredientes
            // 
            DtgIngredientes.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgIngredientes.Columns.AddRange(new DataGridViewColumn[] { Nombre, Unidad, ExActual, ExMinima, CostoUnitario, Estado });
            DtgIngredientes.Dock = DockStyle.Top;
            DtgIngredientes.Location = new Point(0, 684);
            DtgIngredientes.Name = "DtgIngredientes";
            DtgIngredientes.RowHeadersWidth = 82;
            DtgIngredientes.Size = new Size(1481, 385);
            DtgIngredientes.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            // 
            // Unidad
            // 
            Unidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unidad.HeaderText = "Unidad ";
            Unidad.MinimumWidth = 10;
            Unidad.Name = "Unidad";
            // 
            // ExActual
            // 
            ExActual.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExActual.HeaderText = "ExActual";
            ExActual.MinimumWidth = 10;
            ExActual.Name = "ExActual";
            // 
            // ExMinima
            // 
            ExMinima.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExMinima.HeaderText = "ExMinima";
            ExMinima.MinimumWidth = 10;
            ExMinima.Name = "ExMinima";
            // 
            // CostoUnitario
            // 
            CostoUnitario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CostoUnitario.HeaderText = "Costo Und";
            CostoUnitario.MinimumWidth = 10;
            CostoUnitario.Name = "CostoUnitario";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estados";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // FrmIngredientes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1481, 1129);
            Controls.Add(DtgIngredientes);
            Controls.Add(GbxIngredientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIngredientes";
            Text = "FrmIngredientes";
            GbxIngredientes.ResumeLayout(false);
            GbxIngredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgIngredientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxIngredientes;
        private TextBox TxtDescripcion;
        private TextBox TxtUnidad;
        private Button BtnCerrar;
        private Button BtnLimpiar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Button BtnAgregar;
        private CheckBox ChebxEstado;
        private TextBox TxtNombre;
        private Label LblDisponibleCliente;
        private Label LblExActual;
        private Label LblUnidad;
        private Label LblNombre;
        private TextBox TxtExMini;
        private TextBox TxtExActual;
        private Label LblCosto;
        private TextBox TxtCostoUnit;
        private Label LblExminima;
        private DataGridView DtgIngredientes;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn ExActual;
        private DataGridViewTextBoxColumn ExMinima;
        private DataGridViewTextBoxColumn CostoUnitario;
        private DataGridViewTextBoxColumn Estado;
    }
}