
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GFT
{
    class Calculadora
    {
         enum Menu {Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6 , Sair = 7}
        static void Main(string[] args)
        {
           bool escolheuSair =  false;
           while (!escolheuSair)
           {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
           Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-Multiplicacao\n5-Pontecia\n6-Raiz\n7-Sair");

           Menu opcao = (Menu)int.Parse(Console.ReadLine());

           switch (opcao)
           {
            case Menu.Soma:
               Soma();
               break;

            case Menu.Subtracao:   
               Sub();
               break;

            case Menu.Divisao:
               Div();
               break;

            case Menu.Multiplicacao:
               Mult();
               break;
            case Menu.Potencia:
               Pot();
               break;

            case Menu.Raiz:
               Raiz();
               break;

            case Menu.Sair:
               escolheuSair = true;  
              break;           
           }

           Console.Clear();

           }

        }
         static void Soma()
         {
            Console.WriteLine("A soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
         }

                  static void Sub()
         {
            Console.WriteLine("A Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
         }

                  static void Div()
         {
            Console.WriteLine("A Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
         }

                  static void Mult()
         {
            Console.WriteLine("A Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
         }

                  static void Pot()
         {
            Console.WriteLine("A Potencia de um numero: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
         }

                           static void Raiz()
         {
            Console.WriteLine("A Raiz de um numero: ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
         }

        }

}
