using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;



namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               
                // Fundamentos 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos",Comentarios.Executar},
                {"Conversoes - Fundamentos",Conversoes.Executar},
                {"Formatando Numero - Fundamentos",FormatandoNumero.Executar},
                {"Inferencia - Fundamentos",Inferencia.Executar},
                {"Interpolacao - Fundamentos",Interpolacao.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Notacao Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Operadores Aritmeticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Operadores Atribuicao - Fundamentos",OperadoresAtribuicao.Executar},
                {"Operadores Logicos - Fundamentos",OperadoresLogicos.Executar },
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"Operadores Unarios - Fundamentos",OperadoresUnarios.Executar },
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar },
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar },
                
                
                //Estruturas de Controle
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If Else If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Estrutura Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
               
                
                //ClassesEMetodos
                {"Atributos Estaticos - Classes E Metodos", AtributosEstaticos.Executar },
                {"Construtores - Classes E Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes E Metodos", DesafioAtributo.Executar },
                {"Exemplo Enum - Classes E Metodos", ExemploEnum.Executar },
                {"Exemplo Struct - Classes E Metodos", ExemploStruct.Executar },
                {"Get Set - Classes E Metodos", GetSet.Executar },
                {"Membros - Classes E Metodos", Membros.Executar },
                {"Metodos Com Retorno - Classes E Metodos",MetodosComRetorno.Executar },
                {"Metodos Estaticos - Classes E Metodos",MetodosEstaticos.Executar },
                {"Parametro Padrao - Classes E Metodos", ParametroPadrao.Executar },
                {"Parametros Nomeados - Classes E Metodos", ParametrosNomeados.Executar },
                {"Parametros Por Referencia - Classes E Metodos", ParametrosPorReferencia.Executar },
                {"Params - Classes E Metodos", Params.Executar },
                {"Props - Classes e Métodos,", Props.Executar },
                {"Readonly - Classes e Métodos,", Readonly.Executar },
                {"Struct Vs Classe - Classes e Métodos,", StructVsClasse.Executar },
                {"Valor Vs Referencia- Classes e Métodos,", ValorVsReferencia.Executar },

                //Coleções
                {"Array - Coleções ", Colecoes.Array.Executar },
                {"List- Coleções ", ColecoesList.Executar },
                {"Array List - Coleções ", ColecoesArrayList.Executar },
                {"Set - Coleções ", ColecoesSet.Executar },
                {"Queue - Coleções ", ColecoesQueue.Executar },
                {"Igualdade - Coleções ", Igualdade.Executar },
                {"Stack - Coleções ", ColecoesStack.Executar },
                {"Colecoes Dictionary - Coleções ", ColecoesDictionary.Executar },
                
                
                
                //OO
                {"Herança - OO ", Heranca.Executar },
                {"Contrutor This - OO ", ConstrutorThis.Executar },
                {"Encapsulamento - OO ", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO ", Polimorfismo.Executar },
                {"Abstract - OO ", Abstract.Executar },
                {"Interface - OO ", Interface.Executar },
                {"Sealed - OO ", Sealed.Executar },
               
                // Metodos e funções 

                {"Exemplo Lambda - Metodos & Funcoes ", ExemploLambda.Executar },
                {"Lambda Como Delegates - Metodos & Funcoes ",LambdasDelegate.Executar },
                {"Usando Delegates - Metodos & Funcoes ",UsandoDelegates.Executar },
                {"Delegates Com Funcões Anonimas  - Metodos & Funcoes ",DelegateFunAnonima.Executar },
                {"Delegates Como Parametros  - Metodos & Funcoes ",DelegateComoParametros.Executar },
                {"Metodos de Extensao - Metodos & Funcoes ",MetodosDeExtensao.Executar },
               
                
                // Excecões 
     
                {"Primeria Excecao - Exceções ",PrimeiraExcecao.Executar },
                {"Excecoes Personalizadas - Exceções ", ExcecoesPersonalizadas.Executar },
                

                //Api
                {"Primeiro Arquivo - Usando API ", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - Usando API ", LendoArquivos.Executar },
                {"Exemplo File Info - Usando API ", ExemploFileInfo.Executar },
                {"Diretorios - Usando API ", Diretorios.Executar },
                {"Exemplo Directory Info - Usando API ",ExemploDirectoryInfo.Executar },
                {"Exemplo Path - Usando API ",ExemploPath.Executar },
                {"Exemplo Date Time - Usando API ",ExemploDateTime.Executar },
                {"Exemplo Time Span - Usando API ", ExemploTimeSpan.Executar },
                


                //Tópicos Avançados 
                {"LINQ #01 - Tópicos Avançados",LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados",LINQ2.Executar },
                {"Nullables - Tópicos Avançados",Nullables.Executar },
                {"Dynamics - Tópicos Avançados",Dynamics.Executar },



            });

            central.SelecionarEExecutar();
        }
    }
}