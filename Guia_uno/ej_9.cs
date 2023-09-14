using System;
using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {
        string nombre;
        int jornalXHora;
        int cantidadHoras;
        float bruto;
        float neto;
        float totalJub;
        float totalOtros;

        bool numero_valido;

        const float jubilacion = 0.1f;
        const float otros = 0.07f;

        Console.WriteLine("Ingrese el nombre");
        nombre = Console.ReadLine();

        do
        {
            Console.WriteLine("Ingrese el jornal por hora");
            numero_valido = Int32.TryParse(Console.ReadLine(), out jornalXHora);

            if (!numero_valido)
            {
                Console.WriteLine("Ingrese un numero valido");
            }

        } while (!numero_valido);

        do
        {
            Console.WriteLine("Ingrese las horas trabajadas");
            numero_valido = Int32.TryParse(Console.ReadLine(), out cantidadHoras);
            
            if (!numero_valido)
            {
                Console.WriteLine("Ingrese un numero valido");
            }

        }while (!numero_valido);


        bruto = jornalXHora * cantidadHoras;

        totalJub = bruto * jubilacion;

        totalOtros = bruto * otros;

        neto = bruto - totalJub - totalOtros;

        Console.WriteLine($"Sueldo bruto: {bruto} \nRetencion jubilaciones: {totalJub} \nTotal otros: {totalOtros} \nSueldo neto: {neto}");

        Console.WriteLine("Ingrese cualquier tecla");
        Console.ReadKey();  









    }
}
