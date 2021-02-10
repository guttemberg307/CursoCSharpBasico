using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada; //UINT na hora de passar na chamada 
                                 //vai ser obrigatorio passar um valor positivo, caso contrario vai dar erro de compilação
        public Moto()
        {
        }

        public Moto(string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            // 1 opção
            //if (Cilindrada > 0) // nao ira aparecer um valor negativo
            //{
            //    Cilindrada = cilindrada;
            //}

            // 2 opção
            //Cilindrada = Math.Abs(cilindrada); // pega todos os valores negativos e transforma em positivos 

            Cilindrada = cilindrada;
        }

    }


    class GetSet
    {
        public static void Executar()
        {

            var moto1 = new Moto("Kavasaki", "Ninja Zx-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetMarca("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());


        }
    }
}