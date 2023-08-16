using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
        o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
        Entrada
            O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores,
            respectivamente dois inteiros e um valor com 2 casas decimais.

        Saída
            A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo,
            lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
        EXEMPLO DE ENTRADA
            12 1 5.30
            16 2 5.10
        EXEMPLO DE SAIDA
            VALOR A PAGAR: R$ 15.50
    */
    public class CalculoSimples
    {
        public string linha1 { get; set; }
        public string linha2 { get; set; }
        public string[] valores1 { get; set; }
        public string[] valores2 { get; set; }
        public int codigo1 { get; set; }
        public int codigo2 { get; set; }
        public int numeroPeca1 { get; set; }
        public int numeroPeca2 { get; set; }
        public double valorUnitario1 { get; set; }
        public double valorUnitario2 { get; set; }

        public void CalcSimples()
        {
            linha1 = Console.ReadLine();
            linha2 = Console.ReadLine();

            valores1 = linha1.Split(' ');
            valores2 = linha2.Split(' ');

            codigo1 = int.Parse(valores1[0]);
            numeroPeca1 = int.Parse(valores1[1]);
            valorUnitario1 = double.Parse(valores1[2]);

            codigo2 = int.Parse(valores2[0]);
            numeroPeca2 = int.Parse(valores2[1]);
            valorUnitario2 = double.Parse(valores2[2]);

            var calcValores = (numeroPeca1 * valorUnitario1) + (numeroPeca2 * valorUnitario2);

            Console.WriteLine($"VALOR A PAGAR: R$ {calcValores.ToString("F2")}");
        }
    }
}
