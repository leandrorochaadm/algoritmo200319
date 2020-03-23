using System;
using System.Globalization;

namespace leandro200319
{
    class Exercicio1
    {
        public static void Exe()
        {
            Console.WriteLine("Faça um algoritmo para ler três valores reais e informar \n" +
                "se estes podem ou não formar os lados de um triângulo e qual tipo de triângulo \n" +
                "seria: equilátero, isósceles ou escaleno.");
            Console.WriteLine();

            Console.Write("Digite o tamanho do 1º lado: ");
            Double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o tamanho do 2º lado: ");
            Double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o tamanho do 3º lado: ");
            Double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a <= 0 | b <= 0 | c <= 0)
            {
                Console.WriteLine("Para formar um triângulo  precisa ter os lados maiores do que zero.");
            }
            else if (((a == b)&(a!=c)) | ((a == c)&(a!=b)) | ((b == c)&(b!=a)) )
            {
                Console.WriteLine("Esse é um triângulo Isósceles");
            }
            else if ((a == b) & (a == c) & (b == c))
            {
                Console.WriteLine("Esse é um triângulo Equilátero");
            }
            else
            {
                Console.WriteLine("Esse é um triângulo Escaleno");
            }
            

            /*
            Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(b.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
            */
            Console.WriteLine();
        }
    }
}
