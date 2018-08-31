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
    public partial class Form_Devolucao : Form
    {

        private int CODIGOCLIENTE;
        private int CODIGODEPENDENTE;
        private double CREDITO;
        private double MULTA;
        private double SALDO;
        private double DINHEIRO;
        private double TROCO;
        Dictionary<string, double> DIC_CAT_PRECOS = new Dictionary<string, double>();

        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        
        
        public Form_Devolucao()
        {
            InitializeComponent();
        }

        private void Form_Devolucao_Load(object sender, EventArgs e)
        {
            
        }


        private void Metodo_Carregar_Cliente()
        {

            // Rotina de Locações por dependentes // 

            if (CODIGODEPENDENTE >= 10000)
            {

                try
                {

                    CONEXAO.Open();
                                        
                    SqlCommand CONSULTADEPENDENTE = new SqlCommand("SELECT DEPENDENTES.DEP_Nome FROM DEPENDENTES WHERE DEPENDENTES.DEP_Cod = @COD_DEP ", CONEXAO);
                    SqlParameter CD1 = new SqlParameter("@COD_DEP", CODIGODEPENDENTE);
                    CONSULTADEPENDENTE.Parameters.Add(CD1);
                    LEITOR = null;
                    LEITOR = CONSULTADEPENDENTE.ExecuteReader();

                    while (LEITOR.Read())
                    {
                        textBox_Dependente.Text = LEITOR["DEP_Nome"].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Houve um problema ao consultar o dependente do titular");
                }
                finally
                {
                    if (LEITOR != null)
                    {
                        LEITOR.Close();
                    }

                    if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                        CONEXAO.Close();
                }
            }


            // Rotinas para carregar os dados do cliente vinculado a locação //

            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTACLIENTE = new SqlCommand("SELECT CLIENTES.CLI_Nome, CLIENTES.CLI_Status, CLIENTES.CLI_Data, CLIENTES.CLI_Nasc, CLIENTES.CLI_SALDO, CLIENTES.CLI_Foto, CLIENTES.CLI_Sexo from CLIENTES WHERE CLIENTES.CLI_COD =  @COD_CLIENTE;", CONEXAO);
                SqlParameter CL1 = new SqlParameter("@COD_CLIENTE", CODIGOCLIENTE);
                CONSULTACLIENTE.Parameters.Add(CL1);
                LEITOR = null;
                LEITOR = CONSULTACLIENTE.ExecuteReader();

                while (LEITOR.Read())
                {

                    label_Cod_Cli_Info.Text = CODIGOCLIENTE.ToString();
                    if (int.Parse(LEITOR["CLI_Status"].ToString()) == 0)
                    {
                        label_Status_Info.Text = "ATIVO";
                    }
                    else
                        label_Status_Info.Text = "INATIVO";

                    textBox_Cliente_Desde.Text = LEITOR["CLI_Data"].ToString();
                    textBox_Nome_CLi.Text = LEITOR["CLI_Nome"].ToString();

                    if (LEITOR["CLI_Foto"].ToString() != " ")
                    {
                        pictureBox_Cliente.Image = Bitmap.FromFile(LEITOR["CLI_Foto"].ToString());
                    }
                    else
                    {
                        if (LEITOR["CLI_Sexo"].ToString() == "M")
                        {
                            pictureBox_Cliente.Image = Properties.Resources.masculino;
                        }
                        else
                        {
                            pictureBox_Cliente.Image = Properties.Resources.feminino;
                        }
                    }

                    CREDITO = double.Parse(LEITOR["CLI_Saldo"].ToString());
                    textBox_Cli_Credito.Text = CREDITO.ToString();

                }
            }

            catch
            {
                MessageBox.Show("Hove um problema ao carregar o cliente");
            }
            finally
            {
                if (LEITOR != null)
                {
                    LEITOR.Close();
                }

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }


            MetodoConsulta_Filmes_Locados();
            METODO_ATUALIZACAO_LOCACAO();

        }


        // Método para carregar os filmes locados pelo cliente //

        private void MetodoConsulta_Filmes_Locados()
        {

            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTA_FILME = new SqlCommand("SELECT CODFILMES.COD_Cod, FILMES.FIL_Titulo, LOCACOES.LOC_Data_Loc, LOCACOES.LOC_Data_Dev, CATALOGO_PRECOS.CAT_DESCRICAO, LOCACOES.LOC_Valor, DATEDIFF(DAY, LOCACOES.LOC_Data_Dev, GETDATE()) as ATRASO FROM CODFILMES INNER JOIN FILMES ON CODFILMES.FIL_Cod = FILMES.FIL_Cod INNER JOIN LOCACOES ON CODFILMES.COD_Cod = LOCACOES.COD_Cod INNER JOIN CATALOGO_PRECOS	ON CATALOGO_PRECOS.CAT_Cod = FILMES.CAT_Cod WHERE LOCACOES.LOC_Status = 0 AND LOCACOES.CLI_Cod = @CODIGO_CLIENTE", CONEXAO);
                SqlParameter CFL = new SqlParameter("@CODIGO_CLIENTE", CODIGOCLIENTE);
                CONSULTA_FILME.Parameters.Add(CFL);
                                
                LEITOR = null;
                LEITOR = CONSULTA_FILME.ExecuteReader();

                listView_Filmes_locados.Items.Clear();

                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_FILMES = new ListViewItem(LEITOR["COD_Cod"].ToString());

                    ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem DATA_LOCACAO = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem DATA_DEVOLUCAO = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem CATEGORIA = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem VALOR = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem ATRASO_DEV = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem MULTA = new ListViewItem.ListViewSubItem();
                    

                    TITULO_FILME.Text = LEITOR["FIL_Titulo"].ToString();
                    CODIGO_FILMES.SubItems.Add(TITULO_FILME);

                    DATA_LOCACAO.Text = LEITOR["LOC_Data_Loc"].ToString();
                    CODIGO_FILMES.SubItems.Add(DATA_LOCACAO);

                    DATA_DEVOLUCAO.Text = LEITOR["LOC_Data_Dev"].ToString();
                    CODIGO_FILMES.SubItems.Add(DATA_DEVOLUCAO);
                    
                    CATEGORIA.Text = LEITOR["CAT_Descricao"].ToString();
                    CODIGO_FILMES.SubItems.Add(CATEGORIA);

                    VALOR.Text = LEITOR["LOC_Valor"].ToString();
                    CODIGO_FILMES.SubItems.Add(VALOR);

                    if (int.Parse(LEITOR["ATRASO"].ToString()) > 0)
                    {
                        ATRASO_DEV.Text = LEITOR["ATRASO"].ToString();
                    }
                    else
                        ATRASO_DEV.Text = "0";

                    CODIGO_FILMES.SubItems.Add(ATRASO_DEV);

                    if (int.Parse(LEITOR["ATRASO"].ToString()) > 0)
                    {
                        MULTA.Text = (int.Parse(LEITOR["ATRASO"].ToString()) * double.Parse(LEITOR["LOC_Valor"].ToString())).ToString();
                    }
                    else
                        MULTA.Text = "0.00";

                    CODIGO_FILMES.SubItems.Add(MULTA);

                    listView_Filmes_locados.Items.Add(CODIGO_FILMES);

                }

            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar os FILMES", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }
              

        

        // Metodo para relacionar o código do filme consultado ao código do cliente que alugou o mesmo //

        private void Metodo_Consulta_Locacoes()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTA_LOCACOES = new SqlCommand("SELECT LOCACOES.CLI_Cod, LOCACOES.LOC_Dep FROM LOCACOES WHERE LOCACOES.LOC_Status = 0 AND LOCACOES.COD_Cod = @COD_FILME;", CONEXAO);
                SqlParameter CF1 = new SqlParameter("@COD_FILME", int.Parse(maskedTextBox_Cod_Filme.Text.Replace("_", "")));
                CONSULTA_LOCACOES.Parameters.Add(CF1);
                LEITOR = null;
                LEITOR = CONSULTA_LOCACOES.ExecuteReader();
                                
                while (LEITOR.Read())
                {
                    CODIGOCLIENTE = int.Parse(LEITOR["CLI_Cod"].ToString());
                    CODIGODEPENDENTE = int.Parse(LEITOR["LOC_Dep"].ToString());                           
                }
            }

            catch
            {
                MessageBox.Show("Hove um problema ao carregar o codigo do cliente vinculado ao filme");
            }
            finally
            {
                if (LEITOR != null)
                {
                    LEITOR.Close();
                }

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }

            Metodo_Carregar_Cliente();
        }


        
        
        // Metodo para selecionar os filmes que serão devolvidos // 
        
        
        private void Metodo_Selecionar_Filmes()
        {                                   
            

            if (listView_Filmes_locados.SelectedItems.Count != 0)
            {
                
                ListViewItem CODIGO_FILMES = new ListViewItem(listView_Filmes_locados.SelectedItems[0].Text);

                ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem DATA_LOCACAO = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem DATA_DEVOLUCAO = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem CATEGORIA = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem VALOR = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem ATRASO_DEV = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem MULTA = new ListViewItem.ListViewSubItem();

                TITULO_FILME.Text = listView_Filmes_locados.SelectedItems[0].SubItems[1].Text;
                CODIGO_FILMES.SubItems.Add(TITULO_FILME);

                DATA_LOCACAO.Text = listView_Filmes_locados.SelectedItems[0].SubItems[2].Text;
                CODIGO_FILMES.SubItems.Add(DATA_LOCACAO);

                DATA_DEVOLUCAO.Text = listView_Filmes_locados.SelectedItems[0].SubItems[3].Text;
                CODIGO_FILMES.SubItems.Add(DATA_DEVOLUCAO);

                CATEGORIA.Text = listView_Filmes_locados.SelectedItems[0].SubItems[4].Text;
                CODIGO_FILMES.SubItems.Add(CATEGORIA);

                VALOR.Text = listView_Filmes_locados.SelectedItems[0].SubItems[5].Text; ;
                CODIGO_FILMES.SubItems.Add(VALOR);

                ATRASO_DEV.Text = listView_Filmes_locados.SelectedItems[0].SubItems[6].Text; ;
                CODIGO_FILMES.SubItems.Add(ATRASO_DEV);

                MULTA.Text = listView_Filmes_locados.SelectedItems[0].SubItems[7].Text; ;
                CODIGO_FILMES.SubItems.Add(MULTA);

                listView_Filmes_Devolvidos.Items.Add(CODIGO_FILMES);

                listView_Filmes_locados.SelectedItems[0].Remove();

                METODO_ATUALIZACAO_LOCACAO();

            }
        }


        // Metodo  de disparo para a tecla enter //

        private void Form_Devolucao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Filme.Focused == true)
                    {
                        if (maskedTextBox_Cod_Filme.Text.Replace("_", "") != "")
                        {
                            Metodo_Consulta_Locacoes();
                        }
                    }                    
                    if (listView_Filmes_locados.Focused == true)
                    {
                        Metodo_Selecionar_Filmes();
                    }

                    if (textBox_Dinheiro.Focused == true)
                    {
                        METODO_ATUALIZACAO_LOCACAO();
                    }



                    break;
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_Cod_Filme.Text.Replace("_", "") != "")
            {   
                Metodo_Consulta_Locacoes();
            }            
        }

        private void pictureBoxIncluir_Click(object sender, EventArgs e)
        {
            Metodo_Selecionar_Filmes();
        }

        private void listView_Filmes_locados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metodo_Selecionar_Filmes();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Selecionar_Filmes();
        }

        private void visualizarCapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_Filmes_locados.SelectedItems.Count != 0)
            {
                Form_Visualizar_Filmes VISUALIZA_FILME = new Form_Visualizar_Filmes(int.Parse(listView_Filmes_locados.SelectedItems[0].Text));
                VISUALIZA_FILME.ShowDialog();
            }
        }

        private void listView_Filmes_locados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Metodo_Selecionar_Filmes();
        }



        // Metodo para finalizar as locações //


        private void button_Finalizar_Click(object sender, EventArgs e)
        {

            METODO_ATUALIZACAO_LOCACAO();

            if (listView_Filmes_Devolvidos.Items.Count != 0)
            {

                try
                {

                    CONEXAO.Open();

                    for (int I = 0; I < listView_Filmes_Devolvidos.Items.Count; I++)
                    {

                        SqlCommand FINALIZAR_LOCACAO = new SqlCommand("UPDATE LOCACOES SET LOCACOES.LOC_Status = 1, LOCACOES.LOC_Data_Devulacao = GETDATE() WHERE LOCACOES.COD_Cod = @COD_CODIDO;", CONEXAO);
                        SqlParameter FL1 = new SqlParameter("@COD_CODIDO", listView_Filmes_Devolvidos.Items[I].Text);
                        FINALIZAR_LOCACAO.Parameters.Add(FL1);
                        FINALIZAR_LOCACAO.ExecuteNonQuery();


                        SqlCommand ALTERAR_STATUS = new SqlCommand("UPDATE CODFILMES SET CODFILMES.COD_Status = 0 WHERE CODFILMES.COD_Cod = @COD_FIL;", CONEXAO);
                        SqlParameter ACF1 = new SqlParameter("@COD_FIL", listView_Filmes_Devolvidos.Items[I].Text);
                        ALTERAR_STATUS.Parameters.Add(ACF1);
                        ALTERAR_STATUS.ExecuteNonQuery();


                        if (TROCO <= 0)
                        {
                            SqlCommand ALTERAR_SALDO_CLI = new SqlCommand("UPDATE CLIENTES SET CLIENTES.CLI_Saldo = @SALDO_CLI WHERE CLIENTES.CLI_Cod = @CODI_CLI;", CONEXAO);
                            SqlParameter ACS = new SqlParameter("@SALDO_CLI", TROCO);
                            SqlParameter ACS1 = new SqlParameter("@CODI_CLI", CODIGOCLIENTE);
                            ALTERAR_SALDO_CLI.Parameters.Add(ACS);
                            ALTERAR_SALDO_CLI.Parameters.Add(ACS1);
                            ALTERAR_SALDO_CLI.ExecuteNonQuery();
                        }
                        else
                        {
                            if (checkBox_Creditar.Checked == true)
                            {
                                SqlCommand ALTERAR_SALDO_CLI = new SqlCommand("UPDATE CLIENTES SET CLIENTES.CLI_Saldo = @SALDO_CLI WHERE CLIENTES.CLI_Cod = @CODI_CLI;", CONEXAO);
                                SqlParameter ACS = new SqlParameter("@SALDO_CLI", TROCO);
                                SqlParameter ACS1 = new SqlParameter("@CODI_CLI", CODIGOCLIENTE);
                                ALTERAR_SALDO_CLI.Parameters.Add(ACS);
                                ALTERAR_SALDO_CLI.Parameters.Add(ACS1);
                                ALTERAR_SALDO_CLI.ExecuteNonQuery();
                            }
                            else
                            {
                                TROCO = 0.0;
                                SqlCommand ALTERAR_SALDO_CLI = new SqlCommand("UPDATE CLIENTES SET CLIENTES.CLI_Saldo = @SALDO_CLI WHERE CLIENTES.CLI_Cod = @CODI_CLI;", CONEXAO);
                                SqlParameter ACS = new SqlParameter("@SALDO_CLI", TROCO);
                                SqlParameter ACS1 = new SqlParameter("@CODI_CLI", CODIGOCLIENTE);
                                ALTERAR_SALDO_CLI.Parameters.Add(ACS);
                                ALTERAR_SALDO_CLI.Parameters.Add(ACS1);
                                ALTERAR_SALDO_CLI.ExecuteNonQuery();
                            }


                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Houve um problema ao carregar a locação");
                }
                finally
                {
                    if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                        CONEXAO.Close();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione o filme para a devolução o clique em cancelar");
            }
        }



        // Metodo para atualizar os valores da devolução //

        private void METODO_ATUALIZACAO_LOCACAO()
        {
            MULTA = 0;

            for (int I = 0; I < listView_Filmes_Devolvidos.Items.Count; I++)
            {
                MULTA += double.Parse(listView_Filmes_Devolvidos.Items[I].SubItems[7].Text);
                textBox_Total_Loc.Text = MULTA.ToString();
            }

            if (MULTA > 0)
            {
                SALDO = CREDITO - MULTA;
            }
            else
                SALDO = CREDITO;
            textBox_Cli_Saldo.Text = SALDO.ToString();

            TROCO = double.Parse(textBox_Dinheiro.Text) - (-SALDO);
            textBox_Troco.Text = TROCO.ToString();
        }                         


    }
}
