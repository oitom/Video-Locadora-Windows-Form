using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Media;

namespace video_locadora
{
    public partial class Form_Principal : Form
    {
        MP3Player mplayer;
        public Form_Principal()
        {
            InitializeComponent();
            mplayer = new Media.MP3Player();
            mplayer.OpenFile += new MP3Player.OpenFileEventHandler(mplayer_OpenFile);
            mplayer.PlayFile += new MP3Player.PlayFileEventHandler(mplayer_PlayFile);
            mplayer.StopFile += new MP3Player.StopFileEventHandler(mplayer_StopFile);
            mplayer.PauseFile += new MP3Player.PauseFileEventHandler(mplayer_PauseFile);
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

            Form_Login Formulario_Login = new Form_Login();
            Formulario_Login.ShowDialog();
           //// Chama o formulário para login do usuário
           // Form_Login Formulario_Login = new Form_Login();
           // if (Formulario_Login.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
           //   this.Close();
           // //atualiza o nome do usuário logado, no toolstripMenu
           // toolStripNomeUsuario.Text = Formulario_Login.Nome;
        }
        //Metodo para chamar os formularios, de acordo com o menu
        private void Chamando_Fomrularios_Menu(object Formulario, EventArgs e)
        {
            //Recebe o valor da tag de cada ToolStrip e PictureBox
            string Menu_Opcao = ((ToolStripMenuItem)Formulario).Tag.ToString();
            switch (Menu_Opcao)
            {
                case "LOCACAO":
                    Form_Locacao Formulario_Locacao = new Form_Locacao();
                    Formulario_Locacao.ShowDialog();
                    break;
                case "DEVOLUCAO":
                    Form_Devolucao Formulario_Devolucao = new Form_Devolucao();
                    Formulario_Devolucao.ShowDialog();
                    break;
                case "LOGIN":
                    Form_Login Formulario_Login = new Form_Login();
                    Formulario_Login.ShowDialog();
                    toolStripNomeUsuario.Text = Formulario_Login.Nome;
                    break;
                case "SAIR":
                    this.Close();
                    break;
                case "CONSULTA_CLIENTE":
                    Form_Consulta_Cliente Formulario_Consulta_Cliente = new Form_Consulta_Cliente();
                    Formulario_Consulta_Cliente.ShowDialog();
                    break;
                case "CONSULTA_FILME":
                    Form_Consulta_Filme Formulario_Consulta_Filme = new Form_Consulta_Filme();
                    Formulario_Consulta_Filme.ShowDialog();
                    break;
                case "CADASTRO_CLIENTE_NOVO":
                    Form_Novo_Cliente Formulario_Cliente = new Form_Novo_Cliente();
                    Formulario_Cliente.ShowDialog();
                    break;
                case "CADASTRO_CLIENTE_ALTERAR":
                    Form_Altera_Cliente Formulario_AlteraCliente = new Form_Altera_Cliente();
                    Formulario_AlteraCliente.ShowDialog();
                    break;
                case "CADASTRO_FILMES_NOVO":
                    Form_Novo_Filme Formulario_Filme = new Form_Novo_Filme();
                    Formulario_Filme.ShowDialog();
                    break;
                case "CADASTRO_FILMES_ALTERAR":
                    Form_Alterar_Filme Formulario_Altera_Filme = new Form_Alterar_Filme();
                    Formulario_Altera_Filme.ShowDialog();
                    break;
                case "CADASTRO_USUARIO_NOVO":
                    Form_Novo_Usuario Formulario_Usuario = new Form_Novo_Usuario();
                    Formulario_Usuario.ShowDialog();
                    break;
                case "CADASTRO_USUARIO_ALTERAR":
                    Form_Alterar_Usuario Formulario_Altera_Usuario = new Form_Alterar_Usuario();
                    Formulario_Altera_Usuario.ShowDialog();
                    break;
                case "RELATORIO_FILMES_TODOS":
                    Form_Relatorio_Filme_Todos Formulario_Relatorio_FilmesTodos = new Form_Relatorio_Filme_Todos();
                    Formulario_Relatorio_FilmesTodos.ShowDialog();
                    break;
                case "RELATORIO_FILMES_LOCADOS":
                    Form_Relatorio_Filmes_Locados Formulario_Relatorio_FilmesLocados = new Form_Relatorio_Filmes_Locados();
                    Formulario_Relatorio_FilmesLocados.ShowDialog();
                    break;
                case "RELATORIO_CLIENTE":
                    Form_Relatorio_Cliente Formulario_Relatorio_Cliente = new Form_Relatorio_Cliente();
                    Formulario_Relatorio_Cliente.ShowDialog();
                    break;
                case "RELATORIO_FINANCEIRO_DIA":
                    Form_Relatorio_Dia Formulario_Relatorio_Dia = new Form_Relatorio_Dia();
                    Formulario_Relatorio_Dia.ShowDialog();
                    break;
                case "RELATORIO_FINANCEIRO_MES":
                    Form_Relatorio_Mes Formulario_Relatorio_Mes = new Form_Relatorio_Mes();
                    Formulario_Relatorio_Mes.ShowDialog();
                    break;
                case "RELATORIO_FINANCEIRO_ANO":
                    Form_Relatorio_Ano Formulario_Relatorio_Ano = new Form_Relatorio_Ano();
                    Formulario_Relatorio_Ano.ShowDialog();
                    break;
                case "CADASTRO_CLIENTES_EXCLUIR":
                    Form_Excluir_Cliente formulario_Exclusao = new Form_Excluir_Cliente();
                    formulario_Exclusao.ShowDialog();
                    break;
                case "EXCLUIR_FILME":
                    Form_Excluir_Filme Formulario_Exclusao_Filme = new Form_Excluir_Filme();
                    Formulario_Exclusao_Filme.ShowDialog();
                    break;
                case "EXCLUIR_USUARIO":
                    Form_Excluir_Usuario Formulario_Exclusao_Usuario = new Form_Excluir_Usuario();
                    Formulario_Exclusao_Usuario.ShowDialog();
                    break;
              }
            
        }
        //Metodo para chamar os formulários de acordo com o seu ícone
        private void Chamando_Formulario_PictureBox(object Fomulario, EventArgs e)
        {
            //passa o Icone_Menu a Tag de cada PictureBox
            string Icone_Menu = ((PictureBox)Fomulario).Tag.ToString();

            switch (Icone_Menu)
            { 
                case "LOGIN":
                    Form_Login Formulario_Login = new Form_Login();
                    Formulario_Login.ShowDialog();
                    toolStripNomeUsuario.Text = Formulario_Login.Nome;
                    break;
                case "LOCACAO":
                    Form_Locacao Formulario_Locacao = new Form_Locacao();
                    Formulario_Locacao.ShowDialog();
                    break;
                case "DEVOLUCAO":
                     Form_Devolucao Formulario_Devolucao = new Form_Devolucao();
                    Formulario_Devolucao.ShowDialog();
                    break;
                case "ADD_CLIENTE":
                    Form_Novo_Cliente Formulario_ADD_Cliente = new Form_Novo_Cliente();
                    Formulario_ADD_Cliente.ShowDialog();
                    break;
                case "CONSULTA_CLIENTE":
                    Form_Consulta_Cliente Formulario_Consulta_Cliente = new Form_Consulta_Cliente();
                    Formulario_Consulta_Cliente.ShowDialog();
                    break;
                case "CONSULTA_FILME":
                    Form_Consulta_Filme Formulario_Consulta_Filme = new Form_Consulta_Filme();
                    Formulario_Consulta_Filme.ShowDialog();
                    break;
            }

        }
        //Metodo para atualizar o relógio, e dar a saldação
        private void timer_Tick(object sender, EventArgs e)
        {
            int Hora = DateTime.Now.Hour;
            if (DateTime.Now.Hour < 12)
                labelMensagem.Text = "Bom Dia!";
            else if (DateTime.Now.Hour > 18)
                labelMensagem.Text = "Boa Noite!";
            else
                labelMensagem.Text = "Boa Tarde!";
            
            labelRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Metodod para acessar o as teclas de atalho
        private void Form_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            //Pega a tecla precionada e direciona o sua determinada ação
            switch (e.KeyCode)
            {
                case Keys .F10:
                    Form_Locacao Fomulario_Locacao = new Form_Locacao();
                    Fomulario_Locacao.ShowDialog();
                    break;
                case Keys.F11:
                    Form_Devolucao Formulario_Devolucao = new Form_Devolucao();
                    Formulario_Devolucao.ShowDialog();
                    break;
                case Keys.F3:
                    Form_Login Formulario_Login = new Form_Login();
                    Formulario_Login.ShowDialog();
                    break;
                case Keys.F5:
                    Form_Consulta_Cliente Formulario_Consulta_Cliente = new Form_Consulta_Cliente();
                    Formulario_Consulta_Cliente.ShowDialog();
                    break;
                case Keys.F6:
                    Form_Consulta_Filme Formulario_Consulta_Filme = new Form_Consulta_Filme();
                    Formulario_Consulta_Filme.ShowDialog();
                    break;
                case Keys.F7:
                    Form_Novo_Cliente Formulario_Cadastro_Cliente = new Form_Novo_Cliente();
                    Formulario_Cadastro_Cliente.ShowDialog();
                    break;            
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Categoria fORMULARIO_CAT = new Form_Categoria();
            fORMULARIO_CAT.ShowDialog();
        }

        
        void mplayer_OpenFile(Object sender, OpenFileEventArgs e)
        {
            Linha_tempo.Maximum = (int)(mplayer.AudioLength / 1000);
            Linha_tempo.Value = 0;
            timer.Enabled = false;
        }

        void mplayer_StopFile(Object sender, StopFileEventArgs e)
        {

            timer.Enabled = false;
            Linha_tempo.Value = 0;
        }

        void mplayer_PauseFile(Object sender, PauseFileEventArgs e)
        {
            
            timer.Enabled = false;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            mplayer.Seek((ulong)(Linha_tempo.Value * 1000));
        }

        void mplayer_PlayFile(Object sender, PlayFileEventArgs e)
        {

            Linha_tempo.Maximum = (int)(mplayer.AudioLength / 1000);
            timer.Enabled = true;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            mplayer.VolumeAll = Volume.Value;
        }

        private void Com_Som(object sender, EventArgs e)
        {
            mplayer.VolumeAll = Volume.Value;
        }

        private void Sem_som(object sender, EventArgs e)
        {
            mplayer.VolumeAll = 0;        
        }

        private void Play_Click(object sender, EventArgs e)
        {

            mplayer.Play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            mplayer.Pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            mplayer.Stop();
        }

        private void EscolheMusica_Click(object sender, EventArgs e)
        {
            OpenFileDialog File_Music = new OpenFileDialog();
            File_Music.Filter = "mp3 files|*.mp3";
            if (File_Music.ShowDialog() == DialogResult.OK)
            {
                string Nome = File_Music.FileName;
                string[] split = Nome.Split(new Char[] { '\\'});
                int p = split.Length;
                Nome = split[p - 1];
                Escolhe_Musica.Text = Nome;
                
                mplayer.Open(File_Music.FileName);
            }

            mplayer.Play();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Linha_tempo.Value = (int)(mplayer.CurrentPosition / 1000);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Linha_tempo_Scroll(object sender, EventArgs e)
        {

        }

    }
}

