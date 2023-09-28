using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Security.Cryptography;

public class Program
{



    public static void Main(string[] args)

    {

        const int cantidadPrestadores = 100;
        const int cantidadPrestaciones = 100;
        const int cantidadPrestacionesPorPrestador = 10000;
        const int cantidadPrestacionesRealizadas = 1000;


        //Arreglos de prestadores
        string[] codigoPrestador = new string[cantidadPrestadores];
        string[] nombrePrestador = new string[cantidadPrestadores];
        //Arreglos de prestaciones
        string[] codigoPrestacion = new string[cantidadPrestaciones];
        string[] nombrePrestacion = new string[cantidadPrestaciones];
        //Arreglos de prestaciones por proveedor
        string[] prestacionesPorPrestadorPrestador = new string[cantidadPrestacionesPorPrestador];
        string[] prestacionesPorPrestadorPrestacion = new string[cantidadPrestacionesPorPrestador];
        //Arreglos de prestaciones realizadas
        int[] numeroPrestacionRealizada = new int[cantidadPrestacionesRealizadas];
        DateTime[] fechaPrestacionRealizada = new DateTime[cantidadPrestacionesRealizadas];
        string[] prestadorPrestacionRealizada = new string[cantidadPrestacionesRealizadas];
        string[] prestacionPrestacionRealizada = new string[cantidadPrestacionesRealizadas];
        string[] DNIPrestacionRealizada = new string[cantidadPrestacionesRealizadas];
        double[] importePrestacionRealizada = new double[cantidadPrestacionesRealizadas];

        //Variables del flujo principal
        string opcion = "";
        CargaInicial(codigoPrestador, nombrePrestador, codigoPrestacion, nombrePrestacion, numeroPrestacion
        Realizada, fechaPrestacionRealizada, prestadorPrestacionRealizada, prestacionPrestacionRealizada, D
        NIPrestacionRealizada, importePrestacionRealizada, prestacionesPorPrestadorPrestador, prestaciones
        PorPrestadorPrestacion);

        do
        {
            opcion = pedirStringNoVacio("Ingrese la opcion deseada: \n1. Nueva
           prestacion\n2.Listar prestaciones realizadas\n3.Listar prestadores" +
           
            "\n99. Salir");
            if (opcion == "1")
            {
                IngresarPrestacion(codigoPrestador, nombrePrestador, codigoPrestacion, nombrePrestacion, numeroPres
                tacionRealizada, fechaPrestacionRealizada, prestadorPrestacionRealizada, prestacionPrestacionReali
                zada, DNIPrestacionRealizada, importePrestacionRealizada, prestacionesPorPrestadorPrestador, presta
                cionesPorPrestadorPrestacion);
            }
            else if (opcion == "2")
            {
                ListarPrestacionesRealizadas(codigoPrestador, nombrePrestador, codigoPrestacion, nombrePrestacion,
                numeroPrestacionRealizada, fechaPrestacionRealizada, prestadorPrestacionRealizada, prestacionPrest
                acionRealizada, DNIPrestacionRealizada, importePrestacionRealizada);
            }
            else if (opcion == "3")
            { ListarPrestadores(codigoPrestador, nombrePrestador); }
        } while (opcion != "99");



        static int pedirInteger(string mensaje, int minimo)
        { 
        
        
        }

        static string pedirStringNoVacio(string mensaje)
        { 
        }


        static void ListarPrestadores(string[] codigoPrestador, string[] nombrePrestador)
        {
            armarListadoCodigoNombre(codigoPrestador, nombrePrestador);
        }


        static string armarListadoCodigoNombre(string[] codigo, string[] nombre)
        { 
        }

        int buscarEnArreglo(int[] arreglo, int aBuscar)
        {
            int retorno = -1;
            for (int fila = 0; fila <= arreglo.GetUpperBound(0) && retorno == -1; fila++)
            {
                if (arreglo[fila] == aBuscar)
                {
                    retorno = fila;
                }
            }
            return (retorno);
        }
        int buscarEnArreglosString(string[] arreglo, string aBuscar)
        {
            int retorno = -1;
            for (int fila = 0; fila <= arreglo.GetUpperBound(0) && retorno == -1; fila++)
            {
                if (arreglo[fila] == aBuscar)
                {
                    retorno = fila;
                }
            }
            return (retorno);
        }



        void IngresarPrestacion(codigoPrestador, nombrePrestador, codigoPrestacion, nombrePrestacion, numeroPres
                tacionRealizada, fechaPrestacionRealizada, prestadorPrestacionRealizada, prestacionPrestacionReali
                zada, DNIPrestacionRealizada, importePrestacionRealizada, prestacionesPorPrestadorPrestador, presta
                cionesPorPrestadorPrestacion)
        {

            int respuestaLugar;
            int respuestaOtro; 
            int busqueda;
            string busquedaPrestador;
            string busquedaPrestacion;
            string PediryGuardar;
            respuestaLugar = buscarEnArreglo(numeroPrestacionRealizada, 0);

            if (respuestaLugar == -1)
            {
                Console.WriteLine("No hay lugar para mas prestaciones");
            }

            else
            {
                Console.WriteLine("Ingrese el numero de prestacion solicitada");
                busqueda = pedirInteger(Console.ReadLine(), 0);
                respuestaOtro = buscarEnArreglo(numeroPrestacionRealizada, busqueda);

                if (respuestaOtro != -1)
                {
                    Console.WriteLine("El numero de prestacion ya existe");
                }

                else
                {

                    do 
                    {
                        ListarPrestadores(codigoPrestador, nombrePrestador);

                        Console.WriteLine("Ingrese un codigo de prestador");
                        busquedaPrestador = pedirStringNoVacio(Console.ReadLine());
                        respuestaOtro = buscarEnArreglosString(codigoPrestador, busquedaPrestador);

                        if (respuestaOtro == -1)
                        {
                            Console.WriteLine("El prestador no existe");
                        }

                        else
                        {
                            do
                            {
                                Console.WriteLine(armarListadoCodigoNombre(codigoPrestacion, nombrePrestacion));
                                Console.WriteLine("Ingrese un codigo de prestacion");
                                busquedaPrestacion = pedirStringNoVacio(Console.ReadLine());
                                respuestaOtro = buscarEnArreglosString(codigoPrestacion, busquedaPrestacion);

                                if (respuestaOtro == -1)
                                {
                                    Console.WriteLine("La prestacion no existe");

                                }

                                else if ()
                                {
                                    Console.WriteLine("El prestador no tiene esa prestacion");


                                }

                                else
                                {

                                    fechaPrestacionRealizada[respuestaLugar] = DateTime.Now;
                                    Console.WriteLine("Ingrese su DNI");
                                    DNIPrestacionRealizada[respuestaLugar] = pedirStringNoVacio(Console.ReadLine());

                                    Console.WriteLine("Ingrese un importe");
                                    importePrestacionRealizada[respuestaLugar] = pedirInteger(Console.ReadLine(), 0);
                                                                                                           
                                }
                            } while (respuestaOtro == -1);

                        }

                    } while (respuestaOtro == -1);
                    



                }

            }





        }





        Console.ReadKey();  

    }


}



