using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdChallenges.Beginner
{
    /*DESCRICAO
        Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas,
        o valor que recebe por hora e calcula o salário desse funcionário. A seguir,
        mostre o número e o salário do funcionário, com duas casas decimais.

        Entrada
            O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número,
            quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

        Saída
            Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade.
            No caso do salário, também deve haver um espaço em branco após o $.
        EXEMPLO DE ENTRADA
            25
            100
            5.50
        EXEMPLO DE SAIDA
            NUMBER = 25
            SALARY = U$ 550.00
    */
    public class Salario
    {
        public int nFuncionario { get; set; }
        public int horaFuncionario { get; set; }
        public double valorHoraFuncionario { get; set; }

        public void CalcSalario()
        {
            nFuncionario = int.Parse(Console.ReadLine());
            horaFuncionario = int.Parse(Console.ReadLine());
            valorHoraFuncionario = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            var calculaHora = valorHoraFuncionario * horaFuncionario;

            Console.WriteLine($"NUMBER = {nFuncionario}");
            Console.WriteLine($"SALARY = U$ {calculaHora.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}
