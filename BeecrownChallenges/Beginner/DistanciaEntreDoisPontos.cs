using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles,
        mostrando 4 casas decimais após a vírgula, segundo a fórmula:
        Distancia = Math.Sqrt(((NumeroX2 - NumeroX1) * 2) + ((NumeroY2 - NumeroY1) * 2))
        Entrada
            O arquivo de entrada contém duas linhas de dados.
            A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.
        Saída
            Calcule e imprima o valor da distância segundo a fórmula fornecida,
            com 4 casas após o ponto decimal.
        EXEMPLO DE ENTRADA
            1.0 7.0
            5.0 9.0
        EXEMPLO DE SAIDA
            4.4721
    */
    public class DistanciaEntreDoisPontos
    {
        public double NumeroX1 { get; set; }
        public double NumeroX2 { get; set; }
        public double NumeroY1 { get; set; }
        public double NumeroY2 { get; set; }
        public string LinhaX { get; set; }
        public string LinhaY { get; set; }
        public string[] ValoresX { get; set; }
        public string[] ValoresY { get; set; }

        public void CalcDistancia()
        {
            LinhaX = Console.ReadLine();
            LinhaY = Console.ReadLine();

            ValoresX = LinhaX.Split(' ');
            ValoresY = LinhaY.Split(' ');

            NumeroX1 = double.Parse(ValoresX[0]);
            NumeroY1 = double.Parse(ValoresX[1]);
            NumeroX2 = double.Parse(ValoresY[0]);
            NumeroY2 = double.Parse(ValoresY[1]);
            var distancia = Math.Sqrt(Math.Pow(NumeroX2 - NumeroX1, 2) + Math.Pow(NumeroY2 - NumeroY1, 2));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
