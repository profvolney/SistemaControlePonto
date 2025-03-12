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
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
            MostrarFrutasCombo();
        }        
    public void MostrarFrutasCombo()
    {
            var frutas = new List<string> { "Limão", "Pêra", "Maçã" };
            
            frutas.Add("Morango");
            frutas.Add("Abacate");
            frutas.Add("Laranja");
            frutas.Add("Goiaba");
            frutas.Add("Uva");          

        foreach (var item in frutas)
        {
            
            MessageBox.Show($"O nome das frutas são...{frutas.ToString()}");
            
            BindingSource source = new BindingSource();
                source.DataSource = frutas;
                cboFrutas.DataSource = source.DataSource;
        }


    }

    };


}
