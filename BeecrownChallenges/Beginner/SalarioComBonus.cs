namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
        Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

        Entrada
            O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais,
            representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

        Saída
            Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
        EXEMPLO DE ENTRADA
            JOAO
            500.00
            1230.30
        EXEMPLO DE SAIDA
            TOTAL = R$ 684.54
    */
    public class SalarioComBonus
    {
        public string? nomeVendedor { get; set; }
        public double salarioVendedor { get; set; }
        public double valorVendas { get; set; }

        public void CalcSalario()
        {

            nomeVendedor = Console.ReadLine();
            salarioVendedor = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            valorVendas = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            var calculaComissao = salarioVendedor + (0.15 * valorVendas);

            Console.WriteLine($"TOTAL = R$ {calculaComissao.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}
