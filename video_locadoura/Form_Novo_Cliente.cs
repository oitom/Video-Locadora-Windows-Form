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
    public partial class Form_Novo_Cliente : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        public Dictionary<string, int> Dicionario_CIDADES = new Dictionary<string, int>();
        
        public Form_Novo_Cliente()
        {
            
            InitializeComponent();
        }

        bool erro = false;
        int COD_CLI;
        OpenFileDialog procurar;
        //Metodo para carregar a foto do cliente
        private void Add_Foto(object sender, EventArgs e)
        {
            procurar = new OpenFileDialog();
            if (procurar.ShowDialog() != null && procurar.FileName != "")
                pictureBoxFoto.Image = Bitmap.FromFile(procurar.FileName.ToString());
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo para verificação do sexo do cliente para definir uma foto padrão
        private void Foto_Sexo(object sender, EventArgs e)
        {
            if (radioButtonMasc.Checked == true)
                pictureBoxFoto.Image = Properties.Resources.masculino;
            else
                pictureBoxFoto.Image = Properties.Resources.feminino;
        }
        //Metodo para atualizar as cidades cadastradas
        public void AtualizaCidades()
        {
            try
            {
                CONEXAO.Open();
                //Seleciona as cidades
                SqlCommand COMANDOSELECT_CID = new SqlCommand("SELECT CID_DESC, CID_Cod FROM CIDADES", CONEXAO);
                LEITOR = null;
                LEITOR = COMANDOSELECT_CID.ExecuteReader();

                Dicionario_CIDADES.Clear();
                //carrega as cidades no Dicionário "CIDADES"
                while (LEITOR.Read())
                    Dicionario_CIDADES[LEITOR["CID_Desc"].ToString()] = int.Parse(LEITOR["CID_Cod"].ToString());
            }
            catch
            {
                MessageBox.Show("Erro em carregar as cidades");
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();
            }

        
        }

        private void Form_Novo_Cliente_Load(object sender, EventArgs e)
        {
            AtualizaCidades();
            try
            {
                CONEXAO.Open();
                //Seleciona o ultimo código do cliente cadastrado
                SqlCommand COMANDOCONSULTA_CODCLI = new SqlCommand("SELECT Max(CLI_Cod) FROM CLIENTES", CONEXAO);
                COD_CLI = (int)COMANDOCONSULTA_CODCLI.ExecuteScalar();
                COD_CLI++;                
                textBox_Codigo.Text = COD_CLI.ToString();
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
            
           
            //Carrega o comboBox estado
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTAUF = new SqlCommand("SELECT UF_Desc FROM UF", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTAUF.ExecuteReader();
                comboBox_Estado.SelectedIndex = 0;
                while (LEITOR.Read())
                {
                    comboBox_Estado.Items.Add(LEITOR["UF_Desc"].ToString());
                }

                comboBox_Cidade.Items.Add("Selecione");
                comboBox_Cidade.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Houve um problema ao carregar os estados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (LEITOR != null)
                    LEITOR.Close();

                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }

            //Carrega o comboBox Parentesco
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTAPAREN = new SqlCommand("SELECT PAR_Desc FROM PARENTESCOS", CONEXAO);
                LEITOR = null;
                LEITOR = CONSULTAPAREN.ExecuteReader();
                comboBox_parentesco_1.SelectedIndex = 0;
                comboBox_parentesco_2.SelectedIndex = 0;
                comboBox_parentesco_3.SelectedIndex = 0;
                while (LEITOR.Read())
                {
                    comboBox_parentesco_1.Items.Add(LEITOR["PAR_Desc"].ToString());
                    comboBox_parentesco_2.Items.Add(LEITOR["PAR_Desc"].ToString());
                    comboBox_parentesco_3.Items.Add(LEITOR["PAR_Desc"].ToString());
                }

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


        private void Salvar_Dados(object sender, EventArgs e)
        {
            error.Clear();
            erro = false;
            labelErroCPF.Visible = false;
            //Remove os caracteres indesejados
            string Dt_Nascimento = maskedTextBox_Dt_Nasc.Text;
            string CPF = maskedTextBox_CPF.Text;
            string CEP = maskedTextBox_CEP.Text;
            string Tel = maskedTextBox_Telefone.Text;
            string Cel = maskedTextBox_Celular.Text;
            string Dt_Nasc_1 = maskedTextBox_Dt_Nasc_1.Text;
            string Dt_Nasc_2 = maskedTextBox_Dt_Nasc_2.Text;
            string Dt_Nasc_3 = maskedTextBox_Dt_Nasc_3.Text;
            Dt_Nascimento = Dt_Nascimento.Replace("/", "");
            CPF = CPF.Replace(".", ""); Cel = Cel.Replace("(", "");
            CPF = CPF.Replace("-", ""); Cel = Cel.Replace(")", "");
            CEP = CPF.Replace(".", ""); Cel = Cel.Replace("-", "");
            CEP = CPF.Replace("-", ""); Dt_Nasc_1 = Dt_Nasc_1.Replace("/", "");
            Tel = Tel.Replace("(", ""); Dt_Nasc_2 = Dt_Nasc_1.Replace("/", "");
            Tel = Tel.Replace(")", ""); Dt_Nasc_3 = Dt_Nasc_1.Replace("/", "");
            Tel = Tel.Replace("-", "");

         
            //Verificação dos campos obrigatórios
            if (!(ValidaCPF(maskedTextBox_CPF.Text)))
                labelErroCPF.Visible = true;
            else
                labelErroCPF.Visible = false;

            if (textBox_Codigo.Text.Trim() == "")
            {
                error.SetError(textBox_Codigo, "O campo 'Código' não está preenchido!");
                erro = true;
            }
            if (textBox_Nome.Text.Trim() == "")
            {
                error.SetError(maskedTextBox_Dt_Nasc, "O campo 'Nome' não está preenchido!");
                erro = true;
            }
            if (maskedTextBox_Dt_Nasc.Text.Trim().Length < 10)
            {
                error.SetError(maskedTextBox_Dt_Nasc, "O campo 'Data de Nascimento' não está preenchido!");
                erro = true;
            }
            if (textBox_RG.Text.Trim() == "")
            {
                error.SetError(radioButtonFem, "O campo 'RG' não está preenchido!");
                erro = true;
            }
            if (!(ValidaCPF(maskedTextBox_CPF.Text)))
            {
                error.SetError(radioButtonFem, "O campo 'CPF' não está preenchido!");
                erro = true;
            }
            if (textBox_Logradouro.Text.Trim() == "")
            {
                error.SetError(textBox_Complemento, "O campo 'Logradouro' não está preenchido!");
                erro = true;
            }
            if (textBox_Numero.Text.Trim() == "")
            {
                error.SetError(textBox_Complemento, "O campo 'Número' não está preenchido!");
                erro = true;
            }
            if (textBox_Bairro.Text.Trim() == "")
            {
                error.SetError(maskedTextBox_CEP, "O campo 'Bairro' não está preenchido!");
                erro = true;
            }
            if (comboBox_Estado.Text.Trim() == "")
            {
                error.SetError(maskedTextBox_CEP, "O campo 'Estado' não está preenchido!");
                erro = true;
            }
            if (comboBox_Cidade.Enabled == false)
            {
                error.SetError(maskedTextBox_CEP, "O campo 'Cidade' não está preenchido!");
                erro = true;
            }
            if (maskedTextBox_CEP.Text.Trim().Length < 10)
            {
                error.SetError(maskedTextBox_CEP, "O campo 'CEP' não está preenchido!");
                erro = true;
            }

            //Verifica se os campos do dependentes estão preenchido
            if (textBox_Dep_Nome_1.Text != "")
            {
                string DtNas_1 = maskedTextBox_Dt_Nasc_1.Text;
                DtNas_1 = DtNas_1.Replace("/", "");

                if (DtNas_1.Trim() == "")
                {
                    error.SetError(maskedTextBox_Dt_Nasc_1, "A Data de Nasc. está preenchido!");
                    erro = true;
                }
                if (comboBox_parentesco_1.SelectedIndex == 0)
                {
                    error.SetError(maskedTextBox_Dt_Nasc_1, "Parentesco não está preenchido!");
                    erro = true;
                }  
            }
            //Verifica se os campos do dependentes estão preenchido
            if (textBox_Dep_Nome_2.Text != "")
            { 
                string DtNas_2 = maskedTextBox_Dt_Nasc_2.Text;
                DtNas_2 = DtNas_2.Replace("/", "");

              if (DtNas_2.Trim() == " ")
              {
                 error.SetError(maskedTextBox_Dt_Nasc_2, "A Data de Nasc. não está preenchido!");
                 erro = true;
              }
              if (comboBox_parentesco_2.SelectedIndex == 0)
              {
                 error.SetError(maskedTextBox_Dt_Nasc_2, "O parentesco não está preenchido!");
                 erro = true;
              }
            }
            //Verifica se os campos do dependentes estão preenchido
            if (textBox_Dep_Nome_3.Text != "")
            {
                string DtNas_3 = maskedTextBox_Dt_Nasc_3.Text;
                DtNas_3 = DtNas_3.Replace("/", "");
                
                if (DtNas_3.Trim() == " ")
                {
                    error.SetError(maskedTextBox_Dt_Nasc_3, "Não está preenchido!");
                    erro = true;
                }
                if (comboBox_parentesco_3.SelectedIndex == 0)
                {
                    error.SetError(maskedTextBox_Dt_Nasc_3, "O parenteesco não está preenchido!");
                    erro = true;
                }
            }
           
            if (erro == false)
            {
                //cadastrar usuario
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja adicionar " + textBox_Nome.Text + " como novo cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        CONEXAO.Open();
                        //Comando para inseri o cliente
                        SqlCommand COMANDOINSERIR_END = new SqlCommand("INSERT INTO ENDERECOS VALUES (@END_Logradouro, @END_Num, @END_Complemento, @END_Bairro, @END_CEP, @CID_Cod)", CONEXAO);
                        SqlParameter P1 = new SqlParameter("@END_Logradouro", textBox_Logradouro.Text);
                        SqlParameter P2 = new SqlParameter("@END_Num", textBox_Numero.Text);
                        SqlParameter P3 = new SqlParameter("@END_Complemento", textBox_Complemento.Text);
                        SqlParameter P4 = new SqlParameter("@END_Bairro", textBox_Bairro.Text);
                        SqlParameter P5 = new SqlParameter("@END_CEP", maskedTextBox_CEP.Text);



                        SqlParameter P6 = new SqlParameter("@CID_cod", Dicionario_CIDADES[comboBox_Cidade.SelectedItem.ToString()]);

                        COMANDOINSERIR_END.Parameters.Add(P1); COMANDOINSERIR_END.Parameters.Add(P2);
                        COMANDOINSERIR_END.Parameters.Add(P3); COMANDOINSERIR_END.Parameters.Add(P4);
                        COMANDOINSERIR_END.Parameters.Add(P5); COMANDOINSERIR_END.Parameters.Add(P6);
                        COMANDOINSERIR_END.ExecuteNonQuery();

                        SqlCommand COMANDOINSERIR_CLI = new SqlCommand("INSERT INTO CLIENTES VALUES (@CLI_Data, @CLI_Nome, @CLI_Nasc, @CLI_RG, @CLI_CPF, @CLI_Sexo, @CLI_Tel, @CLI_Cel, @CLI_Email, @CLI_Foto, @CLI_Saldo, 0, @END_Cod)", CONEXAO);
                        string data = DateTime.Now.ToString("yyyy-MM-dd");
                        SqlParameter PC1 = new SqlParameter("@CLI_Data", data);
                        SqlParameter PC2 = new SqlParameter("@CLI_Nome", textBox_Nome.Text);

                        string[] Separa_data1;
                        Separa_data1 = maskedTextBox_Dt_Nasc.Text.Split(new char[] { '/' });
                        string Data_Nascimento = Separa_data1[2] + "-" + Separa_data1[1] + "-" + Separa_data1[0];

                        SqlParameter PC3 = new SqlParameter("@CLI_Nasc", Data_Nascimento);
                        SqlParameter PC4 = new SqlParameter("@CLI_RG", textBox_RG.Text);
                        SqlParameter PC5 = new SqlParameter("@CLI_CPF", CPF);
                        SqlParameter PC6;
                        if (radioButtonFem.Checked)
                            PC6 = new SqlParameter("@CLI_SEXO", "F");
                        else
                            PC6 = new SqlParameter("@CLI_SEXO", "M");

                        SqlParameter PC7 = new SqlParameter("@CLI_Tel", Tel);
                        SqlParameter PC8 = new SqlParameter("@CLI_Cel", Cel);
                        SqlParameter PC9 = new SqlParameter("@CLI_Email", textBox_Email.Text);
                        SqlParameter PC10;
                        //Caso o cliente não tenha adicionado uma foto, é salvado a foto padrão
                        if (procurar == null)
                        {
                            if(radioButtonFem.Checked == true)
                                PC10 = new SqlParameter("@CLI_Foto", @"C:\PROGRAMA LOCADORA\BANCO DE DADOS\IMAGENS USUARIO\feminino.JPG");
                            else
                                PC10 = new SqlParameter("@CLI_Foto", @"C:\PROGRAMA LOCADORA\BANCO DE DADOS\IMAGENS USUARIO\masculino.JPG");
                        }
                        else
                            PC10 = new SqlParameter("@CLI_Foto", procurar.FileName.ToString());

                        SqlParameter PC11 = new SqlParameter("@CLI_Saldo", "0.00");

                        //Comando par capturar o código do endereço
                        SqlCommand COMANDOSELECT = new SqlCommand("SELECT Max(END_Cod) FROM ENDERECOS", CONEXAO);
                        int CD_END = (int)COMANDOSELECT.ExecuteScalar();
                        SqlParameter PC12 = new SqlParameter("@END_Cod", CD_END);
                        COMANDOINSERIR_CLI.Parameters.Add(PC1); COMANDOINSERIR_CLI.Parameters.Add(PC2);
                        COMANDOINSERIR_CLI.Parameters.Add(PC3); COMANDOINSERIR_CLI.Parameters.Add(PC4);
                        COMANDOINSERIR_CLI.Parameters.Add(PC5); COMANDOINSERIR_CLI.Parameters.Add(PC6);
                        COMANDOINSERIR_CLI.Parameters.Add(PC7); COMANDOINSERIR_CLI.Parameters.Add(PC8);
                        COMANDOINSERIR_CLI.Parameters.Add(PC9); COMANDOINSERIR_CLI.Parameters.Add(PC10);
                        COMANDOINSERIR_CLI.Parameters.Add(PC11); COMANDOINSERIR_CLI.Parameters.Add(PC12);
                        COMANDOINSERIR_CLI.ExecuteNonQuery();

                        //Verifica se foi preenchido algun dependente
                        if (textBox_Dep_Nome_1.Text != "")
                        {
                            //Cadastra o dependente 1
                            SqlCommand COMANDOINSERCAO_PAR_1 = new SqlCommand("INSERT INTO DEPENDENTES VALUES (@DEP_Nome, @DEP_Nasc, @CLI_Cod, @PAR_Cod)", CONEXAO);
                            SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_1.Text);
                            string[] Separa_data2;
                            Separa_data2 = maskedTextBox_Dt_Nasc_1.Text.Split(new char[] { '/' });
                            string Data_Nascimento2 = Separa_data2[2] + "-" + Separa_data2[1] + "-" + Separa_data2[0];

                            SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento2);
                            SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                            SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_1.SelectedIndex);
                            COMANDOINSERCAO_PAR_1.Parameters.Add(PD1N); COMANDOINSERCAO_PAR_1.Parameters.Add(PD1D);
                            COMANDOINSERCAO_PAR_1.Parameters.Add(PD1C); COMANDOINSERCAO_PAR_1.Parameters.Add(PD1P);
                            COMANDOINSERCAO_PAR_1.ExecuteNonQuery();
                           
                        }
                        if (textBox_Dep_Nome_2.Text != "")
                        {
                            //Cadastra o dependente 2
                            SqlCommand COMANDOINSERCAO_PAR_2 = new SqlCommand("INSERT INTO DEPENDENTES VALUES (@DEP_Nome, @DEP_Nasc, @CLI_Cod, @PAR_Cod)", CONEXAO);
                            SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_2.Text);
                            string[] Separa_data3;
                            Separa_data3 = maskedTextBox_Dt_Nasc_2.Text.Split(new char[] { '/' });
                            string Data_Nascimento3 = Separa_data3[2] + "-" + Separa_data3[1] + "-" + Separa_data3[0];

                            SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento3);
                            SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                            SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_2.SelectedIndex);
                            COMANDOINSERCAO_PAR_2.Parameters.Add(PD1N); COMANDOINSERCAO_PAR_2.Parameters.Add(PD1D);
                            COMANDOINSERCAO_PAR_2.Parameters.Add(PD1C); COMANDOINSERCAO_PAR_2.Parameters.Add(PD1P);
                            COMANDOINSERCAO_PAR_2.ExecuteNonQuery();
                            
                        }
                        if (textBox_Dep_Nome_3.Text != "")
                        {

                            //Cadastra o dependente 3
                            SqlCommand COMANDOINSERCAO_PAR_3 = new SqlCommand("INSERT INTO DEPENDENTES VALUES (@DEP_Nome, @DEP_Nasc, @CLI_Cod, @PAR_Cod)", CONEXAO);
                            SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_3.Text);
                            string[] Separa_data4;
                            Separa_data4 = maskedTextBox_Dt_Nasc_3.Text.Split(new char[] { '/' });
                            string Data_Nascimento4 = Separa_data4[2] + "-" + Separa_data4[1] + "-" + Separa_data4[0];

                            SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento4);
                            SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                            SqlParameter PD1P = new SqlParameter("@PAR_Cod", (int)comboBox_parentesco_3.SelectedIndex);
                            COMANDOINSERCAO_PAR_3.Parameters.Add(PD1N); COMANDOINSERCAO_PAR_3.Parameters.Add(PD1D);
                            COMANDOINSERCAO_PAR_3.Parameters.Add(PD1C); COMANDOINSERCAO_PAR_3.Parameters.Add(PD1P);
                            COMANDOINSERCAO_PAR_3.ExecuteNonQuery();
                            
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
                    }

                    MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    Limpar();
                }
            }
        }
        //Metodo para limpar o formulário
        public void Limpar()
        {
            error.Clear();
            textBox_Codigo.Text = "";
            labelErroCPF.Visible = false;
            comboBox_Estado.SelectedIndex = 0;
            comboBox_Cidade.Enabled = false;
            buttonNovaCiadade.Enabled = false;
            comboBox_Cidade.SelectedIndex = 0;
            comboBox_parentesco_1.SelectedIndex = 0;
            comboBox_parentesco_2.SelectedIndex = 0;
            comboBox_parentesco_3.SelectedIndex = 0;
            //Limpa os componentes do comboBox Dados Pessoais
            foreach (object o in this.groupBox_Dados_Pessoais.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";

                radioButtonFem.Checked = false;
                radioButtonMasc.Checked = true;
            }

            pictureBoxFoto.Image = Properties.Resources.masculino;
            //Limpa os componentes do comboBox endereço
            foreach (object o in this.groupBox_Endereço.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";

                comboBox_Estado.Text = "";
                comboBox_Cidade.Text = "";
            }
            //Limpa os componentes do comboBox Contato
            foreach (object o in this.groupBox_Contato.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
            }
            //Limpa os componentes do comboBox Dependentes
            foreach (object o in this.groupBox_Dependentes.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
             }
            try
            {
                CONEXAO.Open();
                SqlCommand COMANDOCONSULTA_CODCLI = new SqlCommand("SELECT Max(CLI_Cod) FROM CLIENTES", CONEXAO);
                COD_CLI = (int)COMANDOCONSULTA_CODCLI.ExecuteScalar();
                COD_CLI++;
                textBox_Codigo.Text = COD_CLI.ToString();
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
                return false;

            // Verifica os Patterns mais Comuns para CPF's 
            if (clearCPF.Equals("00000000000") || clearCPF.Equals("11111111111") || clearCPF.Equals("22222222222") || clearCPF.Equals("33333333333") || clearCPF.Equals("44444444444") || clearCPF.Equals("55555555555") || clearCPF.Equals("66666666666") || clearCPF.Equals("77777777777") || clearCPF.Equals("88888888888") || clearCPF.Equals("99999999999"))
                return false;

            // Verifica se no Array Existe Apenas Números
            foreach (char c in clearCPF)
            {
                if (!char.IsNumber(c))
                    return false;
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
                modI = 0;
            else
                modI = 11 - modI;

            // Verifica o Digito 1
            if (cpfArray[9] != modI)
                return false;

            // Aplica o Peso para o Digito Verificador 2
            totalDigitoII += modI * 2;
            // Aplica Regras do Dígito Verificador 2
            modII = totalDigitoII % 11;
            if (modII < 2)
                modII = 0;
            else
                modII = 11 - modII;

            // Verifica o Digito 2
            if (cpfArray[10] != modII)
            {
                return false;
            }
            // CPF Válido!
            return true;

        }
        //metodo para carregar as cidades de acordo com o sei estado
        private void SelectCidades(string Cidade)
        {
            try
            {
                //Limpa o comboBox Cidades
                if (comboBox_Cidade.Items.Count != 0)
                    comboBox_Cidade.Items.Clear();
                
                
                CONEXAO.Open();
                SqlCommand COMANDOSELECAO = new SqlCommand("SELECT CIDADES.CID_Desc FROM CIDADES INNER JOIN UF ON CIDADES.UF_Cod = UF.UF_Cod WHERE UF.UF_Cod = @CODIGO ORDER BY CID_Desc", CONEXAO);
                SqlParameter P1 = new SqlParameter("@CODIGO", comboBox_Estado.SelectedIndex.ToString());
                
                COMANDOSELECAO.Parameters.Add(P1);
                LEITOR = null;
                LEITOR = COMANDOSELECAO.ExecuteReader();
                comboBox_Cidade.Items.Add("Selecione");
                comboBox_Cidade.SelectedIndex = 0;

                //Carrega o comboBox Cidade
                while (LEITOR.Read())
                    comboBox_Cidade.Items.Add(LEITOR["CID_Desc"].ToString());
                                
                if (Cidade != null)
                    comboBox_Cidade.SelectedItem = Cidade;
                
            }
            catch
            {
                MessageBox.Show("Houve um problema com a conenão com o banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();

            }

        }

        //Metodo para chamar o Formulário Nova Cidade
        private void NovaCiadade_Click(object sender, EventArgs e)
        {
            //Chama o formulário Nova ciade e passando como parâmetro o código do estado selecionado
            FormNova_Cidade Formulario_Cadastro_Cidade = new FormNova_Cidade(comboBox_Estado.SelectedIndex);
            Formulario_Cadastro_Cidade.ShowDialog();
            //após o cadastro da nova cidade, ela é selecionada com comboBox Cidades
            SelectCidades(Formulario_Cadastro_Cidade.CIDADE);
            
            //Retorna o ultimo elemento do Dicionario Cidades
            int Cod_cidade = Dicionario_CIDADES.Values.Last();
		    Cod_cidade++;
            //Adiciona a próxima cidade no dicionário
            Dicionario_CIDADES.Add(comboBox_Cidade.SelectedItem.ToString(), Cod_cidade);           
        }
        //Metodo para verificar se foi selecionado algum estado
        private void comboBox_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Estado.SelectedIndex > 0)
            {
                comboBox_Cidade.Enabled = true;
                buttonNovaCiadade.Enabled = true;
                buttonNovaCiadade.Enabled = true;
                SelectCidades(null);
                
            }
            else
            {
                comboBox_Estado.Enabled = true;
                comboBox_Cidade.Enabled = false;
                buttonNovaCiadade.Enabled = false;
                
            }
        }
        public object CODIGO_ENDERECO { get; set; }
        
    }
}