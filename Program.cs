using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculadoraCompletaPeloCmd
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potenciacao, Raiz, Sair };

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário NÃO(!) ESCOLHER SAIR EXIBA O MENU
            {
                // Exiba o menu
                Console.WriteLine("Seja bem vindo ao CALC,selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potenciacao\n6-Raiz\n7-Sair");

                /*OPCAO 1
                string opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;
                */

                //OPCAO 2
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potenciacao:
                        Potenciacao();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
            //Feche
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.WriteLine("====================");
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine($"O resultado eh {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.WriteLine("====================");
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 - num2;
            Console.Write($"O resultado eh: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisao de dois numeros");
            Console.WriteLine("=======================");
            Console.Write("Digite o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 / num2;
            Console.WriteLine($"O resultado eh {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicao de dois numeros");
            Console.WriteLine("===========================");
            Console.Write("Digite o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 * num2;
            Console.WriteLine($"O resultado eh {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Potenciacao()
        {
            Console.WriteLine("Pontenciacao");
            Console.WriteLine("============");
            Console.Write("Digite o valor da base: ");
            float vlBase = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor do expoente: ");
            float vlExpoente = float.Parse(Console.ReadLine());
            float resultado = (float)Math.Pow(vlBase, vlExpoente);
            Console.WriteLine($"O resultado eh {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz Quadrada");
            Console.WriteLine("=============");
            Console.Write("Digite um numero: ");
            float raiz = float.Parse(Console.ReadLine());
            float resultado = (float)Math.Sqrt(raiz);
            Console.WriteLine($"O resultado eh {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}