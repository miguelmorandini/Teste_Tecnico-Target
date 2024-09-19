using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace questao01
{
    /*1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
        IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitando e lendo a inserção de um número: 
            Console.WriteLine("--- QUESTÃO 01 - FIBONACCI ---\nInsira um número: ");
            int numero = int.Parse(Console.ReadLine());

            //Chamando a função para a verificação se o número digitado faz parte da sequência de Fibonacci:
            if (Fibonacci(numero))
            {
                Console.WriteLine($"\nO número {numero} pertence a sequência de Fibonacci!");
            }
            else
            {
                Console.WriteLine($"\nO número {numero} não pertence a sequência de Fibonacci.");
            }


            //Função para a verificação se o número digitado faz parte da sequência de Fibonacci:
            static bool Fibonacci(int numero)
            {
                int a = 0; //Primeiro elemento da sequência de Fibonacci
                int b = 1; //Segundo elemento da sequência de Fibonacci
                int c = 0; //Variável para armazenar o próximo elemento da sequência

                //Sequência de Fibonacci:
                while (c < numero)
                {
                    c = a + b; //Calculando p elemento seguinte
                    a = b; //O elemento 'a' se torna o segundo elemento
                    b = c; //E o elemento 'b' se torna o novo número calculado
                }

                return c == numero;
            }
        }

        
    }
}
