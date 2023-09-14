using System;

public class Program2
{
	public static void Main(string[] args)
	{

		int lado1;
		int lado2;
		int lado3;

		bool ladoValido;

		do 
		{	
			Console.WriteLine("Ingrese el primer lado");
			ladoValido = Int32.TryParse(Console.ReadLine(), out lado1);

			if (!ladoValido) {
				Console.WriteLine("Ingrese un numero");
			}

		} while(!ladoValido);

		
		do 
		{	
			Console.WriteLine("Ingrese el segundo lado");
			ladoValido = Int32.TryParse(Console.ReadLine(), out lado2);

			if (!ladoValido) {
				Console.WriteLine("Ingrese un numero");
			}

		} while(!ladoValido);

		
		do 
		{	
			Console.WriteLine("Ingrese el tercer lado");
			ladoValido = Int32.TryParse(Console.ReadLine(), out lado3);

			if (!ladoValido) {
				Console.WriteLine("Ingrese un numero");
			}

		} while(!ladoValido);


		if (lado1 == lado2 && lado1==lado3 && lado2==lado3)
		{
			Console.WriteLine("El triangulo es equilatero");
		}

		else if (lado1==lado2 || lado2 == lado3 || lado1==lado3)
		{
			Console.WriteLine("El triangulo es isósceles");
		}

		else 
		{
			Console.WriteLine("El triangulo es escaleno");
		}
		

	}
}


