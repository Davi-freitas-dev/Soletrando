using soletrando.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace soletrando
{
    public partial class Form2 : Form
    {

        public List<Palavras> Erros2 { get; private set; } = new List<Palavras>();
        private GerenciadorPalavras gerenciador;
        private Form1 form1;

      
        public void RegistrarErrosDoJogo()
        {
            gerenciador.AdicionarErrosAErros2(Erros2);
        }


        public Form2()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            gerenciador = new GerenciadorPalavras();

        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TextoDoCampo1
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TextoDoCampo2
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }





        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


            gerenciador.LimparPalavras();


            System.Windows.Forms.CheckBox[] checkboxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox9 };

            bool algumMarcado = checkboxes.Any(c => c.Checked);

            if (!algumMarcado)
            {
                MessageBox.Show("Marque ao menos uma categoria.");
                return;
            }

            // Carregar palavras por categoria
            if (checkBox1.Checked) gerenciador.CarregarPalavrasMapa();
            if (checkBox2.Checked) gerenciador.CarregarPalavrasAnimaisMarinhos();
            if (checkBox3.Checked) gerenciador.CarregarPalavras();
            if (checkBox4.Checked) gerenciador.CarregarPalavrasTransporte();
            if (checkBox5.Checked) gerenciador.CarregarPalavrasFloress();
            if (checkBox6.Checked) gerenciador.CarregarPalavrasVestuarios();
            if (checkBox7.Checked) gerenciador.CarregarPalavrasOutrosAnimais();

            // Recupera erros do Form1 se checkbox9 estiver marcado
            if (checkBox9.Checked && Erros2.Any())
            {

                gerenciador.AdicionarErrosAPalavras(Erros2);



            }

            // Embaralha a lista e mostra a primeira palavra
            gerenciador.PrepararOrdem();


            if (gerenciador.TemPalavras())
            {
                form1 = new Form1(gerenciador, this);
                // Abre o Form1 para começar a soletrar
                form1.StartPosition = FormStartPosition.Manual;
                form1.Location = this.Location;
                form1.Size = this.Size;           // copia o tamanho
                form1.WindowState = this.WindowState;
                this.Hide();
                form1.ShowDialog();

                // Ao fechar o Form1, retorna para o Form2
                this.Show();
                this.BringToFront();
            }
            else
            {
                MessageBox.Show("Não há palavras para exibir.");
            }



        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            bool marcar = checkBox8.Checked;
            foreach (var c in new System.Windows.Forms.CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox9 })
                c.Checked = marcar;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
