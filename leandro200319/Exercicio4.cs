using System;
using System.Globalization;

namespace leandro200319
{
    class Exercicio4
    {
        public static void Exe()
        {
            Console.WriteLine("Uma empresa de vendas tem três corretores. A empresa paga ao corretor uma comissão calculada de  acordo  com  o  valor\n" +
                "  de  suas  vendas. Se  o  valor  da  venda  de  um  corretor  for  maior  que  R$ 50.000.00 a comissão será de 12% do valor vendido. \n" +
                "Se o valor da venda docorretor estiver entre R$ 30.000.00 e R$ 50.000.00 a comissão será de 9.5%. \n" +
                "Em qualquer outro caso, a comissão será de 7%. \n" +
                "Escreva um algoritmo que gere um relatório contendo nome, valor da venda e comissão de cada um dos corretores. \n" +
                "O relatório deve mostrar também o total de vendas da empresa.");

            Console.Write("Digite o nome do 1º corretor:");
            String corretor1 = Console.ReadLine();
            Console.Write("Digite o valor da venda dele: ");
            Double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
           
            Console.Write("Digite o nome do 2º corretor:");
            String corretor2 = Console.ReadLine();
            Console.Write("Digite o valor da venda dele: ");
            Double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);          
            
            Console.Write("Digite o nome do 3º corretor:");
            String corretor3 = Console.ReadLine();
            Console.Write("Digite o valor da venda dele: ");
            Double v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double c1 = CalculaComissao(v1);
            double c2 = CalculaComissao(v2);
            double c3 = CalculaComissao(v3);
            Console.WriteLine(">>> Relatório <<<");
            Console.WriteLine("O(A) corretor(a) {0}, vendeu R$ {1}, e terá uma comissão de R$ {2}", corretor1, v1.ToString("F2"), c1.ToString("F2"));
            Console.WriteLine("O(A) corretor(a) {0}, vendeu R$ {1}, e terá uma comissão de R$ {2}", corretor2, v2.ToString("F2"), c2.ToString("F2"));
            Console.WriteLine("O(A) corretor(a) {0}, vendeu R$ {1}, e terá uma comissão de R$ {2}", corretor3, v3.ToString("F2"), c3.ToString("F2"));
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Valor total de vendas foi R$ {0} e o total de comissões foi R$ {1}.", (v1+v2+v3).ToString("F2"), (c1+c2+c3).ToString("F2"));

            /* 
            Console.WriteLine(v1);
            Console.WriteLine(c1.ToString("F2"));
            */
            Console.WriteLine();
        }

        private static double CalculaComissao(double venda)
        {
            if (venda>50000.0)
            {
                return venda*0.12;
            }
            else if (venda>=30000)
            {
                return venda * 0.095;
            }
            return venda*0.07;
            
        }

    }
}
