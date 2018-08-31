namespace video_locadora
{
    partial class Form_Excluir_Filme
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
            this.maskedTextBox_Cod_Filme = new System.Windows.Forms.MaskedTextBox();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.textBox_Nome_filme = new System.Windows.Forms.TextBox();
            this.label_Nome_Cliente = new System.Windows.Forms.Label();
            this.label_Cod_Cliente = new System.Windows.Forms.Label();
            this.listView_Filmes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // maskedTextBox_Cod_Filme
            // 
            this.maskedTextBox_Cod_Filme.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBox_Cod_Filme.Mask = "999999";
            this.maskedTextBox_Cod_Filme.Name = "maskedTextBox_Cod_Filme";
            this.maskedTextBox_Cod_Filme.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Filme.TabIndex = 0;
            this.maskedTextBox_Cod_Filme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Excluir
            // 
            this.button_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Excluir.Location = new System.Drawing.Point(666, 423);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir.TabIndex = 17;
            this.button_Excluir.Text = "&Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            this.button_Excluir.Click += new System.EventHandler(this.button_Locar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancelar.Location = new System.Drawing.Point(585, 423);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 16;
            this.button_Cancelar.Text = "&Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // textBox_Nome_filme
            // 
            this.textBox_Nome_filme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nome_filme.Location = new System.Drawing.Point(118, 25);
            this.textBox_Nome_filme.Name = "textBox_Nome_filme";
            this.textBox_Nome_filme.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_filme.TabIndex = 15;
            // 
            // label_Nome_Cliente
            // 
            this.label_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Nome_Cliente.AutoSize = true;
            this.label_Nome_Cliente.Location = new System.Drawing.Point(115, 9);
            this.label_Nome_Cliente.Name = "label_Nome_Cliente";
            this.label_Nome_Cliente.Size = new System.Drawing.Size(31, 13);
            this.label_Nome_Cliente.TabIndex = 19;
            this.label_Nome_Cliente.Text = "Filme";
            // 
            // label_Cod_Cliente
            // 
            this.label_Cod_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Cod_Cliente.AutoSize = true;
            this.label_Cod_Cliente.Location = new System.Drawing.Point(12, 9);
            this.label_Cod_Cliente.Name = "label_Cod_Cliente";
            this.label_Cod_Cliente.Size = new System.Drawing.Size(40, 13);
            this.label_Cod_Cliente.TabIndex = 18;
            this.label_Cod_Cliente.Text = "Código";
            // 
            // listView_Filmes
            // 
            this.listView_Filmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Filmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Filmes.FullRowSelect = true;
            this.listView_Filmes.Location = new System.Drawing.Point(12, 49);
            this.listView_Filmes.Name = "listView_Filmes";
            this.listView_Filmes.Size = new System.Drawing.Size(729, 368);
            this.listView_Filmes.TabIndex = 20;
            this.listView_Filmes.UseCompatibleStateImageBehavior = false;
            this.listView_Filmes.View = System.Windows.Forms.View.Details;
            this.listView_Filmes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Filmes_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Título";
            this.columnHeader2.Width = 461;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gênero";
            this.columnHeader3.Width = 175;
            // 
            // Form_Excluir_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 458);
            this.Controls.Add(this.listView_Filmes);
            this.Controls.Add(this.maskedTextBox_Cod_Filme);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Nome_filme);
            this.Controls.Add(this.label_Nome_Cliente);
            this.Controls.Add(this.label_Cod_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form_Excluir_Filme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Filme";
            this.Load += new System.EventHandler(this.Form_Alterar_Filme_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Filme_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Filme;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.TextBox textBox_Nome_filme;
        private System.Windows.Forms.Label label_Nome_Cliente;
        private System.Windows.Forms.Label label_Cod_Cliente;
        private System.Windows.Forms.ListView listView_Filmes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;

    }
}