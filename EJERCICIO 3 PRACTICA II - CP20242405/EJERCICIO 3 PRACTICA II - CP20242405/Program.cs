class ejercicio3
{
    static void Main()
    {
        int numero;

        while (true)
        {
            Console.WriteLine("Ingrese un numero de tres digitos: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 100 && numero <= 999)
            {
                
                int centenas = numero / 100;
                int decena = (numero / 10) % 10;
                int unidad = numero % 10;

                int suma = centenas + decena + unidad;
                Console.WriteLine($"La suma de los digitos es: {suma}");
                break;
            }
            else
            {
                Console.WriteLine("Intente de nuevo, por favor ingrese un numero de tres digitos (de 100 a 999).");
            }
        }
    }
}