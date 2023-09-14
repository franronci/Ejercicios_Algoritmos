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

        int contador = 100;


        for (int linea = 0; linea < 5; linea++)
        {

            if (linea % 2 == 0) 
            {
                for (int lineab = 0; lineab < 20; lineab++)
                {
                    matriz_de_0[lineab, linea] = contador;
                    contador--;

                }
            }

            else
            {
                for (int lineab = 19; lineab > -1 ; lineab--)
                {
                    matriz_de_0[lineab, linea] = contador;
                    contador--;

                }
            }
          
        }

        for (int j = 0; j < 20; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(string.Format("{0} ", matriz_de_0[j, i]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }



        Console.WriteLine("Aprete una tecla");
        Console.ReadKey();

    }
}

