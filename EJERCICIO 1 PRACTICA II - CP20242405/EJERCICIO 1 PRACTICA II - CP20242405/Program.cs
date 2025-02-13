class ejercicio1
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

                Console.WriteLine($"El primer digito es: {decena}");
                Console.WriteLine($"El segundo digito es: {unidad}");
                break;
            }
            else
            {
                Console.WriteLine("Intente de nuevo, por favor ingrese un numero de dos digitos (de 10 a 99).");
            }
        }
    }
}