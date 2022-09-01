using System;

class Programa
{
    public static void Main(string[] args)
    {
        string nome;
        double salario, reajuste, novoSalario, tempoEmpresa;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite seu salario atual: ");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tempo de empresa: ");
        tempoEmpresa = double.Parse(Console.ReadLine());

        if (tempoEmpresa < 3){
            reajuste = (salario * 0.03);
            novoSalario = (salario + reajuste);
            Console.WriteLine("Salario atual: R$" + salario + ".");
            Console.WriteLine("Reajuste: R$" + reajuste + ".");
            Console.WriteLine("Novo salario: R$" + novoSalario + ".");
        } else if (tempoEmpresa > 10){
            reajuste = (salario * 0.20);
            novoSalario = (salario + reajuste);
            Console.WriteLine("Salario atual: R$" + salario + ".");
            Console.WriteLine("Reajuste: R$" + reajuste + ".");
            Console.WriteLine("Novo salario: R$" + novoSalario + ".");
        } else {
            reajuste = (salario * 0.125);
            novoSalario = (salario + reajuste);
            Console.WriteLine("Salario atual: R$" + salario + ".");
            Console.WriteLine("Reajuste: R$" + reajuste + ".");
            Console.WriteLine("Novo salario: R$" + novoSalario + ".");
        }

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}