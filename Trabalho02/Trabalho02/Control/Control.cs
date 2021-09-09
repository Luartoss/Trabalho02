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
        public static List<Celula> ListaTexto(string texto)
        {
            List<Celula> lista = new List<Celula>();
            foreach (var item in texto)
            {
                string temp = item.ToString().ToUpper();
                if (temp == "A" || temp == "D")
                {
                    Celula unica = Model.Model.A1();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "E" || temp == "F")
                {
                    Celula unica = Model.Model.A2();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "B" || temp == "C")
                {
                    Celula unica = Model.Model.A3();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "G" || temp == "I" || temp == "U")
                {
                    Celula unica = Model.Model.B1();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "H" || temp == "J" || temp == "V")
                {
                    Celula unica = Model.Model.B2();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "K" || temp == "L")
                {
                    Celula unica = Model.Model.B3();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "M" || temp == "O" || temp == "Q")
                {
                    Celula unica = Model.Model.C1();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "N" || temp == "T" || temp == "P")
                {
                    Celula unica = Model.Model.C2();
                    unica.letra = temp;
                    lista.Add(unica);
                }
                if (temp == "R" || temp == "S" || temp == "Z")
                {
                    Celula unica = Model.Model.C3();
                    unica.letra = temp;
                    lista.Add(unica);
                }
            }
            return lista;
        }


        public static int Verifica(List<Celula> lista, Celula[][] matriz)
        {
            int pontos = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (i < lista.Count)
                    {

                    if (lista[i].letra == matriz[i][j].letra)
                    {
                            while (true)
                            {

                                 int tempCol = 0;
                                 int tempLin = 0;
                                 pontos++;
                                 tempCol = j;
                                 tempLin = i;

                                 lista.RemoveAt(i);

                                 tempCol = tempCol - lista[i].coluna;
                                tempLin = tempLin - lista[i].linha;

                                if (tempCol == 1 || tempCol == -1 && tempLin == 1 || tempLin == -1)
                                {
                                    i = 0;
                                    break;
                                }
                                else {
                                    break;
                                }
                            }
                    }
                    }
                }
            }
            return pontos;

        }
    }

}


