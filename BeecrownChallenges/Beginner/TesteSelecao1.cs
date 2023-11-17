using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeecrownChallenges.Beginner
{
    public class TesteSelecao1
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public string Valor { get; set; }
        public string[] Valores { get; set; }
        public void CalcTesteSelecao()
        {
            Valor = Console.ReadLine();
            Valores = Valor.Split();
            A = int.Parse(Valores[0]);
            B = int.Parse(Valores[1]);
            C = int.Parse(Valores[2]);
            D = int.Parse(Valores[3]);

            var maiorABCD = B > C
                && D > A
                && (C + D) > (A + B)
                && (C > 0 && D > 0)
                && A % 2 == 0;

            if (maiorABCD)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}