using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso; // construtor cheio 
        }

        public Comida() { }// contrutor vazio
    }


    public class Feijao : Comida // feijao herda atributos direto de comida 
    {
        
    }

    public class Arroz : Comida
    {    
        public Arroz(double peso) : base(peso) { } // chama o contrutor base forçando o usuario a passar um valor na construçao da classe 
        
    }

    public class Carne : Comida
    {
        
    }

    public class Pessoa
    {
        public double Peso;

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;

        //}

        public void Comer(Comida comida) // todas a comidas serao relacionadas somente a essa chamada 
        {
            Peso += comida.Peso;
        }



    }
    class Polimorfismo
    {

        public static void Executar()
        {

            Feijao ingrediente1 = new Feijao();// instancia o alimento e acrescenta um peso a ele 
            ingrediente1.Peso = 0.3; // 300 gramas 

            Arroz ingrediente2 = new Arroz(0.25);
           

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;// 300 gramas 

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}Kg!");
        }

    }

}

