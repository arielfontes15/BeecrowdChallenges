using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
    Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
    Entrada
        O arquivo de entrada contém um valor inteiro N.
    Saída
        Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
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
    public class ConversaoDeTempo
    {
        public int Valor { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public void CalcTempo()
        {
            Valor = int.Parse(Console.ReadLine());

            Horas = Valor / 3600;
            Minutos = Valor % 3600 / 60;
            Segundos = Valor % 60;

            Console.WriteLine($"{Horas}:{Minutos}:{Segundos}");
        }
    }
}
