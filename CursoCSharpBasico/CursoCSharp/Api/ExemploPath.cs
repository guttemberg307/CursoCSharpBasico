
using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome(); // dentro do home do usuario criamos um arquivo chamado exemplo_path_arquivo.txt
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))// se o arquivo nao existir 
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta)) // se o diretorio nao existir passando a pasta 
            {
                Directory.CreateDirectory(pasta); // o diretorio vai ser criado passando a pasta 
            }


            Console.WriteLine(Path.GetExtension(arquivo));// vai passar a extenção do arquivo 
            Console.WriteLine(Path.GetFileName(arquivo));// vai passaro nome do arquivo 
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));// nome do arquivo sem extensão 
            Console.WriteLine(Path.GetDirectoryName(arquivo)); // vai passar o diretorio do arquivo 
            Console.WriteLine(Path.HasExtension(arquivo));// retorna se o metodo tem extensão ou nao // retornara false ou true 

            Console.WriteLine(Path.HasExtension(pasta));// vai dizer se na pasta tem ou nao tem extensao no caso da pasta vai aparecer falso 
            Console.WriteLine(Path.GetFullPath(pasta));// vai mostrar o caminho completo 
            Console.WriteLine(Path.GetPathRoot(pasta));// em que raiz a pasta é localizada se esta no dico C , E , D 

        }
    }
}
