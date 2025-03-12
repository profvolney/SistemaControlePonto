using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlePonto.Views
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Dados inválidos! Por favor preencha os campos corretamente!");
            }
            else
            {
                if (txtEmail.Text == "jason.volney@outlook.com" && txtSenha.Text == "123")
                {
                    ControlePonto ponto = new ControlePonto();
                    ponto.Show();
                    this.Hide();
                    MessageBox.Show("Logado com sucesso!!!");

                }
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '•';
            }
        }
    }
}
