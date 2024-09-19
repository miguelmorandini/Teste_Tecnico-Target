namespace questao02
{
    /*2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.
        IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;*/

    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitando e lendo a inserção de uma string: 
            Console.WriteLine("--- QUESTÃO 02 - STRING ---\nInforme uma frase ou palavra: ");
            string entrada = Console.ReadLine();

            //Chamando a função que verifica a presença da letra 'A':
            LetraA(entrada);
        }

        //Função que verifica a presença da letra 'A':
        static void LetraA(string entrada)
        {
            int contador = 0; //Variável que armazena a quantidade de letras 'a'

            //Convertendo a string de entrada em letras maiúsculas:
            string entradaMaisculas = entrada.ToLower();

            //Percorrendo a entrada para verificar se a letra 'a' está presnte
            foreach (char c in entradaMaisculas) 
            {
                if (c == 'a')
                {
                    contador++; //Cada vez que uma letra 'a' é localizada, acrecenta-se 1 no contador
                }
            }

            if (contador > 0)
            {
                Console.WriteLine($"\nA letra 'a' está presente {contador} vez(es) nesta frase.");
            }
            else
            {
                Console.WriteLine("\nA letra 'a' não está presente nesta frase.");
            }
        }
    }
}
