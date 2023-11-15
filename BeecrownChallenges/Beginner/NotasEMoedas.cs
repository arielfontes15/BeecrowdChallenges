using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
        As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
        Entrada
            O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
        Saída
            Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.
            Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
        EXEMPLO DE ENTRADA
            576
        EXEMPLO DE SAIDA         	
            576
            5 nota(s) de R$ 100,00
            1 nota(s) de R$ 50,00
            1 nota(s) de R$ 20,00
            0 nota(s) de R$ 10,00
            1 nota(s) de R$ 5,00
            0 nota(s) de R$ 2,00
            1 nota(s) de R$ 1,00
    */
    public class NotasEMoedas
    {
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public int[] Notas { get; set; } = { 100, 50, 20, 10, 5, 2 };
        public double[] Moedas { get; set; } = { 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

        public void CalcNotasEMoedas()
        {
            Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Convertendo para centavos
            int centavos = (int)(Valor * 100);

            Console.WriteLine("NOTAS:");
            foreach (var nota in Notas)
            {
                var Quantidade = centavos / (nota * 100);
                Console.WriteLine($"{Quantidade} nota(s) de R$ {nota}.00");
                centavos %= nota * 100;
            }

            Console.WriteLine("MOEDAS:");
            foreach (var moeda in Moedas)
            {
                var Quantidade = centavos / (int)(moeda * 100);
                Console.WriteLine($"{Quantidade} moeda(s) de R$ {moeda.ToString("#0.00", CultureInfo.InvariantCulture)}");
                centavos %= (int)(moeda * 100);
            }
        }
    }
}
