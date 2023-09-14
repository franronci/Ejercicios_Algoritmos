using System;

public class Program1
{
	public static void Main(string[] args)
	{

            string texto1;
            string texto2;
            string textoInte;

            Console.WriteLine("Ingrese el primer string");
            texto1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo string");
            texto2 = Console.ReadLine();

            Console.WriteLine("variable1 " + texto1 + "- variable2 " + texto2 );

            textoInte = texto1;
            texto1 = texto2;
            texto2 = textoInte;

             Console.WriteLine("variable1 " + texto1 + "- variable2 " + texto2 );




	}
}


