using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaControlePonto.Models
{
    public class Opcoes
    {
        private const string strConn = "Data Source=.;Initial Catalog=WPF;Integrated Security=True;Trust Server Certificate=True";

        public int id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public byte Nivel { get; set; }

        public Opcoes(string? nome, string? descricao, byte nivel)
        {
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }


        public static HashSet<Opcoes> Criar(MenuStrip menu)
        {
            var hashSetOpcoes = new HashSet<Opcoes>();

            // Nível 1
            foreach (ToolStripMenuItem item in menu.Items)
            {
                var descricao1 = item.Text;

                if (item.HasDropDownItems)
                {
                    // Nível 2
                    foreach (ToolStripMenuItem opcao in item.DropDownItems)
                    {
                        var descricao2 = descricao1 + " / " + opcao.Text;

                        if (opcao.HasDropDownItems)
                        {
                            foreach (ToolStripMenuItem subOpcao in opcao.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + subOpcao.Text;
                                hashSetOpcoes.Add(new Opcoes(subOpcao.Name, descricao3, 3));
                            }
                        }
                        else
                        {
                            hashSetOpcoes.Add(new Opcoes(opcao.Name, descricao2, 2));
                        }
                    }
                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                }
            }

            return hashSetOpcoes;
        }

        public static bool SalvarMenu(HashSet<Opcoes> opcoes)
        {
            var sql = "Insert into MenuOpcoes (nome, descricao, nivel) Values (@nome, @descricao, @nivel)";

            try
            {
                using (var cn = new SqlConnection(strConn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                        cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                        cmd.Parameters.Add("@nivel", SqlDbType.TinyInt);

                        foreach (var item in opcoes)
                        {
                            cmd.Parameters["@nome"].Value = item.Nome;
                            cmd.Parameters["@descricao"].Value = item.Descricao;
                            cmd.Parameters["@nivel"].Value = item.Nivel;

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool GravarMySQL(HashSet<Opcoes> opcoes)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost;database=;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                MessageBox.Show("Conectado ao MySQL");
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível a conectar ao Banco de Dados!!", ex.Message);
                return false;
            }


        }
    }
}
