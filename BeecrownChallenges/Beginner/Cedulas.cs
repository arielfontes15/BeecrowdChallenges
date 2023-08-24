using System;
using System.Collections.Generic;
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
    public class Cedulas
    {
        public int Valor { get; set; }
        public int[] Notas { get; set; }
        public int Quantidade { get; set; }

        public void CalcCedulas()
        {
            Valor = int.Parse(Console.ReadLine());
            int[] Notas = { 100, 50, 20, 10, 5, 2, 1};

            Console.WriteLine(Valor);

            foreach(var nota in Notas)
            {
                Quantidade = Valor / nota;
                Console.WriteLine($"{Quantidade} nota(s) de R$ {nota},00");
                Valor %= nota;
            }
        }
    }
}
