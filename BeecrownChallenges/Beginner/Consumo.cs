using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).
        Entrada
            O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto,
            com um dígito após o ponto decimal.
        Saída
            Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula,
            seguido da mensagem "km/l".
        EXEMPLO DE ENTRADA
            500
            35.0
        EXEMPLO DE SAIDA
            14.286 km/l
    */
    public class Consumo
    {
        public int NumeroX { get; set; }
        public double NumeroY { get; set; }

        public void CalcConsumo()
        {
            NumeroX = int.Parse(Console.ReadLine());
            NumeroY = double.Parse(Console.ReadLine());

            var consumo = NumeroX / NumeroY;

            Console.WriteLine($"{consumo.ToString("F3")} km/l");
        }
    }
}
