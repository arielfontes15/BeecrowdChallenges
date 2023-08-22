using Microsoft.VisualBasic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”.
        Utilize a fórmula:
            Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b).
            Um segundo passo, portanto é necessário para chegar no resultado esperado.
        Entrada
            O arquivo de entrada contém três valores inteiros.
        Saída
            Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
        EXEMPLO DE ENTRADA
            7 14 106
        EXEMPLO DE SAIDA
            106 eh o maior
    */
    public class OMaior
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public string linha { get; set; }
        public string[] valores { get; set; }

        public void CalcMaior()
        {
            linha = Console.ReadLine();
            valores = linha.Split();

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            var maiorAB = (A + B + Math.Abs(A - B)) / 2;

            var maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;
            Console.WriteLine($"{maior} eh o maior");
        }
    }
}
