namespace video_locadora
{
    partial class Form_Relatorio_Filmes_Locados
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
            this.listViewFilmes_Locados = new System.Windows.Forms.ListView();
            this.coluna_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_classificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewFilmes_Locados
            // 
            this.listViewFilmes_Locados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilmes_Locados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_codigo,
            this.coluna_titulo,
            this.coluna_genero,
            this.coluna_classificacao,
            this.coluna_categoria});
            this.listViewFilmes_Locados.Location = new System.Drawing.Point(12, 12);
            this.listViewFilmes_Locados.Name = "listViewFilmes_Locados";
            this.listViewFilmes_Locados.Size = new System.Drawing.Size(750, 433);
            this.listViewFilmes_Locados.TabIndex = 12;
            this.listViewFilmes_Locados.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes_Locados.View = System.Windows.Forms.View.Details;
            // 
            // coluna_codigo
            // 
            this.coluna_codigo.Text = "Código";
            this.coluna_codigo.Width = 89;
            // 
            // coluna_titulo
            // 
            this.coluna_titulo.Text = "Título";
            this.coluna_titulo.Width = 275;
            // 
            // coluna_genero
            // 
            this.coluna_genero.Text = "Gênero";
            this.coluna_genero.Width = 131;
            // 
            // coluna_classificacao
            // 
            this.coluna_classificacao.Text = "Classificação";
            this.coluna_classificacao.Width = 77;
            // 
            // coluna_categoria
            // 
            this.coluna_categoria.Text = "Categoria";
            this.coluna_categoria.Width = 173;
            // 
            // Form_Relatorio_Filmes_Locados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.listViewFilmes_Locados);
            this.Name = "Form_Relatorio_Filmes_Locados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmes Locados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFilmes_Locados;
        private System.Windows.Forms.ColumnHeader coluna_codigo;
        private System.Windows.Forms.ColumnHeader coluna_titulo;
        private System.Windows.Forms.ColumnHeader coluna_genero;
        private System.Windows.Forms.ColumnHeader coluna_classificacao;
        private System.Windows.Forms.ColumnHeader coluna_categoria;


    }
}