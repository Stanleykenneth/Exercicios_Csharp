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

            Console.WriteLine("SOMA = " + soma);


        }
    }
}
