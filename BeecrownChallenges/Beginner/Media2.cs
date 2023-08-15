using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
        A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2,
        a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

        Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
        Saída
            Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo,
            com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade.
            Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
        EXEMPLO DE ENTRADA
            5.0
            6.0
            7.0
        EXEMPLO DE SAIDA
            MEDIA = 6.3
    */
    public class Media2
    {
        public double NotaA { get; set; }
        public double NotaB { get; set; }
        public double NotaC { get; set; }

        public double PesoA { get; set; }
        public double PesoB { get; set; }
        public double PesoC { get; set; }

        public double Media { get; set; }

        public Media2()
        {
        }

        public void CalcMedia()
        {
            NotaA = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            NotaB = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            NotaC = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            // Define os pesos das notas
            PesoA = 2;
            PesoB = 3;
            PesoC = 5;

            // Calcula a média ponderada
            Media = (NotaA * PesoA + NotaB * PesoB + NotaC * PesoC) / (PesoA + PesoB + PesoC);

            // Imprime o resultado com 1 dígito após o ponto decimal
            Console.WriteLine("MEDIA = " + Media.ToString("F1"));
        }
    }
}
