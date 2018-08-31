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
    public partial class Form_Alterar_Filme : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        public Form_Alterar_Filme()
        {
            InitializeComponent();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            MetodoAlteraFilme();
        }
        
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filme_KeyDown(object sender, KeyEventArgs e)
        {
            //após informar o código ou o nome do filmes, e ter apertado enter
            //chama o formulário de atualização de filme
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Filme.Focused == true || textBox_Nome_filme.Focused == true)
                    {
                        MetodoConsulta();
                    }
                    if (listView_Filmes.Focused == true)
                    {
                       MetodoAlteraFilme();
                    }
                    break;
            }
        }

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTAFILME;
                //faz a consulta pelo código do filme informado
                if (maskedTextBox_Cod_Filme.Focused == true)
                {
                    CONSULTAFILME = new SqlCommand("SELECT FIL_Cod, FIL_Titulo, GEN_Desc FROM FILMES INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);

                    SqlParameter FIL = new SqlParameter("@FIL_COD", int.Parse(maskedTextBox_Cod_Filme.Text));
                    CONSULTAFILME.Parameters.Add(FIL);
                }
                else
                {
                    //faz a consulta pelo nome do filme informado
                    CONSULTAFILME = new SqlCommand("SELECT FIL_Cod, FIL_Titulo, GEN_Desc FROM FILMES INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod WHERE FIL_Titulo like @FIL_DESC", CONEXAO);
                    SqlParameter FIL_1 = new SqlParameter("@FIL_DESC", "%" + textBox_Nome_filme.Text + "%");
                    CONSULTAFILME.Parameters.Add(FIL_1);

                }

                LEITOR = null;
                LEITOR = CONSULTAFILME.ExecuteReader();

                listView_Filmes.Items.Clear();

                //preenche os campos do list view de acordo os dados do filme
                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_FILME = new ListViewItem(LEITOR["FIL_Cod"].ToString());

                    ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem GENERO_FILME = new ListViewItem.ListViewSubItem();


                    TITULO_FILME.Text = LEITOR["FIL_Titulo"].ToString();
                    CODIGO_FILME.SubItems.Add(TITULO_FILME);

                    GENERO_FILME.Text = LEITOR["GEN_Desc"].ToString();
                    CODIGO_FILME.SubItems.Add(GENERO_FILME);
                    
                    listView_Filmes.Items.Add(CODIGO_FILME);
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


        private void MetodoAlteraFilme()
        {
            //Verifica se tem algum item selecionado, e chama o formulário de altualização de filme
            //onde é passado como parâmetro o seu código
            if (listView_Filmes.SelectedItems.Count != 0)
            {
                Form_Atualiza_Filme formulario_Atualiza_Filme = new Form_Atualiza_Filme(int.Parse(listView_Filmes.SelectedItems[0].Text));
                formulario_Atualiza_Filme.ShowDialog();
                //limpa o list view após fechar o formulario de atualização de filme
                listView_Filmes.Items.Clear();
                textBox_Nome_filme.Text = "";
                maskedTextBox_Cod_Filme.Text = "";
            }
        }

        public void MouseDouble_Click(object sender, MouseEventArgs e)
        {
            MetodoAlteraFilme();
        }

    }
}
