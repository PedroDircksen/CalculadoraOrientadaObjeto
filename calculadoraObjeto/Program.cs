using System;

namespace calculadoraObjeto
{

    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0, numero2 = 0;
            Calculadora calculadora = new Calculadora();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para somar...........................................");
                Console.WriteLine("Digite 2 para subtrair........................................");
                Console.WriteLine("Digite 3 para multiplicação...................................");
                Console.WriteLine("Digite 4 para divisão.........................................");
                Console.WriteLine("Digite 5 para acessar o histórico de operações................");
                Console.WriteLine("Digite 6 para sair.........................................");
                int opcaoMenu = Convert.ToInt32(Console.ReadLine());

                if (opcaoMenu != 1 && opcaoMenu != 2 && opcaoMenu != 3 && opcaoMenu != 4 && opcaoMenu != 5 && opcaoMenu != 6)
                {
                    Console.WriteLine("Número inválido, tente novamente.");
                    Console.ReadLine();
                    continue;
                }

                if (opcaoMenu==6)
                {
                    break;
                }

                if (opcaoMenu == 5)
                {
                    calculadora.MostrarHistorico();
                    Console.ReadLine();
                    continue;

                }

                Console.Write("Informe o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.Write("Informe o segundo número: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    if(opcaoMenu == 4 && numero2 == 0)
                    {
                        Console.WriteLine("Segundo número ínvalido, tente novamente");
                        Console.ReadLine();
                    }
                } while (opcaoMenu == 4 && numero2 == 0);

                if (opcaoMenu == 1)
                {
                    calculadora.ResultadoSoma = calculadora.Somar(numero1, numero2);
                    Console.WriteLine(calculadora.ResultadoSoma);
                    Console.ReadLine();
                    continue;
                }
                else if (opcaoMenu == 2)
                {
                    calculadora.ResultadoSubtracao = calculadora.Subtrair(numero1, numero2);
                    Console.WriteLine(calculadora.ResultadoSubtracao);
                    Console.ReadLine();
                    continue;

                }
                else if (opcaoMenu == 3)
                {
                    calculadora.ResultadoMultiplicacao = calculadora.Multiplicar(numero1, numero2);
                    Console.WriteLine(calculadora.ResultadoMultiplicacao);
                    Console.ReadLine();
                    continue;

                }
                else if (opcaoMenu == 4)
                {
                    calculadora.ResultadoDivisao = calculadora.Dividir(numero1, numero2);
                    Console.WriteLine(calculadora.ResultadoDivisao);
                    Console.ReadLine();
                    continue;

                }
            }
        }
    }
}
