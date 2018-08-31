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
    public partial class FormNova_Cidade : Form
    {

        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private int Cod;
        public string CIDADE;
        //Recebe no construtor o código do estado da nova cidade
        public FormNova_Cidade(int Codigo)
        {
            Cod = Codigo;
            InitializeComponent();
        }
        //Método para cadastrar a nova cidade
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXAO.Open();
                //Inseri a nova cidade
                SqlCommand COMANDOINSERIR = new SqlCommand("INSERT INTO CIDADES VALUES (@CID_Desc,@UF_Cod)", CONEXAO);
                SqlParameter P1 = new SqlParameter("@CID_Desc", textBoxCidade.Text);
                SqlParameter P2 = new SqlParameter("@UF_Cod", Cod);
                COMANDOINSERIR.Parameters.Add(P1);
                COMANDOINSERIR.Parameters.Add(P2);
                DialogResult Resultado = MessageBox.Show("Você tem certeza que deseja cadastrar a cidade de " + textBoxCidade.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    COMANDOINSERIR.ExecuteNonQuery();
                    CIDADE = textBoxCidade.Text;
                    Form_Novo_Cliente form = new Form_Novo_Cliente();
                    form.AtualizaCidades();
   
                    
                }              
            }
            catch
            {
                MessageBox.Show("Houve um problema com a conenão com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();             
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
