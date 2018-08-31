namespace video_locadora
{
    partial class Form_Novo_Usuario
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
            this.components = new System.ComponentModel.Container();
            this.label19 = new System.Windows.Forms.Label();
            this.toolTipInformações = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxRg = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxConfirmar_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBoxDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_Foto = new System.Windows.Forms.GroupBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.button_Add_Foto = new System.Windows.Forms.Button();
            this.radioButtonMasc = new System.Windows.Forms.RadioButton();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.labelErroSenha = new System.Windows.Forms.Label();
            this.labelErroCPF = new System.Windows.Forms.Label();
            this.labelErro_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox_Foto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(187, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 83;
            this.label19.Text = "Data Admissão:";
            // 
            // toolTipInformações
            // 
            this.toolTipInformações.IsBalloon = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLimpar.Location = new System.Drawing.Point(288, 206);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(66, 23);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "&Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.Limpar_Form);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCadastrar.Location = new System.Drawing.Point(360, 206);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 11;
            this.buttonCadastrar.Text = "&Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxRg
            // 
            this.textBoxRg.Location = new System.Drawing.Point(12, 64);
            this.textBoxRg.MaxLength = 30;
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(93, 20);
            this.textBoxRg.TabIndex = 1;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(111, 64);
            this.maskedTextBoxCpf.Mask = "000,000,000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBoxCpf.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "RG:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 24);
            this.textBoxNome.MaxLength = 80;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(256, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 139);
            this.textBoxLogin.MaxLength = 12;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(256, 20);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(12, 183);
            this.textBoxSenha.MaxLength = 8;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(125, 20);
            this.textBoxSenha.TabIndex = 7;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(12, 167);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 75;
            this.labelSenha.Text = "Senha";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 123);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 74;
            this.labelLogin.Text = "Login";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 73;
            this.labelNome.Text = "Nome";
            // 
            // textBoxConfirmar_Senha
            // 
            this.textBoxConfirmar_Senha.Location = new System.Drawing.Point(143, 183);
            this.textBoxConfirmar_Senha.MaxLength = 8;
            this.textBoxConfirmar_Senha.Name = "textBoxConfirmar_Senha";
            this.textBoxConfirmar_Senha.PasswordChar = '*';
            this.textBoxConfirmar_Senha.Size = new System.Drawing.Size(125, 20);
            this.textBoxConfirmar_Senha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Confirmar Senha";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // maskedTextBoxDataAdmissao
            // 
            this.maskedTextBoxDataAdmissao.Location = new System.Drawing.Point(199, 63);
            this.maskedTextBoxDataAdmissao.Mask = "00/00/0000";
            this.maskedTextBoxDataAdmissao.Name = "maskedTextBoxDataAdmissao";
            this.maskedTextBoxDataAdmissao.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxDataAdmissao.TabIndex = 3;
            // 
            // groupBox_Foto
            // 
            this.groupBox_Foto.Controls.Add(this.pictureBoxFoto);
            this.groupBox_Foto.Location = new System.Drawing.Point(288, 12);
            this.groupBox_Foto.Name = "groupBox_Foto";
            this.groupBox_Foto.Size = new System.Drawing.Size(147, 159);
            this.groupBox_Foto.TabIndex = 87;
            this.groupBox_Foto.TabStop = false;
            this.groupBox_Foto.Text = "Foto";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = global::video_locadora.Properties.Resources.masculino;
            this.pictureBoxFoto.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(130, 140);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 0;
            this.pictureBoxFoto.TabStop = false;
            // 
            // button_Add_Foto
            // 
            this.button_Add_Foto.Location = new System.Drawing.Point(288, 177);
            this.button_Add_Foto.Name = "button_Add_Foto";
            this.button_Add_Foto.Size = new System.Drawing.Size(147, 23);
            this.button_Add_Foto.TabIndex = 9;
            this.button_Add_Foto.Text = "Adicionar Foto";
            this.button_Add_Foto.UseVisualStyleBackColor = true;
            this.button_Add_Foto.Click += new System.EventHandler(this.button_Add_Foto_Click);
            // 
            // radioButtonMasc
            // 
            this.radioButtonMasc.AutoSize = true;
            this.radioButtonMasc.Checked = true;
            this.radioButtonMasc.Location = new System.Drawing.Point(12, 103);
            this.radioButtonMasc.Name = "radioButtonMasc";
            this.radioButtonMasc.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasc.TabIndex = 4;
            this.radioButtonMasc.TabStop = true;
            this.radioButtonMasc.Text = "Masculino";
            this.radioButtonMasc.UseVisualStyleBackColor = true;
            this.radioButtonMasc.CheckedChanged += new System.EventHandler(this.Foto_sexo);
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Location = new System.Drawing.Point(91, 103);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFem.TabIndex = 5;
            this.radioButtonFem.Text = "Feminino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Sexo";
            // 
            // labelErroSenha
            // 
            this.labelErroSenha.AutoSize = true;
            this.labelErroSenha.ForeColor = System.Drawing.Color.Red;
            this.labelErroSenha.Location = new System.Drawing.Point(9, 210);
            this.labelErroSenha.Name = "labelErroSenha";
            this.labelErroSenha.Size = new System.Drawing.Size(131, 13);
            this.labelErroSenha.TabIndex = 91;
            this.labelErroSenha.Tag = "ERRO_SENHA";
            this.labelErroSenha.Text = "As senhas não coincidem!";
            this.labelErroSenha.Visible = false;
            // 
            // labelErroCPF
            // 
            this.labelErroCPF.AutoSize = true;
            this.labelErroCPF.ForeColor = System.Drawing.Color.Red;
            this.labelErroCPF.Location = new System.Drawing.Point(108, 87);
            this.labelErroCPF.Name = "labelErroCPF";
            this.labelErroCPF.Size = new System.Drawing.Size(69, 13);
            this.labelErroCPF.TabIndex = 91;
            this.labelErroCPF.Tag = "ERRO_SENHA";
            this.labelErroCPF.Text = "CPF inválido!";
            this.labelErroCPF.Visible = false;
            // 
            // labelErro_Login
            // 
            this.labelErro_Login.AutoSize = true;
            this.labelErro_Login.ForeColor = System.Drawing.Color.Red;
            this.labelErro_Login.Location = new System.Drawing.Point(51, 123);
            this.labelErro_Login.Name = "labelErro_Login";
            this.labelErro_Login.Size = new System.Drawing.Size(92, 13);
            this.labelErro_Login.TabIndex = 92;
            this.labelErro_Login.Text = "Login já existente!";
            this.labelErro_Login.Visible = false;
            // 
            // Form_Novo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 241);
            this.Controls.Add(this.labelErro_Login);
            this.Controls.Add(this.labelErroCPF);
            this.Controls.Add(this.labelErroSenha);
            this.Controls.Add(this.radioButtonMasc);
            this.Controls.Add(this.radioButtonFem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox_Foto);
            this.Controls.Add(this.button_Add_Foto);
            this.Controls.Add(this.maskedTextBoxDataAdmissao);
            this.Controls.Add(this.textBoxConfirmar_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxRg);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_Novo_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            //this.Load += new System.EventHandler(this.Form_Novo_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox_Foto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolTip toolTipInformações;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox textBoxRg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxConfirmar_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataAdmissao;
        private System.Windows.Forms.GroupBox groupBox_Foto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button button_Add_Foto;
        private System.Windows.Forms.RadioButton radioButtonMasc;
        private System.Windows.Forms.RadioButton radioButtonFem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelErroSenha;
        private System.Windows.Forms.Label labelErroCPF;
        private System.Windows.Forms.Label labelErro_Login;
    }
}