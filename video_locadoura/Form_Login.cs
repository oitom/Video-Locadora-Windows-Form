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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        public string NomeUsuario;
        public string Nome;
        bool erro = false;

        private void Acessar_Click(object sender, EventArgs e)        
        {
            //Limpa o erro provider
            error.Clear();

            //Verfica se tem campos em branco
            if (textBoxLogin.Text == "")
            {
                error.SetError(textBoxLogin, "Não está preenchido!");
                erro = true;
            }
            if (textBoxSenha.Text == "")
            {
                error.SetError(textBoxSenha, "Não está preenchido!");
                erro = true;
            }
            else
                erro = false;


            if (erro == false)
            {
                //Cria um objeto da classe Usuario, onde é passado como parâmetro o ligin e a senha
               Usuario USU = new Usuario(textBoxLogin.Text, textBoxSenha.Text);
               //recebe o retorno da criptografia dasenha informada
               string senha_Critpto = USU.CriptoSenha(textBoxSenha.Text);

                try
                {
                    CONEXAO.Open();
                    labelErroConectar.Visible = false;
                    //Seleciona a senha cadastrada no banco
                    SqlCommand COMANDOCONSULTA_USU = new SqlCommand("SELECT USU_Senha FROM USUARIO WHERE USU_Login = @USU_Login", CONEXAO);
                    SqlParameter PUSULogin = new SqlParameter("@USU_Login", textBoxLogin.Text);
                    COMANDOCONSULTA_USU.Parameters.Add(PUSULogin);
                    string Senha = "";
                    //Verifica se o usuario existe
                    if (COMANDOCONSULTA_USU.ExecuteScalar() != null)
                        Senha = COMANDOCONSULTA_USU.ExecuteScalar().ToString();

                    //Verifica se a senha informada bate com a senha cadastrada
                    if (Senha == senha_Critpto)
                    {
                        SqlCommand COMANDOCONSULTA_NOME_USU = new SqlCommand("SELECT USU_Nome FROM USUARIO WHERE USU_Login = @USU_Login", CONEXAO);
                        SqlParameter USULogin = new SqlParameter("@USU_Login", textBoxLogin.Text);
                        COMANDOCONSULTA_NOME_USU.Parameters.Add(USULogin);
                        Nome = COMANDOCONSULTA_NOME_USU.ExecuteScalar().ToString();
                        //Carrega o nome do usuário no ToolstripMenu
                        NomeUsuario = Nome;
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                    }
                    else
                    {
                        labelErroConectar.Visible = true;
                        textBoxLogin.Text = "";
                        textBoxSenha.Text = "";
                        textBoxLogin.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na tentativa de conectar com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                        CONEXAO.Close();
                }
            }
         }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //Caso o usuario queira cancelar a entrada no progrma, ele será fechado
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

    }
}
