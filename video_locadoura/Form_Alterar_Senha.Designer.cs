namespace video_locadora
{
    partial class Form_Alterar_Senha
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Senha_Atual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nova_Senha = new System.Windows.Forms.TextBox();
            this.label_Confimar_Senha = new System.Windows.Forms.Label();
            this.textBox_Confirmar_senha = new System.Windows.Forms.TextBox();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.labelErroSenha_Atual = new System.Windows.Forms.Label();
            this.labelErroSenha = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha atual";
            // 
            // textBox_Senha_Atual
            // 
            this.textBox_Senha_Atual.Location = new System.Drawing.Point(12, 25);
            this.textBox_Senha_Atual.Name = "textBox_Senha_Atual";
            this.textBox_Senha_Atual.PasswordChar = '*';
            this.textBox_Senha_Atual.Size = new System.Drawing.Size(217, 20);
            this.textBox_Senha_Atual.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nova senha";
            // 
            // textBox_Nova_Senha
            // 
            this.textBox_Nova_Senha.Location = new System.Drawing.Point(12, 64);
            this.textBox_Nova_Senha.Name = "textBox_Nova_Senha";
            this.textBox_Nova_Senha.PasswordChar = '*';
            this.textBox_Nova_Senha.Size = new System.Drawing.Size(220, 20);
            this.textBox_Nova_Senha.TabIndex = 1;
            // 
            // label_Confimar_Senha
            // 
            this.label_Confimar_Senha.AutoSize = true;
            this.label_Confimar_Senha.Location = new System.Drawing.Point(12, 87);
            this.label_Confimar_Senha.Name = "label_Confimar_Senha";
            this.label_Confimar_Senha.Size = new System.Drawing.Size(83, 13);
            this.label_Confimar_Senha.TabIndex = 0;
            this.label_Confimar_Senha.Text = "Confirmar senha";
            // 
            // textBox_Confirmar_senha
            // 
            this.textBox_Confirmar_senha.Location = new System.Drawing.Point(12, 103);
            this.textBox_Confirmar_senha.Name = "textBox_Confirmar_senha";
            this.textBox_Confirmar_senha.PasswordChar = '*';
            this.textBox_Confirmar_senha.Size = new System.Drawing.Size(220, 20);
            this.textBox_Confirmar_senha.TabIndex = 2;
            // 
            // button_Salvar
            // 
            this.button_Salvar.Location = new System.Drawing.Point(157, 129);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar.TabIndex = 3;
            this.button_Salvar.Text = "&Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // labelErroSenha_Atual
            // 
            this.labelErroSenha_Atual.AutoSize = true;
            this.labelErroSenha_Atual.ForeColor = System.Drawing.Color.Red;
            this.labelErroSenha_Atual.Location = new System.Drawing.Point(129, 9);
            this.labelErroSenha_Atual.Name = "labelErroSenha_Atual";
            this.labelErroSenha_Atual.Size = new System.Drawing.Size(103, 13);
            this.labelErroSenha_Atual.TabIndex = 3;
            this.labelErroSenha_Atual.Text = "Senha atual inválida";
            this.labelErroSenha_Atual.Visible = false;
            // 
            // labelErroSenha
            // 
            this.labelErroSenha.AutoSize = true;
            this.labelErroSenha.ForeColor = System.Drawing.Color.Red;
            this.labelErroSenha.Location = new System.Drawing.Point(101, 87);
            this.labelErroSenha.Name = "labelErroSenha";
            this.labelErroSenha.Size = new System.Drawing.Size(131, 13);
            this.labelErroSenha.TabIndex = 92;
            this.labelErroSenha.Tag = "ERRO_SENHA";
            this.labelErroSenha.Text = "As senhas não coincidem!";
            this.labelErroSenha.Visible = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(76, 129);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 93;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // Form_Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 164);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelErroSenha);
            this.Controls.Add(this.labelErroSenha_Atual);
            this.Controls.Add(this.button_Salvar);
            this.Controls.Add(this.textBox_Confirmar_senha);
            this.Controls.Add(this.label_Confimar_Senha);
            this.Controls.Add(this.textBox_Nova_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Senha_Atual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Alterar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Senha_Atual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nova_Senha;
        private System.Windows.Forms.Label label_Confimar_Senha;
        private System.Windows.Forms.TextBox textBox_Confirmar_senha;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Label labelErroSenha_Atual;
        private System.Windows.Forms.Label labelErroSenha;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ErrorProvider error;
    }
}