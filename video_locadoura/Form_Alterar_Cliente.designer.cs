namespace video_locadora
{
    partial class Form_Altera_Cliente
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
            this.textBox_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.label_Nome_Cliente = new System.Windows.Forms.Label();
            this.label_Cod_Cliente = new System.Windows.Forms.Label();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Locar = new System.Windows.Forms.Button();
            this.maskedTextBox_Cod_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDT_Nas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox_Nome_Cliente
            // 
            this.textBox_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nome_Cliente.Location = new System.Drawing.Point(118, 25);
            this.textBox_Nome_Cliente.Name = "textBox_Nome_Cliente";
            this.textBox_Nome_Cliente.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_Cliente.TabIndex = 1;
            // 
            // label_Nome_Cliente
            // 
            this.label_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Nome_Cliente.AutoSize = true;
            this.label_Nome_Cliente.Location = new System.Drawing.Point(115, 9);
            this.label_Nome_Cliente.Name = "label_Nome_Cliente";
            this.label_Nome_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Nome_Cliente.TabIndex = 10;
            this.label_Nome_Cliente.Text = "Cliente";
            // 
            // label_Cod_Cliente
            // 
            this.label_Cod_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Cod_Cliente.AutoSize = true;
            this.label_Cod_Cliente.Location = new System.Drawing.Point(12, 9);
            this.label_Cod_Cliente.Name = "label_Cod_Cliente";
            this.label_Cod_Cliente.Size = new System.Drawing.Size(40, 13);
            this.label_Cod_Cliente.TabIndex = 8;
            this.label_Cod_Cliente.Text = "Código";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancelar.Location = new System.Drawing.Point(561, 422);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 4;
            this.button_Cancelar.Text = "&Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // button_Locar
            // 
            this.button_Locar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Locar.Location = new System.Drawing.Point(642, 422);
            this.button_Locar.Name = "button_Locar";
            this.button_Locar.Size = new System.Drawing.Size(75, 23);
            this.button_Locar.TabIndex = 5;
            this.button_Locar.Text = "&Alterar";
            this.button_Locar.UseVisualStyleBackColor = true;
            this.button_Locar.Click += new System.EventHandler(this.Locar);
            // 
            // maskedTextBox_Cod_Cliente
            // 
            this.maskedTextBox_Cod_Cliente.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBox_Cod_Cliente.Mask = "999999";
            this.maskedTextBox_Cod_Cliente.Name = "maskedTextBox_Cod_Cliente";
            this.maskedTextBox_Cod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Cliente.TabIndex = 0;
            this.maskedTextBox_Cod_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView_Clientes
            // 
            this.listView_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnNome,
            this.columnHeaderLogin,
            this.columnCPF,
            this.columnHeaderDT_Nas});
            this.listView_Clientes.FullRowSelect = true;
            this.listView_Clientes.Location = new System.Drawing.Point(12, 51);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(705, 365);
            this.listView_Clientes.TabIndex = 13;
            this.listView_Clientes.UseCompatibleStateImageBehavior = false;
            this.listView_Clientes.View = System.Windows.Forms.View.Details;
            this.listView_Clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 268;
            // 
            // columnHeaderLogin
            // 
            this.columnHeaderLogin.Text = "RG";
            this.columnHeaderLogin.Width = 96;
            // 
            // columnCPF
            // 
            this.columnCPF.Text = "CPF";
            this.columnCPF.Width = 169;
            // 
            // columnHeaderDT_Nas
            // 
            this.columnHeaderDT_Nas.Text = "Data Nascimento";
            this.columnHeaderDT_Nas.Width = 105;
            // 
            // Form_Altera_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 457);
            this.Controls.Add(this.listView_Clientes);
            this.Controls.Add(this.maskedTextBox_Cod_Cliente);
            this.Controls.Add(this.button_Locar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Nome_Cliente);
            this.Controls.Add(this.label_Nome_Cliente);
            this.Controls.Add(this.label_Cod_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form_Altera_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.Load += new System.EventHandler(this.Form_Altera_Cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Locacao_Key);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nome_Cliente;
        private System.Windows.Forms.Label label_Nome_Cliente;
        private System.Windows.Forms.Label label_Cod_Cliente;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Locar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Cliente;
        private System.Windows.Forms.ListView listView_Clientes;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnHeaderLogin;
        private System.Windows.Forms.ColumnHeader columnCPF;
        private System.Windows.Forms.ColumnHeader columnHeaderDT_Nas;
    }
}