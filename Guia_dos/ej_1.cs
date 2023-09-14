using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz_de_0 = new int[5, 5];


        for (int linea = 0; linea < 5; linea++)
        {
            for (int lineb = 0; lineb < 5; lineb++)
            {

                if ((linea == 0 && lineb == 0) || (linea == 0 && lineb == 4) || (linea == 1 && lineb == 1)
                    || (linea == 1 && lineb == 3) || (linea == 2 && lineb == 2) ||
                    (linea == 3 && lineb == 1) || (linea == 3 & lineb == 3) || (linea == 4 && lineb == 0) || (linea == 4 && lineb == 4))
                {

                    matriz_de_0[linea, lineb] = 1;

                }

                else
                {
                    matriz_de_0[linea, lineb] = 0;
                }

                       
                                
            }
        }



        for (int linea = 0; linea < 5; linea++)
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

