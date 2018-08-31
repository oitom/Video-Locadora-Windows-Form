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
    public partial class Form_Alterar_Senha : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        int COD_USUARIO = 0;
        public Form_Alterar_Senha(int codigo_usuario)
        {
            COD_USUARIO = codigo_usuario;
            InitializeComponent();
        }
        bool Erro_Senha = false;
        bool erro_preenchimento = false;
        private void button_Salvar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum campo vázio
            //se tiver informa um erro ao lado do campo que está vázio
            error.Clear();
            erro_preenchimento = false;
            if (textBox_Senha_Atual.Text == "")
            {
                error.SetError(textBox_Senha_Atual, "Não está preenchido!");
                erro_preenchimento = true;
            }
            if (textBox_Nova_Senha.Text == "")
            {
                error.SetError(textBox_Nova_Senha, "Não está preenchido!");
                erro_preenchimento = true;
            }
            if (textBox_Confirmar_senha.Text == "")
            {
                error.SetError(textBox_Confirmar_senha, "Não está preenchido!");
                erro_preenchimento = true;
            }

            //se os campos estiverem preenchido, executa o procedimento de alteração de senha
            if (erro_preenchimento == false)
            {
                try
                {
                    //seleciona a senha do usuario
                    CONEXAO.Open();
                    SqlCommand COMANDOSELECT_USU = new SqlCommand("SELECT USU_Senha FROM USUARIO WHERE USU_Cod = @USU_COD", CONEXAO);
                    SqlParameter COD_USU = new SqlParameter("@USU_COD", COD_USUARIO);
                    COMANDOSELECT_USU.Parameters.Add(COD_USU);
                    LEITOR = COMANDOSELECT_USU.ExecuteReader();
                    string Senha_usuario = "";
                    
                    while (LEITOR.Read())
                    {
                        Senha_usuario = LEITOR["USU_Senha"].ToString();

                    }
                    
                    labelErroSenha.Visible = false;
                    labelErroSenha_Atual.Visible = false;

                    string Senha_usuario_Antiga = textBox_Senha_Atual.Text;
                    Usuario Usu = new Usuario("", Senha_usuario_Antiga);
                    string Cripto_Senha = Usu.CriptoSenha(Senha_usuario_Antiga);
                    LEITOR.Close();

                    //verifica se a senha atual está correta
                    if (Cripto_Senha == Senha_usuario)
                    {
                        //verifica se a Nova senha bate com a confirrmar senha
                        if (textBox_Nova_Senha.Text == textBox_Confirmar_senha.Text)
                        {
                            //Comando para alteração da senha
                            Usuario Usuario = new Usuario("", textBox_Confirmar_senha.Text);
                            string Nova_Senha = Usuario.CriptoSenha(textBox_Confirmar_senha.Text);

                            SqlCommand COMANDOUPDATE_USU = new SqlCommand("UPDATE USUARIO SET USU_Senha = @USU_Senha WHERE USU_Cod = @USU_COD", CONEXAO);
                            SqlParameter PUSUCOD = new SqlParameter("@USU_COD", COD_USUARIO);
                            SqlParameter PUSUSENHA = new SqlParameter("@USU_Senha", Nova_Senha);
                            COMANDOUPDATE_USU.Parameters.Add(PUSUCOD);
                            COMANDOUPDATE_USU.Parameters.Add(PUSUSENHA);
                            COMANDOUPDATE_USU.ExecuteNonQuery();


                            MessageBox.Show("Senha alterada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            //mostra que houve um erro na nova senha ou 
                            labelErroSenha.Visible = true;
                            Erro_Senha = true;
                        }
                    }
                    else
                    {
                        //mostra que houve um erro no preenchimento do campo "senha atual"
                        labelErroSenha_Atual.Visible = true;
                        Erro_Senha = true;
                    }

                }
                catch
                {
                    MessageBox.Show("Erro em alterar senha do Usuario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (CONEXAO.State == ConnectionState.Open)
                        CONEXAO.Close();
                    LEITOR.Close();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
