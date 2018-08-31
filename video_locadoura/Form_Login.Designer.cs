namespace video_locadora
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.buttonAcessar = new System.Windows.Forms.Button();
            this.pictureBoxImgLogin = new System.Windows.Forms.PictureBox();
            this.toolTipInformações = new System.Windows.Forms.ToolTip(this.components);
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelErroConectar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAcessar
            // 
            this.buttonAcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcessar.Location = new System.Drawing.Point(209, 90);
            this.buttonAcessar.Name = "buttonAcessar";
            this.buttonAcessar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcessar.TabIndex = 2;
            this.buttonAcessar.Text = "&Acessar";
            this.buttonAcessar.UseVisualStyleBackColor = true;
            this.buttonAcessar.Click += new System.EventHandler(this.Acessar_Click);
            // 
            // pictureBoxImgLogin
            // 
            this.pictureBoxImgLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImgLogin.Image")));
            this.pictureBoxImgLogin.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImgLogin.Name = "pictureBoxImgLogin";
            this.pictureBoxImgLogin.Size = new System.Drawing.Size(68, 72);
            this.pictureBoxImgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImgLogin.TabIndex = 20;
            this.pictureBoxImgLogin.TabStop = false;
            // 
            // toolTipInformações
            // 
            this.toolTipInformações.IsBalloon = true;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(86, 48);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 19;
            this.labelSenha.Text = "Senha";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(86, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Login";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(86, 64);
            this.textBoxSenha.MaxLength = 40;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(198, 20);
            this.textBoxSenha.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(86, 25);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(198, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(128, 90);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // labelErroConectar
            // 
            this.labelErroConectar.AutoSize = true;
            this.labelErroConectar.BackColor = System.Drawing.Color.Transparent;
            this.labelErroConectar.ForeColor = System.Drawing.Color.Red;
            this.labelErroConectar.Location = new System.Drawing.Point(0, 95);
            this.labelErroConectar.Name = "labelErroConectar";
            this.labelErroConectar.Size = new System.Drawing.Size(124, 13);
            this.labelErroConectar.TabIndex = 21;
            this.labelErroConectar.Text = "Login ou senha inválidos";
            this.labelErroConectar.Visible = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.labelErroConectar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAcessar);
            this.Controls.Add(this.pictureBoxImgLogin);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcessar;
        private System.Windows.Forms.PictureBox pictureBoxImgLogin;
        private System.Windows.Forms.ToolTip toolTipInformações;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label labelErroConectar;
    }
}