using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class Program
{



    public static void Main(string[] args)

    {

        int cantidad_alumnos;
        Console.WriteLine("Cuantos alumnos hay en la comision?");
        Int32.TryParse(Console.ReadLine(), out cantidad_alumnos);
        string[] matrizAlumnos = new string[cantidad_alumnos];
        int[] notas_alumnos = new int[cantidad_alumnos];
        string respuesta;
        int contador = 0;
        int nota;
        string nombre;
        string lista_final = "Los alumnos aprobados son:\n";

        bool numeroValido ;

        

        do
        {
            Console.WriteLine("Que desea hacer? \n1.Cargar alumnos \n2. Salir");
            respuesta = Console.ReadLine();

            if (respuesta == "1")    
            {

                if (contador == cantidad_alumnos)
                {
                    Console.WriteLine("No se pueden cargar mas alumnos");
                    respuesta = "2";
                }

                else
                {

                    do
                    {
                        Console.WriteLine("Ingrese el nombre");
                        nombre = Console.ReadLine();

                        if (nombre == "")
                        {
                            Console.WriteLine("Ingrese un valor");
                        }

                    } while (nombre == "");

                    matrizAlumnos[contador] = nombre;

                    do
                    {
                        Console.WriteLine("Ingrese su nota");
                        numeroValido = Int32.TryParse(Console.ReadLine(), out nota);
                        if (!numeroValido || nota>10 || nota<0)
                        {
                            Console.WriteLine("Ingresa una nota valida");
                        }

                    } while (!numeroValido || nota > 10 || nota < 0);

                    notas_alumnos[contador] = nota;
                    contador++;

                }
                
            }

            else if (respuesta == "2")
            {
                Console.WriteLine("La carga a finalizado");    
            }

            else
            {
                Console.WriteLine("Ingrese una opcion valida");
            }

        } while (respuesta != "2");


        for (int i = 0; i<contador; i++)
        {
            if (notas_alumnos[i] >= 4)
            {
                lista_final = lista_final + matrizAlumnos[i];
            }
            lista_final = lista_final + "\n";

        }

        Console.WriteLine(lista_final);




      Console.ReadKey();



        
    }
}

