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
    public partial class Form_Cliente_Consulta : Form
    {

        private int CODIGOCLIENTE;
        private int CODIGODEPENDENTE;
        Dictionary<string, double> DIC_CAT_PRECOS = new Dictionary<string, double>();
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        
        
        public Form_Cliente_Consulta(int CD_CLIENTE)
        {
            InitializeComponent();
            CODIGOCLIENTE = CD_CLIENTE;            
        }


        private void Form_Loc_Cliente_Load(object sender, EventArgs e)
        {
            // CARREGA O CATALOGO DE PRECOS NUM DICIONÁRIO //
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTA_CATALOGO = new SqlCommand("SELECT CATALOGO_PRECOS.CAT_DESCRICAO, CATALOGO_PRECOS.VAL_Valor FROM CATALOGO_PRECOS;", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTA_CATALOGO.ExecuteReader();

                while (LEITOR.Read())
                    DIC_CAT_PRECOS[LEITOR["CAT_DESCRICAO"].ToString()] = double.Parse(LEITOR["VAL_Valor"].ToString());
            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar o Catalogo de Preço");
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();
                

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
            // Rotina Para Locação por dependentes // 
            if (CODIGOCLIENTE >= 10000)
            {
                try
                {
                    CONEXAO.Open();
                    CODIGODEPENDENTE = CODIGOCLIENTE;

                    SqlCommand CONSULTADEPENDENTE = new SqlCommand("SELECT DEPENDENTES.DEP_Nome, DEPENDENTES.DEP_Dt_Nasc, DEPENDENTES.CLI_Cod FROM DEPENDENTES WHERE DEPENDENTES.DEP_Cod = @COD_DEP ", CONEXAO);
                    SqlParameter CD1 = new SqlParameter("@COD_DEP", CODIGODEPENDENTE);
                    CONSULTADEPENDENTE.Parameters.Add(CD1);
                    LEITOR = null;
                    LEITOR = CONSULTADEPENDENTE.ExecuteReader();
                    while (LEITOR.Read())
                    {
                        textBox_Dependente.Text = LEITOR["DEP_Nome"].ToString();
                        CODIGOCLIENTE = int.Parse(LEITOR["CLI_Cod"].ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("Houve um problema ao consultar o dependente do titular");
                }
                finally
                {
                    if (LEITOR != null)
                        LEITOR.Close();
                    
                    if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                        CONEXAO.Close();
                }
            }

            // Informações do titular para vincular a locação //
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Nome, CLIENTES.CLI_Status, CLIENTES.CLI_Data, CLIENTES.CLI_Nasc, CLIENTES.CLI_SALDO, CLIENTES.CLI_Foto from CLIENTES WHERE CLIENTES.CLI_Cod = @COD_CLI ", CONEXAO);
                SqlParameter CL1 = new SqlParameter("@COD_CLI", CODIGOCLIENTE);
                CONSULTACLIENTE.Parameters.Add(CL1);
                LEITOR = null;
                LEITOR = CONSULTACLIENTE.ExecuteReader();
                
                while (LEITOR.Read())
                {

                    textBoxCod_cli.Text = CODIGOCLIENTE.ToString();
                    if (int.Parse(LEITOR["CLI_Status"].ToString()) == 0)
                        textBoxStatus.Text = "ATIVO";
                    else
                        textBoxStatus.Text = "INATIVO";

                    textBox_Cliente_Desde.Text = LEITOR["CLI_Data"].ToString();
                    textBox_Nome_CLi.Text = LEITOR["CLI_Nome"].ToString();

                    if (LEITOR["CLI_Foto"].ToString() != " ")
                        pictureBox_Cliente.Image = Bitmap.FromFile(LEITOR["CLI_Foto"].ToString());
                }
            }
                        
            catch
            {
                MessageBox.Show("Hove um problema ao carregar o cliente");
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();
                

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }

            //Preechimento do list view com os dados das locações feitas pelo cliente
            try
            {
                CONEXAO.Open();
                SqlCommand COMANDO_SELECT_CONSULTA = new SqlCommand("SELECT LOC_Data_Loc, LOC_Data_Dev, FIL_Titulo, GEN_Desc, FIL_Classificacao, TIP_Desc, CAT_DESCRICAO, LOC_Valor FROM CODFILMES INNER JOIN FILMES ON CODFILMES.FIL_Cod = FILMES.FIL_Cod INNER JOIN TIPOS_MIDIAS ON TIPOS_MIDIAS.TIP_Cod = CODFILMES.TIP_Cod INNER JOIN GENEROS ON GENEROS.GEN_Cod = FILMES.GEN_Cod INNER JOIN LOCACOES ON CODFILMES.COD_Cod = LOCACOES.COD_Cod INNER JOIN CATALOGO_PRECOS	ON CATALOGO_PRECOS.CAT_Cod = FILMES.CAT_Cod WHERE LOCACOES.CLI_Cod = @CLI_COD", CONEXAO);
                SqlParameter CLI_COD = new SqlParameter("@CLI_COD", CODIGOCLIENTE);
                COMANDO_SELECT_CONSULTA.Parameters.Add(CLI_COD);
                
                LEITOR = null;
                LEITOR = COMANDO_SELECT_CONSULTA.ExecuteReader();

                listView_Filmes_Disponiveis.Items.Clear();

                while (LEITOR.Read())
                {
                    ListViewItem DT_LOCACAO = new ListViewItem(LEITOR["LOC_Data_Loc"].ToString());

                    ListViewItem.ListViewSubItem DATA_DEVOLUCAO = new ListViewItem.ListViewSubItem();
                    DATA_DEVOLUCAO.Text = LEITOR["LOC_Data_Dev"].ToString();
                    DT_LOCACAO.SubItems.Add(DATA_DEVOLUCAO);

                    ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();
                    TITULO_FILME.Text = LEITOR["FIL_Titulo"].ToString();
                    DT_LOCACAO.SubItems.Add(TITULO_FILME);

                    ListViewItem.ListViewSubItem GENERO = new ListViewItem.ListViewSubItem();
                    GENERO.Text = LEITOR["GEN_Desc"].ToString();
                    DT_LOCACAO.SubItems.Add(GENERO);

                    ListViewItem.ListViewSubItem CLASSIFICACAO = new ListViewItem.ListViewSubItem();
                    CLASSIFICACAO.Text = LEITOR["FIL_Classificacao"].ToString();
                    DT_LOCACAO.SubItems.Add(CLASSIFICACAO);

                    ListViewItem.ListViewSubItem TIPO = new ListViewItem.ListViewSubItem();
                    TIPO.Text = LEITOR["TIP_Desc"].ToString();
                    DT_LOCACAO.SubItems.Add(TIPO);

                    ListViewItem.ListViewSubItem CATEGORIA = new ListViewItem.ListViewSubItem();
                    CATEGORIA.Text = LEITOR["CAT_DESCRICAO"].ToString();
                    DT_LOCACAO.SubItems.Add(CATEGORIA);

                    ListViewItem.ListViewSubItem VALOR = new ListViewItem.ListViewSubItem();
                    VALOR.Text = LEITOR["LOC_Valor"].ToString();
                    DT_LOCACAO.SubItems.Add(VALOR);

                    
                    listView_Filmes_Disponiveis.Items.Add(DT_LOCACAO);
                }

            }
            catch
            {
                MessageBox.Show("Erro em preencher o list View");
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();
                
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }

        private void textBoxCod_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nome_CLi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dependente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Cliente_Desde_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxAviso_TextChanged(object sender, EventArgs e)
        {

        }



    }
}




















