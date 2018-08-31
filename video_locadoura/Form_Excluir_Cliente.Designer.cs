namespace video_locadora
{
    partial class Form_Excluir_Cliente
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
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.columnHeaderLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDT_Nas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBox_Cod_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.textBox_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.label_Nome_Cliente = new System.Windows.Forms.Label();
            this.label_Cod_Cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            // 
            // columnCPF
            // 
            this.columnCPF.Text = "CPF";
            this.columnCPF.Width = 169;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 268;
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
            this.listView_Clientes.Location = new System.Drawing.Point(9, 51);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(705, 375);
            this.listView_Clientes.TabIndex = 20;
            this.listView_Clientes.UseCompatibleStateImageBehavior = false;
            this.listView_Clientes.View = System.Windows.Forms.View.Details;
            this.listView_Clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            // 
            // columnHeaderLogin
            // 
            this.columnHeaderLogin.Text = "RG";
            this.columnHeaderLogin.Width = 96;
            // 
            // columnHeaderDT_Nas
            // 
            this.columnHeaderDT_Nas.Text = "Data Nascimento";
            this.columnHeaderDT_Nas.Width = 105;
            // 
            // maskedTextBox_Cod_Cliente
            // 
            this.maskedTextBox_Cod_Cliente.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBox_Cod_Cliente.Mask = "999999";
            this.maskedTextBox_Cod_Cliente.Name = "maskedTextBox_Cod_Cliente";
            this.maskedTextBox_Cod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Cliente.TabIndex = 14;
            this.maskedTextBox_Cod_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Excluir
            // 
            this.button_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Excluir.Location = new System.Drawing.Point(639, 432);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir.TabIndex = 17;
            this.button_Excluir.Text = "&Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            this.button_Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancelar.Location = new System.Drawing.Point(558, 432);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 16;
            this.button_Cancelar.Text = "&Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // textBox_Nome_Cliente
            // 
            this.textBox_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nome_Cliente.Location = new System.Drawing.Point(118, 25);
            this.textBox_Nome_Cliente.Name = "textBox_Nome_Cliente";
            this.textBox_Nome_Cliente.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_Cliente.TabIndex = 15;
            // 
            // label_Nome_Cliente
            // 
            this.label_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Nome_Cliente.AutoSize = true;
            this.label_Nome_Cliente.Location = new System.Drawing.Point(115, 9);
            this.label_Nome_Cliente.Name = "label_Nome_Cliente";
            this.label_Nome_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Nome_Cliente.TabIndex = 19;
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
            this.label_Cod_Cliente.TabIndex = 18;
            this.label_Cod_Cliente.Text = "Código";
            // 
            // Form_Excluir_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 467);
            this.Controls.Add(this.listView_Clientes);
            this.Controls.Add(this.maskedTextBox_Cod_Cliente);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Nome_Cliente);
            this.Controls.Add(this.label_Nome_Cliente);
            this.Controls.Add(this.label_Cod_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form_Excluir_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cliente_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnCPF;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ListView listView_Clientes;
        private System.Windows.Forms.ColumnHeader columnHeaderLogin;
        private System.Windows.Forms.ColumnHeader columnHeaderDT_Nas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Cliente;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.TextBox textBox_Nome_Cliente;
        private System.Windows.Forms.Label label_Nome_Cliente;
        private System.Windows.Forms.Label label_Cod_Cliente;

    }
}