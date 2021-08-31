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
        
        
        public static List<string> ListaGerada()
        {
            List<string> lista = new List<string>();
            lista.Add(Model.Model.A1());

            lista.Add(Model.Model.A2());

            lista.Add(Model.Model.A3());

            lista.Add(Model.Model.B1());

            lista.Add(Model.Model.B2());

            lista.Add(Model.Model.B3());

            lista.Add(Model.Model.C1());

            lista.Add(Model.Model.C2());

            lista.Add(Model.Model.C3());

            return lista;


        }



    }
}
