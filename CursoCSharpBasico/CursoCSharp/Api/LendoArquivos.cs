using System;
using System.IO;// biblioteca obrigatoria 

namespace CursoCSharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();// ParseHome() substitui o TIL pelo diretorio home na pasta usuarios 




            if (!File.Exists(path))//se o arquivo nao existir ele cria o arquivo 
            {
                using (StreamWriter sw = File.AppendText(path))//StreamWriter esta escrevendo e salvando os dados que quer mandar para o arquivo 
                {
                    sw.WriteLine("Produto;preço;Qtde"); // depois de executado ira aparecer um txt em usuario, nome do pc 
                    sw.WriteLine("Caneta Bic Preta;2.89;89 ");
                    sw.WriteLine("Borracha Branca;2.89;27");

                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))//StreamReader é um leitor que passa um (path) que vai ser lido 
                {
                    var texto = sr.ReadToEnd();//sr.ReadToEnd() vai ler o arquivo completamente 
                    Console.WriteLine(texto);// apresenta o texto acima 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
