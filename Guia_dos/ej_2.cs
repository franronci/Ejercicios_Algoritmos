using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class Program
{



    public static void Main(string[] args)

    {
        int[,] matriz_de_0 = new int[20, 5];

        int contador = 1;


        for (int linea = 0; linea < 20; linea++)
        {
            for (int lineb = 0; lineb < 5; lineb++)
            {
                matriz_de_0[linea, lineb] = contador;
                contador++;

            }
        }



        for (int linea = 0; linea < 20; linea++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(string.Format("{0} ", matriz_de_0[linea, j]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }


        Console.WriteLine("Aprete una tecla");
        Console.ReadKey();

    }
}

