using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
        A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
        Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++),
        assumem que o resultado da divisão entre dois inteiros é outro inteiro.

        Entrada
            O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

        Saída
            A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade.
            O valor deverá ser apresentado com 3 casas após o ponto.
        EXEMPLO DE ENTRADA
            3
        EXEMPLO DE SAIDA
            VOLUME = 113.097    
    */
    public class Esfera
    {
        public double pi { get; set; }
        public int raio { get; set; }

        public void CalcEsfera()
        {
            pi = 3.14159;
            raio = int.Parse(Console.ReadLine());

            var calcVolume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {calcVolume.ToString("F3")}");
        }
    }
}
