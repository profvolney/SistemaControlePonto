namespace SistemaControlePonto.Views
{
    partial class Cadastrar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabUser = new TabPage();
            txtPPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            mtCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            chkFunc = new MaterialSkin.Controls.MaterialCheckbox();
            chkAdmin = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            tabEmployee = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabUser.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabUser);
            materialTabControl1.Controls.Add(tabEmployee);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(794, 533);
            materialTabControl1.TabIndex = 0;
            // 
            // tabUser
            // 
            tabUser.BackColor = Color.White;
            tabUser.Controls.Add(txtPPassword);
            tabUser.Controls.Add(txtPassword);
            tabUser.Controls.Add(mtCheckBox);
            tabUser.Controls.Add(materialLabel4);
            tabUser.Controls.Add(chkFunc);
            tabUser.Controls.Add(chkAdmin);
            tabUser.Controls.Add(materialLabel3);
            tabUser.Controls.Add(materialButton1);
            tabUser.Controls.Add(materialLabel2);
            tabUser.Controls.Add(materialLabel1);
            tabUser.Controls.Add(txtUsuario);
            tabUser.ImageKey = "incorporation.png";
            tabUser.Location = new Point(4, 24);
            tabUser.Name = "tabUser";
            tabUser.Padding = new Padding(3);
            tabUser.Size = new Size(786, 505);
            tabUser.TabIndex = 0;
            tabUser.Text = "Usuário";
            // 
            // txtPPassword
            // 
            txtPPassword.AllowPromptAsInput = true;
            txtPPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPPassword.AnimateReadOnly = false;
            txtPPassword.AsciiOnly = false;
            txtPPassword.BackgroundImageLayout = ImageLayout.None;
            txtPPassword.BeepOnError = false;
            txtPPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPPassword.Depth = 0;
            txtPPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPPassword.HidePromptOnLeave = false;
            txtPPassword.HideSelection = true;
            txtPPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPPassword.LeadingIcon = null;
            txtPPassword.Location = new Point(287, 189);
            txtPPassword.Mask = "";
            txtPPassword.MaxLength = 32767;
            txtPPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPPassword.Name = "txtPPassword";
            txtPPassword.PasswordChar = '•';
            txtPPassword.PrefixSuffixText = null;
            txtPPassword.PromptChar = '_';
            txtPPassword.ReadOnly = false;
            txtPPassword.RejectInputOnFirstFailure = false;
            txtPPassword.ResetOnPrompt = true;
            txtPPassword.ResetOnSpace = true;
            txtPPassword.RightToLeft = RightToLeft.No;
            txtPPassword.SelectedText = "";
            txtPPassword.SelectionLength = 0;
            txtPPassword.SelectionStart = 0;
            txtPPassword.ShortcutsEnabled = true;
            txtPPassword.Size = new Size(250, 48);
            txtPPassword.SkipLiterals = true;
            txtPPassword.TabIndex = 13;
            txtPPassword.TabStop = false;
            txtPPassword.TextAlign = HorizontalAlignment.Left;
            txtPPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPPassword.TrailingIcon = null;
            txtPPassword.UseSystemPasswordChar = false;
            txtPPassword.ValidatingType = null;
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(287, 116);
            txtPassword.Mask = "";
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PrefixSuffixText = null;
            txtPassword.PromptChar = '_';
            txtPassword.ReadOnly = false;
            txtPassword.RejectInputOnFirstFailure = false;
            txtPassword.ResetOnPrompt = true;
            txtPassword.ResetOnSpace = true;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(250, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 12;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ValidatingType = null;
            // 
            // mtCheckBox
            // 
            mtCheckBox.AutoSize = true;
            mtCheckBox.Depth = 0;
            mtCheckBox.Location = new Point(72, 200);
            mtCheckBox.Margin = new Padding(0);
            mtCheckBox.MouseLocation = new Point(-1, -1);
            mtCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            mtCheckBox.Name = "mtCheckBox";
            mtCheckBox.ReadOnly = false;
            mtCheckBox.Ripple = true;
            mtCheckBox.Size = new Size(139, 37);
            mtCheckBox.TabIndex = 11;
            mtCheckBox.Text = "Mostrar Senha";
            mtCheckBox.UseVisualStyleBackColor = true;
            mtCheckBox.CheckedChanged += mtCheckBox_CheckedChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(72, 36);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(54, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Função";
            // 
            // chkFunc
            // 
            chkFunc.AutoSize = true;
            chkFunc.Depth = 0;
            chkFunc.Location = new Point(72, 92);
            chkFunc.Margin = new Padding(0);
            chkFunc.MouseLocation = new Point(-1, -1);
            chkFunc.MouseState = MaterialSkin.MouseState.HOVER;
            chkFunc.Name = "chkFunc";
            chkFunc.ReadOnly = false;
            chkFunc.Ripple = true;
            chkFunc.Size = new Size(119, 37);
            chkFunc.TabIndex = 9;
            chkFunc.Text = "Funcionário";
            chkFunc.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Depth = 0;
            chkAdmin.Location = new Point(72, 55);
            chkAdmin.Margin = new Padding(0);
            chkAdmin.MouseLocation = new Point(-1, -1);
            chkAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            chkAdmin.Name = "chkAdmin";
            chkAdmin.ReadOnly = false;
            chkAdmin.Ripple = true;
            chkAdmin.Size = new Size(81, 37);
            chkAdmin.TabIndex = 8;
            chkAdmin.Text = "Admin";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(287, 167);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(121, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Confirmar Senha";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(365, 265);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(76, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "SALVAR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(289, 20);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(55, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Usuario";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(289, 92);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(46, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(287, 42);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 50);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            // 
            // tabEmployee
            // 
            tabEmployee.BackColor = Color.White;
            tabEmployee.ImageKey = "employee.png";
            tabEmployee.Location = new Point(4, 24);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(786, 505);
            tabEmployee.TabIndex = 1;
            tabEmployee.Text = "Funcionário";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "settings.png");
            imageList1.Images.SetKeyName(1, "employee.png");
            imageList1.Images.SetKeyName(2, "id-card.png");
            imageList1.Images.SetKeyName(3, "incorporation.png");
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(materialTabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 600);
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            materialTabControl1.ResumeLayout(false);
            tabUser.ResumeLayout(false);
            tabUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabUser;
        private TabPage tabEmployee;
        public ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckbox chkFunc;
        private MaterialSkin.Controls.MaterialCheckbox chkAdmin;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCheckbox mtCheckBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
    }
}