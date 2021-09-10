using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho02
{
    public partial class Form1 : Form
    {
        int somatoria;
        List<string> palavras = new List<string>();
        List<char> charr = new List<char>();
        string[][] matriz = Model.Model.GeraMatriz();

        private void GeraMatriz()
        {
            matriz = Control.Control.GeraMatriz(matriz);
        }
        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostraLetra();



        }

        //Função que gera as letras
        private string[][] MostraLetra()
        {

            lbla1.Text = matriz[0][0];
            lbla2.Text = matriz[0][1];
            lbla3.Text = matriz[0][2];

            lblb1.Text = matriz[1][0];
            lblb2.Text = matriz[1][1];
            lblb3.Text = matriz[1][2];

            lblc1.Text = matriz[2][0];
            lblc2.Text = matriz[2][1];
            lblc3.Text = matriz[2][2];

            return matriz;
        }
        private void btnGerarNovamente_Click(object sender, EventArgs e)
        {
            GeraMatriz();
            MostraLetra();
            txtPalavra.Clear();
        }
        string letra = "";
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            letra = txtPalavra.Text.ToUpper();
            bool encontrou = true;
            int pontos = 0;
            int i;
            int j;
            int posicaoletra = 0;
            char separacao = ' ';
            if (conferePalavra())
            {
                MessageBox.Show("Palavra Repetida");
            }
            else
            {

                separacao = Control.Control.Separa(letra, posicaoletra);
                bool verifica = Control.Control.LocalizaPosicao(separacao, matriz, out i, out j);


                if (verifica)
                {
                    pontos = 1;

                    while (encontrou)
                    {
                        

                        charr.Add(separacao);
                        posicaoletra++;
                        separacao = Control.Control.Separa(letra, posicaoletra);
                        if (separacao == ' ')
                        {
                            break;
                        }
                        encontrou = Control.Control.Verifica(i, j, separacao, matriz, out i, out j);


                        if (encontrou)
                        {
                            pontos++;

                        }


                    }
                    somatoria = somatoria + pontos / 2;
                    lblValorPonto.Text = somatoria.ToString();
                    palavras.Add(letra);

                }
                else
                {
                    MessageBox.Show("ERROUUUU");
                }

            }
        }
        private bool conferePalavra()
        {
            bool palavraRepetida = false;
            return palavraRepetida = Control.Control.conferePalavra(palavras, letra);
        }


    }
}