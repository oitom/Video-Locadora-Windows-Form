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
    public partial class Form_Atualiza_Filme : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        int COD_Filme;
        string end_capa = "";
        //Recebe no construtor o codigo do filme a ser alterado
        public Form_Atualiza_Filme( int CODIGO_FIL)
        {
            COD_Filme = CODIGO_FIL;
            InitializeComponent();
        }
        bool erro = false;
        OpenFileDialog procurar;

        //Metodo para capturar a capa do filme, escolhida pelo usuário 
        private  void Capa_Filme(object sender, EventArgs e)
        {
            procurar = new OpenFileDialog();
            if (procurar.ShowDialog() != null && procurar.FileName != "")
                //carrega no  pictureBox a capa selecionada
                pictureBoxCapa.Image = Bitmap.FromFile(procurar.FileName.ToString());
        }

        private void Form_Novo_Filme_Load(object sender, EventArgs e)
        {
            textBoxcodigo.Text = COD_Filme.ToString();
           
            try
            {	 //Carrega o título
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_TITULO = new SqlCommand("SELECT FIL_Titulo FROM FILMES WHERE FIL_Cod = @FIL_COD", CONEXAO);
                SqlParameter COD_FIL = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                LEITOR = null;
                COMANDOSELECT_TITULO.Parameters.Add(COD_FIL);
                LEITOR = COMANDOSELECT_TITULO.ExecuteReader();
                //preenche o título no textBox
                if (LEITOR.Read() == true)
                {
                    textBoxTitulo.Text = LEITOR["FIL_Titulo"].ToString();
                    LEITOR.Close();
                }
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();
            }
            try
            {
                //Carrega a Data de Lançamento filme
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_ANOLAN = new SqlCommand("SELECT FIL_Data_Lanc FROM FILMES WHERE FIL_Cod = @COD_FIL", CONEXAO);
                SqlParameter COD_FIL_1 = new SqlParameter("@COD_FIL", textBoxcodigo.Text);
                COMANDOSELECT_ANOLAN.Parameters.Add(COD_FIL_1);
                LEITOR = null;
                LEITOR = COMANDOSELECT_ANOLAN.ExecuteReader();
                if (LEITOR.Read() == true)
                    textBoxAnoLancamento.Text = LEITOR["FIL_Data_Lanc"].ToString();
             }
            finally
            {
              if (CONEXAO.State == ConnectionState.Open)
                 CONEXAO.Close();
              LEITOR.Close();
            }
            //carrega os dados Opcionais
            try
            {
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_DADOSOP = new SqlCommand("SELECT FIL_Capa, FIL_Diretor, FIL_Produtora, FIL_Sinopse FROM FILMES WHERE FIL_Cod = @FIL_COD", CONEXAO);
                SqlParameter COD_FIL = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                LEITOR = null;
                COMANDOSELECT_DADOSOP.Parameters.Add(COD_FIL);
                LEITOR = COMANDOSELECT_DADOSOP.ExecuteReader();
                //Preenche alguns dados opcionais
                while (LEITOR.Read())
                {
                    textBoxDiretor.Text = LEITOR["FIL_Diretor"].ToString();
                    textBoxProdutora.Text = LEITOR["FIL_Produtora"].ToString();
                    richTextBoxSinopse.Text = LEITOR["FIL_Sinopse"].ToString();
                    end_capa = LEITOR["FIL_Capa"].ToString();
                    //Verifica o endereço da capa do filme
                    if (end_capa == "")
                        pictureBoxCapa.Image = Bitmap.FromFile(@"C:\PROGRAMA LOCADORA\BANCO DE DADOS\IMAGENS CAPA\semfoto.JPG");
                    else
                        pictureBoxCapa.Image = Bitmap.FromFile(end_capa);                             
                }

            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();     
            }

            try
            {
                //carrega a classificação Indicativa do filme
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_CLASS = new SqlCommand("SELECT FIL_Classificacao FROM FILMES WHERE FIL_Cod = @COD_FIL", CONEXAO);
                SqlParameter COD_FIL = new SqlParameter("@COD_FIL", textBoxcodigo.Text);
                COMANDOSELECT_CLASS.Parameters.Add(COD_FIL);
                LEITOR = null;
                LEITOR = COMANDOSELECT_CLASS.ExecuteReader();
                if (LEITOR.Read() == true)
                    textBoxClassificacao_Indicativa.Text = LEITOR["FIL_Classificacao"].ToString();
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();       
            }

            try
            {
                //Carrega o catalogo de preço
                CONEXAO.Open();
                SqlCommand CONSULTIP_MIDIA = new SqlCommand("SELECT CAT_DESCRICAO FROM CATALOGO_PRECOS", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTIP_MIDIA.ExecuteReader();
                comboBoxCatalagoPreco.Items.Add("Selecione");
                comboBoxCatalagoPreco.SelectedIndex = 0;
                //carrega o comboBox com o catalogo de preço do filme a ser alterado
                while (LEITOR.Read())
                {
                    comboBoxCatalagoPreco.Items.Add(LEITOR["CAT_DESCRICAO"].ToString());
                }
                comboBoxCatalagoPreco.SelectedIndex = 0;
                
                CONEXAO.Close();
                LEITOR.Close();
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_CAT = new SqlCommand("SELECT CAT_DESCRICAO FROM CATALOGO_PRECOS INNER JOIN FILMES ON FILMES.CAT_Cod = CATALOGO_PRECOS.CAT_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                COMANDOSELECT_CAT.Parameters.Add(FIL_COD);
                LEITOR = null;
                LEITOR = COMANDOSELECT_CAT.ExecuteReader();

                if (LEITOR.Read() == true)
                {
                    comboBoxCatalagoPreco.SelectedItem = LEITOR["CAT_DESCRICAO"].ToString();
                    LEITOR.Close();
                }
         
            }
            catch
            {
                MessageBox.Show("Houve um problema com a conenão com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
            
            //metodo para carregar o comboBox do Gênero
            Seleciona_Genero();            
            //carrega o comboBox Idioma
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTIP_MIDIA = new SqlCommand("SELECT IDI_Desc FROM IDIOMAS", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTIP_MIDIA.ExecuteReader();
                comboBoxIdiomas_1.Items.Add("Selecione"); comboBoxIdiomas_1.SelectedIndex = 0;
                comboBoxIdiomas_2.Items.Add("Selecione"); comboBoxIdiomas_2.SelectedIndex = 0;
                comboBoxIdiomas_3.Items.Add("Selecione"); comboBoxIdiomas_3.SelectedIndex = 0;
                comboBoxIdiomas_4.Items.Add("Selecione"); comboBoxIdiomas_4.SelectedIndex = 0;
                //Carrega os comboBox de Idiomas
                while (LEITOR.Read())
                {
                    comboBoxIdiomas_1.Items.Add(LEITOR["IDI_Desc"].ToString());
                    comboBoxIdiomas_2.Items.Add(LEITOR["IDI_Desc"].ToString());
                    comboBoxIdiomas_3.Items.Add(LEITOR["IDI_Desc"].ToString());
                    comboBoxIdiomas_4.Items.Add(LEITOR["IDI_Desc"].ToString());
                }
                comboBoxIdiomas_1.SelectedIndex = 0;
                comboBoxIdiomas_2.SelectedIndex = 0;
                comboBoxIdiomas_3.SelectedIndex = 0;
                comboBoxIdiomas_4.SelectedIndex = 0;

                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();
                LEITOR = null;
                CONEXAO.Open();
                //Carrega os idiomas do filme a ser alterado
                SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Desc FROM IDIOMAS INNER JOIN REL_FIL_IDI ON IDIOMAS.IDI_Cod = REL_FIL_IDI.IDI_Cod INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                SqlParameter COD_FIL = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                COMANDOSELECT_IDI.Parameters.Add(COD_FIL);
                LEITOR = COMANDOSELECT_IDI.ExecuteReader();
                
                if (LEITOR.Read() == true)
                    comboBoxIdiomas_1.SelectedItem = LEITOR["IDI_Desc"].ToString();
                if (LEITOR.Read() == true)
                {
                    comboBoxIdiomas_2.Enabled = true;
                    comboBoxIdiomas_2.SelectedItem = LEITOR["IDI_Desc"].ToString();
                } if (LEITOR.Read() == true)
                {
                    comboBoxIdiomas_3.Enabled = true;
                    comboBoxIdiomas_3.SelectedItem = LEITOR["IDI_Desc"].ToString();
                }
                if (LEITOR.Read() == true)
                {
                    comboBoxIdiomas_4.Enabled = true;
                    comboBoxIdiomas_4.SelectedItem = LEITOR["IDI_Desc"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Erro em carregar os idiomas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }

        //Metodo que chama o formulário onde será cadastrado um novo gênero
        private void NovoGenero_Click(object sender, EventArgs e)
        {
            Form_Cadastro_genero formulario_cadastro_Genero = new Form_Cadastro_genero();
            formulario_cadastro_Genero.ShowDialog();
            //após cadastrado o gênero, ele é selecionado no comboBoxGeneros
            Seleciona_Genero();
            comboBoxGenero.SelectedItem = formulario_cadastro_Genero.GENERO;            
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            error.Clear();
            erro = false;
            string Dt_Lancamento = textBoxAnoLancamento.Text;
            Dt_Lancamento = Dt_Lancamento.Replace("/", "");

            //Verfica se algum campo obrigatório está em branco
            if (textBoxcodigo.Text == "")
            {
                error.SetError(textBoxcodigo, "O campo 'Código' não está preechido!");
                erro = true;
            }
            if (textBoxTitulo.Text == "")
            {
                error.SetError(textBoxTitulo, "O campo 'Título' não está preenchido!");
                erro = true;
            }
            if (comboBoxGenero.Text == "")
            {
                error.SetError(buttonNovoGenero, "O campo 'Gênero' não está preenchido!");
                erro = true;
            }
            if (comboBoxCatalagoPreco.Text == "")
            {
                error.SetError(textBoxAnoLancamento, "O campo 'Catalogo de Preço' não está preenchido!");
                erro = true;
            }
            if (textBoxClassificacao_Indicativa.Text == "")
            {
                error.SetError(textBoxClassificacao_Indicativa, "O campo 'Classificação Indicativa' não está preenchido!");
                erro = true;
            }


            if (erro == false)
            {
           
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja fazer alterações no filme " + textBoxTitulo.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        //Altera os dados do filme
                        CONEXAO.Open();
                        SqlCommand COMANDOUPDATE_FILMES = new SqlCommand("UPDATE FILMES SET FIL_Titulo = @FIL_Titulo, GEN_Cod = @GEN_Cod,  FIL_Data_Lanc = @FIL_Data_Lanc, CAT_Cod = @CAT_Cod, FIL_Classificacao = @FIL_Classificacao, FIL_Diretor = @FIL_Diretor, FIL_Produtora = @FIL_Produtora, FIL_Sinopse = @FIL_Sinopse, FIl_Capa = @FIL_Capa WHERE FIL_Cod = @FIL_COD", CONEXAO);
                        SqlParameter COD_FIL = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                        SqlParameter FILME_TITULO = new SqlParameter("@FIL_Titulo", textBoxTitulo.Text);
                        SqlParameter FILME_GENERO = new SqlParameter("@GEN_Cod", comboBoxGenero.SelectedIndex);
                        SqlParameter FILME_LANCAMENTO = new SqlParameter("@FIL_Data_Lanc", textBoxAnoLancamento.Text);
                        SqlParameter FILME_CATEGORIA = new SqlParameter("@CAT_Cod", comboBoxCatalagoPreco.SelectedIndex);
                        SqlParameter FILME_CLASSIFC = new SqlParameter("@FIL_Classificacao", textBoxClassificacao_Indicativa.Text);
                        LEITOR.Close();

                        SqlParameter FILME_DIRETOR;
                        if (textBoxDiretor.Text == "")
                            FILME_DIRETOR = new SqlParameter("@FIL_Diretor", "");
                        else
                            FILME_DIRETOR = new SqlParameter("@FIL_Diretor", textBoxDiretor.Text);

                        SqlParameter FILME_PRODUTORA;
                        if (textBoxProdutora.Text == "")
                            FILME_PRODUTORA = new SqlParameter("@FIL_Produtora", "");
                        else
                            FILME_PRODUTORA = new SqlParameter("@FIL_Produtora", textBoxProdutora.Text);

                        SqlParameter FILME_SINOPSE;
                        if (richTextBoxSinopse.Text == "")
                            FILME_SINOPSE = new SqlParameter("@FIL_Sinopse", "");
                        else
                            FILME_SINOPSE = new SqlParameter("@FIL_Sinopse", richTextBoxSinopse.Text);

                        SqlParameter FILME_CAPA;
                       if (procurar == null)
                            FILME_CAPA = new SqlParameter("@FIL_Capa", end_capa);
                        else
                            FILME_CAPA = new SqlParameter("@FIL_Capa", procurar.FileName.ToString());

                        COMANDOUPDATE_FILMES.Parameters.Add(COD_FIL); COMANDOUPDATE_FILMES.Parameters.Add(FILME_TITULO);
                        COMANDOUPDATE_FILMES.Parameters.Add(FILME_GENERO); COMANDOUPDATE_FILMES.Parameters.Add(FILME_LANCAMENTO);
                        COMANDOUPDATE_FILMES.Parameters.Add(FILME_CATEGORIA); COMANDOUPDATE_FILMES.Parameters.Add(FILME_CLASSIFC);
                        COMANDOUPDATE_FILMES.Parameters.Add(FILME_DIRETOR); COMANDOUPDATE_FILMES.Parameters.Add(FILME_PRODUTORA);
                        COMANDOUPDATE_FILMES.Parameters.Add(FILME_SINOPSE); COMANDOUPDATE_FILMES.Parameters.Add(FILME_CAPA);
                        COMANDOUPDATE_FILMES.ExecuteNonQuery();

                        //Verfica se tem algum Idioma selecionado
                        if (comboBoxIdiomas_1.SelectedIndex != 0 && comboBoxIdiomas_1.Enabled == true)
                        {
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                LEITOR.Close();
                                //Altera os Idioma 1 do filme
                                SqlCommand COMANDOUPDATE_IDI_FIL_1 = new SqlCommand("UPDATE REL_FIL_IDI SET IDI_Cod = @IDI_Cod , FIL_Cod = @FIL_COD WHERE IDI_Cod = @IDI_COD_SLCT AND FIL_Cod = @FIL_COD", CONEXAO);
                                SqlParameter PFilmeIdioma_1 = new SqlParameter("@IDI_Cod", (int)comboBoxIdiomas_1.SelectedIndex);
                                SqlParameter PFilmeCod_1 = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                                SqlParameter IDI_COD_SLCT = new SqlParameter("@IDI_COD_SLCT", IDI_COD);

                                COMANDOUPDATE_IDI_FIL_1.Parameters.Add(IDI_COD_SLCT);
                                COMANDOUPDATE_IDI_FIL_1.Parameters.Add(PFilmeIdioma_1);
                                COMANDOUPDATE_IDI_FIL_1.Parameters.Add(PFilmeCod_1);
                                COMANDOUPDATE_IDI_FIL_1.ExecuteNonQuery();
                            }
                            else
                            {
                                LEITOR.Close();
                                //caso não tenha um idioma ele é inserido
                                SqlCommand COMANDOINSERT_IDI_FIL = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_1, @FIL_Cod_1)", CONEXAO);
                                SqlParameter PFilmeIdioma = new SqlParameter("@IDI_Cod_1", comboBoxIdiomas_1.SelectedIndex);
                                SqlParameter PFilmeCod = new SqlParameter("@FIL_Cod_1", textBoxcodigo.Text);
                                COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeIdioma);
                                COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeCod);
                                COMANDOINSERT_IDI_FIL.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                LEITOR.Close();
                                //deleta o idioma
                                SqlCommand COMANDODELETE_IDI = new SqlCommand("DELETE FROM REL_FIL_IDI WHERE REL_FIL_IDI.FIL_Cod = @FIL_COD AND REL_FIL_IDI.IDI_Cod = @IDI_COD", CONEXAO);
                                SqlParameter FIL_Codigo = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                                SqlParameter IDI_Codigo = new SqlParameter("@IDI_COD", IDI_COD);
                                COMANDODELETE_IDI.Parameters.Add(FIL_Codigo);
                                COMANDODELETE_IDI.Parameters.Add(IDI_Codigo);
                                COMANDODELETE_IDI.ExecuteNonQuery();
                            }

                        }

                        //Verfica se tem algum Idioma selecionado
                        if (comboBoxIdiomas_2.SelectedIndex != 0 && comboBoxIdiomas_2.Enabled == true)
                        {
                            LEITOR.Close();
                            if (CONEXAO.State == ConnectionState.Closed)
                                CONEXAO.Open();

                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                    LEITOR.Close();
                                    //Altera os Idioma 2 do filme
                                    SqlCommand COMANDOINSERT_IDI_FIL_2 = new SqlCommand("UPDATE REL_FIL_IDI SET IDI_Cod = @IDI_Cod_2, FIL_Cod =  @FIL_Cod_2", CONEXAO);
                                    SqlParameter PFilmeIdioma_2 = new SqlParameter("@IDI_Cod_2", (int)comboBoxIdiomas_2.SelectedIndex);
                                    SqlParameter PFilmeCod_2 = new SqlParameter("@FIL_Cod_2", textBoxcodigo.Text);
                                    COMANDOINSERT_IDI_FIL_2.Parameters.Add(PFilmeIdioma_2);
                                    COMANDOINSERT_IDI_FIL_2.Parameters.Add(PFilmeCod_2);
                                    COMANDOINSERT_IDI_FIL_2.ExecuteNonQuery();
                                }
                                else
                                {
                                    LEITOR.Close();
                                    //caso não tenha um idioma ele é inserido
                                    SqlCommand COMANDOINSERT_IDI_FIL = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_1, @FIL_Cod_1)", CONEXAO);
                                    SqlParameter PFilmeIdioma = new SqlParameter("@IDI_Cod_1", comboBoxIdiomas_2.SelectedIndex);
                                    SqlParameter PFilmeCod = new SqlParameter("@FIL_Cod_1", textBoxcodigo.Text);
                                    COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeIdioma);
                                    COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeCod);
                                    COMANDOINSERT_IDI_FIL.ExecuteNonQuery();
                                                                        
                                }
                            }
                        }
                        else
                        {
                            LEITOR.Close();
                            if (CONEXAO.State == ConnectionState.Closed)
                                CONEXAO.Open();

                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                    LEITOR.Close();
                                    //deleta o idioma
                                    SqlCommand COMANDODELETE_IDI = new SqlCommand("DELETE FROM REL_FIL_IDI WHERE REL_FIL_IDI.FIL_Cod = @FIL_COD AND REL_FIL_IDI.IDI_Cod = @IDI_COD", CONEXAO);
                                    SqlParameter FIL_Codigo = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                                    SqlParameter IDI_Codigo = new SqlParameter("@IDI_COD", IDI_COD);
                                    COMANDODELETE_IDI.Parameters.Add(FIL_Codigo);
                                    COMANDODELETE_IDI.Parameters.Add(IDI_Codigo);
                                    COMANDODELETE_IDI.ExecuteNonQuery();
                                }
                            }
                        }

                        //Verfica se tem algum Idioma selecionado
                        if (comboBoxIdiomas_3.SelectedIndex != 0 && comboBoxIdiomas_3.Enabled == true)
                        {
                            LEITOR.Close();
                            if (CONEXAO.State == ConnectionState.Closed)
                                CONEXAO.Open();

                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    if (LEITOR.Read() == true)
                                    {
                                        string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                        LEITOR.Close();
                                        //Altera os Idioma 3 do filme
                                        SqlCommand COMANDOINSERT_IDI_FIL_3 = new SqlCommand("UPDATE REL_FIL_IDI SET IDI_Cod = @IDI_Cod_3, FIL_Cod = @FIL_Cod_3", CONEXAO);
                                        SqlParameter PFilmeIdioma_3 = new SqlParameter("@IDI_Cod_3", (int)comboBoxIdiomas_3.SelectedIndex);
                                        SqlParameter PFilmeCod_3 = new SqlParameter("@FIL_Cod_3", textBoxcodigo.Text);
                                        COMANDOINSERT_IDI_FIL_3.Parameters.Add(PFilmeIdioma_3);
                                        COMANDOINSERT_IDI_FIL_3.Parameters.Add(PFilmeCod_3);
                                        COMANDOINSERT_IDI_FIL_3.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        LEITOR.Close();
                                        //caso não tenha um idioma ele é inserido
                                        SqlCommand COMANDOINSERT_IDI_FIL = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_1, @FIL_Cod_1)", CONEXAO);
                                        SqlParameter PFilmeIdioma = new SqlParameter("@IDI_Cod_1", comboBoxIdiomas_3.SelectedIndex);
                                        SqlParameter PFilmeCod = new SqlParameter("@FIL_Cod_1", textBoxcodigo.Text);
                                        COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeIdioma);
                                        COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeCod);
                                        COMANDOINSERT_IDI_FIL.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        else
                        {
                            LEITOR.Close();
                            if (CONEXAO.State == ConnectionState.Closed)
                                CONEXAO.Open();

                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    if (LEITOR.Read() == true)
                                    {
                                        string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                        LEITOR.Close();
                                        //deleta o idioma
                                        SqlCommand COMANDODELETE_IDI = new SqlCommand("DELETE FROM REL_FIL_IDI WHERE REL_FIL_IDI.FIL_Cod = @FIL_COD AND REL_FIL_IDI.IDI_Cod = @IDI_COD", CONEXAO);
                                        SqlParameter FIL_Codigo = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                                        SqlParameter IDI_Codigo = new SqlParameter("@IDI_COD", IDI_COD);
                                        COMANDODELETE_IDI.Parameters.Add(FIL_Codigo);
                                        COMANDODELETE_IDI.Parameters.Add(IDI_Codigo);
                                        COMANDODELETE_IDI.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        //Verfica se tem algum Idioma selecionado
                        if (comboBoxIdiomas_4.SelectedIndex != 0 && comboBoxIdiomas_4.Enabled == true)
                        {
                            LEITOR.Close();
                            if (CONEXAO.State == ConnectionState.Closed)
                                CONEXAO.Open();

                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    if (LEITOR.Read() == true)
                                    {
                                        if (LEITOR.Read() == true)
                                        {
                                            //Altera os Idioma 4 do filme
                                            string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                            LEITOR.Close();
                                            SqlCommand COMANDOINSERT_IDI_FIL_4 = new SqlCommand("UPDATE REL_FIL_IDI SET IDI_Cod = @IDI_Cod_4, FIL_Cod = @FIL_Cod_4", CONEXAO);
                                            SqlParameter PFilmeIdioma_4 = new SqlParameter("@IDI_Cod_4", (int)comboBoxIdiomas_4.SelectedIndex);
                                            SqlParameter PFilmeCod_4 = new SqlParameter("@FIL_Cod_4", textBoxcodigo.Text);
                                            COMANDOINSERT_IDI_FIL_4.Parameters.Add(PFilmeIdioma_4);
                                            COMANDOINSERT_IDI_FIL_4.Parameters.Add(PFilmeCod_4);
                                            COMANDOINSERT_IDI_FIL_4.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            LEITOR.Close();
                                            //caso não tenha um idioma ele é inserido
                                            SqlCommand COMANDOINSERT_IDI_FIL = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_1, @FIL_Cod_1)", CONEXAO);
                                            SqlParameter PFilmeIdioma = new SqlParameter("@IDI_Cod_1", comboBoxIdiomas_4.SelectedIndex);
                                            SqlParameter PFilmeCod = new SqlParameter("@FIL_Cod_1", textBoxcodigo.Text);
                                            COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeIdioma);
                                            COMANDOINSERT_IDI_FIL.Parameters.Add(PFilmeCod);
                                            COMANDOINSERT_IDI_FIL.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            LEITOR.Close();
                            if (CONEXAO.State == ConnectionState.Closed)
                                CONEXAO.Open();

                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_IDI = new SqlCommand("SELECT IDI_Cod FROM REL_FIL_IDI INNER JOIN FILMES ON FILMES.FIL_Cod = REL_FIL_IDI.FIL_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                            SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                            COMANDOSELECT_IDI.Parameters.Add(FIL_COD);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_IDI.ExecuteReader();

                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    if (LEITOR.Read() == true)
                                    {
                                        if (LEITOR.Read() == true)
                                        {
                                            string IDI_COD = LEITOR["IDI_Cod"].ToString();
                                            LEITOR.Close();
                                            //deleta o idioma
                                            SqlCommand COMANDODELETE_IDI = new SqlCommand("DELETE FROM REL_FIL_IDI WHERE REL_FIL_IDI.FIL_Cod = @FIL_COD AND REL_FIL_IDI.IDI_Cod = @IDI_COD", CONEXAO);
                                            SqlParameter FIL_Codigo = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                                            SqlParameter IDI_Codigo = new SqlParameter("@IDI_COD", IDI_COD);
                                            COMANDODELETE_IDI.Parameters.Add(FIL_Codigo);
                                            COMANDODELETE_IDI.Parameters.Add(IDI_Codigo);
                                            COMANDODELETE_IDI.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Houve um problema com a conexão com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                            CONEXAO.Close();
                        Limpar();
                        MessageBox.Show("Filme alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
        }
        //Metodo para limpar os componentes do formulário
        public void Limpar()
        {
            comboBoxIdiomas_1.SelectedIndex = 0;
            comboBoxIdiomas_2.SelectedIndex = 0;
            comboBoxIdiomas_3.SelectedIndex = 0;
            comboBoxIdiomas_4.SelectedIndex = 0;
            comboBoxGenero.SelectedIndex = 0;
            comboBoxCatalagoPreco.SelectedIndex = 0;
            
            //Limpa os componentes do primeiro Tab do Formulario
            foreach (object o in this.tabPageFilme.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
                else if (o is ComboBox)
                    ((ComboBox)o).Text = "";
            }
            //Limpa os componentes do primeiro Tab do Formulario
            foreach (object o in this.tabPageOpcionais.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
                else if (o is ComboBox)
                    ((ComboBox)o).Text = "";
                richTextBoxSinopse.Text = "";
                pictureBoxCapa.Image = Properties.Resources.semfoto;
            }
            //Preenche o codigo do proximo filmes
            try
            {
                CONEXAO.Open();
                SqlCommand COMANDOCONSULTA_CODFILME = new SqlCommand("SELECT MAX(FIL_Cod) FROM FILMES", CONEXAO);
                COD_Filme = (int)COMANDOCONSULTA_CODFILME.ExecuteScalar();
                COD_Filme++;
                textBoxcodigo.Text = COD_Filme.ToString();
            }
            catch
            {
                MessageBox.Show("Houve um problema em carregar o código do cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
            

        }

        private void Limpar_Form(object sender, EventArgs e)
        {
            Limpar();
        }

        //Método para deixar selecionado o Gênero do filme
        public void Seleciona_Genero()
        {
            if (comboBoxGenero.Items.Count != 0)
            {
                comboBoxGenero.Items.Clear();
            }
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTIP_MIDIA = new SqlCommand("SELECT GEN_Desc FROM GENEROS", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTIP_MIDIA.ExecuteReader();
                comboBoxGenero.Items.Add("Selecione");
                comboBoxGenero.SelectedIndex = 0;
                while (LEITOR.Read())
                {
                    comboBoxGenero.Items.Add(LEITOR["GEN_Desc"].ToString());
                }
                comboBoxGenero.SelectedIndex = 0;
                LEITOR.Close();
                CONEXAO.Close();
                CONEXAO.Open();

                SqlCommand COMANDOSELECT_GEN = new SqlCommand("SELECT GEN_Desc FROM GENEROS INNER JOIN FILMES ON FILMES.GEN_Cod = GENEROS.GEN_Cod WHERE FILMES.FIL_Cod = @FIL_COD", CONEXAO);
                SqlParameter FIL_COD = new SqlParameter("@FIL_COD", textBoxcodigo.Text);
                LEITOR = null;
                COMANDOSELECT_GEN.Parameters.Add(FIL_COD);
                LEITOR = COMANDOSELECT_GEN.ExecuteReader();

                if (LEITOR.Read() == true)
                {
                    comboBoxGenero.SelectedItem = LEITOR["GEN_Desc"].ToString();
                    LEITOR.Close();
                }
            }
            catch
            {
                MessageBox.Show("Houve um problema com a conenão com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }

        //Metodo para verificação de Idiomas
        private void comboBoxIdiomas_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas_2.SelectedIndex > 0)
                comboBoxIdiomas_3.Enabled = true;

            if (comboBoxIdiomas_2.SelectedIndex == 0)
            {
                comboBoxIdiomas_3.Enabled = false;
                comboBoxIdiomas_4.Enabled = false;
            }
            if (comboBoxIdiomas_3.SelectedIndex == 0)
                comboBoxIdiomas_4.Enabled = false;
        }
        //Metodo para verificação de Idiomas
        private void comboBoxIdiomas_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas_1.SelectedIndex > 0)
                comboBoxIdiomas_2.Enabled = true;

            if (comboBoxIdiomas_1.SelectedIndex == 0)
            {
                comboBoxIdiomas_2.Enabled = false;
                comboBoxIdiomas_3.Enabled = false;
                comboBoxIdiomas_4.Enabled = false;
            }

            if (comboBoxIdiomas_2.SelectedIndex == 0)
            {
                comboBoxIdiomas_3.Enabled = false;
                comboBoxIdiomas_4.Enabled = false;
            }
            if (comboBoxIdiomas_3.SelectedIndex == 0)
                comboBoxIdiomas_4.Enabled = false;
        }
        //Metodo para verificação de Idiomas
        private void comboBoxIdiomas_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas_3.SelectedIndex > 0)
                comboBoxIdiomas_4.Enabled = true;

            if (comboBoxIdiomas_3.SelectedIndex == 0)
                comboBoxIdiomas_4.Enabled = false;
        }
    }
}
