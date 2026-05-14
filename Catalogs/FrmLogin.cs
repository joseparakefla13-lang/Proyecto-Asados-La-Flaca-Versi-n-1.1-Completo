using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs;
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
            // Usuario de prueba (predeterminado)
            registeredUsers.Add(new User("Jose", "1234"));
            registeredUsers.Add(new User("Admin", "adminpass"));
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = TxtNameUser.Text;   // ⚠️ Verifica que el TextBox se llame así en el diseñador
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

        private void PbHidePassword_Click(object sender, EventArgs e)
        {
            // 👉 Alterna entre ocultar y mostrar
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false; // muestra la contraseña

            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true; // oculta la contraseña
            }
        }

        private void TxtNameUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 👉 Verificar si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // evita el sonido "ding"
                TxtPassword.Focus(); // pasa el foco al TextBox de contraseña
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnLogin.Focus(); // pasa el foco al botón de login
            }
        }
    }
}
