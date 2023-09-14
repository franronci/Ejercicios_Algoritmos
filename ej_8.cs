using System;
using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {
        bool continuar = true;
        int suma = 0;
        bool montoValido;
        int valor;
        string respuesta;

        do
        {
            do
            {
                Console.WriteLine("Ingrese el monto de la factura");
                montoValido = Int32.TryParse(Console.ReadLine(), out valor);

                if (!montoValido)
                {
                    Console.WriteLine("Ingrese un monto valido");
                }
                suma = suma + valor;
            } while (!montoValido);

            Console.WriteLine("Desea continuar? S/N ");
            respuesta = Console.ReadLine();

            if (respuesta == "N")
            {
                continuar = false;
            }

        } while (continuar);

        Console.WriteLine($"El importe total de las facturas fue de ${suma}");

        Console.WriteLine("Aprete una tecla");
        Console.ReadKey();


    }
}