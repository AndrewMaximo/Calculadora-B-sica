using System;
using System.Globalization;

namespace CalculadoraBasica
{

    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, operacao;
            double resultado = 0;

            Console.Write("Por gentileza, digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Por gentileza, digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero");
                        Console.Write("Por gentileza,  digite o segundo número diferente de 0: ");
                        numero2 = int.Parse(Console.ReadLine());
                        resultado = (double)numero1 / numero2;
                    }
                    else
                    {
                        resultado = (double)numero1 / numero2;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("O resultado é = " + resultado.ToString("F1", CultureInfo.InvariantCulture));


            Console.ReadKey();
            
        }
    }
}