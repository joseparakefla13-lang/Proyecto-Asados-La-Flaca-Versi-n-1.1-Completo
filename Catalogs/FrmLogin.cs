using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;    
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public partial class FrmLogin : Form
    {
        // 👉 Lista de usuarios registrados (puedes cargarla desde JSON más adelante)
        private List<User> registeredUsers = new List<User>();

        public FrmLogin()
        {
            InitializeComponent();
            TxtPassword.UseSystemPasswordChar = true; // oculta la contraseña al iniciar
            // Usuario de prueba (predeterminado)
            registeredUsers.Add(new User("Jose", "1234"));
            registeredUsers.Add(new User("Admin", "adminpass"));
        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(198, 40, 40), 2)) // rojo principal
            {
                e.Graphics.DrawRectangle(p, 0, 0, PnlLogin.Width - 1, PnlLogin.Height - 1);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {


            string enteredUsername = TxtUserName.Text;   // ⚠️ Verifica que el TextBox se llame así en el diseñador
            string enteredPassword = TxtPassword.Text;   // ⚠️ Verifica que el TextBox se llame así en el diseñador

            // Busca si existe un usuario con esas credenciales
            var user = registeredUsers.FirstOrDefault(u => u.Login(enteredUsername, enteredPassword));

            if (user != null)
            {
                MessageBox.Show("Inicio de sesión exitoso. Bienvenido " + user.Username);

                // 👉 Abrir formulario principal
                FrmMainMenu frmPrincipal = new FrmMainMenu();
                frmPrincipal.Show();

                // 👉 Ocultar login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // evita el sonido "ding"

                if (string.IsNullOrWhiteSpace(TxtUserName.Text))
                {
                    MessageBox.Show(" Por favor escriba primero el usuario ");
                    TxtUserName.Focus(); // vuelve al TextBox de usuario
                }
                else
                {
                    TxtPassword.Focus(); // pasa al TextBox de contraseña
                }
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                {
                    MessageBox.Show("Please enter your password.");
                    TxtPassword.Focus();
                }
                else
                {
                    BtnLogin.Focus(); // pasa al botón de login
                }
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
          
    }
}
}
