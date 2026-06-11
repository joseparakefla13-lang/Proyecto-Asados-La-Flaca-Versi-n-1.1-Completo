namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    partial class FrmLogin
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
            pictureBox1 = new PictureBox();
            PnlLogin = new Panel();
            LblOlvidarCintraseña = new Label();
            BtnLogin = new Button();
            TxtPassword = new TextBox();
            LblContraseña = new Label();
            TxtUserName = new TextBox();
            LblNombre = new Label();
            Lblinisiosesion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Copilot_20260602_134910;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(874, 1329);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PnlLogin
            // 
            PnlLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PnlLogin.BackColor = Color.FromArgb(243, 231, 211);
            PnlLogin.Controls.Add(LblOlvidarCintraseña);
            PnlLogin.Controls.Add(BtnLogin);
            PnlLogin.Controls.Add(TxtPassword);
            PnlLogin.Controls.Add(LblContraseña);
            PnlLogin.Controls.Add(TxtUserName);
            PnlLogin.Controls.Add(LblNombre);
            PnlLogin.Controls.Add(Lblinisiosesion);
            PnlLogin.Location = new Point(920, 59);
            PnlLogin.Name = "PnlLogin";
            PnlLogin.Size = new Size(899, 1211);
            PnlLogin.TabIndex = 10;
            PnlLogin.Paint += PnlLogin_Paint;
            // 
            // LblOlvidarCintraseña
            // 
            LblOlvidarCintraseña.AutoSize = true;
            LblOlvidarCintraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOlvidarCintraseña.ForeColor = Color.FromArgb(64, 64, 64);
            LblOlvidarCintraseña.Location = new Point(271, 756);
            LblOlvidarCintraseña.Name = "LblOlvidarCintraseña";
            LblOlvidarCintraseña.Size = new Size(363, 45);
            LblOlvidarCintraseña.TabIndex = 8;
            LblOlvidarCintraseña.Text = "¿Olvide mi contraseña?";
            LblOlvidarCintraseña.Click += label1_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(109, 15, 15);
            BtnLogin.FlatAppearance.BorderColor = Color.Black;
            BtnLogin.FlatAppearance.BorderSize = 3;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.FromArgb(246, 246, 247);
            BtnLogin.Location = new Point(271, 907);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(347, 90);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "INICIAR SESIÓN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click_1;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtPassword.Cursor = Cursors.Hand;
            TxtPassword.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPassword.ForeColor = Color.Gray;
            TxtPassword.Location = new Point(100, 607);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(702, 62);
            TxtPassword.TabIndex = 6;
            TxtPassword.Text = "Ingrese su Contraseña";
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContraseña.ForeColor = Color.FromArgb(45, 45, 45);
            LblContraseña.Location = new Point(100, 493);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(235, 45);
            LblContraseña.TabIndex = 5;
            LblContraseña.Text = "CONTRASEÑA";
            // 
            // TxtUserName
            // 
            TxtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtUserName.Cursor = Cursors.Hand;
            TxtUserName.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUserName.ForeColor = Color.Gray;
            TxtUserName.Location = new Point(100, 334);
            TxtUserName.Multiline = true;
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(702, 62);
            TxtUserName.TabIndex = 2;
            TxtUserName.Text = "Ingrese su Nombre completo";
            TxtUserName.KeyPress += TxtUserName_KeyPress;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.ForeColor = Color.FromArgb(45, 45, 45);
            LblNombre.Location = new Point(100, 231);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(159, 45);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "NOMBRE";
            // 
            // Lblinisiosesion
            // 
            Lblinisiosesion.AutoSize = true;
            Lblinisiosesion.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lblinisiosesion.ForeColor = Color.FromArgb(45, 45, 45);
            Lblinisiosesion.Location = new Point(282, 105);
            Lblinisiosesion.Name = "Lblinisiosesion";
            Lblinisiosesion.Size = new Size(301, 50);
            Lblinisiosesion.TabIndex = 0;
            Lblinisiosesion.Text = "INICIAR SESIÓN";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 15, 15);
            ClientSize = new Size(1874, 1329);
            Controls.Add(PnlLogin);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnlLogin.ResumeLayout(false);
            PnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel PnlLogin;
        private Label Lblinisiosesion;
        private TextBox TxtUserName;
        private Label LblNombre;
        private TextBox TxtPassword;
        private Label LblContraseña;
        private Button BtnLogin;
        private Label LblOlvidarCintraseña;
    }
}