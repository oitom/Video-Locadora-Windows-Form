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
    public partial class Form_Cadastro_genero : Form
    {
        
        public string GENERO;
        public Form_Cadastro_genero()
        {
            InitializeComponent();
        }
        bool erro = false;
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        
        private void button1_Click(object sender, EventArgs e)
        {
            error.Clear();
            //Verifica se os campos estão em branco
            if (textBoxGenero.Text == "")
            {
                error.SetError(textBoxGenero, "Não está preenchido!");
                erro = true;
            }

            if (erro == false)
            { 
                //cadastrar gênero
                try
                {
                    CONEXAO.Open();
                    //cadastra o genêro
                    SqlCommand COMANDOINSERIR = new SqlCommand("INSERT INTO GENEROS VALUES (@GEN_Desc)", CONEXAO);
                    SqlParameter PGen = new SqlParameter("@GEN_Desc", textBoxGenero.Text);
                    COMANDOINSERIR.Parameters.Add(PGen);
                    DialogResult Resultado = MessageBox.Show("Você tem certeza que deseja cadastrar esse gênero " + textBoxGenero.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        COMANDOINSERIR.ExecuteNonQuery();
                        GENERO = textBoxGenero.Text;
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
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
