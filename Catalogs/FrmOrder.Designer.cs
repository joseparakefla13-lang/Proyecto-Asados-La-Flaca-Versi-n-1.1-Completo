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
            PnlSubMenuOrder = new Panel();
            label7 = new Label();
            GbOrderDetail = new GroupBox();
            BtnComplet = new Button();
            BtnProductUptade = new Button();
            TxtTotalPriceToPay = new TextBox();
            label6 = new Label();
            DgvLoadCart = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            PnlProducts = new Panel();
            LsbUploadProductsToOrder = new ListBox();
            button12 = new Button();
            label5 = new Label();
            TxtSelectedProductsForTheOrder = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            pictureBox11 = new PictureBox();
            button11 = new Button();
            PnlSubMenuOrder.SuspendLayout();
            GbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLoadCart).BeginInit();
            PnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // PnlSubMenuOrder
            // 
            PnlSubMenuOrder.BackColor = Color.Maroon;
            PnlSubMenuOrder.Controls.Add(label7);
            PnlSubMenuOrder.Controls.Add(GbOrderDetail);
            PnlSubMenuOrder.Controls.Add(PnlProducts);
            PnlSubMenuOrder.Controls.Add(dateTimePicker1);
            PnlSubMenuOrder.Controls.Add(label4);
            PnlSubMenuOrder.Controls.Add(label3);
            PnlSubMenuOrder.Controls.Add(pictureBox11);
            PnlSubMenuOrder.Controls.Add(button11);
            PnlSubMenuOrder.Dock = DockStyle.Fill;
            PnlSubMenuOrder.Location = new Point(0, 0);
            PnlSubMenuOrder.Margin = new Padding(6);
            PnlSubMenuOrder.Name = "PnlSubMenuOrder";
            PnlSubMenuOrder.Size = new Size(1756, 1158);
            PnlSubMenuOrder.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 38);
            label7.TabIndex = 19;
            label7.Text = "Pedido";
            // 
            // GbOrderDetail
            // 
            GbOrderDetail.BackColor = Color.Beige;
            GbOrderDetail.Controls.Add(BtnComplet);
            GbOrderDetail.Controls.Add(BtnProductUptade);
            GbOrderDetail.Controls.Add(TxtTotalPriceToPay);
            GbOrderDetail.Controls.Add(label6);
            GbOrderDetail.Controls.Add(DgvLoadCart);
            GbOrderDetail.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbOrderDetail.ForeColor = Color.Black;
            GbOrderDetail.Location = new Point(698, 309);
            GbOrderDetail.Margin = new Padding(6);
            GbOrderDetail.Name = "GbOrderDetail";
            GbOrderDetail.Padding = new Padding(6);
            GbOrderDetail.Size = new Size(1013, 746);
            GbOrderDetail.TabIndex = 18;
            GbOrderDetail.TabStop = false;
            GbOrderDetail.Text = "Detalles del Pedido";
            // 
            // BtnComplet
            // 
            BtnComplet.BackColor = Color.Green;
            BtnComplet.FlatStyle = FlatStyle.Flat;
            BtnComplet.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComplet.Location = new Point(548, 656);
            BtnComplet.Margin = new Padding(6);
            BtnComplet.Name = "BtnComplet";
            BtnComplet.Size = new Size(139, 49);
            BtnComplet.TabIndex = 4;
            BtnComplet.Text = "Observar ";
            BtnComplet.UseVisualStyleBackColor = false;
            // 
            // BtnProductUptade
            // 
            BtnProductUptade.BackColor = Color.Maroon;
            BtnProductUptade.FlatStyle = FlatStyle.Flat;
            BtnProductUptade.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProductUptade.Location = new Point(331, 656);
            BtnProductUptade.Margin = new Padding(6);
            BtnProductUptade.Name = "BtnProductUptade";
            BtnProductUptade.Size = new Size(139, 49);
            BtnProductUptade.TabIndex = 3;
            BtnProductUptade.Text = "Cancelar";
            BtnProductUptade.UseVisualStyleBackColor = false;
            // 
            // TxtTotalPriceToPay
            // 
            TxtTotalPriceToPay.BackColor = Color.Beige;
            TxtTotalPriceToPay.ForeColor = Color.Maroon;
            TxtTotalPriceToPay.Location = new Point(417, 571);
            TxtTotalPriceToPay.Margin = new Padding(6);
            TxtTotalPriceToPay.Name = "TxtTotalPriceToPay";
            TxtTotalPriceToPay.Size = new Size(192, 37);
            TxtTotalPriceToPay.TabIndex = 2;
            TxtTotalPriceToPay.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 511);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(198, 30);
            label6.TabIndex = 1;
            label6.Text = "Total a Pagar:";
            // 
            // DgvLoadCart
            // 
            DgvLoadCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLoadCart.BackgroundColor = Color.Beige;
            DgvLoadCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLoadCart.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio, Total });
            DgvLoadCart.GridColor = Color.Black;
            DgvLoadCart.Location = new Point(0, 66);
            DgvLoadCart.Margin = new Padding(6);
            DgvLoadCart.Name = "DgvLoadCart";
            DgvLoadCart.ReadOnly = true;
            DgvLoadCart.RowHeadersWidth = 82;
            DgvLoadCart.Size = new Size(982, 412);
            DgvLoadCart.TabIndex = 0;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 10;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 10;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // PnlProducts
            // 
            PnlProducts.BackColor = Color.Beige;
            PnlProducts.Controls.Add(LsbUploadProductsToOrder);
            PnlProducts.Controls.Add(button12);
            PnlProducts.Controls.Add(label5);
            PnlProducts.Controls.Add(TxtSelectedProductsForTheOrder);
            PnlProducts.ForeColor = Color.Black;
            PnlProducts.Location = new Point(50, 309);
            PnlProducts.Margin = new Padding(6);
            PnlProducts.Name = "PnlProducts";
            PnlProducts.Size = new Size(543, 746);
            PnlProducts.TabIndex = 17;
            // 
            // LsbUploadProductsToOrder
            // 
            LsbUploadProductsToOrder.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LsbUploadProductsToOrder.ForeColor = Color.Black;
            LsbUploadProductsToOrder.FormattingEnabled = true;
            LsbUploadProductsToOrder.Items.AddRange(new object[] { "1 Asado res 170 " });
            LsbUploadProductsToOrder.Location = new Point(20, 149);
            LsbUploadProductsToOrder.Margin = new Padding(6);
            LsbUploadProductsToOrder.Name = "LsbUploadProductsToOrder";
            LsbUploadProductsToOrder.Size = new Size(506, 574);
            LsbUploadProductsToOrder.TabIndex = 17;
            // 
            // button12
            // 
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(454, 66);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(72, 68);
            button12.TabIndex = 15;
            button12.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 14;
            label5.Text = "Productos";
            // 
            // TxtSelectedProductsForTheOrder
            // 
            TxtSelectedProductsForTheOrder.BackColor = Color.White;
            TxtSelectedProductsForTheOrder.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtSelectedProductsForTheOrder.ForeColor = Color.Black;
            TxtSelectedProductsForTheOrder.Location = new Point(20, 70);
            TxtSelectedProductsForTheOrder.Margin = new Padding(6);
            TxtSelectedProductsForTheOrder.Multiline = true;
            TxtSelectedProductsForTheOrder.Name = "TxtSelectedProductsForTheOrder";
            TxtSelectedProductsForTheOrder.Size = new Size(422, 64);
            TxtSelectedProductsForTheOrder.TabIndex = 0;
            TxtSelectedProductsForTheOrder.Text = "Asado Res";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Beige;
            dateTimePicker1.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(1197, 146);
            dateTimePicker1.Margin = new Padding(6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(514, 37);
            dateTimePicker1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(958, 153);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 15;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(541, 153);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 30);
            label3.TabIndex = 13;
            label3.Text = "IDFactura:";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.DarkGoldenrod;
            pictureBox11.Location = new Point(84, 146);
            pictureBox11.Margin = new Padding(6);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(37, 43);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 12;
            pictureBox11.TabStop = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Goldenrod;
            button11.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(70, 131);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(288, 75);
            button11.TabIndex = 0;
            button11.Text = "Nuevo Pedido";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // FrmOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1756, 1158);
            Controls.Add(PnlSubMenuOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOrder";
            PnlSubMenuOrder.ResumeLayout(false);
            PnlSubMenuOrder.PerformLayout();
            GbOrderDetail.ResumeLayout(false);
            GbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLoadCart).EndInit();
            PnlProducts.ResumeLayout(false);
            PnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlSubMenuOrder;
        private Label label7;
        private GroupBox GbOrderDetail;
        private Button BtnComplet;
        private Button BtnProductUptade;
        private TextBox TxtTotalPriceToPay;
        private Label label6;
        private DataGridView DgvLoadCart;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Panel PnlProducts;
        private ListBox LsbUploadProductsToOrder;
        private Button button12;
        private Label label5;
        private TextBox TxtSelectedProductsForTheOrder;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox11;
        private Button button11;
    }
}