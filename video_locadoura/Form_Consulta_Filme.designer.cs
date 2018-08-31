namespace video_locadora
{
    partial class Form_Consulta_Filme
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
            this.radioButton_Titulo_Filme = new System.Windows.Forms.RadioButton();
            this.radioButton_Cod_Filme = new System.Windows.Forms.RadioButton();
            this.maskedTextBox_Cod_Filme = new System.Windows.Forms.MaskedTextBox();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.button_Locar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.coluna_Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Filmes = new System.Windows.Forms.ListView();
            this.coluna_cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Titulo_Filme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton_Titulo_Filme
            // 
            this.radioButton_Titulo_Filme.AutoSize = true;
            this.radioButton_Titulo_Filme.Location = new System.Drawing.Point(125, 13);
            this.radioButton_Titulo_Filme.Name = "radioButton_Titulo_Filme";
            this.radioButton_Titulo_Filme.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Titulo_Filme.TabIndex = 24;
            this.radioButton_Titulo_Filme.TabStop = true;
            this.radioButton_Titulo_Filme.Text = "Título";
            this.radioButton_Titulo_Filme.UseVisualStyleBackColor = true;
            this.radioButton_Titulo_Filme.CheckedChanged += new System.EventHandler(this.radioButton_Nome_Cliente_CheckedChanged);
            // 
            // radioButton_Cod_Filme
            // 
            this.radioButton_Cod_Filme.AutoSize = true;
            this.radioButton_Cod_Filme.Checked = true;
            this.radioButton_Cod_Filme.Location = new System.Drawing.Point(22, 13);
            this.radioButton_Cod_Filme.Name = "radioButton_Cod_Filme";
            this.radioButton_Cod_Filme.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Cod_Filme.TabIndex = 23;
            this.radioButton_Cod_Filme.TabStop = true;
            this.radioButton_Cod_Filme.Text = "Código";
            this.radioButton_Cod_Filme.UseVisualStyleBackColor = true;
            this.radioButton_Cod_Filme.CheckedChanged += new System.EventHandler(this.radioButton_Cod_Cliente_CheckedChanged);
            // 
            // maskedTextBox_Cod_Filme
            // 
            this.maskedTextBox_Cod_Filme.Location = new System.Drawing.Point(19, 36);
            this.maskedTextBox_Cod_Filme.Mask = "999999";
            this.maskedTextBox_Cod_Filme.Name = "maskedTextBox_Cod_Filme";
            this.maskedTextBox_Cod_Filme.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Filme.TabIndex = 16;
            this.maskedTextBox_Cod_Filme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Cod_Filme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            this.maskedTextBox_Cod_Filme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Consulta_KeyDown);
            // 
            // button_Consultar
            // 
            this.button_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Consultar.Location = new System.Drawing.Point(604, 33);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(129, 23);
            this.button_Consultar.TabIndex = 18;
            this.button_Consultar.Text = "CONSULTAR";
            this.button_Consultar.UseVisualStyleBackColor = true;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // button_Locar
            // 
            this.button_Locar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Locar.Location = new System.Drawing.Point(620, 497);
            this.button_Locar.Name = "button_Locar";
            this.button_Locar.Size = new System.Drawing.Size(75, 23);
            this.button_Locar.TabIndex = 21;
            this.button_Locar.Text = "&Locar";
            this.button_Locar.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancelar.Location = new System.Drawing.Point(539, 497);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 20;
            this.button_Cancelar.Text = "&Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // coluna_Categoria
            // 
            this.coluna_Categoria.Text = "Categoria";
            this.coluna_Categoria.Width = 140;
            // 
            // listView_Filmes
            // 
            this.listView_Filmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Filmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_cod,
            this.coluna_Titulo,
            this.coluna_Genero,
            this.coluna_Categoria});
            this.listView_Filmes.FullRowSelect = true;
            this.listView_Filmes.GridLines = true;
            this.listView_Filmes.Location = new System.Drawing.Point(12, 62);
            this.listView_Filmes.Name = "listView_Filmes";
            this.listView_Filmes.Size = new System.Drawing.Size(721, 378);
            this.listView_Filmes.TabIndex = 19;
            this.listView_Filmes.UseCompatibleStateImageBehavior = false;
            this.listView_Filmes.View = System.Windows.Forms.View.Details;
            this.listView_Filmes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            // 
            // coluna_cod
            // 
            this.coluna_cod.Text = "Código";
            // 
            // coluna_Titulo
            // 
            this.coluna_Titulo.Text = "Título";
            this.coluna_Titulo.Width = 390;
            // 
            // coluna_Genero
            // 
            this.coluna_Genero.Text = "Gênero";
            this.coluna_Genero.Width = 122;
            // 
            // textBox_Titulo_Filme
            // 
            this.textBox_Titulo_Filme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Titulo_Filme.Enabled = false;
            this.textBox_Titulo_Filme.Location = new System.Drawing.Point(125, 36);
            this.textBox_Titulo_Filme.Name = "textBox_Titulo_Filme";
            this.textBox_Titulo_Filme.Size = new System.Drawing.Size(333, 20);
            this.textBox_Titulo_Filme.TabIndex = 17;
            this.textBox_Titulo_Filme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            this.textBox_Titulo_Filme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Consulta_KeyDown);
            // 
            // Form_Consulta_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 452);
            this.Controls.Add(this.radioButton_Titulo_Filme);
            this.Controls.Add(this.radioButton_Cod_Filme);
            this.Controls.Add(this.maskedTextBox_Cod_Filme);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.button_Locar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.listView_Filmes);
            this.Controls.Add(this.textBox_Titulo_Filme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Consulta_Filme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Filme";
            this.Load += new System.EventHandler(this.Form_Consulta_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Titulo_Filme;
        private System.Windows.Forms.RadioButton radioButton_Cod_Filme;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Filme;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.Button button_Locar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.ColumnHeader coluna_Categoria;
        private System.Windows.Forms.ListView listView_Filmes;
        private System.Windows.Forms.ColumnHeader coluna_cod;
        private System.Windows.Forms.ColumnHeader coluna_Titulo;
        private System.Windows.Forms.ColumnHeader coluna_Genero;
        private System.Windows.Forms.TextBox textBox_Titulo_Filme;

    }
}