using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
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
    public partial class Cadastrar : MaterialForm
    {
        private readonly string strConn = "Data Source=.;Initial Catalog=WPF;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Cadastrar()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mtCheckBox.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPPassword.PasswordChar = '•';
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {

                using(var conexao = new SqlConnection(strConn))
                {
                    var sql = "INSERT INTO tbl_login (Nome, Senha, PPassword, Admin, Func) VALUES (@Nome, @Senha, @PPassword, @Admin, @Func);";

                    // txtUsuario.Text
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    cmd.Parameters.AddWithValue("@Nome", txtUsuario.Text.ToString());
                    cmd.Parameters.AddWithValue("@Senha", txtPassword.Text.ToString());
                    cmd.Parameters.AddWithValue("@PPassword", txtPPassword.Text.ToString());
                    cmd.Parameters.AddWithValue("@Admin", chkAdmin.Checked);
                    cmd.Parameters.AddWithValue("@Func", chkFunc.Checked);

                    conexao.Open();
                    int i = cmd.ExecuteNonQuery();
                        if(i>0)
                    MessageBox.Show("Dados Salvos no Banco de Dados!!");
                    conexao.Close();
                    this.Hide();
                    
                    var ctrPonto = new ControlePonto();
                    ctrPonto.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }
    }
}
