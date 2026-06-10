namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmReceta
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
            GbxReceta = new GroupBox();
            CmbxIngredientes = new ComboBox();
            CmbxProductos = new ComboBox();
            TxtExActual = new TextBox();
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
            DtgRecetas = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Ingredientes = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GbxReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgRecetas).BeginInit();
            SuspendLayout();
            // 
            // GbxReceta
            // 
            GbxReceta.BackColor = Color.FromArgb(243, 231, 211);
            GbxReceta.Controls.Add(CmbxIngredientes);
            GbxReceta.Controls.Add(CmbxProductos);
            GbxReceta.Controls.Add(TxtExActual);
            GbxReceta.Controls.Add(BtnCerrar);
            GbxReceta.Controls.Add(BtnLimpiar);
            GbxReceta.Controls.Add(BtnEliminar);
            GbxReceta.Controls.Add(BtnGuardar);
            GbxReceta.Controls.Add(BtnAgregar);
            GbxReceta.Controls.Add(ChebxEstado);
            GbxReceta.Controls.Add(LblDisponibleCliente);
            GbxReceta.Controls.Add(LblCantidad);
            GbxReceta.Controls.Add(LblIngredientes);
            GbxReceta.Controls.Add(LblProducto);
            GbxReceta.Cursor = Cursors.Hand;
            GbxReceta.Dock = DockStyle.Top;
            GbxReceta.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxReceta.ForeColor = Color.FromArgb(45, 45, 45);
            GbxReceta.Location = new Point(0, 0);
            GbxReceta.Name = "GbxReceta";
            GbxReceta.Size = new Size(1748, 767);
            GbxReceta.TabIndex = 4;
            GbxReceta.TabStop = false;
            GbxReceta.Text = "Receta de Productos";
            // 
            // CmbxIngredientes
            // 
            CmbxIngredientes.FlatStyle = FlatStyle.Flat;
            CmbxIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxIngredientes.FormattingEnabled = true;
            CmbxIngredientes.Location = new Point(593, 299);
            CmbxIngredientes.Name = "CmbxIngredientes";
            CmbxIngredientes.Size = new Size(365, 53);
            CmbxIngredientes.TabIndex = 33;
            CmbxIngredientes.Text = "Selecciona Ingrediente";
            // 
            // CmbxProductos
            // 
            CmbxProductos.FlatStyle = FlatStyle.Flat;
            CmbxProductos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxProductos.FormattingEnabled = true;
            CmbxProductos.Location = new Point(593, 170);
            CmbxProductos.Name = "CmbxProductos";
            CmbxProductos.Size = new Size(365, 53);
            CmbxProductos.TabIndex = 32;
            CmbxProductos.Text = "Selecciona Producto";
            // 
            // TxtExActual
            // 
            TxtExActual.BorderStyle = BorderStyle.None;
            TxtExActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtExActual.ForeColor = Color.FromArgb(45, 45, 45);
            TxtExActual.Location = new Point(593, 423);
            TxtExActual.Name = "TxtExActual";
            TxtExActual.Size = new Size(365, 43);
            TxtExActual.TabIndex = 27;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrar.Image = Properties.Resources.cerrar_ventana;
            BtnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrar.Location = new Point(1247, 651);
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
            BtnLimpiar.Location = new Point(1018, 651);
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
            BtnEliminar.Location = new Point(790, 651);
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
            BtnGuardar.Location = new Point(566, 651);
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
            BtnAgregar.Location = new Point(337, 651);
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
            ChebxEstado.Location = new Point(806, 534);
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
            LblDisponibleCliente.Location = new Point(541, 534);
            LblDisponibleCliente.Name = "LblDisponibleCliente";
            LblDisponibleCliente.Size = new Size(190, 45);
            LblDisponibleCliente.TabIndex = 4;
            LblDisponibleCliente.Text = "Disponible:";
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCantidad.Location = new Point(391, 421);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(163, 45);
            LblCantidad.TabIndex = 2;
            LblCantidad.Text = "Cantidad:";
            // 
            // LblIngredientes
            // 
            LblIngredientes.AutoSize = true;
            LblIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIngredientes.Location = new Point(338, 299);
            LblIngredientes.Name = "LblIngredientes";
            LblIngredientes.Size = new Size(216, 45);
            LblIngredientes.TabIndex = 1;
            LblIngredientes.Text = "Ingredientes:";
            // 
            // LblProducto
            // 
            LblProducto.AutoSize = true;
            LblProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblProducto.Location = new Point(386, 170);
            LblProducto.Name = "LblProducto";
            LblProducto.Size = new Size(168, 45);
            LblProducto.TabIndex = 0;
            LblProducto.Text = "Producto:";
            // 
            // DtgRecetas
            // 
            DtgRecetas.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgRecetas.Columns.AddRange(new DataGridViewColumn[] { Producto, Ingredientes, Cantidad, Estado });
            DtgRecetas.Dock = DockStyle.Top;
            DtgRecetas.Location = new Point(0, 767);
            DtgRecetas.Name = "DtgRecetas";
            DtgRecetas.RowHeadersWidth = 82;
            DtgRecetas.Size = new Size(1748, 785);
            DtgRecetas.TabIndex = 5;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 10;
            Producto.Name = "Producto";
            // 
            // Ingredientes
            // 
            Ingredientes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ingredientes.HeaderText = "Ingredientes ";
            Ingredientes.MinimumWidth = 10;
            Ingredientes.Name = "Ingredientes";
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // FrmReceta
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1748, 1386);
            Controls.Add(DtgRecetas);
            Controls.Add(GbxReceta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReceta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReceta";
            GbxReceta.ResumeLayout(false);
            GbxReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgRecetas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxReceta;
        private TextBox TxtExActual;
        private TextBox TxtUnidad;
        private Button BtnCerrar;
        private Button BtnLimpiar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Button BtnAgregar;
        private CheckBox ChebxEstado;
        private TextBox TxtNombre;
        private Label LblDisponibleCliente;
        private Label LblCantidad;
        private Label LblIngredientes;
        private Label LblProducto;
        private ComboBox CmbxProductos;
        private ComboBox CmbxIngredientes;
        private DataGridView DtgRecetas;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Ingredientes;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Estado;
    }
}