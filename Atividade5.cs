using System;

class Programa
{
    public static void Main(string[] args)
    {
		double kmRodados; 
        int diarias;
        string tipoCarro;

		Console.WriteLine("Seu veiculo é popular ou luxo? ");
		tipoCarro = (Console.ReadLine());
		Console.WriteLine("Digite qual foi a quantidade de quilometros percorridos: ");
		kmRodados = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o numero de dias que o veiculo foi ocupado: ");
		diarias = int.Parse(Console.ReadLine());

		if(tipoCarro == "Popular" || (tipoCarro == "popular") || (tipoCarro == "p") || (tipoCarro == "P")){
			if(kmRodados <= 100){
				Console.WriteLine("O valor do aluguel é: R$" + (diarias * 90.00 + kmRodados * 0.20));
			} else {
				Console.WriteLine("O valor do aluguel é: R$" + (diarias * 90.00 + kmRodados * 0.10));
			}
		}
		if(tipoCarro == "Luxo" || (tipoCarro == "luxo") || (tipoCarro == "l") || (tipoCarro == "L")){
			if(kmRodados <= 200){
				Console.WriteLine("O valor do aluguel é: R$" + (diarias * 150.00 + kmRodados * 0.30));
			} else {
				Console.WriteLine("O valor do aluguel é: R$" + (diarias * 150.00 + kmRodados * 0.25));
			}
			
		}
        
        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
	}
}