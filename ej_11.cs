using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

public class Program
{
    public static void Main(string[] args)
    {

        float total_Factura = 0;
        float factura;
        int numeroFactura;
        float mayorMonto = 0;
        float menorMonto = 0;
        int numeroMayorMonto = 0;
        int numeroMenorMonto = 0;
        float promedio;
        int contador = 0;

        string respuesta;

        bool continuar = true;
        bool numeroValido;

        do
        {
            do
            {
                Console.WriteLine("Ingrese el numero de su factura");
                numeroValido = Int32.TryParse(Console.ReadLine(), out numeroFactura);
             

                if (!numeroValido)
                {
                    Console.WriteLine("Ingrese un numero valido");
                }



            } while (!numeroValido);

            do
            {
                Console.WriteLine("Ingrese el monto de la factura");
                numeroValido = float.TryParse(Console.ReadLine(), out factura);
            
                if (!numeroValido)
                {
                    Console.WriteLine("Ingrese un numero valido");
                }

                total_Factura = total_Factura + factura;
             

            } while (!numeroValido);

            if (factura > mayorMonto)
            {
                mayorMonto = factura;
                numeroMayorMonto = numeroFactura;
            }
            else if (factura < menorMonto || menorMonto==0)
            {
                menorMonto = factura;
                numeroMenorMonto = numeroFactura;
            }
            contador = contador + 1;

            Console.WriteLine("Desea continuar? S/N");
            respuesta = Console.ReadLine();

            if (respuesta == "N")
            {
                continuar = false;
            }

        } while (continuar);

        promedio = total_Factura / contador;

        Console.WriteLine($"El total de las facturas fue de {total_Factura}. \nEl promedio de las facturas fue de {promedio}." +
            $" \nLa factura com mayor monto fue la N° {numeroMayorMonto} con un valor por {mayorMonto}." +
            $"\nLa factura con menor monto fue la N° {menorMonto} con un valor por {menorMonto}");

        Console.WriteLine("Presion una tecla");
        Console.ReadKey();  

        


    }
}