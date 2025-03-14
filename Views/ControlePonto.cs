using SistemaControlePonto.Models;
using SistemaControlePonto.Views;

namespace SistemaControlePonto
{
    public partial class ControlePonto : Form
    {
        public ControlePonto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opcoes = Opcoes.Criar(menuStrip1);
            dataGridView1.DataSource = opcoes.ToList();

            ConfigurarGrade();

            //Opcoes.SalvarMenu(opcoes);

            //MessageBox.Show("Gerado");

            Opcoes.GravarMySQL(opcoes);

            MessageBox.Show("Gerado no MySQL");
        }

        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["nome"].Width = 300;
            dataGridView1.Columns["nome"].ReadOnly = true;

            dataGridView1.Columns["descricao"].HeaderText = "Nome";
            dataGridView1.Columns["descricao"].Width = 380;
            dataGridView1.Columns["descricao"].ReadOnly = true;

            dataGridView1.Columns["nivel"].HeaderText = "Nível";
            dataGridView1.Columns["nivel"].Width = 60;
            dataGridView1.Columns["nivel"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].ReadOnly = true;

            // adicionando uma coluna
            var acesso = new DataGridViewCheckBoxColumn();
            acesso.HeaderText = "Liberado";
            acesso.Width = 60;
            acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(acesso);


        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportPonto report = new ReportPonto();
            report.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void páginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
        }
    }
}
