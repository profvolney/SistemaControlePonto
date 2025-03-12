namespace SistemaControlePonto.Views
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Wheat;
            label1.Location = new Point(175, 143);
            label1.Name = "label1";
            label1.Size = new Size(432, 80);
            label1.TabIndex = 0;
            label1.Text = "Olá, Seja bem-vindo ao Sistema de Controle de Ponto! Para acessar ao sistema você precisa estar logado. Clique no botão abaixo para ir para a tela de Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkGoldenrod;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(306, 280);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(191, 42);
            btn_login.TabIndex = 1;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(label1);
            MinimumSize = new Size(800, 450);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Welcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_login;
    }
}