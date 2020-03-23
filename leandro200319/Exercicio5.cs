using System;
using System.Globalization;

namespace leandro200319
{
    class Exercicio5
    {
        public static void Exe()
        {
            Console.WriteLine("Suponha que o conceito de um aluno seja determinado em função da sua nota. \n" +
                "Suponha, também, que esta nota seja um valor inteiro na faixa de 0 a 100.");

            Console.Write("Digite a nota: ");
            byte nota = byte.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((nota>=0)&(nota<=100))
            {
                Console.Write("A nota é ");
                if (nota<=49)
                {
                    Console.Write("insufiente\n");
                }
                else if (nota <= 64)
                {
                    Console.Write("regular\n");
                }
                else if (nota <= 84)
                {
                    Console.Write("boa\n");
                }
                else
                {
                    Console.Write("ótima\n");
                }
            }
            else {
                Console.WriteLine("Esse um número digitado NÃO está compreendido entre 0 e 100");
            }
            Console.WriteLine();
        }
    }
}
