using System;
using ProgramasDivisao;
using ProgramasMultiplicar;
using ProgramasSoma;
using ProgramasSubitrair;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisao operacaoDivisao = new Divisao();
            Multiplicar operacaoMultiplicacao = new Multiplicar();
            Soma operacaoSoma = new Soma();
            Subtrair operacaoSubitracao = new Subtrair();

            int numero1 = 0;
            int numero2 = 0;
            int opçao = 0;
            int resultado;

            Console.WriteLine("Digite o Primeiro numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma das opçoes");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            opçao = Convert.ToInt32(Console.ReadLine());

      
            if (opçao == 1)
            {
                Console.WriteLine("A opção escolhida foi soma");
            }
            else if (opçao == 2)
            {
                Console.WriteLine("A opção escolhida foi subtração");

            }
            else if (opçao == 3)
            {
                Console.WriteLine("A opção escolhida foi divisão");
            }
            else if (opçao == 4)
            {
                Console.WriteLine("A opção escolhida foi Multiplicação");
            }

            else
            {
                Console.WriteLine("A opção escolhida não foi encontrada");
            }

                
            

            if (opçao == 1)
            {
                resultado = operacaoSoma.Somar(numero1, numero2);
            }

            else if (opçao == 2)
            {
                resultado = operacaoSubitracao.Subtracao(numero1, numero2);
            }

            else if (opçao == 3)
            {
                resultado = operacaoDivisao.Dividir(numero1, numero2);
            }
            else if (opçao == 4)
            {
                resultado = operacaoMultiplicacao.Multiplicaçao(numero1, numero2);
            }
            else
            {
                Console.WriteLine("Opção invalida");
                return;
            }

            Console.WriteLine("O resultado é " + resultado);
             

            Console.WriteLine("Finalizando o Programa");
            Console.ReadLine();

        }
    }
}
