namespace ejercicioUno
{
    public class nombreDirec
    {
        public static void Main(String[] args)
        {
            string nombre;
            string direccion;

            Console.WriteLine("Por favor, ingrese su nombre.");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese su direccion.");
            direccion = Console.ReadLine();

            Console.WriteLine($"Su nombre es: {nombre} y su direccion es {direccion}");
            Console.WriteLine("Presion una tecla para salir");
            Console.ReadKey(); 
        }
    }
}