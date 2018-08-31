namespace video_locadora
{
    partial class Form_Devolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Devolucao));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_Filmes_locados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datalocacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataDevolucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAtrazo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Multa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Filmes_Devolvidos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label_Cod_Cli_Info = new System.Windows.Forms.Label();
            this.label_Cod_Cli = new System.Windows.Forms.Label();
            this.textBox_Dependente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Cliente = new System.Windows.Forms.PictureBox();
            this.textBox_Nome_CLi = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_Cliente_Desde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Ultima_Loc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Status_Info = new System.Windows.Forms.Label();
            this.label_Dependente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxIncluir = new System.Windows.Forms.PictureBox();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.maskedTextBox_Cod_Filme = new System.Windows.Forms.MaskedTextBox();
            this.label_Cod_Filme = new System.Windows.Forms.Label();
            this.listView_Filmes_Devolvidos = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Filmes_Devolvidos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncluir)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filmes Devolvidos";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filmes Locados";
            // 
            // listView_Filmes_locados
            // 
            this.listView_Filmes_locados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.datalocacao,
            this.DataDevolucao,
            this.columnHeader10,
            this.columnHeaderValor,
            this.columnHeaderAtrazo,
            this.Multa});
            this.listView_Filmes_locados.ContextMenuStrip = this.contextMenuStrip_Filmes_Devolvidos;
            this.listView_Filmes_locados.FullRowSelect = true;
            this.listView_Filmes_locados.Location = new System.Drawing.Point(12, 61);
            this.listView_Filmes_locados.Name = "listView_Filmes_locados";
            this.listView_Filmes_locados.Size = new System.Drawing.Size(810, 267);
            this.listView_Filmes_locados.TabIndex = 3;
            this.listView_Filmes_locados.UseCompatibleStateImageBehavior = false;
            this.listView_Filmes_locados.View = System.Windows.Forms.View.Details;
            this.listView_Filmes_locados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Filmes_locados_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Título";
            this.columnHeader2.Width = 260;
            // 
            // datalocacao
            // 
            this.datalocacao.Text = "Data Locação";
            this.datalocacao.Width = 81;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.Text = "Data Devolução";
            this.DataDevolucao.Width = 91;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Categoria";
            this.columnHeader10.Width = 93;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 92;
            // 
            // columnHeaderAtrazo
            // 
            this.columnHeaderAtrazo.Text = "Atrazo";
            this.columnHeaderAtrazo.Width = 50;
            // 
            // Multa
            // 
            this.Multa.Text = "Multa";
            this.Multa.Width = 74;
            // 
            // contextMenuStrip_Filmes_Devolvidos
            // 
            this.contextMenuStrip_Filmes_Devolvidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devolverToolStripMenuItem,
            this.visualizarCapaToolStripMenuItem});
            this.contextMenuStrip_Filmes_Devolvidos.Name = "contextMenuStrip_Filmes_Devolvidos";
            this.contextMenuStrip_Filmes_Devolvidos.Size = new System.Drawing.Size(154, 48);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.devolverToolStripMenuItem_Click);
            // 
            // visualizarCapaToolStripMenuItem
            // 
            this.visualizarCapaToolStripMenuItem.Name = "visualizarCapaToolStripMenuItem";
            this.visualizarCapaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.visualizarCapaToolStripMenuItem.Text = "Visualizar Capa";
            this.visualizarCapaToolStripMenuItem.Click += new System.EventHandler(this.visualizarCapaToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label_Cod_Cli_Info);
            this.groupBox2.Controls.Add(this.label_Cod_Cli);
            this.groupBox2.Controls.Add(this.textBox_Dependente);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textBox_Nome_CLi);
            this.groupBox2.Controls.Add(this.label_Status);
            this.groupBox2.Controls.Add(this.textBox_Cliente_Desde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Ultima_Loc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_Status_Info);
            this.groupBox2.Controls.Add(this.label_Dependente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(828, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 638);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimento";
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
            this.groupBox3.Location = new System.Drawing.Point(6, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 327);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caixa";
            // 
            // checkBox_Creditar
            // 
            this.checkBox_Creditar.AutoSize = true;
            this.checkBox_Creditar.Checked = true;
            this.checkBox_Creditar.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.button_Finalizar.TabIndex = 3;
            this.button_Finalizar.Text = "&Finalizar";
            this.button_Finalizar.UseVisualStyleBackColor = true;
            this.button_Finalizar.Click += new System.EventHandler(this.button_Finalizar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(166, 298);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
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
            this.textBox_Dinheiro.TabIndex = 0;
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
            this.label15.Location = new System.Drawing.Point(43, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Multas:";
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
            // label_Cod_Cli_Info
            // 
            this.label_Cod_Cli_Info.AutoSize = true;
            this.label_Cod_Cli_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cod_Cli_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Cod_Cli_Info.Location = new System.Drawing.Point(131, 16);
            this.label_Cod_Cli_Info.Name = "label_Cod_Cli_Info";
            this.label_Cod_Cli_Info.Size = new System.Drawing.Size(59, 20);
            this.label_Cod_Cli_Info.TabIndex = 32;
            this.label_Cod_Cli_Info.Text = "00000";
            // 
            // label_Cod_Cli
            // 
            this.label_Cod_Cli.AutoSize = true;
            this.label_Cod_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Cod_Cli.Location = new System.Drawing.Point(6, 16);
            this.label_Cod_Cli.Name = "label_Cod_Cli";
            this.label_Cod_Cli.Size = new System.Drawing.Size(128, 20);
            this.label_Cod_Cli.TabIndex = 31;
            this.label_Cod_Cli.Text = "Código Cliente :";
            // 
            // textBox_Dependente
            // 
            this.textBox_Dependente.Location = new System.Drawing.Point(6, 236);
            this.textBox_Dependente.Name = "textBox_Dependente";
            this.textBox_Dependente.Size = new System.Drawing.Size(332, 20);
            this.textBox_Dependente.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(194, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 166);
            this.groupBox1.TabIndex = 22;
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
            // textBox_Nome_CLi
            // 
            this.textBox_Nome_CLi.Location = new System.Drawing.Point(6, 190);
            this.textBox_Nome_CLi.Name = "textBox_Nome_CLi";
            this.textBox_Nome_CLi.Size = new System.Drawing.Size(332, 20);
            this.textBox_Nome_CLi.TabIndex = 20;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Status.Location = new System.Drawing.Point(6, 43);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(62, 20);
            this.label_Status.TabIndex = 25;
            this.label_Status.Text = "Status:";
            // 
            // textBox_Cliente_Desde
            // 
            this.textBox_Cliente_Desde.Location = new System.Drawing.Point(6, 95);
            this.textBox_Cliente_Desde.Name = "textBox_Cliente_Desde";
            this.textBox_Cliente_Desde.Size = new System.Drawing.Size(125, 20);
            this.textBox_Cliente_Desde.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ultima locação:";
            // 
            // textBox_Ultima_Loc
            // 
            this.textBox_Ultima_Loc.Location = new System.Drawing.Point(6, 141);
            this.textBox_Ultima_Loc.Name = "textBox_Ultima_Loc";
            this.textBox_Ultima_Loc.Size = new System.Drawing.Size(125, 20);
            this.textBox_Ultima_Loc.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cliente desde:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(6, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Aviso:";
            // 
            // label_Status_Info
            // 
            this.label_Status_Info.AutoSize = true;
            this.label_Status_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Status_Info.Location = new System.Drawing.Point(69, 43);
            this.label_Status_Info.Name = "label_Status_Info";
            this.label_Status_Info.Size = new System.Drawing.Size(49, 20);
            this.label_Status_Info.TabIndex = 24;
            this.label_Status_Info.Text = "Ativo";
            // 
            // label_Dependente
            // 
            this.label_Dependente.AllowDrop = true;
            this.label_Dependente.AutoSize = true;
            this.label_Dependente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Dependente.Location = new System.Drawing.Point(6, 213);
            this.label_Dependente.Name = "label_Dependente";
            this.label_Dependente.Size = new System.Drawing.Size(109, 20);
            this.label_Dependente.TabIndex = 29;
            this.label_Dependente.Text = "Dependente :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(67, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(6, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Cliente:";
            // 
            // pictureBoxIncluir
            // 
            this.pictureBoxIncluir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIncluir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIncluir.Image")));
            this.pictureBoxIncluir.Location = new System.Drawing.Point(751, 334);
            this.pictureBoxIncluir.Name = "pictureBoxIncluir";
            this.pictureBoxIncluir.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxIncluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIncluir.TabIndex = 26;
            this.pictureBoxIncluir.TabStop = false;
            this.pictureBoxIncluir.Click += new System.EventHandler(this.pictureBoxIncluir_Click);
            // 
            // button_Consultar
            // 
            this.button_Consultar.Location = new System.Drawing.Point(705, 32);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(117, 23);
            this.button_Consultar.TabIndex = 2;
            this.button_Consultar.Text = "Consultar";
            this.button_Consultar.UseVisualStyleBackColor = true;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // maskedTextBox_Cod_Filme
            // 
            this.maskedTextBox_Cod_Filme.Location = new System.Drawing.Point(12, 35);
            this.maskedTextBox_Cod_Filme.Mask = "99999";
            this.maskedTextBox_Cod_Filme.Name = "maskedTextBox_Cod_Filme";
            this.maskedTextBox_Cod_Filme.Size = new System.Drawing.Size(105, 20);
            this.maskedTextBox_Cod_Filme.TabIndex = 0;
            this.maskedTextBox_Cod_Filme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Cod_Filme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            // 
            // label_Cod_Filme
            // 
            this.label_Cod_Filme.AutoSize = true;
            this.label_Cod_Filme.Location = new System.Drawing.Point(12, 19);
            this.label_Cod_Filme.Name = "label_Cod_Filme";
            this.label_Cod_Filme.Size = new System.Drawing.Size(73, 13);
            this.label_Cod_Filme.TabIndex = 27;
            this.label_Cod_Filme.Text = "Código_Filme:";
            // 
            // listView_Filmes_Devolvidos
            // 
            this.listView_Filmes_Devolvidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11});
            this.listView_Filmes_Devolvidos.Location = new System.Drawing.Point(12, 390);
            this.listView_Filmes_Devolvidos.Name = "listView_Filmes_Devolvidos";
            this.listView_Filmes_Devolvidos.Size = new System.Drawing.Size(810, 260);
            this.listView_Filmes_Devolvidos.TabIndex = 28;
            this.listView_Filmes_Devolvidos.UseCompatibleStateImageBehavior = false;
            this.listView_Filmes_Devolvidos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código";
            this.columnHeader3.Width = 57;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Título";
            this.columnHeader4.Width = 260;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data Locação";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data Devolução";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Categoria";
            this.columnHeader7.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Valor";
            this.columnHeader8.Width = 92;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Atrazo";
            this.columnHeader9.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Multa";
            this.columnHeader11.Width = 74;
            // 
            // Form_Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.listView_Filmes_Devolvidos);
            this.Controls.Add(this.label_Cod_Filme);
            this.Controls.Add(this.maskedTextBox_Cod_Filme);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.pictureBoxIncluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView_Filmes_locados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Devolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.Form_Devolucao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Devolucao_KeyDown);
            this.contextMenuStrip_Filmes_Devolvidos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView_Filmes_locados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader datalocacao;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderAtrazo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxIncluir;
        private System.Windows.Forms.Label label_Cod_Cli_Info;
        private System.Windows.Forms.Label label_Cod_Cli;
        private System.Windows.Forms.TextBox textBox_Dependente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_Cliente;
        private System.Windows.Forms.TextBox textBox_Nome_CLi;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_Cliente_Desde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Ultima_Loc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Status_Info;
        private System.Windows.Forms.Label label_Dependente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_Creditar;
        private System.Windows.Forms.Button button_Finalizar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBox_Total_Loc;
        private System.Windows.Forms.TextBox textBox_Troco;
        private System.Windows.Forms.TextBox textBox_Dinheiro;
        private System.Windows.Forms.TextBox textBox_Cli_Saldo;
        private System.Windows.Forms.TextBox textBox_Cli_Credito;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Filme;
        private System.Windows.Forms.Label label_Cod_Filme;
        private System.Windows.Forms.ColumnHeader DataDevolucao;
        private System.Windows.Forms.ColumnHeader Multa;
        private System.Windows.Forms.ListView listView_Filmes_Devolvidos;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Filmes_Devolvidos;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCapaToolStripMenuItem;
    }
}