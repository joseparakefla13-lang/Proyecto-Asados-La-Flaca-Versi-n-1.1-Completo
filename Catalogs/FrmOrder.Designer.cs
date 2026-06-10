namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmOrder
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
            GbxPedido = new GroupBox();
            textBox3 = new TextBox();
            label1 = new Label();
            DtmFecha = new DateTimePicker();
            CmbxCliente = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            LblEstado = new Label();
            LblFecha = new Label();
            LblCliente = new Label();
            LblCodigo = new Label();
            GbxDellatePedido = new GroupBox();
            BtnCerrarEmpl = new Button();
            BtnLimpiarEmpl = new Button();
            BtnEliminarEmpl = new Button();
            BtnGuardarEmpl = new Button();
            BtnAgregarEmpl = new Button();
            DtgDetallePedido = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            LblTotal = new Label();
            TxtSubTotal = new TextBox();
            LblSubTotal = new Label();
            GbxPedido.SuspendLayout();
            GbxDellatePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgDetallePedido).BeginInit();
            SuspendLayout();
            // 
            // GbxPedido
            // 
            GbxPedido.BackColor = Color.FromArgb(243, 231, 211);
            GbxPedido.Controls.Add(textBox3);
            GbxPedido.Controls.Add(label1);
            GbxPedido.Controls.Add(DtmFecha);
            GbxPedido.Controls.Add(CmbxCliente);
            GbxPedido.Controls.Add(comboBox1);
            GbxPedido.Controls.Add(textBox1);
            GbxPedido.Controls.Add(LblEstado);
            GbxPedido.Controls.Add(LblFecha);
            GbxPedido.Controls.Add(LblCliente);
            GbxPedido.Controls.Add(LblCodigo);
            GbxPedido.Dock = DockStyle.Top;
            GbxPedido.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxPedido.ForeColor = Color.FromArgb(45, 45, 45);
            GbxPedido.Location = new Point(0, 0);
            GbxPedido.Name = "GbxPedido";
            GbxPedido.Size = new Size(1748, 610);
            GbxPedido.TabIndex = 0;
            GbxPedido.TabStop = false;
            GbxPedido.Text = "Datos del Pedido";
            GbxPedido.Enter += GbxPedido_Enter;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(246, 246, 247);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(45, 45, 45);
            textBox3.Location = new Point(498, 466);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 43);
            textBox3.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 466);
            label1.Name = "label1";
            label1.Size = new Size(183, 45);
            label1.TabIndex = 31;
            label1.Text = "N* Pedido:";
            // 
            // DtmFecha
            // 
            DtmFecha.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.CalendarForeColor = Color.FromArgb(45, 45, 45);
            DtmFecha.CalendarMonthBackground = Color.FromArgb(109, 15, 15);
            DtmFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.Location = new Point(1093, 241);
            DtmFecha.MinDate = new DateTime(2026, 6, 5, 0, 0, 0, 0);
            DtmFecha.Name = "DtmFecha";
            DtmFecha.Size = new Size(552, 50);
            DtmFecha.TabIndex = 30;
            // 
            // CmbxCliente
            // 
            CmbxCliente.BackColor = Color.FromArgb(246, 246, 247);
            CmbxCliente.FlatStyle = FlatStyle.Flat;
            CmbxCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxCliente.ForeColor = Color.FromArgb(45, 45, 45);
            CmbxCliente.FormattingEnabled = true;
            CmbxCliente.Items.AddRange(new object[] { "Publico General", "Juan Torrez", "Ricardo Mora", "Jose Lopez" });
            CmbxCliente.Location = new Point(498, 327);
            CmbxCliente.Name = "CmbxCliente";
            CmbxCliente.Size = new Size(278, 53);
            CmbxCliente.TabIndex = 17;
            CmbxCliente.Text = "Clientes";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(246, 246, 247);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(45, 45, 45);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pediente", "Cancelado", "En proceso" });
            comboBox1.Location = new Point(1192, 425);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 53);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Seleccione Cargo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(246, 246, 247);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(45, 45, 45);
            textBox1.Location = new Point(498, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 43);
            textBox1.TabIndex = 13;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstado.Location = new Point(959, 413);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(129, 45);
            LblEstado.TabIndex = 12;
            LblEstado.Text = "Estado:";
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecha.Location = new Point(959, 241);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(114, 45);
            LblFecha.TabIndex = 11;
            LblFecha.Text = "Fecha:";
            // 
            // LblCliente
            // 
            LblCliente.AutoSize = true;
            LblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCliente.Location = new Point(291, 327);
            LblCliente.Name = "LblCliente";
            LblCliente.Size = new Size(132, 45);
            LblCliente.TabIndex = 10;
            LblCliente.Text = "Cliente:";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(291, 188);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(183, 45);
            LblCodigo.TabIndex = 9;
            LblCodigo.Text = "N* Pedido:";
            // 
            // GbxDellatePedido
            // 
            GbxDellatePedido.BackColor = Color.FromArgb(243, 231, 211);
            GbxDellatePedido.Controls.Add(BtnCerrarEmpl);
            GbxDellatePedido.Controls.Add(BtnLimpiarEmpl);
            GbxDellatePedido.Controls.Add(BtnEliminarEmpl);
            GbxDellatePedido.Controls.Add(BtnGuardarEmpl);
            GbxDellatePedido.Controls.Add(BtnAgregarEmpl);
            GbxDellatePedido.Controls.Add(DtgDetallePedido);
            GbxDellatePedido.Controls.Add(textBox2);
            GbxDellatePedido.Controls.Add(LblTotal);
            GbxDellatePedido.Controls.Add(TxtSubTotal);
            GbxDellatePedido.Controls.Add(LblSubTotal);
            GbxDellatePedido.Dock = DockStyle.Top;
            GbxDellatePedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxDellatePedido.ForeColor = Color.FromArgb(45, 45, 45);
            GbxDellatePedido.Location = new Point(0, 610);
            GbxDellatePedido.Name = "GbxDellatePedido";
            GbxDellatePedido.Size = new Size(1748, 968);
            GbxDellatePedido.TabIndex = 1;
            GbxDellatePedido.TabStop = false;
            GbxDellatePedido.Text = "Detalle de Pedido";
            // 
            // BtnCerrarEmpl
            // 
            BtnCerrarEmpl.FlatAppearance.BorderSize = 0;
            BtnCerrarEmpl.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrarEmpl.FlatStyle = FlatStyle.Flat;
            BtnCerrarEmpl.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarEmpl.Image = Properties.Resources.cerrar_ventana;
            BtnCerrarEmpl.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrarEmpl.Location = new Point(780, 611);
            BtnCerrarEmpl.Name = "BtnCerrarEmpl";
            BtnCerrarEmpl.Size = new Size(201, 70);
            BtnCerrarEmpl.TabIndex = 28;
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
            BtnLimpiarEmpl.Location = new Point(507, 611);
            BtnLimpiarEmpl.Name = "BtnLimpiarEmpl";
            BtnLimpiarEmpl.Size = new Size(201, 70);
            BtnLimpiarEmpl.TabIndex = 27;
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
            BtnEliminarEmpl.Location = new Point(1325, 314);
            BtnEliminarEmpl.Name = "BtnEliminarEmpl";
            BtnEliminarEmpl.Size = new Size(201, 70);
            BtnEliminarEmpl.TabIndex = 26;
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
            BtnGuardarEmpl.Location = new Point(1325, 194);
            BtnGuardarEmpl.Name = "BtnGuardarEmpl";
            BtnGuardarEmpl.Size = new Size(201, 70);
            BtnGuardarEmpl.TabIndex = 25;
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
            BtnAgregarEmpl.Location = new Point(1325, 84);
            BtnAgregarEmpl.Name = "BtnAgregarEmpl";
            BtnAgregarEmpl.Size = new Size(201, 70);
            BtnAgregarEmpl.TabIndex = 21;
            BtnAgregarEmpl.Text = "Agregar";
            BtnAgregarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarEmpl.UseVisualStyleBackColor = true;
            // 
            // DtgDetallePedido
            // 
            DtgDetallePedido.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgDetallePedido.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Subtotal });
            DtgDetallePedido.Location = new Point(24, 70);
            DtgDetallePedido.Name = "DtgDetallePedido";
            DtgDetallePedido.RowHeadersWidth = 82;
            DtgDetallePedido.Size = new Size(1056, 517);
            DtgDetallePedido.TabIndex = 16;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 10;
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subtotal.HeaderText = "SubTotal";
            Subtotal.MinimumWidth = 10;
            Subtotal.Name = "Subtotal";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(246, 246, 247);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(45, 45, 45);
            textBox2.Location = new Point(1288, 587);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 43);
            textBox2.TabIndex = 15;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotal.Location = new Point(1122, 585);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(103, 45);
            LblTotal.TabIndex = 14;
            LblTotal.Text = "Total:";
            // 
            // TxtSubTotal
            // 
            TxtSubTotal.BackColor = Color.FromArgb(246, 246, 247);
            TxtSubTotal.BorderStyle = BorderStyle.None;
            TxtSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSubTotal.ForeColor = Color.FromArgb(45, 45, 45);
            TxtSubTotal.Location = new Point(1288, 506);
            TxtSubTotal.Name = "TxtSubTotal";
            TxtSubTotal.Size = new Size(278, 43);
            TxtSubTotal.TabIndex = 13;
            // 
            // LblSubTotal
            // 
            LblSubTotal.AutoSize = true;
            LblSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubTotal.Location = new Point(1122, 504);
            LblSubTotal.Name = "LblSubTotal";
            LblSubTotal.Size = new Size(160, 45);
            LblSubTotal.TabIndex = 9;
            LblSubTotal.Text = "SubTotal:";
            // 
            // FrmOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1748, 1386);
            Controls.Add(GbxDellatePedido);
            Controls.Add(GbxPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOrder";
            GbxPedido.ResumeLayout(false);
            GbxPedido.PerformLayout();
            GbxDellatePedido.ResumeLayout(false);
            GbxDellatePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgDetallePedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxPedido;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label LblEstado;
        private Label LblFecha;
        private Label LblCliente;
        private Label LblCodigo;
        private ComboBox CmbxCliente;
        private DateTimePicker DtmFecha;
        private GroupBox GbxDellatePedido;
        private TextBox TxtSubTotal;
        private Label LblSubTotal;
        private DataGridView DtgDetallePedido;
        private TextBox textBox2;
        private Label LblTotal;
        private TextBox textBox3;
        private Label label1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private Button BtnAgregarEmpl;
        private Button BtnCerrarEmpl;
        private Button BtnLimpiarEmpl;
        private Button BtnEliminarEmpl;
        private Button BtnGuardarEmpl;
    }
}