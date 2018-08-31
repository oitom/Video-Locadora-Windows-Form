namespace video_locadora
{
    partial class Form_Locacao
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
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.coluna_cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_titular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Locar = new System.Windows.Forms.Button();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.maskedTextBox_Cod_Cliente = new System.Windows.Forms.MaskedTextBox();
            this.radioButton_Cod_Cliente = new System.Windows.Forms.RadioButton();
            this.radioButton_Nome_Cliente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_Nome_Cliente
            // 
            this.textBox_Nome_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Nome_Cliente.Enabled = false;
            this.textBox_Nome_Cliente.Location = new System.Drawing.Point(118, 35);
            this.textBox_Nome_Cliente.Name = "textBox_Nome_Cliente";
            this.textBox_Nome_Cliente.Size = new System.Drawing.Size(333, 20);
            this.textBox_Nome_Cliente.TabIndex = 1;
            this.textBox_Nome_Cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
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
            this.listView_Clientes.Location = new System.Drawing.Point(12, 74);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(703, 391);
            this.listView_Clientes.TabIndex = 3;
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
            // coluna_Status
            // 
            this.coluna_Status.Text = "Status";
            this.coluna_Status.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de clientes";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancelar.Location = new System.Drawing.Point(559, 471);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 4;
            this.button_Cancelar.Text = "&Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Locar
            // 
            this.button_Locar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Locar.Location = new System.Drawing.Point(640, 471);
            this.button_Locar.Name = "button_Locar";
            this.button_Locar.Size = new System.Drawing.Size(75, 23);
            this.button_Locar.TabIndex = 5;
            this.button_Locar.Text = "&Locar";
            this.button_Locar.UseVisualStyleBackColor = true;
            this.button_Locar.Click += new System.EventHandler(this.button_Locar_Click);
            // 
            // button_Consultar
            // 
            this.button_Consultar.Location = new System.Drawing.Point(588, 22);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(129, 23);
            this.button_Consultar.TabIndex = 2;
            this.button_Consultar.Text = "CONSULTAR";
            this.button_Consultar.UseVisualStyleBackColor = true;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // maskedTextBox_Cod_Cliente
            // 
            this.maskedTextBox_Cod_Cliente.Location = new System.Drawing.Point(12, 35);
            this.maskedTextBox_Cod_Cliente.Mask = "999999";
            this.maskedTextBox_Cod_Cliente.Name = "maskedTextBox_Cod_Cliente";
            this.maskedTextBox_Cod_Cliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Cod_Cliente.TabIndex = 0;
            this.maskedTextBox_Cod_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Cod_Cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            // 
            // radioButton_Cod_Cliente
            // 
            this.radioButton_Cod_Cliente.AutoSize = true;
            this.radioButton_Cod_Cliente.Checked = true;
            this.radioButton_Cod_Cliente.Location = new System.Drawing.Point(15, 12);
            this.radioButton_Cod_Cliente.Name = "radioButton_Cod_Cliente";
            this.radioButton_Cod_Cliente.Size = new System.Drawing.Size(93, 17);
            this.radioButton_Cod_Cliente.TabIndex = 14;
            this.radioButton_Cod_Cliente.TabStop = true;
            this.radioButton_Cod_Cliente.Text = "Código Cliente";
            this.radioButton_Cod_Cliente.UseVisualStyleBackColor = true;
            this.radioButton_Cod_Cliente.CheckedChanged += new System.EventHandler(this.radioButton_Cod_Cliente_CheckedChanged);
            // 
            // radioButton_Nome_Cliente
            // 
            this.radioButton_Nome_Cliente.AutoSize = true;
            this.radioButton_Nome_Cliente.Location = new System.Drawing.Point(118, 12);
            this.radioButton_Nome_Cliente.Name = "radioButton_Nome_Cliente";
            this.radioButton_Nome_Cliente.Size = new System.Drawing.Size(103, 17);
            this.radioButton_Nome_Cliente.TabIndex = 15;
            this.radioButton_Nome_Cliente.TabStop = true;
            this.radioButton_Nome_Cliente.Text = "Nome do Cliente";
            this.radioButton_Nome_Cliente.UseVisualStyleBackColor = true;
            this.radioButton_Nome_Cliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form_Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 506);
            this.Controls.Add(this.radioButton_Nome_Cliente);
            this.Controls.Add(this.radioButton_Cod_Cliente);
            this.Controls.Add(this.maskedTextBox_Cod_Cliente);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.button_Locar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nome_Cliente);
            this.Controls.Add(this.listView_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form_Locacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.Form_Locacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Locacao_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nome_Cliente;
        private System.Windows.Forms.ListView listView_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Locar;
        private System.Windows.Forms.ColumnHeader coluna_cod;
        private System.Windows.Forms.ColumnHeader coluna_nome;
        private System.Windows.Forms.ColumnHeader coluna_titular;
        private System.Windows.Forms.ColumnHeader coluna_Status;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cod_Cliente;
        private System.Windows.Forms.RadioButton radioButton_Cod_Cliente;
        private System.Windows.Forms.RadioButton radioButton_Nome_Cliente;
    }
}