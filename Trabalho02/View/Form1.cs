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
            MostraLetra();



        }

        //Função que gera as letras
        private string[][] MostraLetra()
        {
            //string[][] matriz = Model.Model.GeraMatriz();

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
        //Função do botão 'Gerar Novamente'
        private void btnGerarNovamente_Click(object sender, EventArgs e)
        {
            MostraLetra();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool encontrou = true;
            string letra = txtPalavra.Text.ToUpper();
            int i;
            int j;
            int posicaoletra = 0;
            char qnomeqdouaqui = ' ';
            qnomeqdouaqui = Control.Control.Separa(letra, posicaoletra);
            bool verifica = Control.Control.LocalizaPosicao(qnomeqdouaqui, matriz, out i, out j);

            if (verifica)
            {
                while (encontrou)
                {

                    posicaoletra++;
                    qnomeqdouaqui = Control.Control.Separa(letra, posicaoletra);
                    encontrou = Control.Control.Verifica(i, j, qnomeqdouaqui, matriz, out i, out j);
                    //cerebro

                }



            }
            else
            {
                MessageBox.Show("ERROUUUU");
            }

            //Control.Control.Verifica(Control.Control.ListaTexto(txtPalavra.Text), MostraLetra());
        }

        private void lbla2_Click(object sender, EventArgs e)
        {

        }
    }
}
