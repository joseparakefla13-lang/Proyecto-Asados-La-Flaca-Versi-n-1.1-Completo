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
            TxtNameUser = new TextBox();
            TxtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LbOlvidarContraseña = new Label();
            PbHidePassword = new PictureBox();
            pictureBox2 = new PictureBox();
            BtnLogin = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbHidePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 1229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtNameUser
            // 
            TxtNameUser.Location = new Point(166, 226);
            TxtNameUser.Name = "TxtNameUser";
            TxtNameUser.Size = new Size(677, 43);
            TxtNameUser.TabIndex = 0;
            TxtNameUser.KeyPress += TxtNameUser_KeyPress;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(166, 443);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(662, 43);
            TxtPassword.TabIndex = 1;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 144);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 69);
            label2.Name = "label2";
            label2.Size = new Size(174, 37);
            label2.TabIndex = 3;
            label2.Text = "Inicie Sessión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 344);
            label3.Name = "label3";
            label3.Size = new Size(151, 37);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // LbOlvidarContraseña
            // 
            LbOlvidarContraseña.AutoSize = true;
            LbOlvidarContraseña.Location = new Point(377, 674);
            LbOlvidarContraseña.Name = "LbOlvidarContraseña";
            LbOlvidarContraseña.Size = new Size(321, 37);
            LbOlvidarContraseña.TabIndex = 5;
            LbOlvidarContraseña.Text = "Se te olvido la contraseña";
            // 
            // PbHidePassword
            // 
            PbHidePassword.Image = Properties.Resources.ojo;
            PbHidePassword.Location = new Point(896, 425);
            PbHidePassword.Name = "PbHidePassword";
            PbHidePassword.Size = new Size(90, 70);
            PbHidePassword.SizeMode = PictureBoxSizeMode.StretchImage;
            PbHidePassword.TabIndex = 7;
            PbHidePassword.TabStop = false;
            PbHidePassword.Click += PbHidePassword_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario;
            pictureBox2.Location = new Point(896, 212);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(395, 555);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(303, 74);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Iniciar Sessión";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.Beige;
            groupBox1.Controls.Add(BtnLogin);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(PbHidePassword);
            groupBox1.Controls.Add(LbOlvidarContraseña);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Controls.Add(TxtNameUser);
            groupBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(880, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 750);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Maroon;
            ClientSize = new Size(2074, 1229);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbHidePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TxtNameUser;
        private TextBox TxtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LbOlvidarContraseña;
        private PictureBox PbHidePassword;
        private PictureBox pictureBox2;
        private Button BtnLogin;
        private GroupBox groupBox1;
    }
}