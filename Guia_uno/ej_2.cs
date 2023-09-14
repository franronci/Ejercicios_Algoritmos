namespace ejercicio2
{
    public class nombreDirec
    {
        public static void Main(String[] args)
        {
            string nombre = "";
            string direccion = "";


            while (nombre == "") 
            {
                Console.WriteLine("Por favor, ingrese su nombre.");
                nombre = Console.ReadLine();

            }

            while (direccion == "")
            {
                Console.WriteLine("Por favor, ingrese su direccion.");
                direccion = Console.ReadLine();

            }

            Console.WriteLine($"Su nombre es: {nombre} y su direccion es {direccion}");
            Console.WriteLine("Presion una tecla para salir");
            Console.ReadKey(); 
        }
    }
}
