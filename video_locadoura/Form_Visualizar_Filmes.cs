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
    public partial class Form_Visualizar_Filmes : Form
    {

        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        private int CODIGO_FILME;

        public Form_Visualizar_Filmes()
        {
            InitializeComponent();
        }

        public Form_Visualizar_Filmes(int COD_FILME)
        {
            InitializeComponent();
            CODIGO_FILME = COD_FILME;
        }


        private void Form_Visualizar_Filmes_Load(object sender, EventArgs e)
        {
            MetodoConsulta();
        }


        private void MetodoConsulta()
        {


            try
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                CONEXAO.Open();

                SqlCommand CONSULTAFILME;

                CONSULTAFILME = new SqlCommand("SELECT CODFILMES.COD_Cod, FILMES.FIL_Titulo, TIPOS_MIDIAS.TIP_Desc, GENEROS.GEN_Desc, CATALOGO_PRECOS.CAT_DESCRICAO, FILMES.FIL_Data_Lanc, FILMES.FIL_Classificacao, FILMES.FIL_Diretor, FILMES.FIL_Produtora, FILMES.FIL_Sinopse, FIL_Capa FROM CODFILMES INNER JOIN FILMES ON CODFILMES.FIL_Cod = FILMES.FIL_Cod INNER JOIN GENEROS ON FILMES.GEN_Cod = GENEROS.GEN_Cod INNER JOIN CATALOGO_PRECOS ON FILMES.CAT_Cod = CATALOGO_PRECOS.CAT_Cod INNER JOIN TIPOS_MIDIAS ON CODFILMES.TIP_Cod = TIPOS_MIDIAS.TIP_Cod WHERE CODFILMES.COD_Cod = @COD_FILME;", CONEXAO);

                SqlParameter CF1 = new SqlParameter("@COD_FILME", CODIGO_FILME);
                CONSULTAFILME.Parameters.Add(CF1);
                
                LEITOR = null;
                LEITOR = CONSULTAFILME.ExecuteReader();
                                
                while (LEITOR.Read())
                {

                    textBox_Codigo.Text = LEITOR["COD_cod"].ToString();

                    textBox_Titulo.Text = LEITOR["FIL_Titulo"].ToString();

                    textBox_Tipo_Midia.Text = LEITOR["TIP_Desc"].ToString();

                    textBox_Genero.Text = LEITOR["GEN_Desc"].ToString();

                    textBox_Categoria.Text = LEITOR["CAT_Descricao"].ToString();

                    textBox_Ano_Lanc.Text = LEITOR["FIL_Data_Lanc"].ToString();

                    textBox_Classificacao.Text = LEITOR["FIL_Classificacao"].ToString();

                    textBox_Diretor.Text = LEITOR["FIL_DIretor"].ToString();

                    textBox_Produtora.Text = LEITOR["FIL_Produtora"].ToString();

                    textBox_Sinopse.Text = LEITOR["FIL_Sinopse"].ToString();

                    pictureBox_Capa_Filme.Image = Bitmap.FromFile(LEITOR["FIL_Capa"].ToString());                    
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


            // Carrega os idiomas Relacionados ao FILMES //

            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTAFILME;

                CONSULTAFILME = new SqlCommand("SELECT IDIOMAS.IDI_Desc FROM IDIOMAS INNER JOIN REL_FIL_IDI ON IDIOMAS.IDI_Cod = REL_FIL_IDI.IDI_Cod WHERE REL_FIL_IDI.FIL_Cod = @CODFILME ORDER BY IDIOMAS.IDI_Desc;", CONEXAO);
                SqlParameter CFI = new SqlParameter("@CODFILME", CODIGO_FILME);
                CONSULTAFILME.Parameters.Add(CFI);

                LEITOR = null;
                LEITOR = CONSULTAFILME.ExecuteReader();

                int CONTADOR = 1;

                while (LEITOR.Read())
                {
                    
                    switch (CONTADOR)
                    {
                        case 1: textBox_Idioma1.Text = LEITOR["IDI_Desc"].ToString(); break;
                        case 2: textBox_Idioma2.Text = LEITOR["IDI_Desc"].ToString(); break;
                        case 3: textBox_Idioma3.Text = LEITOR["IDI_Desc"].ToString(); break;
                        case 4: textBox_Idioma4.Text = LEITOR["IDI_Desc"].ToString(); break;
                    }
                    CONTADOR++;

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
    }
}
