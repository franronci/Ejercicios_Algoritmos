namespace ejercicio3
{
    public class nombreDirec
    {
        public static void Main(String[] args)
        {
            float numero1;
            float numero2;
            bool numero1_es_num;
            bool numero2_es_num;
            float sumaUD;
            const int divisor = 2;

            do
            {
                Console.WriteLine("Ingrese el primer numero");
                numero1_es_num =  float.TryParse(Console.ReadLine(), out numero1);

                if (numero1_es_num == false)
                {
                    Console.WriteLine("Ingrese un valor numerico");
                }
                else if (numero1 < 0 || numero1 > 10)
                {
                    Console.WriteLine("El numero debe ser menor a 10 y mayor que 0");    
                }
              

            } while (numero1 < 0 || numero1 > 10 || numero1_es_num == false);


            do
            {
                Console.WriteLine("Ingrese el segundo numero");
                numero2_es_num = float.TryParse(Console.ReadLine(), out numero2);

                if (numero2_es_num == false)
                {
                    Console.WriteLine("Ingrese un valor numerico");
                }
                else if (numero2 < 0 || numero2 > 10)
                {
                    Console.WriteLine("El numero debe ser menor a 10 y mayor que 0");
                }

            } while (numero2 < 0 || numero2 > 10 || numero2_es_num == false);


            sumaUD = (numero2 + numero1) / divisor;
            Console.WriteLine($"El promedio es {sumaUD}");
            Console.WriteLine("Presion cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
