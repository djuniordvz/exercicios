using System;

class Programa
{
    public static void Main(string[] args)
    {
        double valorImovel, renda, prazo, parcelaMensal, limiteCredito;

        Console.WriteLine("Digite o valor do Imovel: ");
        valorImovel = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Salario: ");
        renda = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o prazo de pagamento em meses: ");
        prazo = double.Parse(Console.ReadLine());

        parcelaMensal = valorImovel / prazo;
        limiteCredito = renda * 0.30;

        if (parcelaMensal > limiteCredito){
            Console.WriteLine("Valor da Parcela: " + parcelaMensal);
            Console.WriteLine("Infelizmente o credito não foi aprovado");
        } else {
            Console.WriteLine("Valor da Parcela: " + parcelaMensal);
            Console.WriteLine("Crédito Aprovado!");
        }

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}