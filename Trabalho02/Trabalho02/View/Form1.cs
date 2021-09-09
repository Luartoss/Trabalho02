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
        public Form1()
        {
            InitializeComponent();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        

        }

        //Função que gera as letras
        public Model.Celula[][] MostraLetra()
        {
            Model.Celula[][] matriz = Model.Model.GeraMatriz();

            lbla1.Text = matriz[0][0].letra;
            lbla2.Text = matriz[0][1].letra;
            lbla3.Text = matriz[0][2].letra;
                                    
            lblb1.Text = matriz[1][0].letra;
            lblb2.Text = matriz[1][1].letra;
            lblb3.Text = matriz[1][2].letra;
                                     
            lblc1.Text = matriz[2][0].letra;
            lblc2.Text = matriz[2][1].letra;
            lblc3.Text = matriz[2][2].letra;

            return matriz;
        }
        //Função do botão 'Gerar Novamente'
        private void btnGerarNovamente_Click(object sender, EventArgs e)
        {
           MostraLetra();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Model.Celula> lista =  Control.Control.ListaTexto(txtPalavra.Text);
            
            
            lblValorPonto.Text = Control.Control.Verifica(lista, MostraLetra()).ToString();
        }

        private void lbla2_Click(object sender, EventArgs e)
        {

        }
    }
}
