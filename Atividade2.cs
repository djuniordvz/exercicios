using System;

class Programa
{
    public static void Main(string[] args)
    {
        double reta1, reta2, reta3;

        Console.WriteLine("Digite a reta 1: ");
        reta1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a reta 2: ");
        reta2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a reta 3: ");
        reta3 = double.Parse(Console.ReadLine());

        if (((reta1 + reta2) > reta3) && ((reta1 + reta3) > reta2) && ((reta2 + reta3) > reta1)){
			Console.WriteLine("É possivel formar um triangulo. ");
		} else {
			Console.WriteLine("Não é possivel formar um triangulo. ");
		}
		if (reta1 == reta2 && reta1 == reta3){
			Console.WriteLine("É um triangulo equilatero.");
		} else {
			if((reta1 == reta2) || (reta1 == reta3) || (reta2 == reta3)){
				Console.WriteLine("É um triangulo Isósceles.");
			} else {
				Console.WriteLine("É um triangulo Escaleno.");
			}
		}

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}