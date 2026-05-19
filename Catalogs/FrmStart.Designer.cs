namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    partial class FrmStart
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
            PnlSubMenuSystems = new Panel();
            FlpSalesOfTheDay = new FlowLayoutPanel();
            label3 = new Label();
            pictureBox12 = new PictureBox();
            textBox1 = new TextBox();
            PnlSubMenuLatestSales = new Panel();
            DgvLatestSales = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            label9 = new Label();
            PnlSubMenuSalesPerDay = new Panel();
            label7 = new Label();
            FlpLowStock = new FlowLayoutPanel();
            label6 = new Label();
            pictureBox15 = new PictureBox();
            textBox4 = new TextBox();
            FlpBillsOfTheDay = new FlowLayoutPanel();
            label4 = new Label();
            pictureBox13 = new PictureBox();
            textBox2 = new TextBox();
            FlpProducts = new FlowLayoutPanel();
            label5 = new Label();
            pictureBox14 = new PictureBox();
            textBox3 = new TextBox();
            PnlSubMenuBestSellingProducts = new Panel();
            LsbUploadBestSellingProducts = new ListBox();
            label8 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            PnlSubMenuSystems.SuspendLayout();
            FlpSalesOfTheDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            PnlSubMenuLatestSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLatestSales).BeginInit();
            PnlSubMenuSalesPerDay.SuspendLayout();
            FlpLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            FlpBillsOfTheDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            FlpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            PnlSubMenuBestSellingProducts.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // PnlSubMenuSystems
            // 
            PnlSubMenuSystems.BackColor = Color.Maroon;
            PnlSubMenuSystems.Controls.Add(FlpSalesOfTheDay);
            PnlSubMenuSystems.Controls.Add(PnlSubMenuLatestSales);
            PnlSubMenuSystems.Controls.Add(PnlSubMenuSalesPerDay);
            PnlSubMenuSystems.Controls.Add(FlpLowStock);
            PnlSubMenuSystems.Controls.Add(FlpBillsOfTheDay);
            PnlSubMenuSystems.Controls.Add(FlpProducts);
            PnlSubMenuSystems.Controls.Add(PnlSubMenuBestSellingProducts);
            PnlSubMenuSystems.Dock = DockStyle.Fill;
            PnlSubMenuSystems.Location = new Point(0, 0);
            PnlSubMenuSystems.Name = "PnlSubMenuSystems";
            PnlSubMenuSystems.Size = new Size(1756, 1158);
            PnlSubMenuSystems.TabIndex = 14;
            // 
            // FlpSalesOfTheDay
            // 
            FlpSalesOfTheDay.BackColor = Color.Beige;
            FlpSalesOfTheDay.Controls.Add(label3);
            FlpSalesOfTheDay.Controls.Add(pictureBox12);
            FlpSalesOfTheDay.Controls.Add(textBox1);
            FlpSalesOfTheDay.Location = new Point(41, 144);
            FlpSalesOfTheDay.Margin = new Padding(6);
            FlpSalesOfTheDay.Name = "FlpSalesOfTheDay";
            FlpSalesOfTheDay.Size = new Size(240, 149);
            FlpSalesOfTheDay.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(6, 0);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 30);
            label3.TabIndex = 0;
            label3.Text = "Ventas del dia";
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(6, 36);
            pictureBox12.Margin = new Padding(6);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(74, 64);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 4;
            pictureBox12.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = Color.Beige;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 10F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(0, 192, 0);
            textBox1.Location = new Point(92, 66);
            textBox1.Margin = new Padding(6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 34);
            textBox1.TabIndex = 3;
            textBox1.Text = "$11,800";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PnlSubMenuLatestSales
            // 
            PnlSubMenuLatestSales.BackColor = Color.Beige;
            PnlSubMenuLatestSales.Controls.Add(DgvLatestSales);
            PnlSubMenuLatestSales.Controls.Add(label9);
            PnlSubMenuLatestSales.Location = new Point(41, 711);
            PnlSubMenuLatestSales.Margin = new Padding(6);
            PnlSubMenuLatestSales.Name = "PnlSubMenuLatestSales";
            PnlSubMenuLatestSales.Size = new Size(1668, 405);
            PnlSubMenuLatestSales.TabIndex = 12;
            // 
            // DgvLatestSales
            // 
            DgvLatestSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLatestSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvLatestSales.BackgroundColor = Color.Beige;
            DgvLatestSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLatestSales.Columns.AddRange(new DataGridViewColumn[] { IdVenta, Empleado, Total, Fecha });
            DgvLatestSales.Location = new Point(24, 43);
            DgvLatestSales.Margin = new Padding(6);
            DgvLatestSales.Name = "DgvLatestSales";
            DgvLatestSales.ReadOnly = true;
            DgvLatestSales.RowHeadersWidth = 82;
            DgvLatestSales.Size = new Size(1625, 342);
            DgvLatestSales.TabIndex = 2;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "IdVenta";
            IdVenta.MinimumWidth = 10;
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 10;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 10;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 10;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(215, 30);
            label9.TabIndex = 1;
            label9.Text = "Ultimas Ventas";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlSubMenuSalesPerDay
            // 
            PnlSubMenuSalesPerDay.BackColor = Color.Beige;
            PnlSubMenuSalesPerDay.Controls.Add(label7);
            PnlSubMenuSalesPerDay.Location = new Point(41, 343);
            PnlSubMenuSalesPerDay.Margin = new Padding(6);
            PnlSubMenuSalesPerDay.Name = "PnlSubMenuSalesPerDay";
            PnlSubMenuSalesPerDay.Size = new Size(700, 326);
            PnlSubMenuSalesPerDay.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(225, 30);
            label7.TabIndex = 0;
            label7.Text = "Ventas por Dias";
            // 
            // FlpLowStock
            // 
            FlpLowStock.BackColor = Color.Beige;
            FlpLowStock.Controls.Add(label6);
            FlpLowStock.Controls.Add(pictureBox15);
            FlpLowStock.Controls.Add(textBox4);
            FlpLowStock.Location = new Point(1453, 144);
            FlpLowStock.Margin = new Padding(6);
            FlpLowStock.Name = "FlpLowStock";
            FlpLowStock.Size = new Size(256, 149);
            FlpLowStock.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(6, 0);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(168, 30);
            label6.TabIndex = 1;
            label6.Text = "Stock Bajos";
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox15.Location = new Point(6, 36);
            pictureBox15.Margin = new Padding(6);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(74, 64);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 6;
            pictureBox15.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.BackColor = Color.Beige;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Georgia", 10F, FontStyle.Bold);
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(92, 66);
            textBox4.Margin = new Padding(6);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 34);
            textBox4.TabIndex = 7;
            textBox4.Text = "8";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // FlpBillsOfTheDay
            // 
            FlpBillsOfTheDay.BackColor = Color.Beige;
            FlpBillsOfTheDay.Controls.Add(label4);
            FlpBillsOfTheDay.Controls.Add(pictureBox13);
            FlpBillsOfTheDay.Controls.Add(textBox2);
            FlpBillsOfTheDay.Location = new Point(496, 144);
            FlpBillsOfTheDay.Margin = new Padding(6);
            FlpBillsOfTheDay.Name = "FlpBillsOfTheDay";
            FlpBillsOfTheDay.Size = new Size(245, 149);
            FlpBillsOfTheDay.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(6, 0);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 30);
            label4.TabIndex = 1;
            label4.Text = "Facturas del dia";
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox13.Location = new Point(6, 36);
            pictureBox13.Margin = new Padding(6);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(74, 64);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.BackColor = Color.Beige;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Georgia", 10F, FontStyle.Bold);
            textBox2.ForeColor = Color.Green;
            textBox2.Location = new Point(92, 40);
            textBox2.Margin = new Padding(6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 60);
            textBox2.TabIndex = 6;
            textBox2.Text = "50";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // FlpProducts
            // 
            FlpProducts.BackColor = Color.Beige;
            FlpProducts.Controls.Add(label5);
            FlpProducts.Controls.Add(pictureBox14);
            FlpProducts.Controls.Add(textBox3);
            FlpProducts.Location = new Point(1009, 144);
            FlpProducts.Margin = new Padding(6);
            FlpProducts.Name = "FlpProducts";
            FlpProducts.Size = new Size(215, 149);
            FlpProducts.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(6, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 1;
            label5.Text = "Productos";
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox14.Location = new Point(6, 36);
            pictureBox14.Margin = new Padding(6);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(74, 64);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.BackColor = Color.Beige;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Georgia", 10F, FontStyle.Bold);
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(92, 66);
            textBox3.Margin = new Padding(6);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 34);
            textBox3.TabIndex = 7;
            textBox3.Text = "140";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // PnlSubMenuBestSellingProducts
            // 
            PnlSubMenuBestSellingProducts.BackColor = Color.Beige;
            PnlSubMenuBestSellingProducts.Controls.Add(LsbUploadBestSellingProducts);
            PnlSubMenuBestSellingProducts.Controls.Add(label8);
            PnlSubMenuBestSellingProducts.Location = new Point(1009, 343);
            PnlSubMenuBestSellingProducts.Margin = new Padding(6);
            PnlSubMenuBestSellingProducts.Name = "PnlSubMenuBestSellingProducts";
            PnlSubMenuBestSellingProducts.Size = new Size(700, 326);
            PnlSubMenuBestSellingProducts.TabIndex = 11;
            // 
            // LsbUploadBestSellingProducts
            // 
            LsbUploadBestSellingProducts.BackColor = Color.Maroon;
            LsbUploadBestSellingProducts.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LsbUploadBestSellingProducts.ForeColor = Color.White;
            LsbUploadBestSellingProducts.FormattingEnabled = true;
            LsbUploadBestSellingProducts.Location = new Point(25, 49);
            LsbUploadBestSellingProducts.Margin = new Padding(6);
            LsbUploadBestSellingProducts.Name = "LsbUploadBestSellingProducts";
            LsbUploadBestSellingProducts.Size = new Size(618, 244);
            LsbUploadBestSellingProducts.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(345, 30);
            label8.TabIndex = 1;
            label8.Text = "Productos más Vendidos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Goldenrod;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1756, 98);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 43);
            label1.TabIndex = 2;
            label1.Text = "Asados La Flaca";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8985, -81);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 1;
            label2.Text = "Guillermina ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1756, 1158);
            Controls.Add(panel3);
            Controls.Add(PnlSubMenuSystems);
            Name = "FrmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStart";
            PnlSubMenuSystems.ResumeLayout(false);
            FlpSalesOfTheDay.ResumeLayout(false);
            FlpSalesOfTheDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            PnlSubMenuLatestSales.ResumeLayout(false);
            PnlSubMenuLatestSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLatestSales).EndInit();
            PnlSubMenuSalesPerDay.ResumeLayout(false);
            PnlSubMenuSalesPerDay.PerformLayout();
            FlpLowStock.ResumeLayout(false);
            FlpLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            FlpBillsOfTheDay.ResumeLayout(false);
            FlpBillsOfTheDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            FlpProducts.ResumeLayout(false);
            FlpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            PnlSubMenuBestSellingProducts.ResumeLayout(false);
            PnlSubMenuBestSellingProducts.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlSubMenuSystems;
        private FlowLayoutPanel FlpSalesOfTheDay;
        private Label label3;
        private PictureBox pictureBox12;
        private TextBox textBox1;
        private Panel PnlSubMenuLatestSales;
        private DataGridView DgvLatestSales;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Fecha;
        private Label label9;
        private Panel PnlSubMenuSalesPerDay;
        private Label label7;
        private FlowLayoutPanel FlpLowStock;
        private Label label6;
        private PictureBox pictureBox15;
        private TextBox textBox4;
        private FlowLayoutPanel FlpBillsOfTheDay;
        private Label label4;
        private PictureBox pictureBox13;
        private TextBox textBox2;
        private FlowLayoutPanel FlpProducts;
        private Label label5;
        private PictureBox pictureBox14;
        private TextBox textBox3;
        private Panel PnlSubMenuBestSellingProducts;
        private ListBox LsbUploadBestSellingProducts;
        private Label label8;
        private Panel panel3;
        private Label label1;
        private Label label2;
    }
}