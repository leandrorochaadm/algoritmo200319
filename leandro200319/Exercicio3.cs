using System;
using System.Globalization;

namespace leandro200319
{
    class Exercicio3
    {
        public static void Exe (){
            Console.WriteLine("Considere  que  o  último  concurso  vestibular  apresentou  três  provas: \n" +
                " Português, Matemática  e Conhecimentos Gerais. \n" +
                "\n Considerando que para cada candidatotem-se um registro contendo o seu nome e as notas obtidas em cada uma dasprovas,\n" +
                " construa um algoritmo que leia o nome e as notas do candidato e forneça:\n" +
                "A - média do candidato\n" +
                "B - Uma informação dizendo se o candidato foi aprovado ou não. \n" +
                "Considere que um candidato é aprovado se sua média for maior que 7.0 e se não apresentou nenhuma nota abaixo de 5.0");
            Console.WriteLine();

            Console.Write("Digite o nome do candidato: ");
            String nome = Console.ReadLine();

            Console.Write("Digite a nota de Português: ");
            Double portugues = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota de Matemática: ");
            Double matematica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota de Conhecimentos Gerais: ");
            Double conhecimento_gerais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Double media = (portugues + matematica + conhecimento_gerais) / 3;

            if ((media>7.0) & (portugues>=5.0) & (matematica>=5.0) & (conhecimento_gerais>=5.0))
            {
                Console.WriteLine("O(A) canditado(a) {0} foi aprovado(a).", nome);
            }
            else
            {
                Console.WriteLine("O(A) canditado(a) {0} não foi aprovado(a).", nome);
            }
            Console.WriteLine();
        }
    }
}
