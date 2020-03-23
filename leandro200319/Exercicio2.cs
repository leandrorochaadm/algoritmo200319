using System;
using System.Globalization;

namespace leandro200319
{
    class Exercicio2
    {
        public static void Exe()
        {
            Console.WriteLine("Elabore um algoritmo que indique se um número digitado \n" +
                "está compreendido entre 20 e 90, ou não.");

            Console.Write("Digite um numero: ");
            Double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((a>=20)&(a<=90))
            {
                Console.WriteLine("Este número digitado está compreendido entre 20 e 90");
            }
            else {
                Console.WriteLine("Esse um número digitado NÃO está compreendido entre 20 e 90");
            }
            Console.WriteLine();
        }
    }
}
