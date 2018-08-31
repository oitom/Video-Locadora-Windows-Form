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
    public partial class Form_Atualiza_Cliente : Form
    {
        private SqlConnection CONEXAO = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=VIDEOLOCADORA; Integrated Security=SSPI");
        private SqlDataReader LEITOR = null;
        private SqlDataReader leitor_1 = null;
        private SqlDataReader leitor_2 = null;
        Dictionary<string, int> CIDADE = new Dictionary<string, int>();

        public int Cod_Cliente = 0;
        
        public Form_Atualiza_Cliente(int COD)
        {
            Cod_Cliente = COD;
            InitializeComponent();
        }        

        bool erro = false;

        int COD_CLI;
        OpenFileDialog procurar;
        //Metodo para captutrar a foto desejada do cliente
        private void Add_Foto(object sender, EventArgs e)
        {
            procurar = new OpenFileDialog();
            //Verifica se o cliente adicionou uma foto
            if (procurar.ShowDialog() != null && procurar.FileName != "")
            {
                //Carrega a foto selecionada no pictureBox
                pictureBoxFoto.Image = Bitmap.FromFile(procurar.FileName.ToString());
            }
        }

        //Metodo para atualizar as cidades
        public void AtualizaCidades()
        {
            try
            {
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_CID = new SqlCommand("SELECT CID_DESC, CID_Cod FROM CIDADES", CONEXAO);
                LEITOR = null;
                LEITOR = COMANDOSELECT_CID.ExecuteReader();

                CIDADE.Clear();
                while (LEITOR.Read())
                {
                    CIDADE[LEITOR["CID_Desc"].ToString()] = int.Parse(LEITOR["CID_Cod"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Erro em atualizar a cidade");
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                LEITOR.Close();
            }
        }


        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para definir a foto padrão do cliente
        private void Foto_Sexo(object sender, EventArgs e)
        {
            //Verifica qual é o sexo do cliente, para definir a foto padrão
            if (radioButtonMasc.Checked == true)
                pictureBoxFoto.Image = Properties.Resources.masculino;
            else
                pictureBoxFoto.Image = Properties.Resources.feminino;
        }
        
        private void Form_Novo_Cliente_Load(object sender, EventArgs e)
        {
            //Carrega o codigo do cliente no textBox
            textBox_Codigo.Text = Cod_Cliente.ToString();

            AtualizaCidades();
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

            //Carrega o Estado escolhido pelo cliente
            try
            {
                CONEXAO.Open();
                SqlCommand COMANDOSELECT_UF = new SqlCommand("select CLIENTES.CLI_Nome, CIDADES.CID_Cod, CID_Desc, UF_Desc from CLIENTES inner join ENDERECOS on ENDERECOS.END_Cod = CLIENTES.END_Cod inner join CIDADES on ENDERECOS.CID_Cod = CIDADES.CID_Cod inner join UF on  CIDADES.UF_Cod = UF.UF_Cod where CLIENTES.CLI_Cod = @COD_CLI", CONEXAO);
                SqlParameter PCOD_CLI = new SqlParameter("@COD_CLI", textBox_Codigo.Text);
                COMANDOSELECT_UF.Parameters.Add(PCOD_CLI);
                leitor_1 = COMANDOSELECT_UF.ExecuteReader();

                leitor_1.Read();                
                comboBox_Estado.SelectedItem = leitor_1["UF_Desc"].ToString();

                if (CONEXAO.State == ConnectionState.Closed)
                    CONEXAO.Open();
                leitor_1.Close();

                SqlCommand COMANDOSELECT_CID = new SqlCommand("select CLIENTES.CLI_Nome, CIDADES.CID_Cod, CID_Desc, UF_Desc from CLIENTES inner join ENDERECOS on ENDERECOS.END_Cod = CLIENTES.END_Cod inner join CIDADES on ENDERECOS.CID_Cod = CIDADES.CID_Cod inner join UF on  CIDADES.UF_Cod = UF.UF_Cod where CLIENTES.CLI_Cod = @CODcli", CONEXAO);
                SqlParameter PCODcli = new SqlParameter("@CODcli", textBox_Codigo.Text);
                COMANDOSELECT_CID.Parameters.Add(PCODcli);
                leitor_2 = COMANDOSELECT_CID.ExecuteReader();
                leitor_2.Read();

                comboBox_Cidade.SelectedItem = leitor_2["CID_Desc"].ToString();
            }
            catch
            {
                MessageBox.Show("erro em carregar a cidade");
            }
            finally
            {
                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
                leitor_2.Close();
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
                MessageBox.Show("Houve em carregar os parentescos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LEITOR.Close();
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }

            //carrrega os dados do cliente 
            try
            {
                CONEXAO.Open();
                SqlCommand CONSULTA_CLI_END = new SqlCommand("SELECT CLI_Nome, CLI_Cel, CLI_CPF, CLI_Email, CLI_Foto, CLI_Nasc, CLI_RG, CLI_Saldo, CLI_Sexo, CLI_Tel, END_Bairro, END_CEP, END_Complemento,END_Logradouro, END_Num, CID_Desc, UF_Desc FROM ENDERECOS INNER JOIN CLIENTES ON ENDERECOS.END_Cod = CLIENTES.END_Cod INNER JOIN CIDADES ON ENDERECOS.CID_Cod = CIDADES.CID_Cod INNER JOIN UF ON CIDADES.UF_Cod = UF.UF_Cod WHERE CLIENTES.CLI_Cod = @COD_Cli", CONEXAO);
                SqlParameter PCOD_CLI = new SqlParameter("@COD_Cli", textBox_Codigo.Text);
                CONSULTA_CLI_END.Parameters.Add(PCOD_CLI);
                LEITOR = null;
                LEITOR = CONSULTA_CLI_END.ExecuteReader();
                //Preenche os campos de acordo com os dados do cliente
                while (LEITOR.Read())
                {
                    textBox_Bairro.Text = LEITOR["END_Bairro"].ToString();
                    textBox_Complemento.Text = LEITOR["END_Complemento"].ToString();
                    string CEP = LEITOR["END_CEP"].ToString();
                    CEP = CEP.Replace(".", "");
                    CEP = CEP.Replace("-", "");
                    maskedTextBox_CEP.Text = CEP;
                    textBox_Numero.Text = LEITOR["END_Num"].ToString();
                    textBox_Email.Text = LEITOR["CLI_Email"].ToString();
                    textBox_Nome.Text = LEITOR["CLI_Nome"].ToString();
                    textBox_RG.Text = LEITOR["CLI_RG"].ToString();
                    string CPF = LEITOR["CLI_CPF"].ToString();
                    CPF = CPF.Replace(".", "");
                    CPF = CPF.Replace("-", "");
                    maskedTextBox_CPF.Text = CPF;
                    textBox_Logradouro.Text = LEITOR["END_Logradouro"].ToString();
                    textBox_Complemento.Text = LEITOR["END_Complemento"].ToString();
                    string DTNasc_CLIENTE = LEITOR["CLI_Nasc"].ToString();
                    string DT_NAS = DTNasc_CLIENTE.Substring(0, 10);
                    maskedTextBox_Dt_Nasc.Text = DT_NAS;
                    string cel = LEITOR["CLI_Cel"].ToString();
                    cel = cel.Replace("(", "");
                    cel = cel.Replace(")", "");
                    cel = cel.Replace("-", "");
                    maskedTextBox_Celular.Text = cel;
                    string tel = LEITOR["CLI_Tel"].ToString();
                    tel = tel.Replace("(", "");
                    tel = tel.Replace(")", "");
                    tel = tel.Replace("-", "");
                    maskedTextBox_Telefone.Text = tel;


                    pictureBoxFoto.Image = Bitmap.FromFile(LEITOR["CLI_Foto"].ToString());
                    pictureBoxFoto.Tag = LEITOR["CLI_Foto"].ToString();

                    string Sexo = LEITOR["CLI_Sexo"].ToString();
                    if (Sexo == "F")
                        radioButtonFem.Checked = true;
                    else
                        radioButtonMasc.Checked = true;
                    LEITOR.Close();
                    // consulta para preencher os dependentes
                    SqlCommand COMANDOSELECT_DEP_PAR = new SqlCommand("SELECT DEP_Nome, DEP_Dt_Nasc, PAR_Desc FROM DEPENDENTES INNER JOIN PARENTESCOS ON DEPENDENTES.PAR_Cod = PARENTESCOS.PAR_Cod INNER JOIN CLIENTES ON DEPENDENTES.CLI_Cod = CLIENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @COD_CLI", CONEXAO);
                    SqlParameter P_COD_CLI = new SqlParameter("@COD_CLI", textBox_Codigo.Text);
                    COMANDOSELECT_DEP_PAR.Parameters.Add(P_COD_CLI);
                    
                    LEITOR = null;
                    LEITOR = COMANDOSELECT_DEP_PAR.ExecuteReader();
                    
                    //Verifica se houve resultado na consulta
                    if (LEITOR.Read() == true)
                    {
                        if (LEITOR["DEP_Nome"].ToString() == "")
                        {
                            textBox_Dep_Nome_1.Text = "";
                            maskedTextBox_Dt_Nasc_1.Text = "";
                        }
                        else
                        {
                            //carrega o dependente 1 do cliente
                            textBox_Dep_Nome_1.Text = LEITOR["DEP_Nome"].ToString();
                            string DT_Nasc_1 = LEITOR["DEP_Dt_Nasc"].ToString();
                            string DATA_0 = DT_Nasc_1.Substring(0, 10);
                            maskedTextBox_Dt_Nasc_1.Text = DATA_0;
                            comboBox_parentesco_1.SelectedItem = LEITOR["PAR_Desc"].ToString();
                        }

                        if (LEITOR.Read() == false || LEITOR["DEP_Nome"].ToString() == "")
                        {
                            textBox_Dep_Nome_2.Text = "";
                            maskedTextBox_Dt_Nasc_2.Text = "";
                        }
                        else
                        {
                            //carrega o dependente 2 do cliente
                            textBox_Dep_Nome_2.Text = LEITOR["DEP_Nome"].ToString();
                            string DT_Nasc_2 = LEITOR["DEP_Dt_Nasc"].ToString();
                            string DATA_1 = DT_Nasc_2.Substring(0, 10);
                            maskedTextBox_Dt_Nasc_2.Text = DATA_1;
                            comboBox_parentesco_2.SelectedItem = LEITOR["PAR_Desc"].ToString();
                        }

                        if (LEITOR.Read() == false || LEITOR["DEP_Nome"].ToString() == "")
                        {
                            textBox_Dep_Nome_3.Text = "";
                            maskedTextBox_Dt_Nasc_3.Text = "";
                        }
                        else
                        {
                            //carrega o dependente 3 do cliente
                            textBox_Dep_Nome_3.Text = LEITOR["DEP_Nome"].ToString();
                            string DT_Nas_3 = LEITOR["DEP_Dt_Nasc"].ToString();
                            string DATA_2 = DT_Nas_3.Substring(0, 10);
                            maskedTextBox_Dt_Nasc_3.Text = DATA_2;
                            comboBox_parentesco_3.SelectedItem = LEITOR["PAR_Desc"].ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("erro em carregar os dependentes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LEITOR.Close();
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();     
            }
        }

        //metodo para salvar as alterações feitas no cliente
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
            
            //Verfica se tem algum campo obrigatório em branco
            if (!(ValidaCPF(maskedTextBox_CPF.Text)))
            {
                labelErroCPF.Visible = true;
            }
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
            if (comboBox_Cidade.Enabled == false || comboBox_Cidade.SelectedItem == "Selecione")
            {
                error.SetError(maskedTextBox_CEP, "O campo 'Cidade' não está preenchido!");
                erro = true;
            }
            if (maskedTextBox_CEP.Text.Trim().Length < 10)
            {
                error.SetError(maskedTextBox_CEP, "O campo 'CEP' não está preenchido!");
                erro = true;
            }
           
            if (erro == false)
            {
                //cadastrar usuario
                DialogResult Resultado = MessageBox.Show("Tem certeza que deseja fazer alterações no cliente " + textBox_Nome.Text +"?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        CONEXAO.Open();
                        //Seleciona o código do endereço do cliente para em segida fazer as alterações
                        SqlCommand COMANDOSELECT_COD_END = new SqlCommand("SELECT ENDERECOS.END_Cod FROM ENDERECOS INNER JOIN CLIENTES ON CLIENTES.END_Cod = ENDERECOS.END_Cod WHERE CLIENTES.CLI_Cod = @CLI_Codigo", CONEXAO);
                        SqlParameter Pcod_cli = new SqlParameter("@CLI_Codigo", textBox_Codigo.Text);
                        COMANDOSELECT_COD_END.Parameters.Add(Pcod_cli);
                        LEITOR = null;
                        LEITOR = COMANDOSELECT_COD_END.ExecuteReader();
                        LEITOR.Read();
                        string END_COD = LEITOR["END_Cod"].ToString();
                        LEITOR.Close();

                        //Altera o endereço do cliente
                        SqlCommand COMANDOUPDATE_END = new SqlCommand("UPDATE ENDERECOS SET END_Logradouro = @END_Logradouro, END_Num = @END_Num, END_Complemento = @END_Complemento, END_Bairro = @END_Bairro, END_CEP = @END_CEP, CID_Cod = @CID_cod WHERE END_Cod = @END_COD", CONEXAO);
                        SqlParameter PCOD_END = new SqlParameter("@END_COD", END_COD);
                        SqlParameter P1 = new SqlParameter("@END_Logradouro", textBox_Logradouro.Text);
                        SqlParameter P2 = new SqlParameter("@END_Num", textBox_Numero.Text);
                        SqlParameter P3 = new SqlParameter("@END_Complemento", textBox_Complemento.Text);
                        SqlParameter P4 = new SqlParameter("@END_Bairro", textBox_Bairro.Text);
                        SqlParameter P5 = new SqlParameter("@END_CEP", maskedTextBox_CEP.Text);
                        SqlParameter P6 = new SqlParameter("@CID_cod", CIDADE[comboBox_Cidade.SelectedItem.ToString()]);

                        COMANDOUPDATE_END.Parameters.Add(PCOD_END);
                        COMANDOUPDATE_END.Parameters.Add(P1); COMANDOUPDATE_END.Parameters.Add(P2);
                        COMANDOUPDATE_END.Parameters.Add(P3); COMANDOUPDATE_END.Parameters.Add(P4);
                        COMANDOUPDATE_END.Parameters.Add(P5); COMANDOUPDATE_END.Parameters.Add(P6);
                        COMANDOUPDATE_END.ExecuteNonQuery();
                        
                        SqlParameter PUF_COD = new SqlParameter("@UF_COD", comboBox_Estado.SelectedIndex);
                        
                        //altera os dados pessoais do cliente
                        SqlCommand COMANDOUPDATE_CLI = new SqlCommand("UPDATE CLIENTES SET CLI_Nasc = @CLI_Nasc, CLI_Nome = @CLI_Nome, CLI_RG = @CLI_RG, CLI_CPF = @CLI_CPF, CLI_Sexo = @CLI_SEXO, CLI_Tel = @CLI_Tel, CLI_Email = @CLI_Email, CLI_Foto = @CLI_Foto WHERE CLI_Cod = @COD_CLI", CONEXAO);
                        string data = DateTime.Now.ToString("yyyy-MM-dd");
                        SqlParameter PCOD_CLI = new SqlParameter("@COD_CLI", textBox_Codigo.Text);
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
                        SqlParameter PC10 = new SqlParameter();

                        //verifica se o cliente alterou a sua foto
                        if (procurar == null)
                            PC10 = new SqlParameter("@CLI_Foto", pictureBoxFoto.Tag);
                        else
                            PC10 = new SqlParameter("@CLI_Foto", procurar.FileName.ToString());
                        SqlParameter PC11 = new SqlParameter("@CLI_Saldo", "0.00");
                        SqlCommand COMANDOSELECT = new SqlCommand("SELECT Max(END_Cod) FROM ENDERECOS", CONEXAO);
                        int CD_END = (int)COMANDOSELECT.ExecuteScalar();
                        SqlParameter PC12 = new SqlParameter("@END_Cod", CD_END);

                        COMANDOUPDATE_CLI.Parameters.Add(PCOD_CLI);
                        COMANDOUPDATE_CLI.Parameters.Add(PC1); COMANDOUPDATE_CLI.Parameters.Add(PC2);
                        COMANDOUPDATE_CLI.Parameters.Add(PC3); COMANDOUPDATE_CLI.Parameters.Add(PC4);
                        COMANDOUPDATE_CLI.Parameters.Add(PC5); COMANDOUPDATE_CLI.Parameters.Add(PC6);
                        COMANDOUPDATE_CLI.Parameters.Add(PC7); COMANDOUPDATE_CLI.Parameters.Add(PC8);
                        COMANDOUPDATE_CLI.Parameters.Add(PC9); COMANDOUPDATE_CLI.Parameters.Add(PC10);
                        COMANDOUPDATE_CLI.Parameters.Add(PC11); COMANDOUPDATE_CLI.Parameters.Add(PC12);
                        COMANDOUPDATE_CLI.ExecuteNonQuery();
                        LEITOR.Close();
                        
                        //Verifica se tem algum dependete
                        if (textBox_Dep_Nome_1.Text != "")
                        {
                            //seleciona os dependentes do cliente
                            SqlCommand COMANDOSELECT_DEP = new SqlCommand("SELECT DEP_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON CLIENTES.CLI_Cod = DEPENDENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @CLI_COD", CONEXAO);
                            SqlParameter PCOD_CLIENTE = new SqlParameter("@CLI_COD", textBox_Codigo.Text);
                            COMANDOSELECT_DEP.Parameters.Add(PCOD_CLIENTE);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_DEP.ExecuteReader();
                            //verifica se houve no retorno de dados após a consulta 
                            if (LEITOR.Read() == true)
                            {
                                //Altera os dados do dependente 1
                                SqlParameter DEP_COD_1 = new SqlParameter("@DEP_COD", LEITOR["DEP_Cod"].ToString());
                                LEITOR.Close();
                                SqlCommand COMANDOUPDATE_DEP = new SqlCommand("UPDATE DEPENDENTES SET DEP_Nome = @DEP_Nome, DEP_Dt_Nasc = @DEP_Nasc, PAR_Cod = @PAR_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON DEPENDENTES.CLI_Cod = CLIENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @COD_CLI AND DEP_Cod = @DEP_COD", CONEXAO);
                                SqlParameter CODIGO_CLI = new SqlParameter("@COD_CLI", textBox_Codigo.Text);
                                SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_1.Text);

                                string[] Separa_data2;
                                Separa_data2 = maskedTextBox_Dt_Nasc_1.Text.Split(new char[] { '/' });
                                string Data_Nascimento2 = Separa_data2[2] + "-" + Separa_data2[1] + "-" + Separa_data2[0];

                                SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento2);
                                SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                                SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_1.SelectedIndex);
                                COMANDOUPDATE_DEP.Parameters.Add(DEP_COD_1);
                                COMANDOUPDATE_DEP.Parameters.Add(CODIGO_CLI);
                                COMANDOUPDATE_DEP.Parameters.Add(PD1N); COMANDOUPDATE_DEP.Parameters.Add(PD1D);
                                COMANDOUPDATE_DEP.Parameters.Add(PD1C); COMANDOUPDATE_DEP.Parameters.Add(PD1P);
                                COMANDOUPDATE_DEP.ExecuteNonQuery();
                            }
                            else
                            {
                                //caso ele não tenha nenhum dependente, o dependente é inseridos
                                LEITOR.Close();
                                SqlCommand COMANDOINSERCAO_DEP_1 = new SqlCommand("INSERT INTO DEPENDENTES VALUES (@DEP_Nome, @DEP_Nasc, @CLI_Cod, @PAR_Cod)", CONEXAO);
                                SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_1.Text);

                                string[] Separa_data3;
                                Separa_data3 = maskedTextBox_Dt_Nasc_1.Text.Split(new char[] { '/' });
                                string Data_Nascimento3 = Separa_data3[2] + "-" + Separa_data3[1] + "-" + Separa_data3[0];

                                SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento3);
                                SqlParameter PD1C = new SqlParameter("@CLI_Cod", textBox_Codigo.Text);
                                SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_1.SelectedIndex);

                                COMANDOINSERCAO_DEP_1.Parameters.Add(PD1N); COMANDOINSERCAO_DEP_1.Parameters.Add(PD1D);
                                COMANDOINSERCAO_DEP_1.Parameters.Add(PD1C); COMANDOINSERCAO_DEP_1.Parameters.Add(PD1P);
                                COMANDOINSERCAO_DEP_1.ExecuteNonQuery();                            
                            }
                        }
                        else
                        {
                            //caso ele excluir o dependente, é selecionado o código do dependente para a excluisão
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_DEP = new SqlCommand("SELECT DEP_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON CLIENTES.CLI_Cod = DEPENDENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @CLI_COD", CONEXAO);
                            SqlParameter PCOD_CLIENTE = new SqlParameter("@CLI_COD", textBox_Codigo.Text);
                            COMANDOSELECT_DEP.Parameters.Add(PCOD_CLIENTE);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_DEP.ExecuteReader();
                            if (LEITOR.Read() == true)
                            {
                                string COD_DEP = LEITOR["DEP_Cod"].ToString();
                                if (COD_DEP != "" && LEITOR["DEP_Cod"] != null)
                                {
                                    LEITOR.Close();
                                    //exclui o dependente de acordo com o seu código
                                    SqlCommand COMANDODELETE_DEP = new SqlCommand("DELETE FROM DEPENDENTES WHERE DEP_Cod = @DEP_Cod", CONEXAO);
                                    SqlParameter PDEP_Cod = new SqlParameter("@DEP_Cod", COD_DEP);
                                    COMANDODELETE_DEP.Parameters.Add(PDEP_Cod);
                                    COMANDODELETE_DEP.ExecuteNonQuery();
                                }
                            }
                            else
                                LEITOR.Close();
                        }
                        //Verifica se tem algum dependete
                        if (textBox_Dep_Nome_2.Text != "")
                        {
                            //seleciona os dependentes do cliente
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_DEP_2 = new SqlCommand("SELECT DEP_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON CLIENTES.CLI_Cod = DEPENDENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @CLI_COD", CONEXAO);
                            SqlParameter PCOD_CLIENTE = new SqlParameter("@CLI_COD", textBox_Codigo.Text);
                            COMANDOSELECT_DEP_2.Parameters.Add(PCOD_CLIENTE);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_DEP_2.ExecuteReader();
                            //verifica se houve no retorno de dados após a consulta 
                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    SqlParameter DEP_COD_2 = new SqlParameter("@DEP_COD", LEITOR["DEP_Cod"].ToString());
                                    //Altera os dados do dependente 2
                                    LEITOR.Close();
                                    SqlCommand COMANDOUPDATE_DEP_2 = new SqlCommand("UPDATE DEPENDENTES SET DEP_Nome = @DEP_Nome, DEP_Dt_Nasc = @DEP_Nasc, PAR_Cod = @PAR_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON DEPENDENTES.CLI_Cod = CLIENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @COD_CLI AND DEP_Cod = @DEP_COD", CONEXAO);
                                    SqlParameter CODIGO_CLI_1 = new SqlParameter("@COD_CLI", textBox_Codigo.Text);
                                    SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_2.Text);
                                    string[] Separa_data3;
                                    Separa_data3 = maskedTextBox_Dt_Nasc_2.Text.Split(new char[] { '/' });
                                    string Data_Nascimento3 = Separa_data3[2] + "-" + Separa_data3[1] + "-" + Separa_data3[0];
                                    SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento3);
                                    SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                                    SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_2.SelectedIndex);
                                    COMANDOUPDATE_DEP_2.Parameters.Add(CODIGO_CLI_1);
                                    COMANDOUPDATE_DEP_2.Parameters.Add(DEP_COD_2);
                                    COMANDOUPDATE_DEP_2.Parameters.Add(PD1N); COMANDOUPDATE_DEP_2.Parameters.Add(PD1D);
                                    COMANDOUPDATE_DEP_2.Parameters.Add(PD1C); COMANDOUPDATE_DEP_2.Parameters.Add(PD1P);
                                    COMANDOUPDATE_DEP_2.ExecuteNonQuery();
                                }
                                else
                                {
                                    //caso ele não tenha nenhum dependente, o dependente é inseridos
                                    LEITOR.Close();
                                    SqlCommand COMANDOINSERCAO_DEP_2 = new SqlCommand("INSERT INTO DEPENDENTES VALUES (@DEP_Nome, @DEP_Nasc, @CLI_Cod, @PAR_Cod)", CONEXAO);
                                    SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_2.Text);
                                    string[] Separa_data3;
                                    Separa_data3 = maskedTextBox_Dt_Nasc_2.Text.Split(new char[] { '/' });
                                    string Data_Nascimento3 = Separa_data3[2] + "-" + Separa_data3[1] + "-" + Separa_data3[0];
                                    SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento3);
                                    SqlParameter PD1C = new SqlParameter("@CLI_Cod", textBox_Codigo.Text);
                                    SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_2.SelectedIndex);
                                    COMANDOINSERCAO_DEP_2.Parameters.Add(PD1N); COMANDOINSERCAO_DEP_2.Parameters.Add(PD1D);
                                    COMANDOINSERCAO_DEP_2.Parameters.Add(PD1C); COMANDOINSERCAO_DEP_2.Parameters.Add(PD1P);
                                    COMANDOINSERCAO_DEP_2.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            //caso ele excluir o dependente, é selecionado o código do dependente para a excluisão
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_DEP_1 = new SqlCommand("SELECT DEP_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON CLIENTES.CLI_Cod = DEPENDENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @CLI_COD", CONEXAO);
                            SqlParameter PCOD_CLIENTE_1 = new SqlParameter("@CLI_COD", textBox_Codigo.Text);
                            COMANDOSELECT_DEP_1.Parameters.Add(PCOD_CLIENTE_1);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_DEP_1.ExecuteReader();
                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    string COD_DEP = LEITOR["DEP_Cod"].ToString();
                                    if (COD_DEP != "" && LEITOR["DEP_Cod"] != null)
                                    {
                                        //exclui o dependente de acordo com o seu código
                                        LEITOR.Close();
                                        SqlCommand COMANDODELETE_DEP = new SqlCommand("DELETE FROM DEPENDENTES WHERE DEP_Cod = @DEP_Cod", CONEXAO);
                                        SqlParameter PDEP_Cod = new SqlParameter("@DEP_Cod", COD_DEP);
                                        COMANDODELETE_DEP.Parameters.Add(PDEP_Cod);
                                        COMANDODELETE_DEP.ExecuteNonQuery();
                                        LEITOR.Close();
                                    }
                                }
                                else
                                    LEITOR.Close();
                            }
                        }
                        //Verifica se tem algum dependete
                        if (textBox_Dep_Nome_3.Text != "")
                        {
                            //seleciona os dependentes do cliente
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_DEP_3 = new SqlCommand("SELECT DEP_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON CLIENTES.CLI_Cod = DEPENDENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @CLI_COD", CONEXAO);
                            SqlParameter PCOD_CLIENTE_2 = new SqlParameter("@CLI_COD", textBox_Codigo.Text);
                            COMANDOSELECT_DEP_3.Parameters.Add(PCOD_CLIENTE_2);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_DEP_3.ExecuteReader();

                            //verifica se houve no retorno de dados após a consulta 
                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {
                                    if (LEITOR.Read() == true)
                                    {
                                        //Altera os dados do dependente 3
                                        string COD_Dependente = LEITOR["DEP_Cod"].ToString();
                                        LEITOR.Close();
                                        SqlCommand COMANDOUPDATE_DEP_3 = new SqlCommand("UPDATE DEPENDENTES SET DEP_Nome = @DEP_Nome, DEP_Dt_Nasc = @DEP_Nasc, PAR_Cod = @PAR_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON DEPENDENTES.CLI_Cod = CLIENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @COD_CLI AND DEP_Cod = @DEP_COD", CONEXAO);
                                        SqlParameter DEP_COD_3 = new SqlParameter("@DEP_COD", COD_Dependente);

                                        SqlParameter CODIGO_CLI_2 = new SqlParameter("@COD_CLI", textBox_Codigo.Text);
                                        SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_3.Text);

                                        string[] Separa_data4;
                                        Separa_data4 = maskedTextBox_Dt_Nasc_3.Text.Split(new char[] { '/' });
                                        string Data_Nascimento4 = Separa_data4[2] + "-" + Separa_data4[1] + "-" + Separa_data4[0];

                                        SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento4);
                                        SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                                        SqlParameter PD1P = new SqlParameter("@PAR_Cod", (int)comboBox_parentesco_3.SelectedIndex);
                                        COMANDOUPDATE_DEP_3.Parameters.Add(CODIGO_CLI_2);
                                        COMANDOUPDATE_DEP_3.Parameters.Add(DEP_COD_3);
                                        COMANDOUPDATE_DEP_3.Parameters.Add(PD1N); COMANDOUPDATE_DEP_3.Parameters.Add(PD1D);
                                        COMANDOUPDATE_DEP_3.Parameters.Add(PD1C); COMANDOUPDATE_DEP_3.Parameters.Add(PD1P);
                                        COMANDOUPDATE_DEP_3.ExecuteNonQuery();
                                    }
                                }
                            }
                            else 
                            {
                                //caso ele não tenha nenhum dependente, o dependente é inseridos
                                LEITOR.Close();
                                SqlCommand COMANDOINSERCAO_DEP_3 = new SqlCommand("INSERT INTO DEPENDENTES VALUES (@DEP_Nome, @DEP_Nasc, @CLI_Cod, @PAR_Cod)", CONEXAO);
                                SqlParameter PD1N = new SqlParameter("@DEP_Nome", textBox_Dep_Nome_2.Text);

                                string[] Separa_data3;
                                Separa_data3 = maskedTextBox_Dt_Nasc_2.Text.Split(new char[] { '/' });
                                string Data_Nascimento3 = Separa_data3[2] + "-" + Separa_data3[1] + "-" + Separa_data3[0];

                                SqlParameter PD1D = new SqlParameter("@DEP_Nasc", Data_Nascimento3);
                                SqlParameter PD1C = new SqlParameter("@CLI_Cod", COD_CLI);
                                SqlParameter PD1P = new SqlParameter("@PAR_Cod", comboBox_parentesco_2.SelectedIndex);
                                COMANDOINSERCAO_DEP_3.Parameters.Add(PD1N); COMANDOINSERCAO_DEP_3.Parameters.Add(PD1D);
                                COMANDOINSERCAO_DEP_3.Parameters.Add(PD1C); COMANDOINSERCAO_DEP_3.Parameters.Add(PD1P);
                                COMANDOINSERCAO_DEP_3.ExecuteNonQuery(); 
                            
                            }
                        }
                        else
                        {
                            //caso ele excluir o dependente, é selecionado o código do dependente para a excluisão
                            LEITOR.Close();
                            SqlCommand COMANDOSELECT_DEP_3 = new SqlCommand("SELECT DEP_Cod FROM DEPENDENTES INNER JOIN CLIENTES ON CLIENTES.CLI_Cod = DEPENDENTES.CLI_Cod WHERE CLIENTES.CLI_Cod = @CLI_COD", CONEXAO);
                            SqlParameter PCOD_CLIENTE_4 = new SqlParameter("@CLI_COD", textBox_Codigo.Text);
                            COMANDOSELECT_DEP_3.Parameters.Add(PCOD_CLIENTE_4);
                            LEITOR = null;
                            LEITOR = COMANDOSELECT_DEP_3.ExecuteReader();
                            if (LEITOR.Read() == true)
                            {
                                if (LEITOR.Read() == true)
                                {                                   
                                    if (LEITOR.Read() == true)
                                    {
                                        string COD_DEP = LEITOR["DEP_Cod"].ToString();
                                        if (COD_DEP != "" && LEITOR["DEP_Cod"] != null)
                                        {
                                            //exclui o dependente de acordo com o seu código
                                            LEITOR.Close();
                                            SqlCommand COMANDODELETE_DEP = new SqlCommand("DELETE FROM DEPENDENTES WHERE DEP_Cod = @DEP_Cod", CONEXAO);
                                            SqlParameter PDEP_Cod = new SqlParameter("@DEP_Cod", COD_DEP);
                                            COMANDODELETE_DEP.Parameters.Add(PDEP_Cod);
                                            COMANDODELETE_DEP.ExecuteNonQuery();
                                            
                                        }
                                        else
                                            LEITOR.Close();
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Houve em alterar os dados do cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                            CONEXAO.Close();
                    }

                    MessageBox.Show("Cliente alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    this.Close();
                }
            }
        }
        //Método para limpar o formulario
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
            //limpa os componentes do groupBox_Dados_Pessoais
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
            //limpa os componentes do groupBox_Endereço
            foreach (object o in this.groupBox_Endereço.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";

                comboBox_Estado.Text = "";
                comboBox_Cidade.Text = "";
            }
            //limpa os componentes do groupBox_Contato
            foreach (object o in this.groupBox_Contato.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Text = "";
                else if (o is MaskedTextBox)
                    ((MaskedTextBox)o).Text = "";
            }
            //limpa os componentes do groupBox_Dependentes
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

        //metodo para carregar as cidades de acordo com o seu estado
        private void SelectCidades(string Cidade)
        {
            try
            {
                //limpa os dados do comboBox cidade
                if (comboBox_Cidade.Items.Count != 0)
                {
                    comboBox_Cidade.Items.Clear();
                }

                if (CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();

                //Seleciona as cidades de acordo com seu estado
                CONEXAO.Open();
                SqlCommand COMANDOSELECAO = new SqlCommand("SELECT CID_Desc FROM CIDADES INNER JOIN UF ON CIDADES.UF_Cod = UF.UF_Cod WHERE UF.UF_Cod = @CODIGO ORDER BY CID_Desc", CONEXAO);
                SqlParameter P1 = new SqlParameter("@CODIGO", comboBox_Estado.SelectedIndex.ToString());
                COMANDOSELECAO.Parameters.Add(P1);
                LEITOR = null;
                LEITOR = COMANDOSELECAO.ExecuteReader();
                comboBox_Cidade.Items.Add("Selecione");
                comboBox_Cidade.SelectedIndex = 0;
                //carrega o comboBox cidade 
                while (LEITOR.Read())
                {
                    comboBox_Cidade.Items.Add(LEITOR["CID_Desc"].ToString());
                    
                }
                //deixa selecionado a cidade do cliente
                if (Cidade != null)
                {
                    comboBox_Cidade.SelectedItem = Cidade;
                }

            }
            catch
            {
                MessageBox.Show("Erro em carregar a cidade de acordo com a UF, do clinte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (CONEXAO != null && CONEXAO.State == ConnectionState.Open)
                    CONEXAO.Close();
            }
        }

        //Metodo para chamar o formulario "Nova Cidade", será cadastrado
        private void NovaCiadade_Click(object sender, EventArgs e)
        {
            FormNova_Cidade Formulario_Cadastro_Cidade = new FormNova_Cidade(comboBox_Estado.SelectedIndex);
            Formulario_Cadastro_Cidade.ShowDialog();
            //Após ter cadastrado a cidade, chama o método para deixar selecionado a cidade do cliente
            SelectCidades(Formulario_Cadastro_Cidade.CIDADE);
        }

        //método para habilitar o comboBox Cidade e o Botão "Nova Cidade",
        //quando ele selecionar algun estado
        private void SelectedIndexChanged(object sender, EventArgs e)
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