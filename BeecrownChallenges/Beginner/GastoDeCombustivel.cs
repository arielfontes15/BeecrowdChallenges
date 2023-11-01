namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L.
        Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo,
        deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e,
        em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.
        Entrada
            O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a velocidade média durante a mesma (em km/h).
        Saída
           Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal
        EXEMPLO DE ENTRADA
            10
            85
        EXEMPLO DE SAIDA
            70.833
    */
    public class GastoDeCombustivel
    {
        public int TempoGasto { get; set; }
        public int Velocidade { get; set; }
        public double Distancia { get; set; }
        public double ConsumoMedio { get; set; }
        public double ConsumoEmLitros { get; set; }

        public void CalcConsumo()
        {
            TempoGasto = int.Parse(Console.ReadLine());
            Velocidade = int.Parse(Console.ReadLine());
            ConsumoMedio = 12;
            Distancia = Velocidade * TempoGasto;
            ConsumoEmLitros = Distancia / ConsumoMedio;
            Console.WriteLine(ConsumoEmLitros.ToString("F3")) ;
        }
    }
}
