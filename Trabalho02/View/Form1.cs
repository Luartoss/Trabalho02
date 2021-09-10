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

        string[][] matriz = Model.Model.GeraMatriz();


        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            matriz = MostraLetra();



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
            lblValorPonto.Text = "0";
            txtPalavra.Text = null;
            matriz = Model.Model.GeraMatriz();
            matriz = MostraLetra();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool encontrou = true;
            string letra = txtPalavra.Text;
            int i;
            int j;
            int posicaoletra = 0;
            char separacao = ' ';
            separacao = Control.Control.Separa(letra, posicaoletra);
            bool verifica = Control.Control.LocalizaPosicao(separacao, matriz, out i, out j);


            if (verifica)
            {
                while (encontrou)
                {

                    posicaoletra++;

                    separacao = Control.Control.Separa(letra, posicaoletra);
                    encontrou = Control.Control.Verifica(i, j, separacao, matriz, out i, out j);

                    int pontos;

                    pontos = +1;

                    int somatoria;

                    somatoria = pontos;

                    lblValorPonto.Text = somatoria.ToString();
                }

            }
            else
            {
                MessageBox.Show("ERROUUUU");
            }

        }
      


    }
}
