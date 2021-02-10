using System;
using System.IO;


namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {

        public static void Executar()
        {
            var  dirProjeto = @"~/source/repos/CursoCSharpBasico/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);// criada uma instancia de directoryInfo passando dirProjeto 

            if (!dirInfo.Exists)// se diInfo nao existir 
            {
                dirInfo.Create();// cria uma novo dirInfo 
            }

            Console.WriteLine("\n\n======================== Arquivos ========================");
            var arquivos = dirInfo.GetFiles(); // nao precisa colocar nada no getfiles pois a intancia de dirInfo já o chama 

            foreach ( var arquivo in arquivos)// faz uma varredura de todos os arquivos dentro da pasta 
            {
                Console.WriteLine(arquivo);// imprime no cosole os arquivos dentro de dirInfo 
            }

            Console.WriteLine("\n\n========================Diretórios ========================");
            var pastas = dirInfo.GetDirectories();
            foreach( var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n======================================================= =========================");
            Console.WriteLine(dirInfo.CreationTime);// data e hora 
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root); // diretorio raiz 
            Console.WriteLine(dirInfo.Parent.Parent); // diretorio pai do pai 
          
        }

    }
}
