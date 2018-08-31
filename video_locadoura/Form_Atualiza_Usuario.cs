using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace video_locadora
{
    public partial class Form_Atualiza_Usuario : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        OpenFileDialog procurar;
        int cod_usu;
        //Recebe no construtor o código do usuárioa ser alterado
        public Form_Atualiza_Usuario(int COD_USU)
        {
            cod_usu = COD_USU;
            InitializeComponent();
        }
        //carrega os dados do usuário
        private void Form_Novo_Usuario_Load(object sender, EventArgs e)
        {
            textBoxCodigo_USU.Text = cod_usu.ToString();
            try
            {
                CONEXAO.Open();
                //seleciona os dados do usuário de acordo com o seu código
                SqlCommand COMANDOSELECT_USU = new SqlCommand("SELECT USU_Cod, USU_Nome, USU_RG, USU_CPF, USU_Sexo, USU_Foto, USU_Dt_Adim, USU_Login, USU_Senha FROM USUARIO WHERE USU_Cod = @USU_COD", CONEXAO);
                SqlParameter COD_USU = new SqlParameter("@USU_COD", textBoxCodigo_USU.Text);
                COMANDOSELECT_USU.Parameters.Add(COD_USU);
                LEITOR = COMANDOSELECT_USU.ExecuteReader();

                //preenche os campos do usuário, para ser alerado
                while (LEITOR.Read())
                {
                    textBoxNome.Text = LEITOR["USU_Nome"].ToString();
                    textBoxRg.Text = LEITOR["USU_RG"].ToString();
                    string CPF = LEITOR["USU_CPF"].ToString();
                    CPF = CPF.Replace(".", "");
                    CPF = CPF.Replace("-", "");
                    maskedTextBoxCpf.Text = CPF;
                    string Sexo = LEITOR["USU_Sexo"].ToString();
                    if (Sexo == "M")
                        radioButtonMasc.Checked = true;
                    else
                        radioButtonFem.Checked = true;
                    string end_foto = LEITOR["USU_Foto"].ToString();
                    //verifica o endereço da foto do usuário
                    if (end_foto == "")
                        pictureBoxFoto.Image = Bitmap.FromFile(@"C:\PROGRAMA LOCADORA\BANCO DE DADOS\IMAGENS USUARIO\masculino.JPG");
                    else
                        pictureBoxFoto.Image = Bitmap.FromFile(end_foto);

                    pictureBoxFoto.Tag = end_foto;

                    string dt_Adim = LEITOR["USU_Dt_Adim"].ToString();
                    dt_Adim = dt_Adim.Replace("/", "");
                    maskedTextBoxDataAdmissao.Text = dt_Adim;
                    textBoxLogin.Text = LEITOR["USU_Login"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Erro em carregar os dados do Usuário");
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                
                if(LEITOR != null)
                    LEITOR.Close();
            }
        }


        bool erro = false;
        //Metodo de verificação dos campos para cadastrar
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            error.Clear();
            erro = false;
            labelErroCPF.Visible = false;
            //cria uma variavel onde seu valor é um campo com algums caracteres removidos
            string DataAdmissao = maskedTextBoxDataAdmissao.Text;
            string CPF = maskedTextBoxCpf.Text;
            DataAdmissao = DataAdmissao.Replace("/", "");
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");
                        
             //chama o método para verificação de CPF
            bool Validacao = ValidaCPF(maskedTextBoxCpf.Text);
            if (Validacao == false)
            {
                labelErroCPF.Visible = true;
            }
            else
                labelErroCPF.Visible = false;
            
            //Verificação de preenchimento dos campos
           if (textBoxNome.Text == "")
            {
                error.SetError(textBoxNome, "Não está preenchido!");
                erro = true;
            }
            if (textBoxRg.Text == "")
            {
                error.SetError(maskedTextBoxDataAdmissao, "Não está preenchido!");
                erro = true;
            }
            if (Validacao == false)
            {
                error.SetError(maskedTextBoxDataAdmissao, "Não está preenchido!");
                erro = true;
            }
            if (DataAdmissao.Length < 8)
            {
                error.SetError(maskedTextBoxDataAdmissao, "Não está preenchido!");
                erro = true;
            }
            if (textBoxLogin.Text == "")
            {
                error.SetError(textBoxLogin, "Não está preenchido!");
                erro = true;
            }
            

            if (erro == false)
            { 
                //cadastrar usuário
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja alterar " + textBoxNome.Text + " como novo Usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                bool erro_login = false;
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        CONEXAO.Open();
                        SqlCommand COMANDOSELECT_LOGIN = new SqlCommand("SELECT USU_Login FROM USUARIO WHERE USU_Cod != @USU_Cod", CONEXAO);
                        SqlParameter PCOD_USU = new SqlParameter("@USU_Cod", textBoxCodigo_USU.Text);
                        COMANDOSELECT_LOGIN.Parameters.Add(PCOD_USU);
                        LEITOR = null;
                        LEITOR = COMANDOSELECT_LOGIN.ExecuteReader();
                        while (LEITOR.Read())
                        {
                            string lOGIN_USU = LEITOR["USU_Login"].ToString();
                            if (textBoxLogin.Text == lOGIN_USU)
                                erro_login = true;
                        }

                        if (erro_login == false)
                        {
                            string COD_USU = textBoxCodigo_USU.Text;
                            LEITOR.Close();
                            SqlCommand COMANDOUPDATE_USU = new SqlCommand("UPDATE USUARIO SET USU_Nome = @USU_Nome, USU_RG = @USU_RG, USU_CPF = @USU_CPF, USU_Dt_Adim = @USU_Dt_Admim, USU_Sexo = @USU_Sexo, USU_Foto = @USU_Foto, USU_Login = @USU_Login WHERE USU_Cod = @USU_COD", CONEXAO);
                            SqlParameter PUSUCOD = new SqlParameter("@USU_COD", COD_USU);
                            SqlParameter PUSUNome = new SqlParameter("@USU_Nome", textBoxNome.Text);
                            SqlParameter PUSURG = new SqlParameter("@USU_RG", textBoxRg.Text);
                            SqlParameter PUSUCPF = new SqlParameter("@USU_CPF", maskedTextBoxCpf.Text);

                            string[] Separa_data;
                            Separa_data = maskedTextBoxDataAdmissao.Text.Split(new char[] { '/' });
                            string Data_Admisao = Separa_data[2] + "-" + Separa_data[1] + "-" + Separa_data[0];

                            SqlParameter PUSUDtAdm = new SqlParameter("@USU_Dt_Admim", Data_Admisao);

                            SqlParameter PUSUSEXO;
                            if (radioButtonFem.Checked == true)
                                PUSUSEXO = new SqlParameter("@USU_Sexo", "F");
                            else
                                PUSUSEXO = new SqlParameter("@USU_Sexo", "M");

                            SqlParameter PUSUFOTO;
                            if (procurar == null)
                                PUSUFOTO = new SqlParameter("@USU_Foto", pictureBoxFoto.Tag);
                            else
                                PUSUFOTO = new SqlParameter("@USU_Foto", procurar.FileName.ToString());

                            SqlParameter PUSULogin = new SqlParameter("@USU_Login", textBoxLogin.Text);

                            COMANDOUPDATE_USU.Parameters.Add(PUSUNome); COMANDOUPDATE_USU.Parameters.Add(PUSURG);
                            COMANDOUPDATE_USU.Parameters.Add(PUSUCPF); COMANDOUPDATE_USU.Parameters.Add(PUSUDtAdm);
                            COMANDOUPDATE_USU.Parameters.Add(PUSUSEXO); COMANDOUPDATE_USU.Parameters.Add(PUSUFOTO);
                            COMANDOUPDATE_USU.Parameters.Add(PUSULogin); COMANDOUPDATE_USU.Parameters.Add(PUSUCOD);
                            COMANDOUPDATE_USU.ExecuteNonQuery();
                            MessageBox.Show("Usuário alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            erro_login = true;
                            labelErro_Login.Visible = true;
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

                        if (erro_login == false)
                        {
                            Limpar();
                            this.Close();
                        }
                    }                    
                }
            }

        }
        //Metodo para Limpar o Formulario
        public void Limpar()
        {
            error.Clear();
            labelErroCPF.Visible = false;
            //Percorre todo os componetens do formulario
            //onde ira limpa-lo
            foreach (object o in this.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
            }
            radioButtonMasc.Checked = true;
            radioButtonFem.Checked = false;
            pictureBoxFoto.Image = Properties.Resources.masculino;
        }
        //Abre a janela para procurar foto e adiciona-la
        private void button_Add_Foto_Click(object sender, EventArgs e)
        {
            procurar = new OpenFileDialog();
            if (procurar.ShowDialog() != null && procurar.FileName != "")
            {
                pictureBoxFoto.Image = Bitmap.FromFile(procurar.FileName.ToString());
            }
        }
        //Define a foto do usuario de acordo com o seu sexo
        private void Foto_sexo(object sender, EventArgs e)
        {
            if (radioButtonMasc.Checked == true)
            {
                pictureBoxFoto.Image = Properties.Resources.masculino;
            }
            else
            {
                pictureBoxFoto.Image = Properties.Resources.feminino;
            }
        }

        private void Limpar_Form(object sender, EventArgs e)
        {
            Limpar();
        }
        //Método para Validação de Cpf e recebe como parâmetro 
        //o CPF informado pelo usuário
        public bool ValidaCPF(string sourceCPF)
        {
            // Pré-Verificação do Tamanho da String (Apenas para Performance)
            if (sourceCPF.Length != 14)
            {
                return false;
            }
            // Cria Objetos
            string clearCPF;
            int[] cpfArray;
            int totalDigitoI = 0;
            int totalDigitoII = 0;
            int modI;
            int modII;
            // Limpa o CPF
            clearCPF = sourceCPF.Trim(); // Elimina Espaços em Branco
            clearCPF = clearCPF.Replace("-", ""); // Remove Separador de Dígito Verificador
            clearCPF = clearCPF.Replace(",", ""); // Remove os Separadores das Casas
            // Verifica o Tamanho do Texto de Input
            if (clearCPF.Length != 11)
            {
                return false;
            }
            // Verifica os Patterns mais Comuns para CPF's 
            if (clearCPF.Equals("00000000000") || clearCPF.Equals("11111111111") || clearCPF.Equals("22222222222") || clearCPF.Equals("33333333333") || clearCPF.Equals("44444444444") || clearCPF.Equals("55555555555") || clearCPF.Equals("66666666666") || clearCPF.Equals("77777777777") || clearCPF.Equals("88888888888") || clearCPF.Equals("99999999999"))
            {
                return false;
            }
            // Verifica se no Array Existe Apenas Números
            foreach (char c in clearCPF)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            // Converte o CPF em Array Numérico para Validar
            cpfArray = new int[11];
            for (int i = 0; i < clearCPF.Length; i++)
            {
                cpfArray[i] = int.Parse(clearCPF[i].ToString());
            }
            // Computa os Totais para os 2 Dígitos Verificadores
            for (int position = 0; position < cpfArray.Length - 2; position++)
            {
                totalDigitoI += cpfArray[position] * (10 - position);
                totalDigitoII += cpfArray[position] * (11 - position);
            }
            // Aplica Regras do Dígito 1
            modI = totalDigitoI % 11;
            if (modI < 2)
            {
                modI = 0;
            }
            else
            {
                modI = 11 - modI;
            }
            // Verifica o Digito 1
            if (cpfArray[9] != modI)
            {
                return false;
            }
            // Aplica o Peso para o Digito Verificador 2
            totalDigitoII += modI * 2;
            // Aplica Regras do Dígito Verificador 2
            modII = totalDigitoII % 11;
            if (modII < 2)
            {
                modII = 0;
            }
            else
            {
                modII = 11 - modII;
            }
            // Verifica o Digito 2
            if (cpfArray[10] != modII)
            {
                return false;
            }
            // CPF Válido!
            return true;

        }
        public void Alterar_Senha()
        {
            int Cod_usuario = int.Parse(textBoxCodigo_USU.Text);
            Form_Alterar_Senha Formulario_Aletra_Senha = new Form_Alterar_Senha(Cod_usuario);
            Formulario_Aletra_Senha.ShowDialog();
        }
        //Metodo para remover foto do usuário
        public void Remover_foto()
        {
            //verifica qual o sexo do usuário, para deixar a imagen padrão
            if (radioButtonFem.Checked == true)
                pictureBoxFoto.Image = Properties.Resources.feminino;
            else
                pictureBoxFoto.Image = Properties.Resources.masculino;
        }

        private void button_Alterar_Senha_Click(object sender, EventArgs e)
        {
            Alterar_Senha();
        }

        private void button_Remover_foto_Click(object sender, EventArgs e)
        {
            Remover_foto();
        }

    }
}
