using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {

        public static void Formatar(int dia, int mes, int ano)// parametros nomeado, esta ordem vai ser apresentanda na tela
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }                       //D2 acrescenta mais um digito caso seje colocado somente 1
        public static void Executar()
        {
            Formatar(ano: 1996, mes: 1, dia: 6); // 06/01/1996 vai ser apresentado assim na tela, idependente da ordem 


        }
    }
}
