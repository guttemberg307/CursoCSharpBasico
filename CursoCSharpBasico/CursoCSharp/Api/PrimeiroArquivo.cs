using System;
using System.IO;


namespace CursoCSharp.Api
{

    public static class ExtensaoString // função extensao string 
    {
        public static string ParseHome(this string path)
        {// essa função substitui o TIL pela pasta home do usuario 

            // compara se a plataforma é linux                                              // ou MacOs 
            string home = (Environment.OSVersion.Platform == PlatformID.Unix) || (Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME") // "?" faz uma atribuição caso seja linux ou Mac 
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"); //("%HOMEDRIVE%%HOMEPATH%") no windows é comom se le uma variavel de ambiente no caso prompt de comando 
            return path.Replace("~", home); // retorna e substitui o Til pela pasta HOME , usando ParseHome

        }

    }
    class PrimeiroArquivo
    {

        public static void Executar()
        {
            //var s = "\teste\testes\a.txt";// \t o compilador interpreta como um TAB
            //Console.WriteLine(s);

            var path = @"~/primeiro_arquivo.txt".ParseHome(); //@ o arroba faz o compilador imprimir de forma literal 
            Console.WriteLine(path);

            if (!File.Exists(path))// se o arquivo nao existir passa o (path)
            {
                using (StreamWriter sw = File.CreateText(path))//StreamWriter esta escrevendo e salvando os dados que quer mandar para o arquivo 
                {
                    sw.WriteLine("");
                    sw.WriteLine("Esse é");// esse texto vai ficar gravado no arquivo txt 
                    sw.WriteLine("O nosso");
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("ArquivoO");

                }
            }
            using (StreamWriter sw = File.AppendText(path))//AppendText adiciona mais texto, a cada execução ele repete o texto abaixo no arquivo 
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }

        }

    }
}