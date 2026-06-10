namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmFactorironPayment
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
            GbxFactura = new GroupBox();
            ChbxEstado = new CheckBox();
            LblMonto = new Label();
            textBox2 = new TextBox();
            LblSubtotal = new Label();
            CmbxEmpleado = new ComboBox();
            textBox3 = new TextBox();
            LblEmpleado = new Label();
            DtmFecha = new DateTimePicker();
            CmbxPedido = new ComboBox();
            textBox1 = new TextBox();
            LblEstado = new Label();
            LblFecha = new Label();
            LblPedido = new Label();
            LblCodigo = new Label();
            BtnAgregar = new Button();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            GbxPago = new GroupBox();
            groupBox2 = new GroupBox();
            TxtMontoPago = new TextBox();
            LblMontoPago = new Label();
            TxtFechaPago = new TextBox();
            LblFechaPago = new Label();
            textBox4 = new TextBox();
            LblFactura = new Label();
            TxtPago = new TextBox();
            LblPago = new Label();
            BtnCerrar = new Button();
            BtnLimpiar = new Button();
            BtnImprimir = new Button();
            GbxFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            GbxPago.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GbxFactura
            // 
            GbxFactura.BackColor = Color.FromArgb(243, 231, 211);
            GbxFactura.Controls.Add(ChbxEstado);
            GbxFactura.Controls.Add(LblMonto);
            GbxFactura.Controls.Add(textBox2);
            GbxFactura.Controls.Add(LblSubtotal);
            GbxFactura.Controls.Add(CmbxEmpleado);
            GbxFactura.Controls.Add(textBox3);
            GbxFactura.Controls.Add(LblEmpleado);
            GbxFactura.Controls.Add(DtmFecha);
            GbxFactura.Controls.Add(CmbxPedido);
            GbxFactura.Controls.Add(textBox1);
            GbxFactura.Controls.Add(LblEstado);
            GbxFactura.Controls.Add(LblFecha);
            GbxFactura.Controls.Add(LblPedido);
            GbxFactura.Controls.Add(LblCodigo);
            GbxFactura.Dock = DockStyle.Top;
            GbxFactura.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxFactura.ForeColor = Color.FromArgb(45, 45, 45);
            GbxFactura.Location = new Point(0, 0);
            GbxFactura.Name = "GbxFactura";
            GbxFactura.Size = new Size(1748, 597);
            GbxFactura.TabIndex = 1;
            GbxFactura.TabStop = false;
            GbxFactura.Text = "Datos de la Factura";
            GbxFactura.Enter += GbxFactura_Enter;
            // 
            // ChbxEstado
            // 
            ChbxEstado.AutoSize = true;
            ChbxEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChbxEstado.Location = new Point(1318, 369);
            ChbxEstado.Name = "ChbxEstado";
            ChbxEstado.Size = new Size(77, 49);
            ChbxEstado.TabIndex = 37;
            ChbxEstado.Text = "Si";
            ChbxEstado.UseVisualStyleBackColor = true;
            // 
            // LblMonto
            // 
            LblMonto.AutoSize = true;
            LblMonto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMonto.Location = new Point(963, 234);
            LblMonto.Name = "LblMonto";
            LblMonto.Size = new Size(214, 45);
            LblMonto.TabIndex = 36;
            LblMonto.Text = "Monto Total:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(246, 246, 247);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(45, 45, 45);
            textBox2.Location = new Point(1224, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 43);
            textBox2.TabIndex = 35;
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubtotal.Location = new Point(1017, 118);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.Size = new Size(160, 45);
            LblSubtotal.TabIndex = 34;
            LblSubtotal.Text = "SubTotal:";
            // 
            // CmbxEmpleado
            // 
            CmbxEmpleado.BackColor = Color.FromArgb(246, 246, 247);
            CmbxEmpleado.FlatStyle = FlatStyle.Flat;
            CmbxEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxEmpleado.ForeColor = Color.FromArgb(45, 45, 45);
            CmbxEmpleado.FormattingEnabled = true;
            CmbxEmpleado.Items.AddRange(new object[] { "Publico General", "Juan Torrez", "Ricardo Mora", "Jose Lopez" });
            CmbxEmpleado.Location = new Point(454, 365);
            CmbxEmpleado.Name = "CmbxEmpleado";
            CmbxEmpleado.Size = new Size(365, 53);
            CmbxEmpleado.TabIndex = 33;
            CmbxEmpleado.Text = "Seleccione.....";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(246, 246, 247);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(45, 45, 45);
            textBox3.Location = new Point(1224, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 43);
            textBox3.TabIndex = 32;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // LblEmpleado
            // 
            LblEmpleado.AutoSize = true;
            LblEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEmpleado.Location = new Point(247, 368);
            LblEmpleado.Name = "LblEmpleado";
            LblEmpleado.Size = new Size(178, 45);
            LblEmpleado.TabIndex = 31;
            LblEmpleado.Text = "Empleado:";
            // 
            // DtmFecha
            // 
            DtmFecha.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.CalendarForeColor = Color.FromArgb(45, 45, 45);
            DtmFecha.CalendarMonthBackground = Color.FromArgb(109, 15, 15);
            DtmFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmFecha.Location = new Point(594, 494);
            DtmFecha.MinDate = new DateTime(2026, 6, 5, 0, 0, 0, 0);
            DtmFecha.Name = "DtmFecha";
            DtmFecha.Size = new Size(561, 50);
            DtmFecha.TabIndex = 30;
            // 
            // CmbxPedido
            // 
            CmbxPedido.BackColor = Color.FromArgb(246, 246, 247);
            CmbxPedido.FlatStyle = FlatStyle.Flat;
            CmbxPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbxPedido.ForeColor = Color.FromArgb(45, 45, 45);
            CmbxPedido.FormattingEnabled = true;
            CmbxPedido.Items.AddRange(new object[] { "Publico General", "Juan Torrez", "Ricardo Mora", "Jose Lopez" });
            CmbxPedido.Location = new Point(454, 234);
            CmbxPedido.Name = "CmbxPedido";
            CmbxPedido.Size = new Size(365, 53);
            CmbxPedido.TabIndex = 17;
            CmbxPedido.Text = "Seleccione.....";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(246, 246, 247);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(45, 45, 45);
            textBox1.Location = new Point(489, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 43);
            textBox1.TabIndex = 13;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstado.Location = new Point(1048, 373);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(129, 45);
            LblEstado.TabIndex = 12;
            LblEstado.Text = "Estado:";
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecha.Location = new Point(426, 494);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(114, 45);
            LblFecha.TabIndex = 11;
            LblFecha.Text = "Fecha:";
            // 
            // LblPedido
            // 
            LblPedido.AutoSize = true;
            LblPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPedido.Location = new Point(291, 237);
            LblPedido.Name = "LblPedido";
            LblPedido.Size = new Size(134, 45);
            LblPedido.TabIndex = 10;
            LblPedido.Text = "Pedido:";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(247, 118);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(187, 45);
            LblCodigo.TabIndex = 9;
            LblCodigo.Text = "N* Factura:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(200, 170, 80);
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnAgregar.FlatStyle = FlatStyle.Popup;
            BtnAgregar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = Color.FromArgb(45, 45, 45);
            BtnAgregar.Image = Properties.Resources.agregar_producto__1_;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(1224, 95);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(292, 70);
            BtnAgregar.TabIndex = 38;
            BtnAgregar.Text = "Generar Factura";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregarEmpl_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio, Subtotal });
            dataGridView1.Location = new Point(12, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1095, 300);
            dataGridView1.TabIndex = 2;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 10;
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "SubTotal";
            Subtotal.MinimumWidth = 10;
            Subtotal.Name = "Subtotal";
            // 
            // GbxPago
            // 
            GbxPago.BackColor = Color.FromArgb(243, 231, 211);
            GbxPago.Controls.Add(groupBox2);
            GbxPago.Controls.Add(BtnCerrar);
            GbxPago.Controls.Add(BtnLimpiar);
            GbxPago.Controls.Add(BtnImprimir);
            GbxPago.Controls.Add(BtnAgregar);
            GbxPago.Controls.Add(dataGridView1);
            GbxPago.Dock = DockStyle.Top;
            GbxPago.Location = new Point(0, 597);
            GbxPago.Name = "GbxPago";
            GbxPago.Size = new Size(1748, 941);
            GbxPago.TabIndex = 3;
            GbxPago.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(109, 15, 15);
            groupBox2.Controls.Add(TxtMontoPago);
            groupBox2.Controls.Add(LblMontoPago);
            groupBox2.Controls.Add(TxtFechaPago);
            groupBox2.Controls.Add(LblFechaPago);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(LblFactura);
            groupBox2.Controls.Add(TxtPago);
            groupBox2.Controls.Add(LblPago);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(246, 246, 247);
            groupBox2.Location = new Point(12, 357);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1095, 396);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pago";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // TxtMontoPago
            // 
            TxtMontoPago.BackColor = Color.FromArgb(246, 246, 247);
            TxtMontoPago.BorderStyle = BorderStyle.None;
            TxtMontoPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMontoPago.ForeColor = Color.FromArgb(45, 45, 45);
            TxtMontoPago.Location = new Point(512, 285);
            TxtMontoPago.Name = "TxtMontoPago";
            TxtMontoPago.Size = new Size(278, 43);
            TxtMontoPago.TabIndex = 21;
            // 
            // LblMontoPago
            // 
            LblMontoPago.AutoSize = true;
            LblMontoPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMontoPago.Location = new Point(305, 285);
            LblMontoPago.Name = "LblMontoPago";
            LblMontoPago.Size = new Size(131, 45);
            LblMontoPago.TabIndex = 20;
            LblMontoPago.Text = "Monto:";
            // 
            // TxtFechaPago
            // 
            TxtFechaPago.BackColor = Color.FromArgb(246, 246, 247);
            TxtFechaPago.BorderStyle = BorderStyle.None;
            TxtFechaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaPago.ForeColor = Color.FromArgb(45, 45, 45);
            TxtFechaPago.Location = new Point(512, 213);
            TxtFechaPago.Name = "TxtFechaPago";
            TxtFechaPago.Size = new Size(278, 43);
            TxtFechaPago.TabIndex = 19;
            // 
            // LblFechaPago
            // 
            LblFechaPago.AutoSize = true;
            LblFechaPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFechaPago.Location = new Point(305, 213);
            LblFechaPago.Name = "LblFechaPago";
            LblFechaPago.Size = new Size(114, 45);
            LblFechaPago.TabIndex = 18;
            LblFechaPago.Text = "Fecha:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(246, 246, 247);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.FromArgb(45, 45, 45);
            textBox4.Location = new Point(512, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 43);
            textBox4.TabIndex = 17;
            // 
            // LblFactura
            // 
            LblFactura.AutoSize = true;
            LblFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFactura.Location = new Point(305, 138);
            LblFactura.Name = "LblFactura";
            LblFactura.Size = new Size(187, 45);
            LblFactura.TabIndex = 16;
            LblFactura.Text = "N* Factura:";
            // 
            // TxtPago
            // 
            TxtPago.BackColor = Color.FromArgb(246, 246, 247);
            TxtPago.BorderStyle = BorderStyle.None;
            TxtPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPago.ForeColor = Color.FromArgb(45, 45, 45);
            TxtPago.Location = new Point(512, 60);
            TxtPago.Name = "TxtPago";
            TxtPago.Size = new Size(278, 43);
            TxtPago.TabIndex = 15;
            // 
            // LblPago
            // 
            LblPago.AutoSize = true;
            LblPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPago.Location = new Point(305, 60);
            LblPago.Name = "LblPago";
            LblPago.Size = new Size(144, 45);
            LblPago.TabIndex = 14;
            LblPago.Text = "Id Pago:";
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = Color.FromArgb(200, 170, 80);
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnCerrar.FlatStyle = FlatStyle.Popup;
            BtnCerrar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrar.Image = Properties.Resources.cerrar_ventana;
            BtnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrar.Location = new Point(1224, 559);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(292, 70);
            BtnCerrar.TabIndex = 41;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(200, 170, 80);
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnLimpiar.FlatStyle = FlatStyle.Popup;
            BtnLimpiar.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.ForeColor = Color.FromArgb(45, 45, 45);
            BtnLimpiar.Image = Properties.Resources.escoba;
            BtnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLimpiar.Location = new Point(1224, 406);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(292, 70);
            BtnLimpiar.TabIndex = 40;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnImprimir
            // 
            BtnImprimir.BackColor = Color.FromArgb(200, 170, 80);
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnImprimir.FlatStyle = FlatStyle.Popup;
            BtnImprimir.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnImprimir.Image = Properties.Resources.computer;
            BtnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImprimir.Location = new Point(1224, 248);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(292, 70);
            BtnImprimir.TabIndex = 39;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // FrmFactorironPayment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1748, 1386);
            Controls.Add(GbxPago);
            Controls.Add(GbxFactura);
            ForeColor = Color.FromArgb(45, 45, 45);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFactorironPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFacturacionPago";
            GbxFactura.ResumeLayout(false);
            GbxFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            GbxPago.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxFactura;
        private TextBox textBox3;
        private Label LblEmpleado;
        private DateTimePicker DtmFecha;
        private ComboBox CmbxPedido;
        private TextBox textBox1;
        private Label LblEstado;
        private Label LblFecha;
        private Label LblPedido;
        private Label LblCodigo;
        private ComboBox CmbxEmpleado;
        private Label LblMonto;
        private TextBox textBox2;
        private Label LblSubtotal;
        private CheckBox ChbxEstado;
        private Button BtnAgregar;
        private DataGridView dataGridView1;
        private GroupBox GbxPago;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private Button BtnImprimir;
        private GroupBox groupBox2;
        private Button BtnCerrar;
        private Button BtnLimpiar;
        private TextBox TxtPago;
        private Label LblPago;
        private TextBox TxtMontoPago;
        private Label LblMontoPago;
        private TextBox TxtFechaPago;
        private Label LblFechaPago;
        private TextBox textBox4;
        private Label LblFactura;
    }
}