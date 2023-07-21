using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/*
Crie um programa que solicite ao usuário dois números e uma operação matemática (+, -, *, /).
O programa deve retornar o resultado da operação.*/

namespace Exercicios
{
    internal class Exercicio01
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int operacao;

            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o segundo número:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Escolha a operação que deseja realizar: \n [1] - SOMA\n [2] - SUBTRAÇÃO\n [3] - MULTIPLICAÇÃO\n [4] - DIVISÃO.\n\n Digite uma opção:");
            Console.WriteLine();
            operacao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (operacao)
            {
                case 1:

                    int soma;

                    soma = num1 + num2;

                    Console.WriteLine(soma);

                    break;


                case 2:

                    int subtracao;

                    subtracao = num1 - num2;

                    Console.WriteLine(subtracao);

                    break;


                case 3:

                    int multiplicacao;

                    multiplicacao = num1 * num2;

                    Console.WriteLine(multiplicacao);

                    break;

                case 4:

                    int divisao;

                    divisao = num1 / num2;

                    Console.WriteLine(divisao);

                    break;

                default:
                    break;
            }
        }
    }
}
