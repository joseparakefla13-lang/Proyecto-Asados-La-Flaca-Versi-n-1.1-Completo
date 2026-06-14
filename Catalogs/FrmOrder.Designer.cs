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
            BtsSearchCustomer = new Button();
            label5 = new Label();
            TxtSearchCustomer = new TextBox();
            CbTitleEmployee = new ComboBox();
            label4 = new Label();
            CbProducts = new ComboBox();
            label3 = new Label();
            TxtQuantity = new TextBox();
            label2 = new Label();
            TxtCustomer = new TextBox();
            TxtPrice = new TextBox();
            label1 = new Label();
            DtmDateOrder = new DateTimePicker();
            CbAvailable = new ComboBox();
            TxtN_Order = new TextBox();
            LblEstado = new Label();
            LblFecha = new Label();
            LblCliente = new Label();
            LblCodigo = new Label();
            GbxDellatePedido = new GroupBox();
            BtnCerrarEmpl = new Button();
            BtnLimpiarEmpl = new Button();
            BtnDeleteOrder = new Button();
            BtnSaveOrder = new Button();
            BtnInsertOrder = new Button();
            DtgOrderDetail = new DataGridView();
            TxtTotal = new TextBox();
            LblTotal = new Label();
            TxtSubTotal = new TextBox();
            LblSubTotal = new Label();
            ProductName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Cuantity = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            N_Order = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            OrderEmployee = new DataGridViewTextBoxColumn();
            GbxPedido.SuspendLayout();
            GbxDellatePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // GbxPedido
            // 
            GbxPedido.BackColor = Color.FromArgb(243, 231, 211);
            GbxPedido.Controls.Add(BtsSearchCustomer);
            GbxPedido.Controls.Add(label5);
            GbxPedido.Controls.Add(TxtSearchCustomer);
            GbxPedido.Controls.Add(CbTitleEmployee);
            GbxPedido.Controls.Add(label4);
            GbxPedido.Controls.Add(CbProducts);
            GbxPedido.Controls.Add(label3);
            GbxPedido.Controls.Add(TxtQuantity);
            GbxPedido.Controls.Add(label2);
            GbxPedido.Controls.Add(TxtCustomer);
            GbxPedido.Controls.Add(TxtPrice);
            GbxPedido.Controls.Add(label1);
            GbxPedido.Controls.Add(DtmDateOrder);
            GbxPedido.Controls.Add(CbAvailable);
            GbxPedido.Controls.Add(TxtN_Order);
            GbxPedido.Controls.Add(LblEstado);
            GbxPedido.Controls.Add(LblFecha);
            GbxPedido.Controls.Add(LblCliente);
            GbxPedido.Controls.Add(LblCodigo);
            GbxPedido.Dock = DockStyle.Top;
            GbxPedido.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbxPedido.ForeColor = Color.FromArgb(45, 45, 45);
            GbxPedido.Location = new Point(0, 0);
            GbxPedido.Name = "GbxPedido";
            GbxPedido.Size = new Size(1748, 617);
            GbxPedido.TabIndex = 0;
            GbxPedido.TabStop = false;
            GbxPedido.Text = "Datos del Pedido";
            // 
            // BtsSearchCustomer
            // 
            BtsSearchCustomer.FlatAppearance.BorderSize = 0;
            BtsSearchCustomer.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtsSearchCustomer.FlatStyle = FlatStyle.Flat;
            BtsSearchCustomer.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtsSearchCustomer.Image = Properties.Resources.agregar_producto__1_;
            BtsSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            BtsSearchCustomer.Location = new Point(1076, 106);
            BtsSearchCustomer.Name = "BtsSearchCustomer";
            BtsSearchCustomer.Size = new Size(201, 70);
            BtsSearchCustomer.TabIndex = 30;
            BtsSearchCustomer.Text = "Buscar";
            BtsSearchCustomer.TextAlign = ContentAlignment.MiddleRight;
            BtsSearchCustomer.UseVisualStyleBackColor = true;
            BtsSearchCustomer.Click += BtsSearchCustomer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(650, 53);
            label5.Name = "label5";
            label5.Size = new Size(440, 45);
            label5.TabIndex = 41;
            label5.Text = "Buscar Por Codigo al cliente";
            // 
            // TxtSearchCustomer
            // 
            TxtSearchCustomer.BackColor = Color.FromArgb(246, 246, 247);
            TxtSearchCustomer.BorderStyle = BorderStyle.None;
            TxtSearchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSearchCustomer.ForeColor = Color.FromArgb(45, 45, 45);
            TxtSearchCustomer.Location = new Point(650, 133);
            TxtSearchCustomer.Name = "TxtSearchCustomer";
            TxtSearchCustomer.Size = new Size(393, 43);
            TxtSearchCustomer.TabIndex = 40;
            // 
            // CbTitleEmployee
            // 
            CbTitleEmployee.BackColor = Color.FromArgb(246, 246, 247);
            CbTitleEmployee.FlatStyle = FlatStyle.Flat;
            CbTitleEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbTitleEmployee.ForeColor = Color.FromArgb(45, 45, 45);
            CbTitleEmployee.FormattingEnabled = true;
            CbTitleEmployee.Items.AddRange(new object[] { "Pediente", "Cancelado", "En proceso" });
            CbTitleEmployee.Location = new Point(1076, 558);
            CbTitleEmployee.Name = "CbTitleEmployee";
            CbTitleEmployee.Size = new Size(552, 53);
            CbTitleEmployee.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(874, 558);
            label4.Name = "label4";
            label4.Size = new Size(169, 45);
            label4.TabIndex = 38;
            label4.Text = "Empleado";
            // 
            // CbProducts
            // 
            CbProducts.BackColor = Color.FromArgb(246, 246, 247);
            CbProducts.FlatStyle = FlatStyle.Flat;
            CbProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbProducts.ForeColor = Color.FromArgb(45, 45, 45);
            CbProducts.FormattingEnabled = true;
            CbProducts.Items.AddRange(new object[] { "Pediente", "Cancelado", "En proceso" });
            CbProducts.Location = new Point(408, 453);
            CbProducts.Name = "CbProducts";
            CbProducts.Size = new Size(365, 53);
            CbProducts.TabIndex = 37;
            CbProducts.Text = "Seleccione Cargo";
            CbProducts.SelectedIndexChanged += CbProducts_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 574);
            label3.Name = "label3";
            label3.Size = new Size(114, 45);
            label3.TabIndex = 36;
            label3.Text = "Precio";
            // 
            // TxtQuantity
            // 
            TxtQuantity.BackColor = Color.FromArgb(246, 246, 247);
            TxtQuantity.BorderStyle = BorderStyle.None;
            TxtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantity.ForeColor = Color.FromArgb(45, 45, 45);
            TxtQuantity.Location = new Point(1215, 461);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(278, 43);
            TxtQuantity.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(889, 461);
            label2.Name = "label2";
            label2.Size = new Size(154, 45);
            label2.TabIndex = 34;
            label2.Text = "Cantidad";
            // 
            // TxtCustomer
            // 
            TxtCustomer.BackColor = Color.FromArgb(246, 246, 247);
            TxtCustomer.BorderStyle = BorderStyle.None;
            TxtCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCustomer.ForeColor = Color.FromArgb(45, 45, 45);
            TxtCustomer.Location = new Point(408, 344);
            TxtCustomer.Name = "TxtCustomer";
            TxtCustomer.Size = new Size(278, 43);
            TxtCustomer.TabIndex = 33;
            // 
            // TxtPrice
            // 
            TxtPrice.BackColor = Color.FromArgb(246, 246, 247);
            TxtPrice.BorderStyle = BorderStyle.None;
            TxtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrice.ForeColor = Color.FromArgb(45, 45, 45);
            TxtPrice.Location = new Point(420, 574);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(278, 43);
            TxtPrice.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 461);
            label1.Name = "label1";
            label1.Size = new Size(173, 45);
            label1.TabIndex = 31;
            label1.Text = "Productos";
            // 
            // DtmDateOrder
            // 
            DtmDateOrder.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmDateOrder.CalendarForeColor = Color.FromArgb(45, 45, 45);
            DtmDateOrder.CalendarMonthBackground = Color.FromArgb(109, 15, 15);
            DtmDateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtmDateOrder.Location = new Point(1076, 219);
            DtmDateOrder.MinDate = new DateTime(2026, 6, 5, 0, 0, 0, 0);
            DtmDateOrder.Name = "DtmDateOrder";
            DtmDateOrder.Size = new Size(552, 50);
            DtmDateOrder.TabIndex = 30;
            // 
            // CbAvailable
            // 
            CbAvailable.BackColor = Color.FromArgb(246, 246, 247);
            CbAvailable.FlatStyle = FlatStyle.Flat;
            CbAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbAvailable.ForeColor = Color.FromArgb(45, 45, 45);
            CbAvailable.FormattingEnabled = true;
            CbAvailable.Items.AddRange(new object[] { "Pediente", "Cancelado", "En proceso" });
            CbAvailable.Location = new Point(1160, 339);
            CbAvailable.Name = "CbAvailable";
            CbAvailable.Size = new Size(365, 53);
            CbAvailable.TabIndex = 16;
            // 
            // TxtN_Order
            // 
            TxtN_Order.BackColor = Color.FromArgb(246, 246, 247);
            TxtN_Order.BorderStyle = BorderStyle.None;
            TxtN_Order.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtN_Order.ForeColor = Color.FromArgb(45, 45, 45);
            TxtN_Order.Location = new Point(408, 219);
            TxtN_Order.Name = "TxtN_Order";
            TxtN_Order.Size = new Size(278, 43);
            TxtN_Order.TabIndex = 13;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstado.Location = new Point(889, 342);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(129, 45);
            LblEstado.TabIndex = 12;
            LblEstado.Text = "Estado:";
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecha.Location = new Point(889, 219);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(114, 45);
            LblFecha.TabIndex = 11;
            LblFecha.Text = "Fecha:";
            // 
            // LblCliente
            // 
            LblCliente.AutoSize = true;
            LblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCliente.Location = new Point(204, 342);
            LblCliente.Name = "LblCliente";
            LblCliente.Size = new Size(132, 45);
            LblCliente.TabIndex = 10;
            LblCliente.Text = "Cliente:";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(153, 217);
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
            GbxDellatePedido.Controls.Add(BtnDeleteOrder);
            GbxDellatePedido.Controls.Add(BtnSaveOrder);
            GbxDellatePedido.Controls.Add(BtnInsertOrder);
            GbxDellatePedido.Controls.Add(DtgOrderDetail);
            GbxDellatePedido.Controls.Add(TxtTotal);
            GbxDellatePedido.Controls.Add(LblTotal);
            GbxDellatePedido.Controls.Add(TxtSubTotal);
            GbxDellatePedido.Controls.Add(LblSubTotal);
            GbxDellatePedido.Dock = DockStyle.Top;
            GbxDellatePedido.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GbxDellatePedido.ForeColor = Color.FromArgb(45, 45, 45);
            GbxDellatePedido.Location = new Point(0, 617);
            GbxDellatePedido.Name = "GbxDellatePedido";
            GbxDellatePedido.Size = new Size(1748, 1107);
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
            BtnCerrarEmpl.Location = new Point(1486, 591);
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
            BtnLimpiarEmpl.Location = new Point(1486, 454);
            BtnLimpiarEmpl.Name = "BtnLimpiarEmpl";
            BtnLimpiarEmpl.Size = new Size(201, 70);
            BtnLimpiarEmpl.TabIndex = 27;
            BtnLimpiarEmpl.Text = "Limpiar";
            BtnLimpiarEmpl.TextAlign = ContentAlignment.MiddleRight;
            BtnLimpiarEmpl.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteOrder
            // 
            BtnDeleteOrder.FlatAppearance.BorderSize = 0;
            BtnDeleteOrder.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnDeleteOrder.FlatStyle = FlatStyle.Flat;
            BtnDeleteOrder.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeleteOrder.Image = Properties.Resources.basura;
            BtnDeleteOrder.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteOrder.Location = new Point(1486, 312);
            BtnDeleteOrder.Name = "BtnDeleteOrder";
            BtnDeleteOrder.Size = new Size(201, 70);
            BtnDeleteOrder.TabIndex = 26;
            BtnDeleteOrder.Text = "Eliminar";
            BtnDeleteOrder.TextAlign = ContentAlignment.MiddleRight;
            BtnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // BtnSaveOrder
            // 
            BtnSaveOrder.FlatAppearance.BorderSize = 0;
            BtnSaveOrder.FlatAppearance.MouseOverBackColor = Color.Blue;
            BtnSaveOrder.FlatStyle = FlatStyle.Flat;
            BtnSaveOrder.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSaveOrder.Image = Properties.Resources.abajo;
            BtnSaveOrder.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSaveOrder.Location = new Point(1486, 185);
            BtnSaveOrder.Name = "BtnSaveOrder";
            BtnSaveOrder.Size = new Size(201, 70);
            BtnSaveOrder.TabIndex = 25;
            BtnSaveOrder.Text = "Guardar";
            BtnSaveOrder.TextAlign = ContentAlignment.MiddleRight;
            BtnSaveOrder.UseVisualStyleBackColor = true;
            BtnSaveOrder.Click += BtnSaveOrder_Click;
            // 
            // BtnInsertOrder
            // 
            BtnInsertOrder.FlatAppearance.BorderSize = 0;
            BtnInsertOrder.FlatAppearance.MouseOverBackColor = Color.Lime;
            BtnInsertOrder.FlatStyle = FlatStyle.Flat;
            BtnInsertOrder.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInsertOrder.Image = Properties.Resources.agregar_producto__1_;
            BtnInsertOrder.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInsertOrder.Location = new Point(1486, 42);
            BtnInsertOrder.Name = "BtnInsertOrder";
            BtnInsertOrder.Size = new Size(201, 70);
            BtnInsertOrder.TabIndex = 21;
            BtnInsertOrder.Text = "Agregar";
            BtnInsertOrder.TextAlign = ContentAlignment.MiddleRight;
            BtnInsertOrder.UseVisualStyleBackColor = true;
            BtnInsertOrder.Click += BtnInsertOrder_Click;
            // 
            // DtgOrderDetail
            // 
            DtgOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgOrderDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DtgOrderDetail.BackgroundColor = Color.FromArgb(243, 231, 211);
            DtgOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgOrderDetail.Columns.AddRange(new DataGridViewColumn[] { ProductName, UnitPrice, Cuantity, Subtotal, N_Order, Customer, Date, OrderEmployee });
            DtgOrderDetail.Location = new Point(24, 70);
            DtgOrderDetail.Name = "DtgOrderDetail";
            DtgOrderDetail.RowHeadersWidth = 82;
            DtgOrderDetail.Size = new Size(1431, 564);
            DtgOrderDetail.TabIndex = 16;
            // 
            // TxtTotal
            // 
            TxtTotal.BackColor = Color.FromArgb(246, 246, 247);
            TxtTotal.BorderStyle = BorderStyle.None;
            TxtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTotal.ForeColor = Color.FromArgb(45, 45, 45);
            TxtTotal.Location = new Point(698, 681);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(278, 43);
            TxtTotal.TabIndex = 15;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotal.Location = new Point(569, 679);
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
            TxtSubTotal.Location = new Point(190, 679);
            TxtSubTotal.Name = "TxtSubTotal";
            TxtSubTotal.Size = new Size(278, 43);
            TxtSubTotal.TabIndex = 13;
            // 
            // LblSubTotal
            // 
            LblSubTotal.AutoSize = true;
            LblSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubTotal.Location = new Point(24, 679);
            LblSubTotal.Name = "LblSubTotal";
            LblSubTotal.Size = new Size(160, 45);
            LblSubTotal.TabIndex = 9;
            LblSubTotal.Text = "SubTotal:";
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.HeaderText = "Producto";
            ProductName.MinimumWidth = 10;
            ProductName.Name = "ProductName";
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnitPrice.HeaderText = "Precio";
            UnitPrice.MinimumWidth = 10;
            UnitPrice.Name = "UnitPrice";
            // 
            // Cuantity
            // 
            Cuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cuantity.HeaderText = "Cantidad";
            Cuantity.MinimumWidth = 10;
            Cuantity.Name = "Cuantity";
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subtotal.HeaderText = "SubTotal";
            Subtotal.MinimumWidth = 10;
            Subtotal.Name = "Subtotal";
            // 
            // N_Order
            // 
            N_Order.HeaderText = "N*Pedido";
            N_Order.MinimumWidth = 10;
            N_Order.Name = "N_Order";
            // 
            // Customer
            // 
            Customer.HeaderText = "Cliente";
            Customer.MinimumWidth = 10;
            Customer.Name = "Customer";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 10;
            Date.Name = "Date";
            // 
            // OrderEmployee
            // 
            OrderEmployee.HeaderText = "Empleado";
            OrderEmployee.MinimumWidth = 10;
            OrderEmployee.Name = "OrderEmployee";
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
            Load += FrmOrder_Load;
            GbxPedido.ResumeLayout(false);
            GbxPedido.PerformLayout();
            GbxDellatePedido.ResumeLayout(false);
            GbxDellatePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxPedido;
        private ComboBox CbAvailable;
        private TextBox TxtN_Order;
        private Label LblEstado;
        private Label LblFecha;
        private Label LblCliente;
        private Label LblCodigo;
        private DateTimePicker DtmDateOrder;
        private GroupBox GbxDellatePedido;
        private TextBox TxtSubTotal;
        private Label LblSubTotal;
        private DataGridView DtgOrderDetail;
        private TextBox TxtTotal;
        private Label LblTotal;
        private TextBox TxtPrice;
        private Label label1;
        private Button BtnInsertOrder;
        private Button BtnCerrarEmpl;
        private Button BtnLimpiarEmpl;
        private Button BtnDeleteOrder;
        private Button BtnSaveOrder;
        private TextBox TxtCustomer;
        private ComboBox CbProducts;
        private Label label3;
        private TextBox TxtQuantity;
        private Label label2;
        private ComboBox CbTitleEmployee;
        private Label label4;
        private Button BtsSearchCustomer;
        private Label label5;
        private TextBox TxtSearchCustomer;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn N_Order;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Cuantity;
        private DataGridViewTextBoxColumn OrderEmployee;
    }
}