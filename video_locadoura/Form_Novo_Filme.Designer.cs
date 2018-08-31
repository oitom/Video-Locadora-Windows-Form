namespace video_locadora
{
    partial class Form_Novo_Filme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Novo_Filme));
            this.tabControlCadastroFilme = new System.Windows.Forms.TabControl();
            this.tabPageFilme = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAnoLancamento = new System.Windows.Forms.TextBox();
            this.comboBoxQuantidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClassificacao_Indicativa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNovoGenero = new System.Windows.Forms.Button();
            this.comboBoxCatalagoPreco = new System.Windows.Forms.ComboBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label1Codigo = new System.Windows.Forms.Label();
            this.tabPageOpcionais = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxCapa = new System.Windows.Forms.PictureBox();
            this.buttonAddCapa = new System.Windows.Forms.Button();
            this.textBoxProdutora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIdiomas_4 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdiomas_3 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdiomas_2 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdiomas_1 = new System.Windows.Forms.ComboBox();
            this.richTextBoxSinopse = new System.Windows.Forms.RichTextBox();
            this.labelSinopse = new System.Windows.Forms.Label();
            this.textBoxDiretor = new System.Windows.Forms.TextBox();
            this.labelIdiomas = new System.Windows.Forms.Label();
            this.labelDiretor = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlCadastroFilme.SuspendLayout();
            this.tabPageFilme.SuspendLayout();
            this.tabPageOpcionais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCadastroFilme
            // 
            this.tabControlCadastroFilme.Controls.Add(this.tabPageFilme);
            this.tabControlCadastroFilme.Controls.Add(this.tabPageOpcionais);
            this.tabControlCadastroFilme.Location = new System.Drawing.Point(12, 12);
            this.tabControlCadastroFilme.Name = "tabControlCadastroFilme";
            this.tabControlCadastroFilme.SelectedIndex = 0;
            this.tabControlCadastroFilme.Size = new System.Drawing.Size(604, 348);
            this.tabControlCadastroFilme.TabIndex = 0;
            // 
            // tabPageFilme
            // 
            this.tabPageFilme.Controls.Add(this.label6);
            this.tabPageFilme.Controls.Add(this.textBoxAnoLancamento);
            this.tabPageFilme.Controls.Add(this.comboBoxQuantidade);
            this.tabPageFilme.Controls.Add(this.label4);
            this.tabPageFilme.Controls.Add(this.textBoxClassificacao_Indicativa);
            this.tabPageFilme.Controls.Add(this.label3);
            this.tabPageFilme.Controls.Add(this.textBoxTitulo);
            this.tabPageFilme.Controls.Add(this.label1);
            this.tabPageFilme.Controls.Add(this.label5);
            this.tabPageFilme.Controls.Add(this.buttonNovoGenero);
            this.tabPageFilme.Controls.Add(this.comboBoxCatalagoPreco);
            this.tabPageFilme.Controls.Add(this.comboBoxGenero);
            this.tabPageFilme.Controls.Add(this.comboBoxTipo);
            this.tabPageFilme.Controls.Add(this.textBoxcodigo);
            this.tabPageFilme.Controls.Add(this.label7);
            this.tabPageFilme.Controls.Add(this.labelGenero);
            this.tabPageFilme.Controls.Add(this.labelTipo);
            this.tabPageFilme.Controls.Add(this.label1Codigo);
            this.tabPageFilme.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilme.Name = "tabPageFilme";
            this.tabPageFilme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilme.Size = new System.Drawing.Size(596, 322);
            this.tabPageFilme.TabIndex = 0;
            this.tabPageFilme.Text = "Filme";
            this.tabPageFilme.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "anos";
            // 
            // textBoxAnoLancamento
            // 
            this.textBoxAnoLancamento.Location = new System.Drawing.Point(225, 150);
            this.textBoxAnoLancamento.Name = "textBoxAnoLancamento";
            this.textBoxAnoLancamento.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnoLancamento.TabIndex = 5;
            // 
            // comboBoxQuantidade
            // 
            this.comboBoxQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuantidade.FormattingEnabled = true;
            this.comboBoxQuantidade.Items.AddRange(new object[] {
            "Selecione",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuantidade.Location = new System.Drawing.Point(95, 190);
            this.comboBoxQuantidade.Name = "comboBoxQuantidade";
            this.comboBoxQuantidade.Size = new System.Drawing.Size(93, 21);
            this.comboBoxQuantidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade adquirida";
            // 
            // textBoxClassificacao_Indicativa
            // 
            this.textBoxClassificacao_Indicativa.Location = new System.Drawing.Point(6, 190);
            this.textBoxClassificacao_Indicativa.MaxLength = 30;
            this.textBoxClassificacao_Indicativa.Name = "textBoxClassificacao_Indicativa";
            this.textBoxClassificacao_Indicativa.Size = new System.Drawing.Size(28, 20);
            this.textBoxClassificacao_Indicativa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Class. indicativa";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(9, 68);
            this.textBoxTitulo.MaxLength = 60;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(429, 20);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ano de Lançamento";
            // 
            // buttonNovoGenero
            // 
            this.buttonNovoGenero.Location = new System.Drawing.Point(444, 110);
            this.buttonNovoGenero.Name = "buttonNovoGenero";
            this.buttonNovoGenero.Size = new System.Drawing.Size(55, 20);
            this.buttonNovoGenero.TabIndex = 3;
            this.buttonNovoGenero.Text = "Novo";
            this.buttonNovoGenero.UseVisualStyleBackColor = true;
            this.buttonNovoGenero.Click += new System.EventHandler(this.buttonNovoGenero_Click);
            // 
            // comboBoxCatalagoPreco
            // 
            this.comboBoxCatalagoPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCatalagoPreco.FormattingEnabled = true;
            this.comboBoxCatalagoPreco.Location = new System.Drawing.Point(6, 149);
            this.comboBoxCatalagoPreco.Name = "comboBoxCatalagoPreco";
            this.comboBoxCatalagoPreco.Size = new System.Drawing.Size(210, 21);
            this.comboBoxCatalagoPreco.TabIndex = 4;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(222, 109);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(216, 21);
            this.comboBoxGenero.TabIndex = 2;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(6, 109);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(210, 21);
            this.comboBoxTipo.TabIndex = 1;
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(6, 29);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.ReadOnly = true;
            this.textBoxcodigo.Size = new System.Drawing.Size(121, 20);
            this.textBoxcodigo.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Catalago de Preço";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(219, 91);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 0;
            this.labelGenero.Text = "Gênero";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(6, 91);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo";
            // 
            // label1Codigo
            // 
            this.label1Codigo.AutoSize = true;
            this.label1Codigo.Location = new System.Drawing.Point(6, 13);
            this.label1Codigo.Name = "label1Codigo";
            this.label1Codigo.Size = new System.Drawing.Size(40, 13);
            this.label1Codigo.TabIndex = 0;
            this.label1Codigo.Text = "Código";
            // 
            // tabPageOpcionais
            // 
            this.tabPageOpcionais.Controls.Add(this.groupBox1);
            this.tabPageOpcionais.Controls.Add(this.buttonAddCapa);
            this.tabPageOpcionais.Controls.Add(this.textBoxProdutora);
            this.tabPageOpcionais.Controls.Add(this.label2);
            this.tabPageOpcionais.Controls.Add(this.comboBoxIdiomas_4);
            this.tabPageOpcionais.Controls.Add(this.comboBoxIdiomas_3);
            this.tabPageOpcionais.Controls.Add(this.comboBoxIdiomas_2);
            this.tabPageOpcionais.Controls.Add(this.comboBoxIdiomas_1);
            this.tabPageOpcionais.Controls.Add(this.richTextBoxSinopse);
            this.tabPageOpcionais.Controls.Add(this.labelSinopse);
            this.tabPageOpcionais.Controls.Add(this.textBoxDiretor);
            this.tabPageOpcionais.Controls.Add(this.labelIdiomas);
            this.tabPageOpcionais.Controls.Add(this.labelDiretor);
            this.tabPageOpcionais.Location = new System.Drawing.Point(4, 22);
            this.tabPageOpcionais.Name = "tabPageOpcionais";
            this.tabPageOpcionais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOpcionais.Size = new System.Drawing.Size(596, 322);
            this.tabPageOpcionais.TabIndex = 1;
            this.tabPageOpcionais.Text = "Dados Opcionais";
            this.tabPageOpcionais.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxCapa);
            this.groupBox1.Location = new System.Drawing.Point(222, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capa";
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCapa.Image")));
            this.pictureBoxCapa.Location = new System.Drawing.Point(6, 16);
            this.pictureBoxCapa.Name = "pictureBoxCapa";
            this.pictureBoxCapa.Size = new System.Drawing.Size(356, 210);
            this.pictureBoxCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCapa.TabIndex = 9;
            this.pictureBoxCapa.TabStop = false;
            // 
            // buttonAddCapa
            // 
            this.buttonAddCapa.Location = new System.Drawing.Point(222, 283);
            this.buttonAddCapa.Name = "buttonAddCapa";
            this.buttonAddCapa.Size = new System.Drawing.Size(368, 33);
            this.buttonAddCapa.TabIndex = 8;
            this.buttonAddCapa.Text = "Obter capa de um arquivo";
            this.buttonAddCapa.UseVisualStyleBackColor = true;
            this.buttonAddCapa.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProdutora
            // 
            this.textBoxProdutora.Location = new System.Drawing.Point(293, 19);
            this.textBoxProdutora.MaxLength = 30;
            this.textBoxProdutora.Name = "textBoxProdutora";
            this.textBoxProdutora.Size = new System.Drawing.Size(300, 20);
            this.textBoxProdutora.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtora";
            // 
            // comboBoxIdiomas_4
            // 
            this.comboBoxIdiomas_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomas_4.Enabled = false;
            this.comboBoxIdiomas_4.FormattingEnabled = true;
            this.comboBoxIdiomas_4.Location = new System.Drawing.Point(6, 140);
            this.comboBoxIdiomas_4.Name = "comboBoxIdiomas_4";
            this.comboBoxIdiomas_4.Size = new System.Drawing.Size(210, 21);
            this.comboBoxIdiomas_4.TabIndex = 6;
            // 
            // comboBoxIdiomas_3
            // 
            this.comboBoxIdiomas_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomas_3.Enabled = false;
            this.comboBoxIdiomas_3.FormattingEnabled = true;
            this.comboBoxIdiomas_3.Location = new System.Drawing.Point(6, 113);
            this.comboBoxIdiomas_3.Name = "comboBoxIdiomas_3";
            this.comboBoxIdiomas_3.Size = new System.Drawing.Size(210, 21);
            this.comboBoxIdiomas_3.TabIndex = 5;
            this.comboBoxIdiomas_3.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomas_3_SelectedIndexChanged);
            // 
            // comboBoxIdiomas_2
            // 
            this.comboBoxIdiomas_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomas_2.Enabled = false;
            this.comboBoxIdiomas_2.FormattingEnabled = true;
            this.comboBoxIdiomas_2.ItemHeight = 13;
            this.comboBoxIdiomas_2.Location = new System.Drawing.Point(6, 86);
            this.comboBoxIdiomas_2.Name = "comboBoxIdiomas_2";
            this.comboBoxIdiomas_2.Size = new System.Drawing.Size(210, 21);
            this.comboBoxIdiomas_2.TabIndex = 4;
            this.comboBoxIdiomas_2.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomas_2_SelectedIndexChanged);
            // 
            // comboBoxIdiomas_1
            // 
            this.comboBoxIdiomas_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomas_1.FormattingEnabled = true;
            this.comboBoxIdiomas_1.Location = new System.Drawing.Point(6, 59);
            this.comboBoxIdiomas_1.Name = "comboBoxIdiomas_1";
            this.comboBoxIdiomas_1.Size = new System.Drawing.Size(210, 21);
            this.comboBoxIdiomas_1.TabIndex = 3;
            this.comboBoxIdiomas_1.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomas_1_SelectedIndexChanged);
            // 
            // richTextBoxSinopse
            // 
            this.richTextBoxSinopse.Location = new System.Drawing.Point(9, 180);
            this.richTextBoxSinopse.MaxLength = 500;
            this.richTextBoxSinopse.Name = "richTextBoxSinopse";
            this.richTextBoxSinopse.Size = new System.Drawing.Size(207, 136);
            this.richTextBoxSinopse.TabIndex = 7;
            this.richTextBoxSinopse.Text = global::video_locadora.Properties.Resources.Resource;
            // 
            // labelSinopse
            // 
            this.labelSinopse.AutoSize = true;
            this.labelSinopse.Location = new System.Drawing.Point(6, 164);
            this.labelSinopse.Name = "labelSinopse";
            this.labelSinopse.Size = new System.Drawing.Size(45, 13);
            this.labelSinopse.TabIndex = 2;
            this.labelSinopse.Text = "Sinopse";
            // 
            // textBoxDiretor
            // 
            this.textBoxDiretor.Location = new System.Drawing.Point(6, 19);
            this.textBoxDiretor.MaxLength = 30;
            this.textBoxDiretor.Name = "textBoxDiretor";
            this.textBoxDiretor.Size = new System.Drawing.Size(281, 20);
            this.textBoxDiretor.TabIndex = 0;
            // 
            // labelIdiomas
            // 
            this.labelIdiomas.AutoSize = true;
            this.labelIdiomas.Location = new System.Drawing.Point(6, 43);
            this.labelIdiomas.Name = "labelIdiomas";
            this.labelIdiomas.Size = new System.Drawing.Size(43, 13);
            this.labelIdiomas.TabIndex = 0;
            this.labelIdiomas.Text = "Idiomas";
            // 
            // labelDiretor
            // 
            this.labelDiretor.AutoSize = true;
            this.labelDiretor.Location = new System.Drawing.Point(6, 3);
            this.labelDiretor.Name = "labelDiretor";
            this.labelDiretor.Size = new System.Drawing.Size(38, 13);
            this.labelDiretor.TabIndex = 0;
            this.labelDiretor.Text = "Diretor";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(379, 366);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "&Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.Limpar_Form);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(460, 366);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(541, 366);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 21;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // Form_Novo_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 401);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.tabControlCadastroFilme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Novo_Filme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes";
            this.Load += new System.EventHandler(this.Form_Novo_Filme_Load);
            this.tabControlCadastroFilme.ResumeLayout(false);
            this.tabPageFilme.ResumeLayout(false);
            this.tabPageFilme.PerformLayout();
            this.tabPageOpcionais.ResumeLayout(false);
            this.tabPageOpcionais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCadastroFilme;
        private System.Windows.Forms.TabPage tabPageFilme;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox textBoxcodigo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label1Codigo;
        private System.Windows.Forms.TabPage tabPageOpcionais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNovoGenero;
        private System.Windows.Forms.ComboBox comboBoxCatalagoPreco;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox comboBoxIdiomas_2;
        private System.Windows.Forms.ComboBox comboBoxIdiomas_1;
        private System.Windows.Forms.RichTextBox richTextBoxSinopse;
        private System.Windows.Forms.Label labelSinopse;
        private System.Windows.Forms.TextBox textBoxDiretor;
        private System.Windows.Forms.Label labelIdiomas;
        private System.Windows.Forms.Label labelDiretor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCapa;
        private System.Windows.Forms.PictureBox pictureBoxCapa;
        private System.Windows.Forms.TextBox textBoxProdutora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIdiomas_4;
        private System.Windows.Forms.ComboBox comboBoxIdiomas_3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxClassificacao_Indicativa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox comboBoxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAnoLancamento;
        private System.Windows.Forms.Label label6;
    }
}