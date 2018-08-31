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
    public partial class Form_Excluir_Filme : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        public Form_Excluir_Filme()
        {
            InitializeComponent();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            this.Close(); 
            Form_Novo_Filme formulario_Filme = new Form_Novo_Filme();
            formulario_Filme.ShowDialog();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Alterar_Filme_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método para funcionamento da tecla <ENTER>
        private void Filme_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                    //Verifica qual campo ele será usado para filtrar o filme
                case Keys.Enter:
                    if (maskedTextBox_Cod_Filme.Focused == true || textBox_Nome_filme.Focused == true)
                        MetodoConsulta();
                    if (listView_Filmes.Focused == true)
                        MetodoExclusaoFilme();
                break;
            }
        }

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTAFILME;
                //Verfica qual campo será usado para filtrar os filmes
                if (maskedTextBox_Cod_Filme.Focused == true)
                {
                    //Seleciona os filme apartir do código informado
                    CONSULTAFILME = new SqlCommand("SELECT FIL_Cod, FIL_Titulo, GEN_Desc FROM FILMES INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);

                    SqlParameter FIL = new SqlParameter("@FIL_COD", int.Parse(maskedTextBox_Cod_Filme.Text));
                    CONSULTAFILME.Parameters.Add(FIL);
                }
                else
                {
                    //Seleciona o filme apatir do nome informado
                    CONSULTAFILME = new SqlCommand("SELECT FIL_Cod, FIL_Titulo, GEN_Desc FROM FILMES INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod WHERE FIL_Titulo like @FIL_DESC", CONEXAO);
                    SqlParameter FIL_1 = new SqlParameter("@FIL_DESC", "%" + textBox_Nome_filme.Text + "%");
                    CONSULTAFILME.Parameters.Add(FIL_1);
                }

                LEITOR = null;
                LEITOR = CONSULTAFILME.ExecuteReader();

                listView_Filmes.Items.Clear();
                //Carrega o list view com os dados do filme
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


        private void MetodoExclusaoFilme()
        {
            //Verfica se tem algum item selecionado
            if (listView_Filmes.SelectedItems.Count != 0)
            {
               string FIL__CODIGO =  listView_Filmes.SelectedItems[0].Text;
                
               DialogResult Resultado = MessageBox.Show("Tem certeza que deseja excluir esse Filme?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

               if (Resultado == System.Windows.Forms.DialogResult.Yes)
               {
                    //cogido para exclusão do filme
                    try
                    {
                        CONEXAO.Open();

                        SqlCommand COMANDODELETE_FIL_CODF = new SqlCommand("DELETE FROM CODFILMES WHERE FIL_Cod = @FIL_COD", CONEXAO);
                        SqlParameter COD_FIL = new SqlParameter("@FIL_COD", FIL__CODIGO);
                        COMANDODELETE_FIL_CODF.Parameters.Add(COD_FIL);
                        COMANDODELETE_FIL_CODF.ExecuteNonQuery();


                        SqlCommand COMANDODELETE_FIL_REL_FIL = new SqlCommand("DELETE FROM REL_FIL_IDI WHERE FIL_Cod = @FIL_COD", CONEXAO);
                        SqlParameter COD_FIL_1 = new SqlParameter("@FIL_COD", FIL__CODIGO);
                        COMANDODELETE_FIL_REL_FIL.Parameters.Add(COD_FIL_1);
                        COMANDODELETE_FIL_REL_FIL.ExecuteNonQuery();

                        SqlCommand COMANDODELETE_FIL = new SqlCommand("DELETE FROM FILMES WHERE FIL_Cod = @FIL_COD", CONEXAO);
                        SqlParameter COD_FIL_2= new SqlParameter("@FIL_COD", FIL__CODIGO);
                        COMANDODELETE_FIL.Parameters.Add(COD_FIL_2);
                        COMANDODELETE_FIL.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("erro em excluir filme");
                    }
                    finally
                    {
                        if (CONEXAO.State == ConnectionState.Open)
                            CONEXAO.Close();
                        LEITOR.Close();

                        listView_Filmes.SelectedItems[0].Remove();
                        MessageBox.Show("Filme excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                    }
                }
            }
        }

        private void listView_Filmes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoExclusaoFilme();
        }

        private void button_Locar_Click(object sender, EventArgs e)
        {
            MetodoExclusaoFilme();
        }

    }
}
