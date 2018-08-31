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
    public partial class Form_Novo_Filme : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        int COD_Filme;
        public Form_Novo_Filme()
        {
            InitializeComponent();
        }
        bool erro = false;
        OpenFileDialog procurar;
        //Metodo para carregar a capa do filme
        private void button1_Click(object sender, EventArgs e)
        {
            //Carrega no pictureBox a capa selecionada
            procurar = new OpenFileDialog();
            if (procurar.ShowDialog() != null && procurar.FileName != "")
                pictureBoxCapa.Image = Bitmap.FromFile(procurar.FileName.ToString());
        }

        private void Form_Novo_Filme_Load(object sender, EventArgs e)
        {
            comboBoxQuantidade.SelectedIndex = 0;
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
                MessageBox.Show("Houve um problema em carregar o código do filme", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }

            //carrega o comboBox Catalogo de preço
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTIP_MIDIA = new SqlCommand("SELECT CAT_DESCRICAO FROM CATALOGO_PRECOS", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTIP_MIDIA.ExecuteReader();
                comboBoxCatalagoPreco.Items.Add("Selecione");
                comboBoxCatalagoPreco.SelectedIndex = 0;
                //Carrega o comboBox catalogo de preço
                while (LEITOR.Read())
                    comboBoxCatalagoPreco.Items.Add(LEITOR["CAT_DESCRICAO"].ToString());
                
                comboBoxCatalagoPreco.SelectedIndex = 0;
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

            //carrega o comboBox tipo do filme
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTIP_MIDIA = new SqlCommand("SELECT TIP_Desc FROM TIPOS_MIDIAS", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTIP_MIDIA.ExecuteReader();
                comboBoxTipo.Items.Add("Selecione");
                comboBoxTipo.SelectedIndex = 0;
                //Carrega o comboBox tipo do filme
                while (LEITOR.Read())
                    comboBoxTipo.Items.Add(LEITOR["TIP_Desc"].ToString());
                
                comboBoxTipo.SelectedIndex = 0;

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
        //Metodo para cadastrar um novo gênero
        private void buttonNovoGenero_Click(object sender, EventArgs e)
        {
            Form_Cadastro_genero formulario_cadastro_Genero = new Form_Cadastro_genero();
            formulario_cadastro_Genero.ShowDialog();
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

            //Verifica se os campos obrigatórios estão preenchido
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
            if (comboBoxTipo.Text == "")
            {
                error.SetError(buttonNovoGenero, "O campo 'Tipo' não está preechido!");
                erro = true;
            }
            if (comboBoxGenero.Text == "")
            {
                error.SetError(buttonNovoGenero, "O campo 'Gênero' não está preenchido!");
                erro = true;
            }
            if (textBoxAnoLancamento.Text == "" )
            {
                error.SetError(textBoxAnoLancamento, "O campo 'Data de Lançamento' não está preenchido!");
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
            if (comboBoxTipo.SelectedIndex == 0)
            {
                error.SetError(buttonNovoGenero, "O campo 'Tipo' não está preenchido!");
                erro = true;
            }


            if (erro == false)
            {
                //Cadastra o filme
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja adicionar o filme " + textBoxTitulo.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        CONEXAO.Open();
                        //Cadastra o filme
                        SqlCommand COMANDOINSERT_FILMES = new SqlCommand("INSERT INTO FILMES VALUES (@FIL_Titulo, @GEN_Cod, @FIL_Data_Lanc, @CAT_Cod, @FIL_Classificacao, @FIL_Diretor, @FIL_Produtora, @FIL_Sinopse, @FIL_Capa)", CONEXAO);
                        SqlParameter PFilmeTitulo = new SqlParameter("@FIL_Titulo", textBoxTitulo.Text);
                        SqlParameter PGenero = new SqlParameter("@GEN_Cod", (int)comboBoxGenero.SelectedIndex);
                        SqlParameter PFilmeLan = new SqlParameter("@FIL_Data_Lanc", textBoxAnoLancamento.Text);
                        SqlParameter PFilmeCate = new SqlParameter("@CAT_Cod", (int)comboBoxCatalagoPreco.SelectedIndex);
                        SqlParameter PFilmeClass = new SqlParameter("@FIL_Classificacao", textBoxClassificacao_Indicativa.Text);

                        SqlParameter PFilmeDiretor;
                        if (textBoxDiretor.Text == "")
                            PFilmeDiretor = new SqlParameter("@FIL_Diretor", " ");
                        else
                            PFilmeDiretor = new SqlParameter("@FIL_Diretor", textBoxDiretor.Text);

                        SqlParameter PFilmeProd;
                        if (textBoxProdutora.Text == "")
                            PFilmeProd = new SqlParameter("@FIL_Produtora", " ");
                        else
                            PFilmeProd = new SqlParameter("@FIL_Produtora", textBoxProdutora.Text);

                        SqlParameter PFilmeSinop;
                        if (richTextBoxSinopse.Text == "")
                            PFilmeSinop = new SqlParameter("@FIL_Sinopse", " ");
                        else
                            PFilmeSinop = new SqlParameter("@FIL_Sinopse", richTextBoxSinopse.Text);

                        SqlParameter PFilmeCapa;
                        if (procurar == null)
                            PFilmeCapa = new SqlParameter("@FIL_Capa", @"C:\PROGRAMA LOCADORA\BANCO DE DADOS\IMAGENS CAPA\semfoto.JPG");
                        else
                            PFilmeCapa = new SqlParameter("@FIL_Capa", procurar.FileName.ToString());

                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeTitulo);
                        COMANDOINSERT_FILMES.Parameters.Add(PGenero);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeLan);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeCate);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeClass);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeDiretor);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeProd);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeSinop);
                        COMANDOINSERT_FILMES.Parameters.Add(PFilmeCapa);
                        COMANDOINSERT_FILMES.ExecuteNonQuery();

                        //Verificação se tem selecionado algum idioma, onde serão cadastrados
                        if (comboBoxIdiomas_1.SelectedIndex != 0)
                        {
                            SqlCommand COMANDOINSERT_IDI_FIL_1 = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_1, @FIL_Cod_1)", CONEXAO);
                            SqlParameter PFilmeIdioma_1 = new SqlParameter("@IDI_Cod_1", (int)comboBoxIdiomas_1.SelectedIndex);
                            SqlParameter PFilmeCod_1 = new SqlParameter("@FIL_Cod_1", textBoxcodigo.Text);
                            COMANDOINSERT_IDI_FIL_1.Parameters.Add(PFilmeIdioma_1);
                            COMANDOINSERT_IDI_FIL_1.Parameters.Add(PFilmeCod_1);
                            COMANDOINSERT_IDI_FIL_1.ExecuteNonQuery();
                        }
                        if (comboBoxIdiomas_2.SelectedIndex != 0)
                        {
                            SqlCommand COMANDOINSERT_IDI_FIL_2 = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_2, @FIL_Cod_2)", CONEXAO);
                            SqlParameter PFilmeIdioma_2 = new SqlParameter("@IDI_Cod_2", (int)comboBoxIdiomas_2.SelectedIndex);
                            SqlParameter PFilmeCod_2 = new SqlParameter("@FIL_Cod_2", textBoxcodigo.Text);
                            COMANDOINSERT_IDI_FIL_2.Parameters.Add(PFilmeIdioma_2);
                            COMANDOINSERT_IDI_FIL_2.Parameters.Add(PFilmeCod_2);
                            COMANDOINSERT_IDI_FIL_2.ExecuteNonQuery();
                        }
                        if (comboBoxIdiomas_3.SelectedIndex != 0)
                        {
                            SqlCommand COMANDOINSERT_IDI_FIL_3 = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_3, @FIL_Cod_3)", CONEXAO);
                            SqlParameter PFilmeIdioma_3 = new SqlParameter("@IDI_Cod_3", (int)comboBoxIdiomas_3.SelectedIndex);
                            SqlParameter PFilmeCod_3 = new SqlParameter("@FIL_Cod_3", textBoxcodigo.Text);
                            COMANDOINSERT_IDI_FIL_3.Parameters.Add(PFilmeIdioma_3);
                            COMANDOINSERT_IDI_FIL_3.Parameters.Add(PFilmeCod_3);
                            COMANDOINSERT_IDI_FIL_3.ExecuteNonQuery();
                        }
                        if (comboBoxIdiomas_4.SelectedIndex != 0)
                        {
                            SqlCommand COMANDOINSERT_IDI_FIL_4 = new SqlCommand("INSERT INTO REL_FIL_IDI VALUES (@IDI_Cod_4, @FIL_Cod_4)", CONEXAO);
                            SqlParameter PFilmeIdioma_4 = new SqlParameter("@IDI_Cod_4", (int)comboBoxIdiomas_4.SelectedIndex);
                            SqlParameter PFilmeCod_4 = new SqlParameter("@FIL_Cod_4", textBoxcodigo.Text);
                            COMANDOINSERT_IDI_FIL_4.Parameters.Add(PFilmeIdioma_4);
                            COMANDOINSERT_IDI_FIL_4.Parameters.Add(PFilmeCod_4);
                            COMANDOINSERT_IDI_FIL_4.ExecuteNonQuery();                        
                        }


                        for (int i = 0; i <= comboBoxQuantidade.SelectedIndex; i++)
                        {
                            SqlCommand COMANDOINSERIR_CODFIL = new SqlCommand("INSERT INTO CODFILMES VALUES (0, @FIL_Cod, @TIP_Cod)", CONEXAO);
                            SqlParameter PQTDFilme = new SqlParameter("@FIL_Cod", COD_Filme);
                            SqlParameter PTipo = new SqlParameter("@TIP_Cod", (int)comboBoxTipo.SelectedIndex);
                            COMANDOINSERIR_CODFIL.Parameters.Add(PQTDFilme);
                            COMANDOINSERIR_CODFIL.Parameters.Add(PTipo);
                            COMANDOINSERIR_CODFIL.ExecuteNonQuery();
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
                        MessageBox.Show("Filme cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //após cadastrado volta na primeiro Tab
                        tabControlCadastroFilme.SelectedTab = tabPageFilme;
                    }

                }
                else
                    Limpar();
            }

        }
               
        //Método para limpar os componentes do formulário
        public void Limpar()
        {
            comboBoxIdiomas_1.SelectedIndex = 0;
            comboBoxIdiomas_2.SelectedIndex = 0;
            comboBoxIdiomas_3.SelectedIndex = 0;
            comboBoxIdiomas_4.SelectedIndex = 0;
            comboBoxQuantidade.SelectedIndex = 0;
            comboBoxTipo.SelectedIndex = 0;
            comboBoxGenero.SelectedIndex = 0;
            comboBoxCatalagoPreco.SelectedIndex = 0;
            //Limpa os componentes do Tabpag 1
            foreach (object o in this.tabPageFilme.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
                else if (o is ComboBox)
                    ((ComboBox)o).Text = "";
            }
            //Limpa os componentes do Tabpag 2
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
        //Método para seleionar o gênero
        public void Seleciona_Genero()
        {
            if (comboBoxGenero.Items.Count != 0)
                comboBoxGenero.Items.Clear();
            
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
        //Método para verificação dos item do comboBox Idiomas
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
        //Método para verificação dos item do comboBox Idiomas
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
        //Método para verificação dos item do comboBox Idiomas
        private void comboBoxIdiomas_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas_3.SelectedIndex > 0)
                comboBoxIdiomas_4.Enabled = true;

            if (comboBoxIdiomas_3.SelectedIndex == 0)
            comboBoxIdiomas_4.Enabled = false;
            
        }
             
    }
}
