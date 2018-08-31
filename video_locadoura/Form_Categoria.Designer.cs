namespace video_locadora
{
    partial class Form_Categoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Normal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Lançamento = new System.Windows.Forms.TextBox();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Promocional = new System.Windows.Forms.TextBox();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normal";
            // 
            // textBox_Normal
            // 
            this.textBox_Normal.Location = new System.Drawing.Point(12, 25);
            this.textBox_Normal.Name = "textBox_Normal";
            this.textBox_Normal.ReadOnly = true;
            this.textBox_Normal.Size = new System.Drawing.Size(156, 20);
            this.textBox_Normal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lançamento";
            // 
            // textBox_Lançamento
            // 
            this.textBox_Lançamento.Location = new System.Drawing.Point(12, 64);
            this.textBox_Lançamento.Name = "textBox_Lançamento";
            this.textBox_Lançamento.ReadOnly = true;
            this.textBox_Lançamento.Size = new System.Drawing.Size(156, 20);
            this.textBox_Lançamento.TabIndex = 3;
            // 
            // button_Alterar
            // 
            this.button_Alterar.Location = new System.Drawing.Point(93, 129);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(75, 23);
            this.button_Alterar.TabIndex = 4;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = true;
            this.button_Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Promocional";
            // 
            // textBox_Promocional
            // 
            this.textBox_Promocional.Location = new System.Drawing.Point(15, 103);
            this.textBox_Promocional.Name = "textBox_Promocional";
            this.textBox_Promocional.ReadOnly = true;
            this.textBox_Promocional.Size = new System.Drawing.Size(153, 20);
            this.textBox_Promocional.TabIndex = 6;
            // 
            // button_Salvar
            // 
            this.button_Salvar.Enabled = false;
            this.button_Salvar.Location = new System.Drawing.Point(12, 129);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar.TabIndex = 7;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // Form_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 164);
            this.Controls.Add(this.button_Salvar);
            this.Controls.Add(this.textBox_Promocional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Alterar);
            this.Controls.Add(this.textBox_Lançamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Normal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Form_Categoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Normal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Lançamento;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Promocional;
        private System.Windows.Forms.Button button_Salvar;
    }
}