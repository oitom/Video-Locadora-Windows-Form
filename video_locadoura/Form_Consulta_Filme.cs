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
    public partial class Form_Consulta_Filme : Form
    {

        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        
        public Form_Consulta_Filme()
        {
            InitializeComponent();
        }
        

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTAFILME;

                if (radioButton_Cod_Filme.Checked == true)
                {
                    CONSULTAFILME = new SqlCommand("SELECT FIL_Cod, FIL_Titulo, GEN_Desc, CAT_DESCRICAO FROM FILMES INNER JOIN GENEROS ON GENEROS.GEN_Cod = FILMES.GEN_Cod INNER JOIN CATALOGO_PRECOS ON CATALOGO_PRECOS.CAT_Cod = FILMES.CAT_Cod WHERE FIL_Cod = @COD_FIL;", CONEXAO);
                    SqlParameter FIL1 = new SqlParameter("@COD_FIL", int.Parse(maskedTextBox_Cod_Filme.Text));
                    CONSULTAFILME.Parameters.Add(FIL1);
                }
                else
                {
                    CONSULTAFILME = new SqlCommand("SELECT FIL_Cod, FIL_Titulo, GEN_Desc, CAT_DESCRICAO FROM FILMES INNER JOIN GENEROS ON GENEROS.GEN_Cod = FILMES.GEN_Cod INNER JOIN CATALOGO_PRECOS ON CATALOGO_PRECOS.CAT_Cod = FILMES.CAT_Cod WHERE FIL_Titulo LIKE @FIL_TITULO",CONEXAO);
                    SqlParameter FIL1 = new SqlParameter("@FIL_TITULO", "%" + textBox_Titulo_Filme.Text + "%");
                    CONSULTAFILME.Parameters.Add(FIL1);

                }


                LEITOR = null;
                LEITOR = CONSULTAFILME.ExecuteReader();

                listView_Filmes.Items.Clear();

                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_FILME = new ListViewItem(LEITOR["FIL_Cod"].ToString());

                    ListViewItem.ListViewSubItem TITULO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem GENERO_FILME = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem CATEGORIA = new ListViewItem.ListViewSubItem();


                    TITULO_FILME.Text = LEITOR["FIL_Titulo"].ToString();
                    CODIGO_FILME.SubItems.Add(TITULO_FILME);

                    GENERO_FILME.Text = LEITOR["GEN_Desc"].ToString();
                    CODIGO_FILME.SubItems.Add(GENERO_FILME);

                    CATEGORIA.Text = LEITOR["CAT_DESCRICAO"].ToString();                    
                    CODIGO_FILME.SubItems.Add(CATEGORIA);

                    listView_Filmes.Items.Add(CODIGO_FILME);

                }

            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar os Filmes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }
        
        private void MetodoLocarFilme()
        {

            if (listView_Filmes.SelectedItems.Count != 0)
            {
                Form_Visualizar_Filmes Formulario_filmes_consulta = new Form_Visualizar_Filmes(int.Parse(listView_Filmes.SelectedItems[0].Text));
                Formulario_filmes_consulta.ShowDialog();
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

        private void Consulta_KeyDown(object sender, KeyEventArgs e)
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
                    if (textBox_Titulo_Filme.Focused == true)
                    {
                        if (textBox_Titulo_Filme.Text != "")
                        {
                            MetodoConsulta();
                        }
                    }
                    if (listView_Filmes.Focused == true)
                    {
                        MetodoLocarFilme();
                    }
                    break;
            }
        }

        private void button_Consultar_Click(object sender, EventArgs e)
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
                if (textBox_Titulo_Filme.Text != "")
                {
                    MetodoConsulta();
                }
            }
        }


        private void radioButton_Cod_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_Cod_Filme.Enabled = true;
            maskedTextBox_Cod_Filme.Focus();
            textBox_Titulo_Filme.Enabled = false;
        }

        private void radioButton_Nome_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Titulo_Filme.Enabled = true;
            textBox_Titulo_Filme.Focus();
            maskedTextBox_Cod_Filme.Enabled = false;
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
