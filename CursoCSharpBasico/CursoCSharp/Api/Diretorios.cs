using System;
using System.IO;


namespace CursoCSharp.Api
{
    class Diretorios
    {

        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();//ParseHome() retorna uma string substituindo o TIL
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharpBasico/CursoCSharp".ParseHome();// endereço da pasta selecionada cursocsharp


            if (Directory.Exists(novoDir))// se existir um diretorio deleta ele.
            {
                Directory.Delete(novoDir, true);// deleta o diretorio de forma recursiva usando TRUE, um diretorio dentro de outro  se usar FALSE vai ser deletado somente um diretorio 

            }

            if(Directory.Exists(novoDirDestino))// se existir um diretorio deleta ele.
            {
                Directory.Delete(novoDirDestino, true);// deleta o diretorio de forma recursiva usando TRUE
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));//(Directory.GetCreationTime() apresenta no console dia,mes,ano e horario que o diretorio foi criado 

            Console.WriteLine("==============================Pastas=================================");

            var pastas = Directory.GetDirectories(dirProjeto);// a variavel pastas recebe Directory.GetDirectories(dirProjeto) que vai retornar as tudo que esta na pasta dirProjeto

            foreach( var pasta in pastas)// fazendo o foreach ele faz uma varredura apresentantado todas as pastas dentro da pasta dirProjeto 
            {
                Console.WriteLine(pasta);// chama todas as pastas imprimindo no console 

            }

            Console.WriteLine("\n\n======================= Arquivos ============================");
            var arquivos = Directory.GetFiles(dirProjeto);// apresenta todos os arquivos dentro da pasta dirProjeto 
            foreach (var arquivo in arquivos) 
            {
                Console.WriteLine(arquivo);// imprime no console 
            }

            Console.WriteLine("\n\n======================= Raiz ============================");
            Console.WriteLine( Directory.GetDirectoryRoot(novoDir));// apresenta a raiz do diretorio 

            Directory.Move(novoDir, novoDirDestino); // move a pasta para novoDir para novoDirDestino
        }
    }
}
