using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges
{
    /*DESCRICAO
     * Leia 2 valores de ponto flutuante de dupla precisão A e B,
     * que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno,
     * sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
     * Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
     * Entrada
        O arquivo de entrada contém 2 valores com uma casa decimal cada um.
     * Saída
        Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo,
        com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade.
        Utilize variáveis de dupla precisão (double) e como todos os problemas,
        não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

        EXEMPLO DE ENTRADA
            5.0
            7.1
        EXEMPLO DE SAIDA
            MEDIA = 6.43182
     */
    public class Media1
    {
        public double NotaA { get; set; }
        public double NotaB { get; set; }
        public double PesoA { get; set; }
        public double PesoB { get; set; }
        public double Media { get; set; }

        public Media1()
        {
        }

        public void CalcMedia()
        {
            NotaA = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            NotaB = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            // Define os pesos das notas
            PesoA = 3.5;
            PesoB = 7.5;

            // Calcula a média ponderada
            Media = (NotaA * PesoA + NotaB * PesoB) / (PesoA + PesoB);

            // Imprime o resultado com 5 dígitos após o ponto decimal
            Console.WriteLine("MEDIA = " + Media.ToString("F5"));
        }
    }
}
