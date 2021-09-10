using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho02.Model
{
    public class Model
    {
        public static Model modelo = new Model();

        //Funções de cada Label

        public static string[][] GeraMatriz()
        {
            string[][] matriz = new string[3][];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new string[3];
            }

            matriz[0][0] = Model.A1();
            matriz[0][1] = Model.A2();
            matriz[0][2] = Model.A3();
            matriz[1][0] = Model.B1();
            matriz[1][1] = Model.B2();
            matriz[1][2] = Model.B3();
            matriz[2][0] = Model.C1();
            matriz[2][1] = Model.C2();
            matriz[2][2] = Model.C3();

            return matriz;
        }
        public static string A1()
        {

            List<string> A1 = new List<string>();
            Random ran = new Random();
            A1.Add("A");
            A1.Add("D");
            string gerador = A1[ran.Next(0, A1.Count)];

            return gerador;
        }
        public static string A2()
        {

            List<string> A2 = new List<string>();
            Random ran = new Random();
            A2.Add("E");
            A2.Add("F");
            string gerador = A2[ran.Next(0, A2.Count)];

            return gerador;
        }
        public static string A3()
        {

            List<string> A3 = new List<string>();
            Random ran = new Random();
            A3.Add("B");
            A3.Add("C");
            string gerador = A3[ran.Next(0, A3.Count)];

            return gerador;
        }
        public static string B1()
        {

            List<string> B1 = new List<string>();
            Random ran = new Random();
            B1.Add("G");
            B1.Add("I");
            B1.Add("U");
            string gerador = B1[ran.Next(0, B1.Count)];

            return gerador;
        }
        public static string B2()
        {

            List<string> B2 = new List<string>();
            Random ran = new Random();
            B2.Add("H");
            B2.Add("J");
            B2.Add("V");
            string gerador = B2[ran.Next(0, B2.Count)];

            return gerador;
        }
        public static string B3()
        {

            List<string> B3 = new List<string>();
            Random ran = new Random();
            B3.Add("K");
            B3.Add("L");

            string gerador = B3[ran.Next(0, B3.Count)];

            return gerador;
        }
        public static string C1()
        {

            List<string> C1 = new List<string>();
            Random ran = new Random();
            C1.Add("M");
            C1.Add("O");
            C1.Add("Q");
            string gerador = C1[ran.Next(0, C1.Count)];

            return gerador;
        }
        public static string C2()
        {

            List<string> C2 = new List<string>();
            Random ran = new Random();
            C2.Add("N");
            C2.Add("T");
            C2.Add("P");
            string gerador = C2[ran.Next(0, C2.Count)];

            return gerador;
        }
        public static string C3()
        {

            List<string> C3 = new List<string>();
            Random ran = new Random();
            C3.Add("R");
            C3.Add("S");
            C3.Add("Z");
            string gerador = C3[ran.Next(0, C3.Count)];

            return gerador;
        }





    }
}