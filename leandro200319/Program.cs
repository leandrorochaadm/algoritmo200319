using System;

namespace leandro200319
{
    class Program
    {
        static void Main(string[] args)
        {
           // Exercicio1 exercicio1 = new Exercicio1();

            Console.WriteLine("Aluno: Leandro Rocha - IFRO - ADS - Algoritmo 1º periodo");
            Console.WriteLine();

            byte exercicio = byte.MaxValue;
            while (exercicio != 0)
            {
                Console.WriteLine("Digite o número do exercício de 1 a 5 que deseja executar \nou digite número 0 para sair e depois presione tecla Enter");
                exercicio = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                
                switch (exercicio)
                {
                    case 1:
                        Exercicio1.Exe();
                        break;
                    case 2:
                        Console.WriteLine("escolheu o exercício 2");
                        break;
                    case 3:
                        Console.WriteLine("escolheu o exercício 3");
                        break;
                    default: Console.WriteLine(">>> Número do exercício digitado inválido <<< \n");
                        break;
                }
            }
        }
    }
}
