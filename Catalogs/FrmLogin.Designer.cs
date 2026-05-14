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
            groupBox1 = new GroupBox();
            BtnLogin = new Button();
            pictureBox2 = new PictureBox();
            PbHidePassword = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtPassword = new TextBox();
            TxtNameUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbHidePassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 1272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Beige;
            groupBox1.Controls.Add(BtnLogin);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(PbHidePassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Controls.Add(TxtNameUser);
            groupBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(815, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1055, 779);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(395, 597);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(303, 74);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Iniciar Sessión";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario;
            pictureBox2.Location = new Point(896, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // PbHidePassword
            // 
            PbHidePassword.Image = Properties.Resources.ojo;
            PbHidePassword.Location = new Point(896, 476);
            PbHidePassword.Name = "PbHidePassword";
            PbHidePassword.Size = new Size(90, 70);
            PbHidePassword.SizeMode = PictureBoxSizeMode.StretchImage;
            PbHidePassword.TabIndex = 7;
            PbHidePassword.TabStop = false;
            PbHidePassword.Click += PbHidePassword_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 705);
            label4.Name = "label4";
            label4.Size = new Size(321, 37);
            label4.TabIndex = 5;
            label4.Text = "Se te olvido la contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 373);
            label3.Name = "label3";
            label3.Size = new Size(151, 37);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 127);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(166, 476);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(662, 70);
            TxtPassword.TabIndex = 1;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // TxtNameUser
            // 
            TxtNameUser.Location = new Point(166, 226);
            TxtNameUser.Multiline = true;
            TxtNameUser.Name = "TxtNameUser";
            TxtNameUser.Size = new Size(677, 70);
            TxtNameUser.TabIndex = 0;
            TxtNameUser.KeyPress += TxtNameUser_KeyPress;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(2082, 1272);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbHidePassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox PbHidePassword;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtPassword;
        private TextBox TxtNameUser;
        private Button BtnLogin;
        private PictureBox pictureBox2;
    }
}