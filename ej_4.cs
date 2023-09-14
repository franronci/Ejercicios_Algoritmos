using System;

public class Program4
{
	public static void Main(string[] args)
	{

		int hora;
		int minutos;
		int segundos;
		int segundosTotales;

		bool horaValida;
		bool minutosValidos;
		bool segundosValidos;


		do
		{
			Console.WriteLine("Ingrese la hora");
			horaValida = Int32.TryParse(Console.ReadLine(), out hora);

			if (!horaValida || hora<0 || hora>23)
			{
				Console.WriteLine("Ingrese una hora valida");
			}
			
		} while (!horaValida || hora<0 || hora>23);

		do
		{
			Console.WriteLine("Ingrese los minutos");
			minutosValidos = Int32.TryParse(Console.ReadLine(), out minutos);

			if (!minutosValidos || minutos<0 || minutos>59)
			{
				Console.WriteLine("Ingrese un minuto valido");
			}
			
		} while (!minutosValidos || minutos<0 || minutos>59);

		do
		{
			Console.WriteLine("Ingrese los segundos");
			segundosValidos = Int32.TryParse(Console.ReadLine(), out segundos);

			if (!segundosValidos || segundos<0 || segundos>59)
			{
				Console.WriteLine("Ingrese una hora segundos");
			}
			
		} while (!segundosValidos || segundos<0 || segundos>59);

		
		segundosTotales = (hora*60) + (minutos*60) + segundos;
		Console.WriteLine("Los segundos totales son " + segundosTotales);

		Console.WriteLine("Aprete cualquier tecla");
		

	}
}


