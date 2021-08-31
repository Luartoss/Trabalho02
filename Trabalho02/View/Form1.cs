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
            GeraLetra();


        }

        //Função que gera as letras
        private void GeraLetra()
        {
            lbla1.Text = Control.Control.ListaGerada()[0];
            lbla2.Text = Control.Control.ListaGerada()[1];
            lbla3.Text = Control.Control.ListaGerada()[2];

            lblb1.Text = Control.Control.ListaGerada()[3];
            lblb2.Text = Control.Control.ListaGerada()[4];
            lblb3.Text = Control.Control.ListaGerada()[5];

            lblc1.Text = Control.Control.ListaGerada()[6];
            lblc2.Text = Control.Control.ListaGerada()[7];
            lblc3.Text = Control.Control.ListaGerada()[8];

        }
        //Função do botão 'Gerar Novamente'
        private void btnGerarNovamente_Click(object sender, EventArgs e)
        {
            GeraLetra();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //condição
        }
    }
}
