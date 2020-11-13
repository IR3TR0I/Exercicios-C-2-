using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("============================");
            Console.WriteLine("Digite seu ano de nascimento");
            Console.WriteLine("============================");


            int ano = int.Parse(Console.ReadLine());

            int idade = 2020-ano;
            double semanas = idade*52.178;

            Console.Write("Você viveu aproximadamente "+idade+" anos E "+semanas+" semanas");
        }
    }
}
