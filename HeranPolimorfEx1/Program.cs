// See https://aka.ms/new-console-template for more information

using HeranPolimorfEx1.Entities;
using System.Globalization;

Console.Write("Entre com o número de funcionários: ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> funcionarios = new List<Funcionario>();

for (int i = 1; i <= n; i++)
{
    Console.Write($"Dados do funcionário #{i}:");

    Console.Write("Terceirizado (y/n)? ");
    char t = char.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Horas: ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (t == 'y')
    {
        Console.Write("Despesa adicional: ");
        double despesaAdicional = double.Parse(Console.ReadLine());

        funcionarios.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, despesaAdicional));
    }
    else
    {
        funcionarios.Add(new Funcionario(nome, horas, valorPorHora));
    }
}

Console.WriteLine();
Console.WriteLine("PAGAMENTOS: ");

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine(funcionario);
}