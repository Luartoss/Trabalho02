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
        public static List<string> ListaTexto(string texto)
        {
            List<string> lista = new List<string>();
            foreach (var item in texto)
            {
                lista.Add(item.ToString());
            }
            return lista;
        }


        //Index de posição na matriz

        public static int Verifica(List<string> lista, string[][] matriz)
        {
            int pontos = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j < lista[i].Length; j++)
                {
                    
                }
            }

            return pontos;
        }

    }
}
