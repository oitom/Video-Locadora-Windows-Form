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
    public partial class Form_Altera_Cliente : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        public Form_Altera_Cliente()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void Consultar_Click(object sender, EventArgs e)
        {
            MetodoConsulta();
        }

        private void listView_Clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoAlteraCliente();
        }

        private void Locacao_Key(object sender, KeyEventArgs e)
        {
            //após o cliente informar o código ou o nome, ao apertar enter chama o método de alteração do cliente

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if ( maskedTextBox_Cod_Cliente.Focused == true || textBox_Nome_Cliente.Focused == true)
                    {
                        MetodoConsulta(); 
                    }
                    if (listView_Clientes.Focused == true)
                    {
                        MetodoAlteraCliente();
                    }
                    break;
            }
        }


        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTACLIENTE;
                
                //faz a busca do cliente pelo código informado 
                if (maskedTextBox_Cod_Cliente.Focused == true)
                {
                    CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Cod, CLIENTES.CLI_Nome, CLIENTES.CLI_RG, CLIENTES.CLI_CPF, CLIENTES.CLI_Nasc FROM CLIENTES WHERE CLI_Cod = @COD_CLI", CONEXAO);

                    SqlParameter CL1 = new SqlParameter("@COD_CLI", int.Parse(maskedTextBox_Cod_Cliente.Text));
                    CONSULTACLIENTE.Parameters.Add(CL1);
                }
                else
                {
                    //faz a busca do cliente pelo nome informado
                    CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Cod, CLIENTES.CLI_Nome, CLIENTES.CLI_RG, CLIENTES.CLI_CPF, CLIENTES.CLI_Nasc FROM CLIENTES WHERE CLI_NOME like @NOME_CLI", CONEXAO);
                    SqlParameter CL1 = new SqlParameter("@NOME_CLI", "%" + textBox_Nome_Cliente.Text + "%" );
                    CONSULTACLIENTE.Parameters.Add(CL1);
                
                }

                LEITOR = null;
                LEITOR = CONSULTACLIENTE.ExecuteReader();

                listView_Clientes.Items.Clear();

                //adiciona no list view os dados do cliente
                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_CLIENTE = new ListViewItem(LEITOR["CLI_Cod"].ToString());

                    ListViewItem.ListViewSubItem NOME_CLIENTE = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem RG_CLIENTE = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem CPF_CLIENTE  = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem DTNasc_CLIENTE = new ListViewItem.ListViewSubItem();

                    NOME_CLIENTE.Text = LEITOR["CLI_Nome"].ToString();
                    CODIGO_CLIENTE.SubItems.Add(NOME_CLIENTE);

                    RG_CLIENTE.Text = LEITOR["CLI_RG"].ToString();
                    CODIGO_CLIENTE.SubItems.Add(RG_CLIENTE);

                    CPF_CLIENTE.Text = LEITOR["CLI_CPF"].ToString();
                    CODIGO_CLIENTE.SubItems.Add(CPF_CLIENTE);

                    DTNasc_CLIENTE.Text = LEITOR["CLI_Nasc"].ToString();
                    string DT = DTNasc_CLIENTE.Text;
                    string DT_NAS = DT.Substring(0, 10);
                    CODIGO_CLIENTE.SubItems.Add(DT_NAS);                    

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

        private void MetodoAlteraCliente()
        {
            //Verifica se foi selecinado algum cliente do list view
            if (listView_Clientes.SelectedItems.Count != 0)
            {
                //chama o formulario de atualização de cliente onde é passado como parâmetro  o código do cliente
                Form_Atualiza_Cliente formulario_Atualiza_cliente = new Form_Atualiza_Cliente(int.Parse(listView_Clientes.SelectedItems[0].Text));
                formulario_Atualiza_cliente.ShowDialog();
                //limpa a lista após alterar o cliente
                listView_Clientes.Items.Clear();
                textBox_Nome_Cliente.Text = "";
                maskedTextBox_Cod_Cliente.Text = "";
            }
        }

        private void Locar(object sender, EventArgs e)
        {
            MetodoAlteraCliente();
        }

        private void Form_Altera_Cliente_Load(object sender, EventArgs e)
        {

        }
     }
}
