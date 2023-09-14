using System;
using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {

        int notaAlta;
        int notaBaja;
        int registroAlto;
        int registroBajo;
        int notaInter;
        int registroInter;
        string respuesta;

        bool notaValida;
        bool registroValido;
        bool continuar = true;


        do
        {
            Console.WriteLine("Ingrese su registro");
            registroValido = Int32.TryParse(Console.ReadLine(), out registroAlto);
            registroBajo = registroAlto;

            if (!registroValido)
            {
                Console.WriteLine("Ingrese un registro valido");
            }

        } while (!registroValido);

        do
        {
            Console.WriteLine("Ingrese su nota");
            notaValida = Int32.TryParse(Console.ReadLine(), out notaAlta);
            notaBaja = notaAlta;

            if (!notaValida || notaAlta>10 || notaAlta<0)
            {
                Console.WriteLine("Ingrese una nota valida");    
            }

            else if (notaAlta >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (notaAlta >= 4 && notaAlta < 7)
            {
                Console.WriteLine("Regularizado");
            }
            else
            {
                Console.WriteLine("Desaprobasate");
            }

        } while (!notaValida || notaAlta > 10 || notaAlta < 0);

        do
        {

            Console.WriteLine("Desea continuar? S/N");
            respuesta = Console.ReadLine();

            if (respuesta == "N")
            {
                continuar = false;
            }
            else if (respuesta == "S")
            {
                do
                {
                    Console.WriteLine("Ingrese su registro");
                    registroValido = Int32.TryParse(Console.ReadLine(), out registroInter);

                    if (!registroValido)
                    {
                        Console.WriteLine("Ingrese un registro valido");
                    }

                } while (!registroValido);

                do
                {
                    Console.WriteLine("Ingrese su nota");
                    notaValida = Int32.TryParse(Console.ReadLine(), out notaInter);

                    if (!notaValida || notaInter > 10 || notaInter < 0)
                    {
                        Console.WriteLine("Ingrese una nota valida");
                    }

                    else if (notaInter >= 7)
                    {
                        Console.WriteLine("Promocionado");
                    }
                    else if (notaInter >= 4 && notaInter < 7)
                    {
                        Console.WriteLine("Regularizado");
                    }
                    else
                    {
                        Console.WriteLine("Desaprobasate");
                    }

                } while (!notaValida || notaInter > 10 || notaInter < 0);

                if (notaInter > notaAlta)
                {
                    registroAlto = registroInter;
                    notaAlta = notaInter;   
                }
                else if (notaInter < notaBaja)
                {
                    registroBajo = registroInter;   
                    notaBaja = notaInter;   
                }

            }

            else
            {
                Console.WriteLine("Ponga una opcion valida");
            }


        } while (continuar);


        Console.WriteLine($"La nota mas alta fue {notaAlta} correspondiente al registro {registroAlto}");
        Console.WriteLine($"La nota mas baja fue {notaBaja} correspondiente al registro {registroBajo}");

        Console.WriteLine("Aprete una tecla");
        Console.ReadKey();



    }
}
