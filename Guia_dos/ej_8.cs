using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class Program
{



    public static void Main(string[] args)

    {

        int codigoCliente = 0;
        int razonSocial = 0;
        int ventaPreiodo = 0; 
        int contador = 0;
        int valorTotal = 0;

        string respuesta;

        bool numeroValido;

        int[] matrizClientes = new int[50];
        int[] matrizRazon = new int[50];
        int[] matrizVenta = new int[50];

        int[,] totales = new int[50,50];

        string listaAMostrar = "";

        do
        {
            Console.WriteLine("Que desea hacer? \n1. Ingresar cliente\n2. Salir ");
            respuesta  = Console.ReadLine();

            if (respuesta == "2")
            {
                Console.WriteLine("Ingreso de ventas finalizado");
            }

            else if (respuesta == "1")
            {

                PediryValidarInt("el codigo", codigoCliente, matrizClientes);

                PediryValidarInt("la razon social", razonSocial, matrizRazon);

                PediryValidarInt("el importe de venta", ventaPreiodo, matrizVenta);

                contador++;
            }

            else
            {
                Console.WriteLine("Ingrese una opcion valida");

            }
        } while (respuesta != "2");


        for (int i = 0; i < contador + 1; i++)
        {
        
            for (int j = 0; j < contador + 1; j++)
            {
                if (matrizClientes[i] == matrizClientes[j])
                {
                    valorTotal = valorTotal + matrizVenta[j];
                }
            }
            totales[i, 0] = matrizClientes[0];
            totales[i, 1] = valorTotal;                
         }




        for (int yiyo =0; yiyo < totales.GetUpperBound(0); yiyo++)
        {
            listaAMostrar = listaAMostrar + totales[yiyo,0] + " " + totales[yiyo,1] + "\n";
        }


        Console.WriteLine(listaAMostrar);




        int PediryValidarInt(string nombreDelDato, int datoDevuelto, int[] matrizApuntada)
        {
            do
            {
                Console.WriteLine($"Ingrese {nombreDelDato} del cliente");
                numeroValido = Int32.TryParse(Console.ReadLine(), out datoDevuelto);

                if (!numeroValido)
                {
                    Console.WriteLine("Ingrese un valor permitido");
                }

            } while (!numeroValido);
            matrizApuntada[contador] = datoDevuelto;
            return (datoDevuelto);
        }

        Console.ReadKey();
    }   


}



