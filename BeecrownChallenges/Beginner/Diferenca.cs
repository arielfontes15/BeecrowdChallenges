using System.Globalization;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Leia quatro valores inteiros A, B, C e D. A seguir,
        calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        Entrada
            O arquivo de entrada contém 4 valores inteiros.
        Saída
            Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
        EXEMPLO DE ENTRADA
            5
            6
            7
            8
        EXEMPLO DE SAIDA
            DIFERENCA = -26
    */
    public class Diferenca
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public void CalcDiferenca()
        {

            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int diferenca = A * B - C * D;
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
