namespace video_locadora
{
    partial class Form_Visualizar_Filmes
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
            this.pictureBox_Capa_Filme = new System.Windows.Forms.PictureBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.textBox_Codigo = new System.Windows.Forms.TextBox();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.textBox_Tipo_Midia = new System.Windows.Forms.TextBox();
            this.groupBox_Dados_Filme = new System.Windows.Forms.GroupBox();
            this.groupBox_Idiomas = new System.Windows.Forms.GroupBox();
            this.textBox_Idioma4 = new System.Windows.Forms.TextBox();
            this.textBox_Idioma2 = new System.Windows.Forms.TextBox();
            this.textBox_Idioma3 = new System.Windows.Forms.TextBox();
            this.textBox_Idioma1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Sinopse = new System.Windows.Forms.TextBox();
            this.textBox_Produtora = new System.Windows.Forms.TextBox();
            this.label_Produtora = new System.Windows.Forms.Label();
            this.textBox_Diretor = new System.Windows.Forms.TextBox();
            this.label_Diretor = new System.Windows.Forms.Label();
            this.textBox_Classificacao = new System.Windows.Forms.TextBox();
            this.label_Classificacao = new System.Windows.Forms.Label();
            this.textBox_Genero = new System.Windows.Forms.TextBox();
            this.textBox_Ano_Lanc = new System.Windows.Forms.TextBox();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Ano_Lanc = new System.Windows.Forms.Label();
            this.label_Categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Capa_Filme)).BeginInit();
            this.groupBox_Dados_Filme.SuspendLayout();
            this.groupBox_Idiomas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Capa_Filme
            // 
            this.pictureBox_Capa_Filme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Capa_Filme.Image = global::video_locadora.Properties.Resources.semfoto;
            this.pictureBox_Capa_Filme.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Capa_Filme.Name = "pictureBox_Capa_Filme";
            this.pictureBox_Capa_Filme.Size = new System.Drawing.Size(823, 564);
            this.pictureBox_Capa_Filme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Capa_Filme.TabIndex = 0;
            this.pictureBox_Capa_Filme.TabStop = false;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(6, 103);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(34, 13);
            this.labelTipo.TabIndex = 102;
            this.labelTipo.Text = "Tipo :";
            // 
            // label_Codigo
            // 
            this.label_Codigo.AutoSize = true;
            this.label_Codigo.Location = new System.Drawing.Point(6, 25);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(46, 13);
            this.label_Codigo.TabIndex = 103;
            this.label_Codigo.Text = "Código :";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(6, 64);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(41, 13);
            this.label_Titulo.TabIndex = 105;
            this.label_Titulo.Text = "Título :";
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Codigo.Location = new System.Drawing.Point(6, 41);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.ReadOnly = true;
            this.textBox_Codigo.Size = new System.Drawing.Size(90, 20);
            this.textBox_Codigo.TabIndex = 106;
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Titulo.Location = new System.Drawing.Point(6, 80);
            this.textBox_Titulo.MaxLength = 60;
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.ReadOnly = true;
            this.textBox_Titulo.Size = new System.Drawing.Size(348, 20);
            this.textBox_Titulo.TabIndex = 104;
            // 
            // textBox_Tipo_Midia
            // 
            this.textBox_Tipo_Midia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Tipo_Midia.Location = new System.Drawing.Point(6, 119);
            this.textBox_Tipo_Midia.MaxLength = 60;
            this.textBox_Tipo_Midia.Name = "textBox_Tipo_Midia";
            this.textBox_Tipo_Midia.ReadOnly = true;
            this.textBox_Tipo_Midia.Size = new System.Drawing.Size(162, 20);
            this.textBox_Tipo_Midia.TabIndex = 104;
            // 
            // groupBox_Dados_Filme
            // 
            this.groupBox_Dados_Filme.Controls.Add(this.groupBox_Idiomas);
            this.groupBox_Dados_Filme.Controls.Add(this.groupBox1);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Produtora);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Produtora);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Diretor);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Diretor);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Classificacao);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Classificacao);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Genero);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Ano_Lanc);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Categoria);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Tipo_Midia);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Titulo);
            this.groupBox_Dados_Filme.Controls.Add(this.textBox_Codigo);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Titulo);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Codigo);
            this.groupBox_Dados_Filme.Controls.Add(this.labelTipo);
            this.groupBox_Dados_Filme.Controls.Add(this.label1);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Ano_Lanc);
            this.groupBox_Dados_Filme.Controls.Add(this.label_Categoria);
            this.groupBox_Dados_Filme.Location = new System.Drawing.Point(841, 12);
            this.groupBox_Dados_Filme.Name = "groupBox_Dados_Filme";
            this.groupBox_Dados_Filme.Size = new System.Drawing.Size(360, 564);
            this.groupBox_Dados_Filme.TabIndex = 1;
            this.groupBox_Dados_Filme.TabStop = false;
            this.groupBox_Dados_Filme.Text = "Dados do Filme";
            // 
            // groupBox_Idiomas
            // 
            this.groupBox_Idiomas.Controls.Add(this.textBox_Idioma4);
            this.groupBox_Idiomas.Controls.Add(this.textBox_Idioma2);
            this.groupBox_Idiomas.Controls.Add(this.textBox_Idioma3);
            this.groupBox_Idiomas.Controls.Add(this.textBox_Idioma1);
            this.groupBox_Idiomas.Location = new System.Drawing.Point(9, 275);
            this.groupBox_Idiomas.Name = "groupBox_Idiomas";
            this.groupBox_Idiomas.Size = new System.Drawing.Size(340, 98);
            this.groupBox_Idiomas.TabIndex = 123;
            this.groupBox_Idiomas.TabStop = false;
            this.groupBox_Idiomas.Text = "Idiomas";
            // 
            // textBox_Idioma4
            // 
            this.textBox_Idioma4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Idioma4.Location = new System.Drawing.Point(173, 68);
            this.textBox_Idioma4.MaxLength = 60;
            this.textBox_Idioma4.Name = "textBox_Idioma4";
            this.textBox_Idioma4.ReadOnly = true;
            this.textBox_Idioma4.Size = new System.Drawing.Size(159, 20);
            this.textBox_Idioma4.TabIndex = 122;
            // 
            // textBox_Idioma2
            // 
            this.textBox_Idioma2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Idioma2.Location = new System.Drawing.Point(173, 29);
            this.textBox_Idioma2.MaxLength = 60;
            this.textBox_Idioma2.Name = "textBox_Idioma2";
            this.textBox_Idioma2.ReadOnly = true;
            this.textBox_Idioma2.Size = new System.Drawing.Size(159, 20);
            this.textBox_Idioma2.TabIndex = 114;
            // 
            // textBox_Idioma3
            // 
            this.textBox_Idioma3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Idioma3.Location = new System.Drawing.Point(8, 68);
            this.textBox_Idioma3.MaxLength = 60;
            this.textBox_Idioma3.Name = "textBox_Idioma3";
            this.textBox_Idioma3.ReadOnly = true;
            this.textBox_Idioma3.Size = new System.Drawing.Size(159, 20);
            this.textBox_Idioma3.TabIndex = 118;
            // 
            // textBox_Idioma1
            // 
            this.textBox_Idioma1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Idioma1.Location = new System.Drawing.Point(8, 29);
            this.textBox_Idioma1.MaxLength = 60;
            this.textBox_Idioma1.Name = "textBox_Idioma1";
            this.textBox_Idioma1.ReadOnly = true;
            this.textBox_Idioma1.Size = new System.Drawing.Size(159, 20);
            this.textBox_Idioma1.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Sinopse);
            this.groupBox1.Location = new System.Drawing.Point(6, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 177);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinopse";
            // 
            // textBox_Sinopse
            // 
            this.textBox_Sinopse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Sinopse.Location = new System.Drawing.Point(6, 19);
            this.textBox_Sinopse.MaxLength = 60;
            this.textBox_Sinopse.Multiline = true;
            this.textBox_Sinopse.Name = "textBox_Sinopse";
            this.textBox_Sinopse.ReadOnly = true;
            this.textBox_Sinopse.Size = new System.Drawing.Size(334, 152);
            this.textBox_Sinopse.TabIndex = 121;
            // 
            // textBox_Produtora
            // 
            this.textBox_Produtora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Produtora.Location = new System.Drawing.Point(6, 236);
            this.textBox_Produtora.MaxLength = 60;
            this.textBox_Produtora.Name = "textBox_Produtora";
            this.textBox_Produtora.ReadOnly = true;
            this.textBox_Produtora.Size = new System.Drawing.Size(162, 20);
            this.textBox_Produtora.TabIndex = 112;
            // 
            // label_Produtora
            // 
            this.label_Produtora.AutoSize = true;
            this.label_Produtora.Location = new System.Drawing.Point(6, 220);
            this.label_Produtora.Name = "label_Produtora";
            this.label_Produtora.Size = new System.Drawing.Size(59, 13);
            this.label_Produtora.TabIndex = 111;
            this.label_Produtora.Text = "Produtora :";
            // 
            // textBox_Diretor
            // 
            this.textBox_Diretor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Diretor.Location = new System.Drawing.Point(174, 197);
            this.textBox_Diretor.MaxLength = 60;
            this.textBox_Diretor.Name = "textBox_Diretor";
            this.textBox_Diretor.ReadOnly = true;
            this.textBox_Diretor.Size = new System.Drawing.Size(180, 20);
            this.textBox_Diretor.TabIndex = 110;
            // 
            // label_Diretor
            // 
            this.label_Diretor.AutoSize = true;
            this.label_Diretor.Location = new System.Drawing.Point(171, 181);
            this.label_Diretor.Name = "label_Diretor";
            this.label_Diretor.Size = new System.Drawing.Size(44, 13);
            this.label_Diretor.TabIndex = 109;
            this.label_Diretor.Text = "Diretor :";
            // 
            // textBox_Classificacao
            // 
            this.textBox_Classificacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Classificacao.Location = new System.Drawing.Point(6, 197);
            this.textBox_Classificacao.MaxLength = 60;
            this.textBox_Classificacao.Name = "textBox_Classificacao";
            this.textBox_Classificacao.ReadOnly = true;
            this.textBox_Classificacao.Size = new System.Drawing.Size(162, 20);
            this.textBox_Classificacao.TabIndex = 108;
            // 
            // label_Classificacao
            // 
            this.label_Classificacao.AutoSize = true;
            this.label_Classificacao.Location = new System.Drawing.Point(9, 181);
            this.label_Classificacao.Name = "label_Classificacao";
            this.label_Classificacao.Size = new System.Drawing.Size(75, 13);
            this.label_Classificacao.TabIndex = 107;
            this.label_Classificacao.Text = "Classificação :";
            // 
            // textBox_Genero
            // 
            this.textBox_Genero.Location = new System.Drawing.Point(174, 119);
            this.textBox_Genero.MaxLength = 60;
            this.textBox_Genero.Name = "textBox_Genero";
            this.textBox_Genero.Size = new System.Drawing.Size(180, 20);
            this.textBox_Genero.TabIndex = 104;
            // 
            // textBox_Ano_Lanc
            // 
            this.textBox_Ano_Lanc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Ano_Lanc.Location = new System.Drawing.Point(174, 158);
            this.textBox_Ano_Lanc.MaxLength = 60;
            this.textBox_Ano_Lanc.Name = "textBox_Ano_Lanc";
            this.textBox_Ano_Lanc.ReadOnly = true;
            this.textBox_Ano_Lanc.Size = new System.Drawing.Size(180, 20);
            this.textBox_Ano_Lanc.TabIndex = 104;
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Categoria.Location = new System.Drawing.Point(6, 158);
            this.textBox_Categoria.MaxLength = 60;
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.ReadOnly = true;
            this.textBox_Categoria.Size = new System.Drawing.Size(162, 20);
            this.textBox_Categoria.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Gênero";
            // 
            // label_Ano_Lanc
            // 
            this.label_Ano_Lanc.AutoSize = true;
            this.label_Ano_Lanc.Location = new System.Drawing.Point(171, 142);
            this.label_Ano_Lanc.Name = "label_Ano_Lanc";
            this.label_Ano_Lanc.Size = new System.Drawing.Size(72, 13);
            this.label_Ano_Lanc.TabIndex = 101;
            this.label_Ano_Lanc.Text = "Lançamento :";
            // 
            // label_Categoria
            // 
            this.label_Categoria.AutoSize = true;
            this.label_Categoria.Location = new System.Drawing.Point(6, 142);
            this.label_Categoria.Name = "label_Categoria";
            this.label_Categoria.Size = new System.Drawing.Size(58, 13);
            this.label_Categoria.TabIndex = 101;
            this.label_Categoria.Text = "Categoria :";
            // 
            // Form_Visualizar_Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 588);
            this.Controls.Add(this.groupBox_Dados_Filme);
            this.Controls.Add(this.pictureBox_Capa_Filme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_Visualizar_Filmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filme";
            this.Load += new System.EventHandler(this.Form_Visualizar_Filmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Capa_Filme)).EndInit();
            this.groupBox_Dados_Filme.ResumeLayout(false);
            this.groupBox_Dados_Filme.PerformLayout();
            this.groupBox_Idiomas.ResumeLayout(false);
            this.groupBox_Idiomas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Capa_Filme;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label_Codigo;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TextBox textBox_Codigo;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.TextBox textBox_Tipo_Midia;
        private System.Windows.Forms.GroupBox groupBox_Dados_Filme;
        private System.Windows.Forms.TextBox textBox_Ano_Lanc;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.Label label_Ano_Lanc;
        private System.Windows.Forms.Label label_Categoria;
        private System.Windows.Forms.TextBox textBox_Genero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Idioma1;
        private System.Windows.Forms.TextBox textBox_Idioma2;
        private System.Windows.Forms.TextBox textBox_Produtora;
        private System.Windows.Forms.Label label_Produtora;
        private System.Windows.Forms.TextBox textBox_Diretor;
        private System.Windows.Forms.Label label_Diretor;
        private System.Windows.Forms.TextBox textBox_Classificacao;
        private System.Windows.Forms.Label label_Classificacao;
        private System.Windows.Forms.TextBox textBox_Idioma3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Sinopse;
        private System.Windows.Forms.GroupBox groupBox_Idiomas;
        private System.Windows.Forms.TextBox textBox_Idioma4;
    }
}