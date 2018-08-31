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
    public partial class Form_Atualizar_Usuario : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        int COD_usuario;
        public Form_Atualizar_Usuario(int codigo_usu)
        {
            COD_usuario = codigo_usu;
            InitializeComponent();
        }

        bool erro = false;
        //Metodo de verificação dos campos para cadastrar
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            error.Clear();
            erro = false;
            labelErroSenha.Visible = false;
            labelErroCPF.Visible = false;
            bool erroSenha = false;
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
            if (textBoxSenha.Text != textBoxConfirmar_Senha.Text)
            {
                labelErroSenha.Visible = true;
                erroSenha = true;
            }
            else
            {
                labelErroSenha.Visible = false;
                erroSenha = false;
            }
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
            if (textBoxSenha.Text == "")
            {
                error.SetError(textBoxConfirmar_Senha, "Não está preenchido!");
                erro = true;
            }
            if (textBoxConfirmar_Senha.Text == "" && labelErroSenha.Visible == false)
            {
                error.SetError(textBoxConfirmar_Senha, "Não está preenchido!");
                erro = true;
            }
            if (erroSenha == true)
            {
                error.SetError(textBoxConfirmar_Senha, "Não está preenchido!");
                erro = true;  
            }

            if (erro == false)
            { 
                //cadastrar usuário
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja adicionar " + textBoxNome.Text + " como novo Usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        CONEXAO.Open();
                        //classe usuario para alterar senha
                        Usuario usu = new Usuario(textBoxLogin.Text, textBoxSenha.Text);
                        string Senha = usu.CriptoSenha(textBoxSenha.Text);
                        
                        SqlCommand COMANDOINSERIR_USU = new SqlCommand("INSERT INTO  USUARIO VALUES (@USU_Nome, @USU_RG, @USU_CPF, @USU_Dt_Adim, @USU_Login, @USU_Senha)", CONEXAO);
                        SqlParameter PUSUNome = new SqlParameter("@USU_Nome", textBoxNome.Text);
                        SqlParameter PUSURG = new SqlParameter("@USU_RG", textBoxRg.Text);
                        SqlParameter PUSUCPF = new SqlParameter("@USU_CPF", maskedTextBoxCpf.Text);

                        string[] Separa_data;
                        Separa_data = maskedTextBoxDataAdmissao.Text.Split(new char[] { '/' });
                        string Data_Admisao = Separa_data[2] + "-" + Separa_data[1] + "-" + Separa_data[0];

                        SqlParameter PUSUDtAdm = new SqlParameter("@USU_Dt_Adim", Data_Admisao);
                        SqlParameter PUSULogin = new SqlParameter("@USU_Login", textBoxLogin.Text);
                        SqlParameter PUSUSenha= new SqlParameter("@USU_Senha", Senha);

                        COMANDOINSERIR_USU.Parameters.Add(PUSUNome); COMANDOINSERIR_USU.Parameters.Add(PUSURG);
                        COMANDOINSERIR_USU.Parameters.Add(PUSUCPF); COMANDOINSERIR_USU.Parameters.Add(PUSUDtAdm);
                        COMANDOINSERIR_USU.Parameters.Add(PUSULogin); COMANDOINSERIR_USU.Parameters.Add(PUSUSenha);               
                        COMANDOINSERIR_USU.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Houve um problema com a conexão com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                            CONEXAO.Close();

                        MessageBox.Show("Usuário cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                else
                    Limpar();
            }


            

        }
        //Metodo para Limpar o Formulario
        public void Limpar()
        {
            error.Clear();
            labelErroCPF.Visible = false;
            labelErroSenha.Visible = false;
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
            OpenFileDialog procurar = new OpenFileDialog();
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
            clearCPF = clearCPF.Replace(".", ""); // Remove os Separadores das Casas
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

        private void Form_Novo_Usuario_Load(object sender, EventArgs e)
        {

        }

      
    }
}
