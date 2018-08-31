using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace video_locadora
{
    public partial class Form_Consulta_Cliente : Form
    {

        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        
        public Form_Consulta_Cliente()
        {
            InitializeComponent();
        }
        

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTACLIENTE;

                if (radioButton_Cod_Cliente.Checked == true)
                {
                    CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Cod, CLIENTES.CLI_Nome, CLIENTES.CLI_Status from CLIENTES WHERE CLIENTES.CLI_Cod = @COD_CLI UNION SELECT DEPENDENTES.DEP_Cod, DEPENDENTES.DEP_Nome, CLIENTES.CLI_Status from DEPENDENTES inner join CLIENTES on DEPENDENTES.CLI_Cod = CLIENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @COD_CLI;", CONEXAO);

                    SqlParameter CL1 = new SqlParameter("@COD_CLI", int.Parse(maskedTextBox_Cod_Cliente.Text));
                    CONSULTACLIENTE.Parameters.Add(CL1);
                }
                else
                {
                    CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Cod, CLIENTES.CLI_Nome, CLIENTES.CLI_Status FROM CLIENTES WHERE CLIENTES.CLI_NOME like @NOME_CLI UNION SELECT DEPENDENTES.DEP_Cod, DEPENDENTES.DEP_Nome, CLIENTES.CLI_Status FROM DEPENDENTES inner join CLIENTES on DEPENDENTES.CLI_Cod = CLIENTES.CLI_Cod WHERE DEPENDENTES.DEP_Nome like @NOME_CLI ORDER BY CLIENTES.CLI_Nome;", CONEXAO);
                    SqlParameter CL1 = new SqlParameter("@NOME_CLI", "%" + textBox_Nome_Cliente.Text + "%");
                    CONSULTACLIENTE.Parameters.Add(CL1);

                }


                LEITOR = null;
                LEITOR = CONSULTACLIENTE.ExecuteReader();

                listView_Clientes.Items.Clear();

                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_CLIENTE = new ListViewItem(LEITOR["CLI_Cod"].ToString());

                    ListViewItem.ListViewSubItem NOME_CLIENTE = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem TITULAR_CLIENTE = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem STATUS_CLIENTE = new ListViewItem.ListViewSubItem();


                    NOME_CLIENTE.Text = LEITOR["CLI_Nome"].ToString();
                    CODIGO_CLIENTE.SubItems.Add(NOME_CLIENTE);

                    if (int.Parse(LEITOR["CLI_Cod"].ToString()) < 10.000)
                    {
                        TITULAR_CLIENTE.Text = "Titular";
                    }
                    else
                        TITULAR_CLIENTE.Text = "Dependente";

                    CODIGO_CLIENTE.SubItems.Add(TITULAR_CLIENTE);


                    if (LEITOR["CLI_Status"].ToString() == "0")
                    {
                        STATUS_CLIENTE.Text = "Ativo";
                    }
                    else
                        STATUS_CLIENTE.Text = "Inativo";

                    CODIGO_CLIENTE.SubItems.Add(STATUS_CLIENTE);

                    listView_Clientes.Items.Add(CODIGO_CLIENTE);

                }

            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar os Clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }



        // METODO QUE DIRECIONA PARA A LOCACAO DE FILMEL //

        private void MetodoLocarFilme()
        {

            if (listView_Clientes.SelectedItems.Count != 0)
            {
                Form_Cliente_Consulta Form = new Form_Cliente_Consulta(int.Parse(listView_Clientes.SelectedItems[0].Text));
                Form.ShowDialog();
                this.Close();
               
            }
        }



        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Locar_Click(object sender, EventArgs e)
        {
            MetodoLocarFilme();
        }


        private void listView_Clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoLocarFilme();
        }

        private void Form_Locacao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Cliente.Focused == true)
                    {
                        if (maskedTextBox_Cod_Cliente.Text.Replace("_", "") != "")
                        {
                            MetodoConsulta();
                        }
                    }
                    if (textBox_Nome_Cliente.Focused == true)
                    {
                        if (textBox_Nome_Cliente.Text != "")
                        {
                            MetodoConsulta();
                        }
                    }
                    if (listView_Clientes.Focused == true)
                    {
                        MetodoLocarFilme();
                    }
                    break;
            }
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {

            if (radioButton_Cod_Cliente.Checked == true)
            {
                if (maskedTextBox_Cod_Cliente.Text.Replace("_", "") != "")
                {
                    MetodoConsulta();
                }
            }
            if (radioButton_Nome_Cliente.Checked == true)
            {
                if (textBox_Nome_Cliente.Text != "")
                {
                    MetodoConsulta();
                }
            }
        }


        private void radioButton_Cod_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_Cod_Cliente.Enabled = true;
            maskedTextBox_Cod_Cliente.Focus();
            textBox_Nome_Cliente.Enabled = false;
        }

        private void radioButton_Nome_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Nome_Cliente.Enabled = true;
            textBox_Nome_Cliente.Focus();
            maskedTextBox_Cod_Cliente.Enabled = false;
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectionStart = 0;
                ((TextBox)sender).SelectAll();
            }
            if (sender is MaskedTextBox)
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
                ((MaskedTextBox)sender).SelectAll();
            }

        }

        private void Form_Consulta_Cliente_Load(object sender, EventArgs e)
        {

        }

                       


    }
}
