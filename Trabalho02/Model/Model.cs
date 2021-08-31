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
        public static string A1()
        {

            List<string> A1 = new List<string>();
            Random ran = new Random();
            List<string> primeiroquadro = new List<string>();
            A1.Add("A");
            A1.Add("D");
            string gerador = A1[ran.Next(0, A1.Count)];

            return gerador;
        }







    }
}
