using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class Program
{



    public static void Main(string[] args)

    {

        string[] vectorAlfabet = new string[5];
        string palabra;
       

        for (int i = 0; i < 5; i++)
        {

            do
            {
                Console.WriteLine("Ingrese la palabra");
                palabra = Console.ReadLine(); 

                if (palabra == "")
                {
                    Console.WriteLine("Ingrese una palabra");
                }

            } while (palabra == "");

            vectorAlfabet[i] = palabra;
        }

        Array.Sort(vectorAlfabet);

        foreach (string j in vectorAlfabet)
        {
            Console.WriteLine(j);
        }




        Console.ReadKey();  

    }


}



