using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            double resultado = 0;

            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Calcular");
                Console.WriteLine("2 - Zerar");
                Console.WriteLine("3 - Sair");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    double num1 = 0;

                    if(resultado == 0){
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());

                    } else {
                        num1 = resultado;
                    }

                    Console.Write("Digite a operação (+, -, *, /): ");
                    string operacao = Console.ReadLine();

                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case "+":
                            resultado = calculadora.Somar(num1, num2);
                            break;
                        case "-":
                            resultado = calculadora.Subtrair(num1, num2);
                            break;
                        case "*":
                            resultado = calculadora.Multiplicar(num1, num2);
                            break;
                        case "/":
                            resultado = calculadora.Dividir(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Operação inválida!");
                            break;
                    }

                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (opcao == "2")
                {
                    calculadora.Zerar();
                    Console.WriteLine("Resultado zerado!");
                }
                else if (opcao == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}
