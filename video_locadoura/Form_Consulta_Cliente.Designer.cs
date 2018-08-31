namespace video_locadora
{
    partial class Form_Consulta_Cliente
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
            this.radioButton_Nome_Cliente = new System.Windows.Forms.RadioButton();
            this.radioButton_Cod_Cliente = new System.Windows.Forms.RadioButton();
            this.maskedTextBox_Cod_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.button_Locar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coluna_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.coluna_cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_titular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton_Nome_Cliente
            // 
            this.radioButton_Nome_Cliente.AutoSize = true;
            this.radioButton_Nome_Cliente.Location = new System.Drawing.Point(125, 13);
            this.radioButton_Nome_Cliente.Name = "radioButton_Nome_Cliente";
            this.radioButton_Nome_Cliente.Size = new System.Drawing.Size(103, 17);
            this.radioButton_Nome_Cliente.TabIndex = 24;
            this.radioButton_Nome_Cliente.TabStop = true;
            this.radioButton_Nome_Cliente.Text = "Nome do Cliente";
            this.radioButton_Nome_Cliente.UseVisualStyleBackColor = true;
            this.radioButton_Nome_Cliente.CheckedChanged += new System.EventHandler(this.radioButton_Nome_Cliente_CheckedChanged);
            // 
            // radioButton_Cod_Cliente
            // 
            this.radioButton_Cod_Cliente.AutoSize = true;
            this.radioButton_Cod_Cliente.Checked = true;
            this.radioButton_Cod_Cliente.Location = new System.Drawing.Point(22, 13);
            this.radioButton_Cod_Cliente.Name = "radioButton_Cod_Cliente";
            this.radioButton_Cod_Cliente.Size = new System.Drawing.Size(93, 17);
            this.radioButton_Cod_Cliente.TabIndex = 23;
            this.radioButton_Cod_Cliente.TabStop = true;
            this.radioButton_Cod_Cliente.Text = "Código Cliente";
            this.radioButton_Cod_Cliente.UseVisualStyleBackColor = true;
            this.radioButton_Cod_Cliente.CheckedChanged += new System.EventHandler(this.radioButton_Cod_Cliente_CheckedChanged);
            // 
            // maskedTextBox_Cod_Cliente
            // 
            this.maskedTextBox_Cod_Cliente.Location = new System.Drawing.Point(19, 36);
            this.maskedTextBox_Cod_Cliente.Mask = "999999";
            this.maskedTextBox_Cod_Cliente.Name = "maskedTextBox_Cod_Cliente";
            this.maskedTextBox_Cod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Cliente.TabIndex = 16;
            this.maskedTextBox_Cod_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Cod_Cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            this.maskedTextBox_Cod_Cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Locacao_KeyDown);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lista de clientes";
            // 
            // coluna_Status
            // 
            this.coluna_Status.Text = "Status";
            this.coluna_Status.Width = 127;
            // 
            // listView_Clientes
            // 
            this.listView_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_cod,
            this.coluna_nome,
            this.coluna_titular,
            this.coluna_Status});
            this.listView_Clientes.FullRowSelect = true;
            this.listView_Clientes.GridLines = true;
            this.listView_Clientes.Location = new System.Drawing.Point(12, 75);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(721, 365);
            this.listView_Clientes.TabIndex = 19;
            this.listView_Clientes.UseCompatibleStateImageBehavior = false;
            this.listView_Clientes.View = System.Windows.Forms.View.Details;
            this.listView_Clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            // 
            // coluna_cod
            // 
            this.coluna_cod.Text = "Código";
            // 
            // coluna_nome
            // 
            this.coluna_nome.Text = "Nome";
            this.coluna_nome.Width = 390;
            // 
            // coluna_titular
            // 
            this.coluna_titular.Text = "Títular";
            this.coluna_titular.Width = 122;
            // 
            // textBox_Nome_Cliente
            // 
            this.textBox_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nome_Cliente.Enabled = false;
            this.textBox_Nome_Cliente.Location = new System.Drawing.Point(125, 36);
            this.textBox_Nome_Cliente.Name = "textBox_Nome_Cliente";
            this.textBox_Nome_Cliente.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_Cliente.TabIndex = 17;
            this.textBox_Nome_Cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Clientes_MouseDoubleClick);
            this.textBox_Nome_Cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Locacao_KeyDown);
            // 
            // Form_Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 452);
            this.Controls.Add(this.radioButton_Nome_Cliente);
            this.Controls.Add(this.radioButton_Cod_Cliente);
            this.Controls.Add(this.maskedTextBox_Cod_Cliente);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.button_Locar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Clientes);
            this.Controls.Add(this.textBox_Nome_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Consulta_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.Form_Consulta_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Nome_Cliente;
        private System.Windows.Forms.RadioButton radioButton_Cod_Cliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Cliente;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.Button button_Locar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader coluna_Status;
        private System.Windows.Forms.ListView listView_Clientes;
        private System.Windows.Forms.ColumnHeader coluna_cod;
        private System.Windows.Forms.ColumnHeader coluna_nome;
        private System.Windows.Forms.ColumnHeader coluna_titular;
        private System.Windows.Forms.TextBox textBox_Nome_Cliente;

    }
}