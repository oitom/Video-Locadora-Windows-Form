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
    public partial class Form_Excluir_Cliente : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        public Form_Excluir_Cliente()
        {
            InitializeComponent();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            MetodoExcluirCliente();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metodo para funcionamento da tecla <ENTER>
        private void Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica qual o campo será filtrado o cliente
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Cliente.Focused == true || textBox_Nome_Cliente.Focused == true)
                        MetodoConsulta(); 
                    if (listView_Clientes.Focused == true)
                        MetodoExcluirCliente();
                break;
            }
        }

        private void MetodoExcluirCliente()
        {
            //verifica se foi selecionado algum cliente
            if (listView_Clientes.SelectedItems.Count != 0)
            {
                string Cod_Cli = listView_Clientes.SelectedItems[0].Text;
                
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja excluir esse cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    //cogido para exclusão de cliente
                    try
                    {
                        CONEXAO.Open();
                        SqlCommand COMANDODELETE_CLI_DEP = new SqlCommand("DELETE FROM DEPENDENTES WHERE CLI_Cod = @CLI_COD", CONEXAO);
                        SqlParameter COD_CLI = new SqlParameter("@CLI_COD", Cod_Cli);
                        COMANDODELETE_CLI_DEP.Parameters.Add(COD_CLI);
                        COMANDODELETE_CLI_DEP.ExecuteNonQuery();


                        SqlCommand COMANDODELETE_CLI = new SqlCommand("DELETE FROM CLIENTES WHERE CLI_Cod = @CLI_COD", CONEXAO);
                        SqlParameter COD_CLI_1 = new SqlParameter("@CLI_COD", Cod_Cli);
                        COMANDODELETE_CLI.Parameters.Add(COD_CLI_1);
                        COMANDODELETE_CLI.ExecuteNonQuery();

                        SqlCommand COMANDODELETE_CLI_END = new SqlCommand("DELETE FROM ENDERECOS WHERE ENDERECOS.END_Cod = @CLI_COD", CONEXAO);
                        SqlParameter COD_CLI_2 = new SqlParameter("@CLI_COD", Cod_Cli);
                        COMANDODELETE_CLI_END.Parameters.Add(COD_CLI_2);
                        COMANDODELETE_CLI_END.ExecuteNonQuery();
                       
                    }
                    catch
                    {
                        MessageBox.Show("erro em deletar cliente");
                    }
                    finally
                    {
                        if (CONEXAO.State == ConnectionState.Open)
                            CONEXAO.Close();
                        LEITOR.Close();

                        //após excluir o cliente, ele é limpado do list view
                        listView_Clientes.SelectedItems[0].Remove();
                        MessageBox.Show("Cliente excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maskedTextBox_Cod_Cliente.Text = "";
                        textBox_Nome_Cliente.Text = "";
                                
                    }
                }
            }
        }

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTACLIENTE;
                //Verifica qual campo será usado para filtra o cliente
                if (maskedTextBox_Cod_Cliente.Focused == true)
                {
                    //Seleciona os clientes aparti do código informado
                    CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Cod, CLIENTES.CLI_Nome, CLIENTES.CLI_RG, CLIENTES.CLI_CPF, CLIENTES.CLI_Nasc FROM CLIENTES WHERE CLI_Cod = @COD_CLI", CONEXAO);

                    SqlParameter CL1 = new SqlParameter("@COD_CLI", int.Parse(maskedTextBox_Cod_Cliente.Text));
                    CONSULTACLIENTE.Parameters.Add(CL1);
                }
                else
                {
                    //Seleciona os cliente apartir do nome informado
                    CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Cod, CLIENTES.CLI_Nome, CLIENTES.CLI_RG, CLIENTES.CLI_CPF, CLIENTES.CLI_Nasc FROM CLIENTES WHERE CLI_NOME like @NOME_CLI", CONEXAO);
                    SqlParameter CL1 = new SqlParameter("@NOME_CLI", "%" + textBox_Nome_Cliente.Text + "%");
                    CONSULTACLIENTE.Parameters.Add(CL1);

                }

                LEITOR = null;
                LEITOR = CONSULTACLIENTE.ExecuteReader();

                listView_Clientes.Items.Clear();

                //Preenche o list view com os dados do cliente
                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_CLIENTE = new ListViewItem(LEITOR["CLI_Cod"].ToString());

                    ListViewItem.ListViewSubItem NOME_CLIENTE = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem RG_CLIENTE = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem CPF_CLIENTE = new ListViewItem.ListViewSubItem();

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

        private void listView_Clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoExcluirCliente();
        }

    }
}
