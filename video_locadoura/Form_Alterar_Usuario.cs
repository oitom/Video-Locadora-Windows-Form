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
    public partial class Form_Alterar_Usuario : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        public Form_Alterar_Usuario()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            //após ter preenchido o campo "Código" ou "Nome" e ter precionado a tecla "ENTER" 
            //é feito a pesquisa para listar o usuário
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Usuario.Focused == true || textBox_Nome_Usuario.Focused == true)
                    {
                        MetodoConsulta();
                    }
                    if (listView_Usuario.Focused == true)
                    {
                        MetodoAlteraUsuario();
                    }
                    break;
            }
        }
        private void MetodoAlteraUsuario()
        {
            //Verifica se tem algum item selecionado, onde é passado como parametro o seu código
            if (listView_Usuario.SelectedItems.Count != 0)
            {
                Form_Atualiza_Usuario formulario_Atualiza_Usuario = new Form_Atualiza_Usuario(int.Parse(listView_Usuario.SelectedItems[0].Text));
                formulario_Atualiza_Usuario.ShowDialog();
                //Após ter atualizado os dados do usuário, o list view é limpo
                listView_Usuario.Items.Clear();
                textBox_Nome_Usuario.Text = "";
                maskedTextBox_Cod_Usuario.Text = "";
            }
        }

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();

                SqlCommand CONSULTAUSUARIO;

                //Faz a consulta dos dados do usuário pelo código informado
                if (maskedTextBox_Cod_Usuario.Focused == true)
                {
                    CONSULTAUSUARIO = new SqlCommand("SELECT USU_Cod, USU_Nome, USU_Login, USU_CPF FROM USUARIO WHERE USU_Cod = @COD_USU", CONEXAO);

                    SqlParameter USU1 = new SqlParameter("@COD_USU", int.Parse(maskedTextBox_Cod_Usuario.Text));
                    CONSULTAUSUARIO.Parameters.Add(USU1);
                }
                else
                {
                    //Faz a consulta dos dados do usuário pelo nome informado
                    CONSULTAUSUARIO = new SqlCommand("SELECT USU_Cod, USU_Nome, USU_Login, USU_CPF FROM USUARIO WHERE USU_Nome like @NOME_USU", CONEXAO);
                    SqlParameter USU = new SqlParameter("@NOME_USU", "%" + textBox_Nome_Usuario.Text + "%");
                    CONSULTAUSUARIO.Parameters.Add(USU);

                }

                LEITOR = null;
                LEITOR = CONSULTAUSUARIO.ExecuteReader();

                listView_Usuario.Items.Clear();

                //carrega o list view com os dados dos usuários deacordo com o campo
                while (LEITOR.Read())
                {
                    ListViewItem CODIGO_USUARIO = new ListViewItem(LEITOR["USU_Cod"].ToString());

                    ListViewItem.ListViewSubItem NOME_USUARIO = new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem LOGIN_USUARIO= new ListViewItem.ListViewSubItem();

                    ListViewItem.ListViewSubItem CPF_USUARIO = new ListViewItem.ListViewSubItem();


                    NOME_USUARIO.Text = LEITOR["USU_Nome"].ToString();
                    CODIGO_USUARIO.SubItems.Add(NOME_USUARIO);

                    LOGIN_USUARIO.Text = LEITOR["USU_Login"].ToString();
                    CODIGO_USUARIO.SubItems.Add(LOGIN_USUARIO);

                    CPF_USUARIO.Text = LEITOR["USU_CPF"].ToString();
                    CODIGO_USUARIO.SubItems.Add(CPF_USUARIO);

                    listView_Usuario.Items.Add(CODIGO_USUARIO);

                }

            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar os Usuários", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }

        private void Usuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoAlteraUsuario();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            MetodoAlteraUsuario();
        }
        
    }
}

