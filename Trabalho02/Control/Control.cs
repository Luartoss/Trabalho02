using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho02.Model;



namespace Trabalho02.Control
{
    class Control

    {
        public static string[][] GeraMatriz(string[][] matriz)
        {
            return matriz = Model.Model.GeraMatriz();
        }
        public static List<string> ListaTexto(string texto)
        {
            List<string> lista = new List<string>();
            foreach (var item in texto)
            {
                lista.Add(item.ToString());
            }
            return lista;
        }

        public static bool conferePalavra(List<string> palavras, string letra)
        {
            bool palavraRepetida = false;
            foreach (var item in palavras)
            {
                if (item == letra)
                {
                    palavraRepetida = true;
                    break;
                }
            }
            return palavraRepetida;
        }
        public static bool confereLetra(List<char> charr, char separacao)
        {
            bool letraRepetida = false;

            foreach (var item in charr)
            {
                if (item == separacao)
                {
                    letraRepetida = true;
                    break;
                }
            }
            return letraRepetida;
        }
        public static bool Verifica(int linha, int coluna, char letra, string[][] matriz, out int i, out int j)
        {
            bool encontrou = false;
            i = linha;
            j = coluna;

            while (true)
            {

                i = DiminuiLinha(linha);
                j = DiminuiColuna(coluna);


                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                i = DiminuiLinha(linha);


                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                i = DiminuiLinha(linha);
                j = AcrescentaColuna(coluna);

                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                j = DiminuiColuna(coluna);

                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                j = AcrescentaColuna(coluna);

                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                i = AcrescentaLinha(linha);
                j = DiminuiColuna(coluna);

                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                i = AcrescentaLinha(linha);

                encontrou = Execute(i, j, letra, matriz);

                if (encontrou)
                {
                    break;
                }
                i = linha;
                j = coluna;
                i = AcrescentaLinha(linha);
                j = AcrescentaColuna(coluna);

                encontrou = Execute(i, j, letra, matriz);


                break;
            }
            return encontrou;



        }
        public static int DiminuiLinha(int i)
        {
            if (i > 0)
            {
                i--;
            }
            return i;
        }
        public static int AcrescentaLinha(int i)
        {
            if (i < 2)
            {
                i++;
            }
            return i;

        }
        public static int DiminuiColuna(int j)
        {
            if (j > 0)
            {
                j--;
            }
            return j;

        }
        public static int AcrescentaColuna(int j)
        {
            if (j < 2)
            {
                j++;
            }
            return j;

        }
        public static bool Execute(int i, int j, char letra, string[][] matriz)
        {
            bool deucerto = false;

            if (Convert.ToChar(matriz[i][j]) == letra)
            {
                deucerto = true;
            }

            return deucerto;


        }
        public static char Separa(string letra, int posicaoletra)
        {
            char caractere = ' ';

            if (posicaoletra >= letra.Length)
            {


            }
            else
            {

                caractere = Convert.ToChar(letra[posicaoletra]);

            }
            return caractere;


        }
        public static bool LocalizaPosicao(char comparacao, string[][] matriz, out int i, out int j)
        {
            bool conferencia = false;
            i = 0;
            j = 0;

            for (int k = 0; k < matriz.Length; k++)
            {
                for (int l = 0; l < matriz[k].Length; l++)
                {
                    if (Convert.ToChar(matriz[k][l]) == comparacao)
                    {
                        conferencia = true;
                        i = k;
                        j = l;


                    }



                }
            }

            return conferencia;



        }


    }
}