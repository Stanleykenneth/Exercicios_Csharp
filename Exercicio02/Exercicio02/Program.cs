using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/*
    01 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
         mensagem explicativa, conforme exemplos. 
*/

namespace Exercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int soma;

            soma = num1 + num2;
            Console.WriteLine();

            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int soma1;
            soma1 = num3 + num4;
            Console.WriteLine();

            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());

            int soma2;
            soma2 = num5 - num5;
            Console.WriteLine();

            Console.WriteLine("SOMA = " + soma);
            Console.WriteLine("SOMA = " + soma1);
            Console.WriteLine("SOMA = " + soma2);


        }
    }
}
