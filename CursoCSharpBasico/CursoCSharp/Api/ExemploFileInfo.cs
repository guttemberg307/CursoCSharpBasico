using System;
using System.IO;

namespace CursoCSharp.Api
{

    class ExemploFileInfo
    {

        public static void ExcluirSeExistir(params string[] caminhos)//o parametro caminhos  agrupa qualquer quantidade 1,2,3,4....dentro do Array de strings nomeados por caminhos 
        
        {
                foreach (var caminho in caminhos) // para cada caminhos em caminhos 
                {
                    FileInfo arquivo = new FileInfo(caminho); // instancia de fileinfo passando caminho para arquivo 

                    if (arquivo.Exists)// se o arquivo existir deleta 
                    {
                        arquivo.Delete();
                    }
                }

         }
            public static void Executar()
            {
                var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
                var caminhoDestino = @"~/arq_destino.txt".ParseHome();
                var caminhoCopia = @"~/arq_copia.txt".ParseHome();

                ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);// so para garantir que os arquivos vao ser excluidos antes de executar o progama 

                using (StreamWriter sw = File.CreateText(caminhoOrigem))// vai ser criado o texto abaixo dentro de um arquivo txt 
                {
                    sw.WriteLine("Arquivo original!");
                }

                FileInfo origem = new FileInfo(caminhoOrigem); // instancia de FileInfo 
                Console.WriteLine(origem.Name);// nome do arquivo 
                Console.WriteLine(origem.IsReadOnly); // somente leitura ou escrita // verdadeiro ou falso // booleano 
                Console.WriteLine(origem.FullName);//  nome completo do arquivo e origem onde ele esta no disco C:
                Console.WriteLine(origem.Extension);// qual a extensão do arquivo txt? doc ? etc



                origem.CopyTo(caminhoCopia); // faz uma copia do arquivo original dentro da propria pasta 
                origem.CopyTo(caminhoDestino);//move o arquivo de local pra o arquivo chamado arq_destino 
            }
        

    }
}
