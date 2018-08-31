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
    public partial class Form_Loc_Cliente : Form
    {

        private int CODIGOCLIENTE;
        private int CODIGODEPENDENTE;
        private string NASC_CLI;
        private string NASC_DEP;
        private double CREDITO;
        private double TOTAL;
        private double SALDO;
        private double DINHEIRO;
        private double TROCO;
        Dictionary<string, double> DIC_CAT_PRECOS = new Dictionary<string, double>();
        

        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        
        
        public Form_Loc_Cliente(int CD_CLIENTE)
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
                {
                    DIC_CAT_PRECOS[LEITOR["CAT_DESCRICAO"].ToString()] = double.Parse(LEITOR["VAL_Valor"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar o Catalogo de Preço");
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
                        NASC_DEP = LEITOR["DEP_Dt_Nasc"].ToString();
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
                    {
                        LEITOR.Close();
                    }  

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
                    
                    NASC_CLI = LEITOR["CLI_Nasc"].ToString();
                    
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
        }



        // Carrega a lista de Filmes //

        

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTAFILME;

                if ( radioButton_Cod_Filme.Checked == true)
                {
                    CONSULTAFILME = new SqlCommand("SELECT CODFILMES.COD_Cod, FILMES.FIL_Titulo, GENEROS.GEN_Desc, FILMES.FIL_Classificacao, CATALOGO_PRECOS.CAT_DESCRICAO, TIPOS_MIDIAS.TIP_Desc, CODFILMES.COD_Status FROM CODFILMES INNER JOIN FILMES ON CODFILMES.FIL_Cod = FILMES.FIL_Cod INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod INNER JOIN CATALOGO_PRECOS ON FILMES.CAT_Cod = CATALOGO_PRECOS.CAT_Cod INNER JOIN TIPOS_MIDIAS ON CODFILMES.TIP_Cod = TIPOS_MIDIAS.TIP_Cod WHERE CODFILMES.COD_Cod = @COD_FIL;", CONEXAO);
                    SqlParameter CF1 = new SqlParameter("@COD_FIL", int.Parse(maskedTextBox_Cod_Filme.Text));
                    CONSULTAFILME.Parameters.Add(CF1);
                }
                else
                {
                    CONSULTAFILME = new SqlCommand("SELECT CODFILMES.COD_Cod, FILMES.FIL_Titulo, GENEROS.GEN_Desc, FILMES.FIL_Classificacao, CATALOGO_PRECOS.CAT_DESCRICAO, TIPOS_MIDIAS.TIP_Desc, CODFILMES.COD_Status FROM CODFILMES INNER JOIN FILMES ON CODFILMES.FIL_Cod = FILMES.FIL_Cod INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod INNER JOIN CATALOGO_PRECOS ON FILMES.CAT_Cod = CATALOGO_PRECOS.CAT_Cod INNER JOIN TIPOS_MIDIAS ON CODFILMES.TIP_Cod = TIPOS_MIDIAS.TIP_Cod WHERE FILMES.FIL_TITULO like @NOME_FIL ORDER BY FILMES.FIL_TITULO", CONEXAO);
                    SqlParameter CF1 = new SqlParameter("@NOME_FIL", "%" + textBox_Nome_Filme.Text + "%");
                    CONSULTAFILME.Parameters.Add(CF1);

                }


                LEITOR = null;
                LEITOR = CONSULTAFILME.ExecuteReader();

                listView_Filmes_Disponiveis.Items.Clear();

                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_FILMES = new ListViewItem(LEITOR["COD_Cod"].ToString());

                    ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem GENERO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem CLASSIFICACAO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem TIPO_MIDIA = new ListViewItem.ListViewSubItem();
                    
                    ListViewItem.ListViewSubItem CATALOGO_PRECO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem STATUS_FILME = new ListViewItem.ListViewSubItem();


                    TITULO_FILME.Text = LEITOR["FIL_Titulo"].ToString();
                    CODIGO_FILMES.SubItems.Add(TITULO_FILME);
                    
                    GENERO_FILME.Text = LEITOR["GEN_Desc"].ToString();
                    CODIGO_FILMES.SubItems.Add(GENERO_FILME);

                    CLASSIFICACAO_FILME.Text = LEITOR["FIL_Classificacao"].ToString();
                    CODIGO_FILMES.SubItems.Add(CLASSIFICACAO_FILME);

                    TIPO_MIDIA.Text = LEITOR["TIP_Desc"].ToString();
                    CODIGO_FILMES.SubItems.Add(TIPO_MIDIA);

                    CATALOGO_PRECO_FILME.Text = LEITOR["CAT_Descricao"].ToString();
                    CODIGO_FILMES.SubItems.Add(CATALOGO_PRECO_FILME);
                    
                    if (LEITOR["COD_Status"].ToString() == "0")
                    {
                        STATUS_FILME.Text = "DISPONÍVEL";
                    }
                    else
                        STATUS_FILME.Text = "LOCADO";

                    CODIGO_FILMES.SubItems.Add(STATUS_FILME);
                    
                    listView_Filmes_Disponiveis.Items.Add(CODIGO_FILMES);

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



        // Adiciona o filme selecionado da lista de filmes a relação de filmes a ser locada //


        private void Metodo_Selecionar_Filmes()
        {

            bool FILME_VERIFICACAO = false;

            if (listView_Filmes_Disponiveis.SelectedItems.Count != 0)
            {

                for (int I = 0; I < listView_Relacao_Filmes.Items.Count; I++)
                {

                    if (listView_Relacao_Filmes.Items[I].Text == listView_Filmes_Disponiveis.SelectedItems[0].Text)
                    {
                        FILME_VERIFICACAO = true;
                        MessageBox.Show("Este Filme já foi SELECIONADO");
                    }
                }
            }

            if (listView_Filmes_Disponiveis.SelectedItems[0].SubItems[6].Text == "LOCADO")
            {
                FILME_VERIFICACAO = true;
                MessageBox.Show("Este fime já está locado");
            }
                
            

            if (listView_Filmes_Disponiveis.SelectedItems.Count != 0 && FILME_VERIFICACAO == false)
            {
                Filmes FILME_SELECIONADO = new Filmes(int.Parse(listView_Filmes_Disponiveis.SelectedItems[0].Text), listView_Filmes_Disponiveis.SelectedItems[0].SubItems[1].Text, listView_Filmes_Disponiveis.SelectedItems[0].SubItems[2].Text, listView_Filmes_Disponiveis.SelectedItems[0].SubItems[3].Text, listView_Filmes_Disponiveis.SelectedItems[0].SubItems[4].Text, listView_Filmes_Disponiveis.SelectedItems[0].SubItems[5].Text, listView_Filmes_Disponiveis.SelectedItems[0].SubItems[6].Text);
                
                ListViewItem CODIGO_FILMES = new ListViewItem(FILME_SELECIONADO.CODIGO.ToString());

                ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem GENERO_FILME = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem CLASSIFICACAO_FILME = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem TIPO_MIDIA = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem CATALOGO_PRECO_FILME = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem VALOR_CATALOGO = new ListViewItem.ListViewSubItem();

                ListViewItem.ListViewSubItem DATA_DEVOLUCAO = new ListViewItem.ListViewSubItem();


                TITULO_FILME.Text = FILME_SELECIONADO.TITULO;
                CODIGO_FILMES.SubItems.Add(TITULO_FILME);

                GENERO_FILME.Text = FILME_SELECIONADO.GENERO;
                CODIGO_FILMES.SubItems.Add(GENERO_FILME);

                CLASSIFICACAO_FILME.Text = FILME_SELECIONADO.CLASSIFICACAO;
                CODIGO_FILMES.SubItems.Add(CLASSIFICACAO_FILME);

                TIPO_MIDIA.Text = FILME_SELECIONADO.TIPO_MIDIA;
                CODIGO_FILMES.SubItems.Add(TIPO_MIDIA);

                CATALOGO_PRECO_FILME.Text = FILME_SELECIONADO.CATEGORIA;
                CODIGO_FILMES.SubItems.Add(CATALOGO_PRECO_FILME);

                VALOR_CATALOGO.Text = DIC_CAT_PRECOS[FILME_SELECIONADO.CATEGORIA].ToString();
                CODIGO_FILMES.SubItems.Add(VALOR_CATALOGO);
                                
                DATA_DEVOLUCAO.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
                CODIGO_FILMES.SubItems.Add(DATA_DEVOLUCAO);

                listView_Relacao_Filmes.Items.Add(CODIGO_FILMES);

                listView_Filmes_Disponiveis.SelectedItems[0].Remove();

                METODO_ATUALIZACAO_LOCACAO();                                
            }
        }


        // Metodo para atualisar as alterações //
        

        private void METODO_ATUALIZACAO_LOCACAO()
        {

            int CONTADOR = 0;
            TOTAL = 0;



            for (int I = 0; I < listView_Relacao_Filmes.Items.Count; I++)
            {
                if (I < 3)
                {
                    CONTADOR++;
                }
            }

            if (listView_Relacao_Filmes.SelectedItems.Count == 0)
            {
                TOTAL = 0.0;
                textBox_Total_Loc.Text = TOTAL.ToString();
            }
            
            for ( int I = 0 ; I < listView_Relacao_Filmes.Items.Count; I++)
            {
                
                if (listView_Relacao_Filmes.Items[I].SubItems[5].Text != "LANÇAMENTO")
                {
                    listView_Relacao_Filmes.Items[I].SubItems[7].Text = DateTime.Now.AddDays(CONTADOR).ToString("dd/MM/yyyy");
                }

                TOTAL += double.Parse(listView_Relacao_Filmes.Items[I].SubItems[6].Text);

                textBox_Total_Loc.Text = TOTAL.ToString();
            }

            SALDO = CREDITO - TOTAL;
            TROCO = double.Parse(textBox_Dinheiro.Text) - (-SALDO); 
            
            textBox_Cli_Saldo.Text = SALDO.ToString();
            textBox_Troco.Text = TROCO.ToString();                        

        }



        // METODOS PARA CONFIGURAÇÕES DE COMPONENTES //

        

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

        
        private void pictureBoxIncluir_Click(object sender, EventArgs e)
        {
            if (listView_Filmes_Disponiveis.Focused == true)
            {
                Metodo_Selecionar_Filmes();
            }            
        }

        private void listView_Filmes_Disponiveis_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Metodo_Selecionar_Filmes();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodo_Selecionar_Filmes();
        }

        private void visualizarCapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_Filmes_Disponiveis.SelectedItems.Count != 0)
            {
                Form_Visualizar_Filmes VISUALIZA_FILME = new Form_Visualizar_Filmes(int.Parse(listView_Filmes_Disponiveis.SelectedItems[0].Text));
                VISUALIZA_FILME.ShowDialog();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_Relacao_Filmes.SelectedItems.Count != 0)
            {
                listView_Relacao_Filmes.SelectedItems[0].Remove();
                METODO_ATUALIZACAO_LOCACAO();
            }

        }

        private void visualizarCapaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView_Relacao_Filmes.SelectedItems.Count != 0)
            {
                Form_Visualizar_Filmes VISUALIZA_FILME = new Form_Visualizar_Filmes(int.Parse(listView_Relacao_Filmes.SelectedItems[0].Text));
                VISUALIZA_FILME.ShowDialog();
            }
        }

        // Evento para teclas precionadas //

        private void Form_Loc_Cliente_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Filme.Focused == true)
                    {
                        if (maskedTextBox_Cod_Filme.Text.Replace("_", "") != "")
                        {
                            MetodoConsulta();
                        }
                    }
                    if (textBox_Nome_Filme.Focused == true)
                    {
                        if (textBox_Nome_Filme.Text != "")
                        {
                            MetodoConsulta();
                        }
                    }
                    if (listView_Filmes_Disponiveis.Focused == true)
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

        private void button_Consul_Fime_Click(object sender, EventArgs e)
        {
            if (radioButton_Cod_Filme.Checked == true)
            {
                if (maskedTextBox_Cod_Filme.Text.Replace("_", "") != "")
                {
                    MetodoConsulta();
                }
            }
            if (radioButton_Titulo_Filme.Checked == true)
            {
                if (textBox_Nome_Filme.Text != "")
                {
                    MetodoConsulta();
                }
            }
        }

        private void radioButton_Cod_Filme_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_Cod_Filme.Enabled = true;
            maskedTextBox_Cod_Filme.Focus();
            textBox_Nome_Filme.Enabled = false;
        }

        private void radioButton_Titulo_Filme_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Nome_Filme.Enabled = true;
            textBox_Nome_Filme.Focus();
            maskedTextBox_Cod_Filme.Enabled = false;            
        }

        private void pictureBoxLimpar_Click(object sender, EventArgs e)
        {
            if (listView_Relacao_Filmes.SelectedItems.Count != 0)
            {
                listView_Relacao_Filmes.SelectedItems[0].Remove();
                METODO_ATUALIZACAO_LOCACAO();
            }
        }




        // Metodo para finalizar as locações //


        private void button_Finalizar_Click(object sender, EventArgs e)
        {


            if (listView_Relacao_Filmes.Items.Count != 0)
            {

                try
                {

                    CONEXAO.Open();

                    for (int I = 0; I < listView_Relacao_Filmes.Items.Count; I++)
                    {

                        SqlCommand INSERTLOCACOES = new SqlCommand("INSERT INTO LOCACOES (LOC_Data_Loc, LOC_Valor, LOC_Data_Dev, LOC_Dep, LOC_status, CLI_Cod, COD_Cod) VALUES (@DATA_LOC, @VAL_LOC, @DATA_DEV, @COD_DEP, 0, @COD_CLI, @COD_FIL);", CONEXAO);
                        SqlParameter CL1 = new SqlParameter("@DATA_LOC", DateTime.Now.ToString("dd-MM-yyyy"));
                        SqlParameter CL2 = new SqlParameter("@VAL_LOC", double.Parse(listView_Relacao_Filmes.Items[I].SubItems[6].Text));
                        SqlParameter CL3 = new SqlParameter("@DATA_DEV", listView_Relacao_Filmes.Items[I].SubItems[7].Text.Replace("/", "-"));
                        SqlParameter CL4 = new SqlParameter("@COD_DEP", CODIGODEPENDENTE);
                        SqlParameter CL5 = new SqlParameter("@COD_CLI", CODIGOCLIENTE);
                        SqlParameter CL6 = new SqlParameter("@COD_FIL", listView_Relacao_Filmes.Items[I].Text);
                        INSERTLOCACOES.Parameters.Add(CL1);
                        INSERTLOCACOES.Parameters.Add(CL2);
                        INSERTLOCACOES.Parameters.Add(CL3);
                        INSERTLOCACOES.Parameters.Add(CL4);
                        INSERTLOCACOES.Parameters.Add(CL5);
                        INSERTLOCACOES.Parameters.Add(CL6);
                        INSERTLOCACOES.ExecuteNonQuery();



                        SqlCommand ALTERAR_STATUS = new SqlCommand("UPDATE CODFILMES SET CODFILMES.COD_Status = 1 WHERE CODFILMES.COD_Cod = @COD_FIL;", CONEXAO);
                        SqlParameter ACF1 = new SqlParameter("@COD_FIL", listView_Relacao_Filmes.Items[I].Text);
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
                            if (checkBox_Creditar.Checked != true)
                            {
                                TROCO = 0.0;
                            }

                            SqlCommand ALTERAR_SALDO_CLI = new SqlCommand("UPDATE CLIENTES SET CLIENTES.CLI_Saldo = @SALDO_CLI WHERE CLIENTES.CLI_Cod = @CODI_CLI;", CONEXAO);
                            SqlParameter ACS = new SqlParameter("@SALDO_CLI", TROCO);
                            SqlParameter ACS1 = new SqlParameter("@CODI_CLI", CODIGOCLIENTE);
                            ALTERAR_SALDO_CLI.Parameters.Add(ACS);
                            ALTERAR_SALDO_CLI.Parameters.Add(ACS1);
                            ALTERAR_SALDO_CLI.ExecuteNonQuery();
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
                MessageBox.Show("Adicione o filme a ser locado na tabela abaixo ou clique em cancelar para sair");
            }


        }        
    }
}




















