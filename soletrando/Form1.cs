using soletrando.classes;
using System;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace soletrando
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private GerenciadorPalavras gerenciador;

        private int pontosJogador1 = 0;
        private int pontosJogador2 = 0;
        private bool vezJogador1 = true;

        // Construtor obrigatório com gerenciador
        public Form1(GerenciadorPalavras g, Form2 f)
        {
            InitializeComponent();
            gerenciador = g;
            form2 = f;
            this.AcceptButton = button3;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            /* gerenciador.CarregarPalavrasMapa();
             gerenciador.PrepararOrdem();*/

            AtualizarTela();
            jogador1.Text = form2.TextoDoCampo1;
            jogador2.Text = form2.TextoDoCampo2;


            AtualizarPlacar();
            AtualizarVez();
        }

        private void JogadorAcertou()
        {
            if (vezJogador1)
            {
                pontosJogador1++;
            }
            else
            {
                pontosJogador2++;
            }

            AtualizarPlacar();
            TrocarVez();
        }
        private void JogadorErrou()
        {
            TrocarVez();
        }

        private void TrocarVez()
        {
            vezJogador1 = !vezJogador1;
            AtualizarVez();
        }

        private void AtualizarVez()
        {
            if (vezJogador1)
                lblVez.Text = $"Vez de: {jogador1.Text}";
            else
                lblVez.Text = $"Vez de: {jogador2.Text}";
        }

        private void AtualizarPlacar()
        {
            lblPontos1.Text = $"Pontos: {pontosJogador1}";
            lblPontos2.Text = $"Pontos: {pontosJogador2}";
        }

        public void AtualizarTela()
        {
            var p = gerenciador.MostrarProximaPalavra();
            if (p != null)
            {
                pictureBox1.Image = p.Imagem;
                resposta.Text = "";
                label1.Text = gerenciador.TotalDePalavras();
            }
            else
            {
                MessageBox.Show("Acabaram as palavras!");
                form2.RegistrarErrosDoJogo();
                this.Close();


            }
        }




        private async void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            string input = resposta.Text.Trim();

            if (gerenciador.PalavraAtual != null)
            {
                if (string.Equals(input, gerenciador.PalavraAtual.Texto, StringComparison.OrdinalIgnoreCase))
                {
                    var acertou = new Palavras("acertou", null, gerenciador.CarregarAudio("acertou.wav"));
                    await Task.Run(() => acertou.TocarAudio());
                    await Task.Delay(3000);
                    JogadorAcertou();
                    AtualizarTela();
                }
                else
                {
                    var errou = new Palavras("errou", null, gerenciador.CarregarAudio("errou.wav"));
                    await Task.Run(() => errou.TocarAudio());
                    JogadorErrou();

                    if (!listBox1.Items.Contains(gerenciador.PalavraAtual.Texto))
                        listBox1.Items.Add(gerenciador.PalavraAtual.Texto);

                    gerenciador.AdicionarPalavraAtualAosErros();
                    // gerenciador.AdicionarPalavraAtualAosErros();
                }


            }

            button3.Enabled = true;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gerenciador.PalavraAtual?.TocarAudio();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AtualizarTela();/*  gerenciador.MostrarProximaPalavra();
            //quantidade de palavras
            string texto = label1.Text; // "Temos 5 palavras"
            string[] partes = texto.Split(' '); // separa por espaços
            int valor = int.Parse(partes[1]);  // pega o segundo elemento ("5")
            valor--;                           // decrementa
            label1.Text = "Falta " + valor + " palavras";  */


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible; // se estava visível, oculta; se estava oculto, mostra

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            form2.RegistrarErrosDoJogo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jogador2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
