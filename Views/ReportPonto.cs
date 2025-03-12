namespace SistemaControlePonto.Views
{
    public partial class ReportPonto : Form
    {
        public ReportPonto()
        {
            InitializeComponent();
        }

        private void ReportPonto_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaControlePonto.RelatorioPonto.rdlc";
            reportViewer1.RefreshReport();
        }

    }
}
