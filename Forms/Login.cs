using Coatza_Reporta.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coatza_Reporta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            if (txtUser.Text == "AtencionC98" && txtPassword.Text == "989899")
            {
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta.");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
