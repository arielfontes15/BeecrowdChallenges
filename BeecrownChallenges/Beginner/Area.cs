using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
        Entrada
            O arquivo de entrada contém três valores com um dígito após o ponto decimal.
        Saída
            O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima,
            sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
        EXEMPLO DE ENTRADA
            3.0 4.0 5.2
        EXEMPLO DE SAIDA
            TRIANGULO: 7.800
            CIRCULO: 84.949
            TRAPEZIO: 18.200
            QUADRADO: 16.000
            RETANGULO: 12.000
    */
    public class Area
    {
        public string linha { get; set; }
        public string[] valores { get; set; }

        public void CalcArea()
        {
            double A, B, C;
            linha = Console.ReadLine();
            valores = linha.Split(' ');

            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);

            //Multiplica BASE * ALTURA / 2
            var trianguloRetangulo = (A * C) / 2;
            var circulo = 3.14159 * Math.Pow(C, 2);
            var trapezio = ((A + B) * C) / 2;
            var quadrado = Math.Pow(B, 2);
            var retangulo = A * B;
            Console.WriteLine($"TRIANGULO: {trianguloRetangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
        }
    }
}
