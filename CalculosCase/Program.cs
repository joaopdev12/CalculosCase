using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            double num2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Escolha um operador: +, -, *, /");
            string operador = Console.ReadLine();

            switch(operador)
            {
                case "+":
                    Console.WriteLine("O resultado da soma é: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("O resultado da subtração é: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("O resultado da multiplicação é: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("O resultado da divisão é: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("digite um operador valido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
