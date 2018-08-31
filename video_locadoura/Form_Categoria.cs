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
    public partial class Form_Categoria : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        string Valor_PRO = "";
        string Valor_LAN = "";
        string Valor_NOR = "";
        
        public Form_Categoria()
        {
            InitializeComponent();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            textBox_Lançamento.ReadOnly = false;
            textBox_Normal.ReadOnly = false;
            textBox_Promocional.ReadOnly = false;
            button_Salvar.Enabled = true;
        }


        private void Form_Categoria_Load(object sender, EventArgs e)
        {
            textBox_Lançamento.ReadOnly = true;
            textBox_Normal.ReadOnly = true;
            textBox_Promocional.ReadOnly = true;
            button_Salvar.Enabled = false;
            try 
	        {
                
                //Seleciona os valores das categorias e carrega nos TextBoxs
                CONEXAO.Open();
                SqlCommand COMANDO_SELECT_CAT = new SqlCommand("SELECT CAT_Cod, CAT_DESCRICAO, VAL_Valor FROM CATALOGO_PRECOS ", CONEXAO);
                LEITOR = null;
                LEITOR = COMANDO_SELECT_CAT.ExecuteReader();

                //carrega os valore respectivos a sua descrição
                if (LEITOR.Read() == true)
                {
                    Valor_LAN = LEITOR["VAL_Valor"].ToString();
                    Valor_LAN = Valor_LAN.Substring(0, 4);                    
                    textBox_Lançamento.Text = Valor_LAN;
                }
                if (LEITOR.Read() == true)
                {
                    Valor_NOR = LEITOR["VAL_Valor"].ToString();
                    Valor_NOR = Valor_NOR.Substring(0, 4);
                    textBox_Normal.Text = Valor_NOR;
                }
                if (LEITOR.Read() == true)
                {
                    Valor_PRO = LEITOR["VAL_Valor"].ToString();
                    Valor_PRO = Valor_PRO.Substring(0, 4);
                    textBox_Promocional.Text = Valor_PRO;
                }
	        }
            catch
            {
                MessageBox.Show("Erro em carregar o valor da categoria");
            }
	        finally
	        {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();
	        }

        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();

                CONEXAO.Open();

                //Verifica se houve alteração nos valores da categoria
                //se tiver são alterados
                if (Valor_LAN != textBox_Lançamento.Text)
                {
                    SqlCommand COMANDO_UPDATE = new SqlCommand("UPDATE CATALOGO_PRECOS SET VAL_Valor = @VALOR WHERE CAT_DESCRICAO = 'LANÇAMENTO' ", CONEXAO);
                    SqlParameter PVALOR = new SqlParameter("@VALOR", textBox_Lançamento.Text);
                    COMANDO_UPDATE.Parameters.Add(PVALOR);
                    COMANDO_UPDATE.ExecuteNonQuery();
                }
                if (Valor_NOR != textBox_Normal.Text)
                {
                    SqlCommand COMANDO_UPDATE = new SqlCommand("UPDATE CATALOGO_PRECOS SET VAL_Valor = @VALOR WHERE CAT_DESCRICAO = 'NORMAL' ", CONEXAO);
                    SqlParameter PVALOR = new SqlParameter("@VALOR", textBox_Normal.Text);
                    COMANDO_UPDATE.Parameters.Add(PVALOR);
                    COMANDO_UPDATE.ExecuteNonQuery();
                }
                if (Valor_PRO != textBox_Promocional.Text)
                {
                    SqlCommand COMANDO_UPDATE = new SqlCommand("UPDATE CATALOGO_PRECOS SET VAL_Valor = @VALOR WHERE CAT_DESCRICAO = 'PROMOCIONAL' ", CONEXAO);
                    SqlParameter PVALOR = new SqlParameter("@VALOR", textBox_Promocional.Text);
                    COMANDO_UPDATE.Parameters.Add(PVALOR);
                    COMANDO_UPDATE.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Erro em alterar o valor da categoria");
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();

                MessageBox.Show("Categoria foi alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Lançamento.ReadOnly = true;
                textBox_Normal.ReadOnly = true;
                textBox_Promocional.ReadOnly = true;
                button_Salvar.Enabled = false;

            }
        }
        
    }
}
