using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class Program
{



    public static void Main(string[] args)

    {

        string respuesta;
        string cliente;
        string domicilio;
        string telefono;
        int contador = 0;

        string[,] matriz_de_clientes = new string[50, 3];

        bool seguir = true;

        do
        {

            Console.WriteLine("Elija la opcion. \n1. Alta de cliente \n2. Consulta \n3. Salir  ");
            respuesta = Console.ReadLine();

            if (respuesta == "3")
            {
                seguir = false;
            }

            else if (respuesta == "1")
            {

                Console.WriteLine("Ingrese el nombre");
                cliente = Console.ReadLine();

                matriz_de_clientes[contador, 0] = cliente;

                Console.WriteLine("Ingrese el domicilio");
                domicilio = Console.ReadLine();
                matriz_de_clientes[contador, 1] = domicilio;

                Console.WriteLine("Ingrese el telefono");
                telefono = Console.ReadLine();
                matriz_de_clientes[contador, 2] = telefono;

                contador++;

            }

            else if (respuesta == "2")
            {

                Console.WriteLine("Ingrese el cliente buscado");
                cliente = Console.ReadLine();

                for ( int i = 0; i < contador+1; i++)
                {

                    if (matriz_de_clientes[i,0] == cliente)
                    {
                        Console.WriteLine($"El cliente {cliente}, vive en {matriz_de_clientes[i, 1]} y su telefono es {matriz_de_clientes[i, 2]}");
                        
                    }
                }
                Console.WriteLine("No se encontro el nombre buscado");
            }
            

        } while (seguir);



        for (int j = 0; j < contador; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(string.Format("{0} ", matriz_de_clientes[j, i]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }














        Console.ReadKey();



        
    }
}

