class ejercicio2
{
    static void Main()
    {
        int numero;

        while (true)
        {
            Console.WriteLine("Ingrese un numero de dos digitos: ");
            numero = int.Parse(Console.ReadLine());
            
            if (numero >= 10 && numero <= 99)
            {
                int decena = numero / 10;
                int unidad = numero % 10;

                int suma = decena + unidad;
                Console.WriteLine($"La suma de ambos digitos es: {suma}");
                break;
            }
            else
            {
                Console.WriteLine("Intente de nuevo, por favor ingrese un numero de dos digitos (de 10 a 99).");
            }
        }
    }
}