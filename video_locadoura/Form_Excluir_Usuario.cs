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
    public partial class Form_Excluir_Usuario : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;

        public Form_Excluir_Usuario()
        {
            InitializeComponent();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Novo_Usuario formulario_Usuario = new Form_Novo_Usuario();
            formulario_Usuario.ShowDialog();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Métofo para funcionamento da tecla <ENTER>
        private void Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (maskedTextBox_Cod_Usuario.Focused == true || textBox_Nome_Usuario.Focused == true)
                        MetodoConsulta();
                    if (listView_Usuario.Focused == true)
                        MetodoAlteraUsuario();
                break;
            }
        }
        private void MetodoAlteraUsuario()
        {

            if (listView_Usuario.SelectedItems.Count != 0)
            {
                string Cod_usuario = listView_Usuario.SelectedItems[0].Text;

                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja excluir esse Usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    //cogido para exclusão de Usuario
                    try
                    {
                        CONEXAO.Open();
                        //Comando para deletar o usuário
                        SqlCommand COMANDODELETE_USU = new SqlCommand("DELETE FROM USUARIO WHERE USU_Cod = @USU_COD", CONEXAO);
                        SqlParameter COD_USU = new SqlParameter("@USU_COD", Cod_usuario);
                        COMANDODELETE_USU.Parameters.Add(COD_USU);
                        COMANDODELETE_USU.ExecuteNonQuery();

                    }
                    catch
                    {
                        MessageBox.Show("erro em deletar Usuário");
                    }
                    finally
                    {
                        if (CONEXAO.State == ConnectionState.Open)
                            CONEXAO.Close();
                        LEITOR.Close();

                        listView_Usuario.SelectedItems[0].Remove();
                        MessageBox.Show("Usuário apagado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void MetodoConsulta()
        {
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTAUSUARIO;
                //Verifica qual é o campo para filtra os usuários
                if (maskedTextBox_Cod_Usuario.Focused == true)
                {
                    //Seleciona o usuário usando como filtro o código
                    CONSULTAUSUARIO = new SqlCommand("SELECT USU_Cod, USU_Nome, USU_Login, USU_CPF FROM USUARIO WHERE USU_Cod = @COD_USU", CONEXAO);
                    SqlParameter USU1 = new SqlParameter("@COD_USU", int.Parse(maskedTextBox_Cod_Usuario.Text));
                    CONSULTAUSUARIO.Parameters.Add(USU1);
                }
                else
                {
                    //Seleciona o usuário usando como filtro o Nome
                    CONSULTAUSUARIO = new SqlCommand("SELECT USU_Cod, USU_Nome, USU_Login, USU_CPF FROM USUARIO WHERE USU_Nome like @NOME_USU", CONEXAO);
                    SqlParameter USU = new SqlParameter("@NOME_USU", "%" + textBox_Nome_Usuario.Text + "%");
                    CONSULTAUSUARIO.Parameters.Add(USU);
                }

                LEITOR = null;
                LEITOR = CONSULTAUSUARIO.ExecuteReader();

                listView_Usuario.Items.Clear();
                //Carrga os list view com os dados do usuário
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

        private void listView_Usuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MetodoAlteraUsuario();
        }

        private void button_Locar_Click(object sender, EventArgs e)
        {
            MetodoAlteraUsuario();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

