
class ejercicio4
{
    static void Main()
    {
        int numero;

        while (true)
        {
            Console.WriteLine("Ingrese un numero de cuatro digitos: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 1000 && numero <= 9999)
            {
                int mil = numero / 1000;
                int centena = (numero / 100)% 10;
                int decena = (numero / 10) % 10;
                int unidad = numero % 10;

                Console.WriteLine($"El primer digito es: {mil}");
                Console.WriteLine($"El segundo digito es: {centena}");
                Console.WriteLine($"El tercer digito es: {decena}");
                Console.WriteLine($"El cuarto digito es: {unidad}");
                break;
            }
            else
            {
                Console.WriteLine("Intente de nuevo, por favor ingrese un numero de cuatro digitos (de 1000 a 9999).");
            }
        }
    }
}