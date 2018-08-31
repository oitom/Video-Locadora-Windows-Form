namespace video_locadora
{
    partial class Form_Excluir_Usuario
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
            this.listView_Usuario = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBox_Cod_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.textBox_Nome_Usuario = new System.Windows.Forms.TextBox();
            this.label_Nome_Usuario = new System.Windows.Forms.Label();
            this.label_Cod_Cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_Usuario
            // 
            this.listView_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnNome,
            this.columnHeaderLogin,
            this.columnCPF});
            this.listView_Usuario.FullRowSelect = true;
            this.listView_Usuario.Location = new System.Drawing.Point(12, 51);
            this.listView_Usuario.Name = "listView_Usuario";
            this.listView_Usuario.Size = new System.Drawing.Size(705, 366);
            this.listView_Usuario.TabIndex = 20;
            this.listView_Usuario.UseCompatibleStateImageBehavior = false;
            this.listView_Usuario.View = System.Windows.Forms.View.Details;
            this.listView_Usuario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Usuario_MouseDoubleClick);
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 307;
            // 
            // columnHeaderLogin
            // 
            this.columnHeaderLogin.Text = "Login";
            this.columnHeaderLogin.Width = 196;
            // 
            // columnCPF
            // 
            this.columnCPF.Text = "CPF";
            this.columnCPF.Width = 137;
            // 
            // maskedTextBox_Cod_Usuario
            // 
            this.maskedTextBox_Cod_Usuario.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBox_Cod_Usuario.Mask = "999999";
            this.maskedTextBox_Cod_Usuario.Name = "maskedTextBox_Cod_Usuario";
            this.maskedTextBox_Cod_Usuario.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Usuario.TabIndex = 14;
            this.maskedTextBox_Cod_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Excluir
            // 
            this.button_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Excluir.Location = new System.Drawing.Point(642, 423);
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
            this.button_Cancelar.Location = new System.Drawing.Point(561, 423);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 16;
            this.button_Cancelar.Text = "&Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // textBox_Nome_Usuario
            // 
            this.textBox_Nome_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nome_Usuario.Location = new System.Drawing.Point(118, 25);
            this.textBox_Nome_Usuario.Name = "textBox_Nome_Usuario";
            this.textBox_Nome_Usuario.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_Usuario.TabIndex = 15;
            // 
            // label_Nome_Usuario
            // 
            this.label_Nome_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Nome_Usuario.AutoSize = true;
            this.label_Nome_Usuario.Location = new System.Drawing.Point(115, 9);
            this.label_Nome_Usuario.Name = "label_Nome_Usuario";
            this.label_Nome_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label_Nome_Usuario.TabIndex = 19;
            this.label_Nome_Usuario.Text = "Usuário";
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
            // Form_Excluir_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 457);
            this.Controls.Add(this.listView_Usuario);
            this.Controls.Add(this.maskedTextBox_Cod_Usuario);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Nome_Usuario);
            this.Controls.Add(this.label_Nome_Usuario);
            this.Controls.Add(this.label_Cod_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form_Excluir_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Usuário";
           // this.Load += new System.EventHandler(this.Form_Alterar_Usuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Usuario;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnHeaderLogin;
        private System.Windows.Forms.ColumnHeader columnCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Usuario;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.TextBox textBox_Nome_Usuario;
        private System.Windows.Forms.Label label_Nome_Usuario;
        private System.Windows.Forms.Label label_Cod_Cliente;

    }
}