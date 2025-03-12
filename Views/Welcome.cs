﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SistemaControlePonto.Views
{
    public partial class Welcome : MaterialForm
    {        
        public Welcome()
        {
            InitializeComponent();     
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);

            LoginScreen login = new LoginScreen();

            login.Show();
            this.Hide();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();

            speech.SetOutputToDefaultAudioDevice();

            speech.Speak(label1.Text);
        }
    }
}
