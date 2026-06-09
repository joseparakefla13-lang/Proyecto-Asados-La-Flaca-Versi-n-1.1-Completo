namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmProducts
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
            GbxDatosProductos = new GroupBox();
            TxtDescripcion = new TextBox();
            LblDescripcion = new Label();
            TxtPrecio = new TextBox();
            LblNombreProduc = new Label();
            CmbxCategoria = new ComboBox();
            BtnCerrar = new Button();
            BtnLimpiar = new Button();
            ChebxEstado = new CheckBox();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            BtnAgregar = new Button();
            TxtNombreProduc = new TextBox();
            TxtProductos = new TextBox();
            label8 = new Label();
            LblPrecioProduct = new Label();
            LblCategoria = new Label();
            LblProductos = new Label();
            DtgProductos = new DataGridView();
            IDProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            CategoriaProducto = new DataGridViewTextBoxColumn();
            PrecioProducto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoProducto = new DataGridViewTextBoxColumn();
            GbxDatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgProductos).BeginInit();
            SuspendLayout();
            // 
            // GbxDatosProductos
            // 
            GbxDatosProductos.BackColor = Color.FromArgb(243, 231, 211);
            GbxDatosProductos.Controls.Add(TxtDescripcion);
            GbxDatosProductos.Controls.Add(LblDescripcion);
            GbxDatosProductos.Controls.Add(TxtPrecio);
            GbxDatosProductos.Controls.Add(LblNombreProduc);
            GbxDatosProductos.Controls.Add(CmbxCategoria);
            GbxDatosProductos.Controls.Add(BtnCerrar);
            GbxDatosProductos.Controls.Add(BtnLimpiar);
            GbxDatosProductos.Controls.Add(ChebxEstado);
            GbxDatosProductos.Controls.Add(BtnEliminar);
            GbxDatosProductos.Controls.Add(BtnGuardar);
            GbxDatosProductos.Controls.Add(BtnAgregar);
            GbxDatosProductos.Controls.Add(TxtNombreProduc);
            GbxDatosProductos.Controls.Add(TxtProductos);
            GbxDatosProductos.Controls.Add(label8);
            GbxDatosProductos.Controls.Add(LblPrecioProduct);
            GbxDatosProductos.Controls.Add(LblCategoria);
            GbxDatosProductos.Controls.Add(LblProductos);
            GbxDatosProductos.Cursor = Cursors.Hand;
            GbxDatosProductos.Dock = DockStyle.Top;
            GbxDatosProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxDatosProductos.Location = new Point(0, 0);
            GbxDatosProductos.Name = "GbxDatosProductos";
            GbxDatosProductos.Size = new Size(1481, 604);
            GbxDatosProductos.TabIndex = 2;
            GbxDatosProductos.TabStop = false;
            GbxDatosProductos.Text = "Productos del Menú";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BackColor = Color.FromArgb(246, 246, 247);
            TxtDescripcion.BorderStyle = BorderStyle.None;
            TxtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescripcion.ForeColor = Color.FromArgb(45, 45, 45);
            TxtDescripcion.Location = new Point(961, 159);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(365, 133);
            TxtDescripcion.TabIndex = 29;
            TxtDescripcion.TextChanged += TxtTelefono_TextChanged;
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescripcion.Location = new Point(739, 159);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(204, 45);
            LblDescripcion.TabIndex = 28;
            LblDescripcion.Text = "Descripcion:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.BackColor = Color.FromArgb(246, 246, 247);
            TxtPrecio.BorderStyle = BorderStyle.None;
            TxtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecio.ForeColor = Color.FromArgb(45, 45, 45);
            TxtPrecio.Location = new Point(284, 320);
            TxtPrecio.Multiline = true;
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(395, 45);
            TxtPrecio.TabIndex = 22;
            // 
            // LblNombreProduc
            // 
            LblNombreProduc.AutoSize = true;
            LblNombreProduc.Location = new Point(34, 240);
            LblNombreProduc.Name = "LblNombreProduc";
            LblNombreProduc.Size = new Size(153, 45);
            LblNombreProduc.TabIndex = 21;
            LblNombreProduc.Text = "Nombre:";
            // 
            // CmbxCategoria
            // 
            CmbxCategoria.BackColor = Color.FromArgb(246, 246, 247);
            CmbxCategoria.FlatStyle = FlatStyle.Flat;
            CmbxCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxCategoria.ForeColor = Color.FromArgb(45, 45, 45);
            CmbxCategoria.FormattingEnabled = true;
            CmbxCategoria.Items.AddRange(new object[] { "Frescos Naturales", "Bebidas", "Asados", "Fritanga" });
            CmbxCategoria.Location = new Point(284, 159);
            CmbxCategoria.Name = "CmbxCategoria";
            CmbxCategoria.Size = new Size(395, 53);
            CmbxCategoria.TabIndex = 20;
            CmbxCategoria.Text = "Seleccione la Categoria";
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrar.Image = Properties.Resources.cerrar_ventana;
            BtnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrar.Location = new Point(1243, 491);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(201, 70);
            BtnCerrar.TabIndex = 19;
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
            BtnLimpiar.Location = new Point(1014, 491);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(201, 70);
            BtnLimpiar.TabIndex = 18;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // ChebxEstado
            // 
            ChebxEstado.AutoSize = true;
            ChebxEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChebxEstado.Location = new Point(284, 416);
            ChebxEstado.Name = "ChebxEstado";
            ChebxEstado.Size = new Size(141, 49);
            ChebxEstado.TabIndex = 14;
            ChebxEstado.Text = "Activo";
            ChebxEstado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Image = Properties.Resources.basura;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(786, 491);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(201, 70);
            BtnEliminar.TabIndex = 17;
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
            BtnGuardar.Location = new Point(562, 491);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(201, 70);
            BtnGuardar.TabIndex = 16;
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
            BtnAgregar.Location = new Point(333, 491);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(201, 70);
            BtnAgregar.TabIndex = 15;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // TxtNombreProduc
            // 
            TxtNombreProduc.BackColor = Color.FromArgb(246, 246, 247);
            TxtNombreProduc.BorderStyle = BorderStyle.None;
            TxtNombreProduc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombreProduc.ForeColor = Color.FromArgb(45, 45, 45);
            TxtNombreProduc.Location = new Point(284, 240);
            TxtNombreProduc.Multiline = true;
            TxtNombreProduc.Name = "TxtNombreProduc";
            TxtNombreProduc.Size = new Size(395, 45);
            TxtNombreProduc.TabIndex = 11;
            // 
            // TxtProductos
            // 
            TxtProductos.BackColor = Color.FromArgb(246, 246, 247);
            TxtProductos.BorderStyle = BorderStyle.None;
            TxtProductos.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtProductos.ForeColor = Color.FromArgb(45, 45, 45);
            TxtProductos.Location = new Point(284, 87);
            TxtProductos.Name = "TxtProductos";
            TxtProductos.Size = new Size(291, 39);
            TxtProductos.TabIndex = 8;
            TxtProductos.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 416);
            label8.Name = "label8";
            label8.Size = new Size(129, 45);
            label8.TabIndex = 7;
            label8.Text = "Estado:";
            // 
            // LblPrecioProduct
            // 
            LblPrecioProduct.AutoSize = true;
            LblPrecioProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPrecioProduct.Location = new Point(34, 320);
            LblPrecioProduct.Name = "LblPrecioProduct";
            LblPrecioProduct.Size = new Size(195, 45);
            LblPrecioProduct.TabIndex = 3;
            LblPrecioProduct.Text = "Precio Unit:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Location = new Point(34, 159);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(174, 45);
            LblCategoria.TabIndex = 2;
            LblCategoria.Text = "Categoria:";
            // 
            // LblProductos
            // 
            LblProductos.AutoSize = true;
            LblProductos.Location = new Point(34, 87);
            LblProductos.Name = "LblProductos";
            LblProductos.Size = new Size(225, 45);
            LblProductos.TabIndex = 0;
            LblProductos.Text = "ID Productos:";
            // 
            // DtgProductos
            // 
            DtgProductos.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgProductos.Columns.AddRange(new DataGridViewColumn[] { IDProducto, NombreProducto, CategoriaProducto, PrecioProducto, Descripcion, EstadoProducto });
            DtgProductos.Dock = DockStyle.Top;
            DtgProductos.Location = new Point(0, 604);
            DtgProductos.Name = "DtgProductos";
            DtgProductos.RowHeadersWidth = 82;
            DtgProductos.Size = new Size(1481, 482);
            DtgProductos.TabIndex = 3;
            // 
            // IDProducto
            // 
            IDProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDProducto.HeaderText = "ID";
            IDProducto.MinimumWidth = 10;
            IDProducto.Name = "IDProducto";
            // 
            // NombreProducto
            // 
            NombreProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreProducto.HeaderText = "Nombre";
            NombreProducto.MinimumWidth = 10;
            NombreProducto.Name = "NombreProducto";
            // 
            // CategoriaProducto
            // 
            CategoriaProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoriaProducto.HeaderText = "Categoria";
            CategoriaProducto.MinimumWidth = 10;
            CategoriaProducto.Name = "CategoriaProducto";
            // 
            // PrecioProducto
            // 
            PrecioProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrecioProducto.HeaderText = "Precio";
            PrecioProducto.MinimumWidth = 10;
            PrecioProducto.Name = "PrecioProducto";
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 10;
            Descripcion.Name = "Descripcion";
            // 
            // EstadoProducto
            // 
            EstadoProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EstadoProducto.HeaderText = "Estado";
            EstadoProducto.MinimumWidth = 10;
            EstadoProducto.Name = "EstadoProducto";
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1481, 1129);
            Controls.Add(DtgProductos);
            Controls.Add(GbxDatosProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducts";
            GbxDatosProductos.ResumeLayout(false);
            GbxDatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxDatosProductos;
        private Button BtnCerrar;
        private Button BtnLimpiar;
        private CheckBox ChebxEstado;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Button BtnAgregar;
        private TextBox TxtNombreProduc;
        private TextBox TxtProductos;
        private Label label8;
        private Label LblPrecioProduct;
        private Label LblCategoria;
        private Label LblProductos;
        private ComboBox CmbxCategoria;
        private Label LblNombreProduc;
        private TextBox TxtPrecio;
        private DataGridView DtgProductos;
        private TextBox TxtDescripcion;
        private Label LblDescripcion;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn CategoriaProducto;
        private DataGridViewTextBoxColumn PrecioProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoProducto;
    }
}