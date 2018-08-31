namespace video_locadora
{
    partial class Form_Loc_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Loc_Cliente));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nome_Filme = new System.Windows.Forms.TextBox();
            this.listView_Relacao_Filmes = new System.Windows.Forms.ListView();
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_classificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataDevolucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripRelacao_Filmes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCapaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Cod_Cli_Info = new System.Windows.Forms.Label();
            this.label_Cod_Cli = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Creditar = new System.Windows.Forms.CheckBox();
            this.button_Finalizar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBox_Total_Loc = new System.Windows.Forms.TextBox();
            this.textBox_Troco = new System.Windows.Forms.TextBox();
            this.textBox_Dinheiro = new System.Windows.Forms.TextBox();
            this.textBox_Cli_Saldo = new System.Windows.Forms.TextBox();
            this.textBox_Cli_Credito = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Dependente = new System.Windows.Forms.TextBox();
            this.textBox_Nome_CLi = new System.Windows.Forms.TextBox();
            this.textBox_Cliente_Desde = new System.Windows.Forms.TextBox();
            this.textBox_Ultima_Loc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Dependente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_Status_Info = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Cliente = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView_Filmes_Disponiveis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Filmes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxDevolver = new System.Windows.Forms.PictureBox();
            this.pictureBoxLimpar = new System.Windows.Forms.PictureBox();
            this.maskedTextBox_Cod_Filme = new System.Windows.Forms.MaskedTextBox();
            this.button_Consul_Fime = new System.Windows.Forms.Button();
            this.radioButton_Cod_Filme = new System.Windows.Forms.RadioButton();
            this.radioButton_Titulo_Filme = new System.Windows.Forms.RadioButton();
            this.contextMenuStripRelacao_Filmes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cliente)).BeginInit();
            this.contextMenuStrip_Filmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLimpar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-137, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-178, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // textBox_Nome_Filme
            // 
            this.textBox_Nome_Filme.Enabled = false;
            this.textBox_Nome_Filme.Location = new System.Drawing.Point(111, 35);
            this.textBox_Nome_Filme.Name = "textBox_Nome_Filme";
            this.textBox_Nome_Filme.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_Filme.TabIndex = 1;
            // 
            // listView_Relacao_Filmes
            // 
            this.listView_Relacao_Filmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_titulo,
            this.coluna_genero,
            this.coluna_classificacao,
            this.columnHeader8,
            this.coluna_categoria,
            this.coluna_Valor,
            this.columnHeaderDataDevolucao});
            this.listView_Relacao_Filmes.ContextMenuStrip = this.contextMenuStripRelacao_Filmes;
            this.listView_Relacao_Filmes.FullRowSelect = true;
            this.listView_Relacao_Filmes.GridLines = true;
            this.listView_Relacao_Filmes.Location = new System.Drawing.Point(12, 368);
            this.listView_Relacao_Filmes.Name = "listView_Relacao_Filmes";
            this.listView_Relacao_Filmes.Size = new System.Drawing.Size(810, 239);
            this.listView_Relacao_Filmes.TabIndex = 11;
            this.listView_Relacao_Filmes.UseCompatibleStateImageBehavior = false;
            this.listView_Relacao_Filmes.View = System.Windows.Forms.View.Details;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            this.coluna_codigo.Width = 79;
            // 
            // coluna_titulo
            // 
            this.coluna_titulo.Text = "Título";
            this.coluna_titulo.Width = 200;
            // 
            // coluna_genero
            // 
            this.coluna_genero.Text = "Gênero";
            this.coluna_genero.Width = 104;
            // 
            // coluna_classificacao
            // 
            this.coluna_classificacao.Text = "Classificação";
            this.coluna_classificacao.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Midia";
            // 
            // coluna_categoria
            // 
            this.coluna_categoria.Text = "Categoria";
            this.coluna_categoria.Width = 93;
            // 
            // coluna_Valor
            // 
            this.coluna_Valor.Text = "Valor";
            this.coluna_Valor.Width = 79;
            // 
            // columnHeaderDataDevolucao
            // 
            this.columnHeaderDataDevolucao.Text = "Data devolução";
            this.columnHeaderDataDevolucao.Width = 95;
            // 
            // contextMenuStripRelacao_Filmes
            // 
            this.contextMenuStripRelacao_Filmes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem,
            this.visualizarCapaToolStripMenuItem1});
            this.contextMenuStripRelacao_Filmes.Name = "contextMenuStripRelacao_Filmes";
            this.contextMenuStripRelacao_Filmes.Size = new System.Drawing.Size(154, 70);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // visualizarCapaToolStripMenuItem1
            // 
            this.visualizarCapaToolStripMenuItem1.Name = "visualizarCapaToolStripMenuItem1";
            this.visualizarCapaToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.visualizarCapaToolStripMenuItem1.Text = "Visualizar Capa";
            this.visualizarCapaToolStripMenuItem1.Click += new System.EventHandler(this.visualizarCapaToolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Cod_Cli_Info);
            this.groupBox2.Controls.Add(this.label_Cod_Cli);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox_Dependente);
            this.groupBox2.Controls.Add(this.textBox_Nome_CLi);
            this.groupBox2.Controls.Add(this.textBox_Cliente_Desde);
            this.groupBox2.Controls.Add(this.textBox_Ultima_Loc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_Dependente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label_Status_Info);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_Status);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(828, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 653);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimento";
            // 
            // label_Cod_Cli_Info
            // 
            this.label_Cod_Cli_Info.AutoSize = true;
            this.label_Cod_Cli_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cod_Cli_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Cod_Cli_Info.Location = new System.Drawing.Point(131, 22);
            this.label_Cod_Cli_Info.Name = "label_Cod_Cli_Info";
            this.label_Cod_Cli_Info.Size = new System.Drawing.Size(59, 20);
            this.label_Cod_Cli_Info.TabIndex = 17;
            this.label_Cod_Cli_Info.Text = "00000";
            // 
            // label_Cod_Cli
            // 
            this.label_Cod_Cli.AutoSize = true;
            this.label_Cod_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Cod_Cli.Location = new System.Drawing.Point(6, 22);
            this.label_Cod_Cli.Name = "label_Cod_Cli";
            this.label_Cod_Cli.Size = new System.Drawing.Size(128, 20);
            this.label_Cod_Cli.TabIndex = 16;
            this.label_Cod_Cli.Text = "Código Cliente :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Creditar);
            this.groupBox3.Controls.Add(this.button_Finalizar);
            this.groupBox3.Controls.Add(this.buttonCancelar);
            this.groupBox3.Controls.Add(this.textBox_Total_Loc);
            this.groupBox3.Controls.Add(this.textBox_Troco);
            this.groupBox3.Controls.Add(this.textBox_Dinheiro);
            this.groupBox3.Controls.Add(this.textBox_Cli_Saldo);
            this.groupBox3.Controls.Add(this.textBox_Cli_Credito);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(10, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 327);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caixa";
            // 
            // checkBox_Creditar
            // 
            this.checkBox_Creditar.AutoSize = true;
            this.checkBox_Creditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox_Creditar.Location = new System.Drawing.Point(223, 237);
            this.checkBox_Creditar.Name = "checkBox_Creditar";
            this.checkBox_Creditar.Size = new System.Drawing.Size(88, 24);
            this.checkBox_Creditar.TabIndex = 5;
            this.checkBox_Creditar.Text = "Creditar";
            this.checkBox_Creditar.UseVisualStyleBackColor = true;
            // 
            // button_Finalizar
            // 
            this.button_Finalizar.Location = new System.Drawing.Point(247, 298);
            this.button_Finalizar.Name = "button_Finalizar";
            this.button_Finalizar.Size = new System.Drawing.Size(75, 23);
            this.button_Finalizar.TabIndex = 7;
            this.button_Finalizar.Text = "&Finalizar";
            this.button_Finalizar.UseVisualStyleBackColor = true;
            this.button_Finalizar.Click += new System.EventHandler(this.button_Finalizar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(166, 298);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBox_Total_Loc
            // 
            this.textBox_Total_Loc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Total_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total_Loc.Location = new System.Drawing.Point(117, 45);
            this.textBox_Total_Loc.Name = "textBox_Total_Loc";
            this.textBox_Total_Loc.ReadOnly = true;
            this.textBox_Total_Loc.Size = new System.Drawing.Size(100, 26);
            this.textBox_Total_Loc.TabIndex = 1;
            this.textBox_Total_Loc.Text = "0";
            this.textBox_Total_Loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Troco
            // 
            this.textBox_Troco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Troco.Location = new System.Drawing.Point(117, 235);
            this.textBox_Troco.Name = "textBox_Troco";
            this.textBox_Troco.ReadOnly = true;
            this.textBox_Troco.Size = new System.Drawing.Size(100, 26);
            this.textBox_Troco.TabIndex = 4;
            this.textBox_Troco.Text = "0";
            this.textBox_Troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Dinheiro
            // 
            this.textBox_Dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Dinheiro.Location = new System.Drawing.Point(117, 188);
            this.textBox_Dinheiro.Name = "textBox_Dinheiro";
            this.textBox_Dinheiro.Size = new System.Drawing.Size(100, 26);
            this.textBox_Dinheiro.TabIndex = 3;
            this.textBox_Dinheiro.Text = "0";
            this.textBox_Dinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Dinheiro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            // 
            // textBox_Cli_Saldo
            // 
            this.textBox_Cli_Saldo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Cli_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cli_Saldo.Location = new System.Drawing.Point(117, 139);
            this.textBox_Cli_Saldo.Name = "textBox_Cli_Saldo";
            this.textBox_Cli_Saldo.ReadOnly = true;
            this.textBox_Cli_Saldo.Size = new System.Drawing.Size(100, 26);
            this.textBox_Cli_Saldo.TabIndex = 2;
            this.textBox_Cli_Saldo.Text = "0";
            this.textBox_Cli_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Cli_Credito
            // 
            this.textBox_Cli_Credito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Cli_Credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cli_Credito.Location = new System.Drawing.Point(117, 93);
            this.textBox_Cli_Credito.Name = "textBox_Cli_Credito";
            this.textBox_Cli_Credito.ReadOnly = true;
            this.textBox_Cli_Credito.Size = new System.Drawing.Size(100, 26);
            this.textBox_Cli_Credito.TabIndex = 0;
            this.textBox_Cli_Credito.Text = "0";
            this.textBox_Cli_Credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 24);
            this.label16.TabIndex = 15;
            this.label16.Text = "Dinheiro:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Total:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(40, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 24);
            this.label17.TabIndex = 15;
            this.label17.Text = "Troco:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "Saldo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Crédito:";
            // 
            // textBox_Dependente
            // 
            this.textBox_Dependente.Location = new System.Drawing.Point(6, 242);
            this.textBox_Dependente.Name = "textBox_Dependente";
            this.textBox_Dependente.Size = new System.Drawing.Size(332, 20);
            this.textBox_Dependente.TabIndex = 2;
            // 
            // textBox_Nome_CLi
            // 
            this.textBox_Nome_CLi.Location = new System.Drawing.Point(6, 196);
            this.textBox_Nome_CLi.Name = "textBox_Nome_CLi";
            this.textBox_Nome_CLi.Size = new System.Drawing.Size(332, 20);
            this.textBox_Nome_CLi.TabIndex = 2;
            // 
            // textBox_Cliente_Desde
            // 
            this.textBox_Cliente_Desde.Location = new System.Drawing.Point(6, 101);
            this.textBox_Cliente_Desde.Name = "textBox_Cliente_Desde";
            this.textBox_Cliente_Desde.Size = new System.Drawing.Size(125, 20);
            this.textBox_Cliente_Desde.TabIndex = 0;
            // 
            // textBox_Ultima_Loc
            // 
            this.textBox_Ultima_Loc.Location = new System.Drawing.Point(6, 147);
            this.textBox_Ultima_Loc.Name = "textBox_Ultima_Loc";
            this.textBox_Ultima_Loc.Size = new System.Drawing.Size(125, 20);
            this.textBox_Ultima_Loc.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(6, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Aviso:";
            // 
            // label_Dependente
            // 
            this.label_Dependente.AllowDrop = true;
            this.label_Dependente.AutoSize = true;
            this.label_Dependente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Dependente.Location = new System.Drawing.Point(6, 219);
            this.label_Dependente.Name = "label_Dependente";
            this.label_Dependente.Size = new System.Drawing.Size(109, 20);
            this.label_Dependente.TabIndex = 15;
            this.label_Dependente.Text = "Dependente :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(67, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Descrição";
            // 
            // label_Status_Info
            // 
            this.label_Status_Info.AutoSize = true;
            this.label_Status_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Status_Info.Location = new System.Drawing.Point(69, 49);
            this.label_Status_Info.Name = "label_Status_Info";
            this.label_Status_Info.Size = new System.Drawing.Size(49, 20);
            this.label_Status_Info.TabIndex = 15;
            this.label_Status_Info.Text = "Ativo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cliente desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ultima locação:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Status.Location = new System.Drawing.Point(6, 49);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(62, 20);
            this.label_Status.TabIndex = 15;
            this.label_Status.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(194, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 166);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            // 
            // pictureBox_Cliente
            // 
            this.pictureBox_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Cliente.Image")));
            this.pictureBox_Cliente.Location = new System.Drawing.Point(8, 19);
            this.pictureBox_Cliente.Name = "pictureBox_Cliente";
            this.pictureBox_Cliente.Size = new System.Drawing.Size(130, 140);
            this.pictureBox_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cliente.TabIndex = 14;
            this.pictureBox_Cliente.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Relação dos Filmes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Filmes Disponíveis";
            // 
            // listView_Filmes_Disponiveis
            // 
            this.listView_Filmes_Disponiveis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Filmes_Disponiveis.ContextMenuStrip = this.contextMenuStrip_Filmes;
            this.listView_Filmes_Disponiveis.FullRowSelect = true;
            this.listView_Filmes_Disponiveis.GridLines = true;
            this.listView_Filmes_Disponiveis.Location = new System.Drawing.Point(11, 74);
            this.listView_Filmes_Disponiveis.Name = "listView_Filmes_Disponiveis";
            this.listView_Filmes_Disponiveis.Size = new System.Drawing.Size(810, 232);
            this.listView_Filmes_Disponiveis.TabIndex = 3;
            this.listView_Filmes_Disponiveis.UseCompatibleStateImageBehavior = false;
            this.listView_Filmes_Disponiveis.View = System.Windows.Forms.View.Details;
            this.listView_Filmes_Disponiveis.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Filmes_Disponiveis_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Título";
            this.columnHeader2.Width = 275;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gênero";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Classificação";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Midia";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoria";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 79;
            // 
            // contextMenuStrip_Filmes
            // 
            this.contextMenuStrip_Filmes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.visualizarCapaToolStripMenuItem});
            this.contextMenuStrip_Filmes.Name = "contextMenuStrip_Filmes";
            this.contextMenuStrip_Filmes.Size = new System.Drawing.Size(154, 48);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.adicionarToolStripMenuItem.Text = "&Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // visualizarCapaToolStripMenuItem
            // 
            this.visualizarCapaToolStripMenuItem.Name = "visualizarCapaToolStripMenuItem";
            this.visualizarCapaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.visualizarCapaToolStripMenuItem.Text = "&Visualizar Capa";
            this.visualizarCapaToolStripMenuItem.Click += new System.EventHandler(this.visualizarCapaToolStripMenuItem_Click);
            // 
            // pictureBoxDevolver
            // 
            this.pictureBoxDevolver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDevolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDevolver.Image")));
            this.pictureBoxDevolver.Location = new System.Drawing.Point(751, 312);
            this.pictureBoxDevolver.Name = "pictureBoxDevolver";
            this.pictureBoxDevolver.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxDevolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDevolver.TabIndex = 25;
            this.pictureBoxDevolver.TabStop = false;
            this.pictureBoxDevolver.Click += new System.EventHandler(this.pictureBoxIncluir_Click);
            // 
            // pictureBoxLimpar
            // 
            this.pictureBoxLimpar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLimpar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLimpar.Image")));
            this.pictureBoxLimpar.Location = new System.Drawing.Point(751, 613);
            this.pictureBoxLimpar.Name = "pictureBoxLimpar";
            this.pictureBoxLimpar.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLimpar.TabIndex = 25;
            this.pictureBoxLimpar.TabStop = false;
            this.pictureBoxLimpar.Click += new System.EventHandler(this.pictureBoxLimpar_Click);
            // 
            // maskedTextBox_Cod_Filme
            // 
            this.maskedTextBox_Cod_Filme.Location = new System.Drawing.Point(11, 35);
            this.maskedTextBox_Cod_Filme.Mask = "99999";
            this.maskedTextBox_Cod_Filme.Name = "maskedTextBox_Cod_Filme";
            this.maskedTextBox_Cod_Filme.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBox_Cod_Filme.TabIndex = 0;
            this.maskedTextBox_Cod_Filme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Consul_Fime
            // 
            this.button_Consul_Fime.Location = new System.Drawing.Point(692, 23);
            this.button_Consul_Fime.Name = "button_Consul_Fime";
            this.button_Consul_Fime.Size = new System.Drawing.Size(130, 23);
            this.button_Consul_Fime.TabIndex = 2;
            this.button_Consul_Fime.Text = "Consultar";
            this.button_Consul_Fime.UseVisualStyleBackColor = true;
            this.button_Consul_Fime.Click += new System.EventHandler(this.button_Consul_Fime_Click);
            // 
            // radioButton_Cod_Filme
            // 
            this.radioButton_Cod_Filme.AutoSize = true;
            this.radioButton_Cod_Filme.Checked = true;
            this.radioButton_Cod_Filme.Location = new System.Drawing.Point(11, 12);
            this.radioButton_Cod_Filme.Name = "radioButton_Cod_Filme";
            this.radioButton_Cod_Filme.Size = new System.Drawing.Size(88, 17);
            this.radioButton_Cod_Filme.TabIndex = 26;
            this.radioButton_Cod_Filme.TabStop = true;
            this.radioButton_Cod_Filme.Text = "Código Filme:";
            this.radioButton_Cod_Filme.UseVisualStyleBackColor = true;
            this.radioButton_Cod_Filme.CheckedChanged += new System.EventHandler(this.radioButton_Cod_Filme_CheckedChanged);
            // 
            // radioButton_Titulo_Filme
            // 
            this.radioButton_Titulo_Filme.AutoSize = true;
            this.radioButton_Titulo_Filme.Location = new System.Drawing.Point(111, 12);
            this.radioButton_Titulo_Filme.Name = "radioButton_Titulo_Filme";
            this.radioButton_Titulo_Filme.Size = new System.Drawing.Size(96, 17);
            this.radioButton_Titulo_Filme.TabIndex = 27;
            this.radioButton_Titulo_Filme.TabStop = true;
            this.radioButton_Titulo_Filme.Text = "Titulo do Filme:";
            this.radioButton_Titulo_Filme.UseVisualStyleBackColor = true;
            this.radioButton_Titulo_Filme.CheckedChanged += new System.EventHandler(this.radioButton_Titulo_Filme_CheckedChanged);
            // 
            // Form_Loc_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.radioButton_Titulo_Filme);
            this.Controls.Add(this.radioButton_Cod_Filme);
            this.Controls.Add(this.button_Consul_Fime);
            this.Controls.Add(this.maskedTextBox_Cod_Filme);
            this.Controls.Add(this.pictureBoxLimpar);
            this.Controls.Add(this.pictureBoxDevolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_Nome_Filme);
            this.Controls.Add(this.listView_Relacao_Filmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Filmes_Disponiveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Loc_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Loc_Cliente";
            this.Load += new System.EventHandler(this.Form_Loc_Cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Loc_Cliente_KeyDown);
            this.contextMenuStripRelacao_Filmes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cliente)).EndInit();
            this.contextMenuStrip_Filmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLimpar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nome_Filme;
        private System.Windows.Forms.ListView listView_Relacao_Filmes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_Cliente;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_Ultima_Loc;
        private System.Windows.Forms.Label label_Status_Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button_Finalizar;
        private System.Windows.Forms.CheckBox checkBox_Creditar;
        private System.Windows.Forms.TextBox textBox_Total_Loc;
        private System.Windows.Forms.TextBox textBox_Troco;
        private System.Windows.Forms.TextBox textBox_Dinheiro;
        private System.Windows.Forms.TextBox textBox_Cli_Saldo;
        private System.Windows.Forms.TextBox textBox_Cli_Credito;
        private System.Windows.Forms.TextBox textBox_Nome_CLi;
        private System.Windows.Forms.TextBox textBox_Cliente_Desde;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.ColumnHeader coluna_titulo;
        private System.Windows.Forms.ColumnHeader coluna_genero;
        private System.Windows.Forms.ColumnHeader coluna_classificacao;
        private System.Windows.Forms.ColumnHeader coluna_categoria;
        private System.Windows.Forms.ColumnHeader coluna_Valor;
        private System.Windows.Forms.ListView listView_Filmes_Disponiveis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBoxDevolver;
        private System.Windows.Forms.PictureBox pictureBoxLimpar;
        private System.Windows.Forms.ColumnHeader columnHeaderDataDevolucao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Filmes;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCapaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRelacao_Filmes;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCapaToolStripMenuItem1;
        private System.Windows.Forms.Label label_Cod_Cli;
        private System.Windows.Forms.Label label_Cod_Cli_Info;
        private System.Windows.Forms.TextBox textBox_Dependente;
        private System.Windows.Forms.Label label_Dependente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Filme;
        private System.Windows.Forms.Button button_Consul_Fime;
        private System.Windows.Forms.RadioButton radioButton_Cod_Filme;
        private System.Windows.Forms.RadioButton radioButton_Titulo_Filme;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}