class ejercicio5
{
    static void Main()
    {
        int edad1, edad2, edad3;

        Console.WriteLine("Ingrese la edad del primer niño: ");
        edad1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la edad del segundo niño: ");
        edad2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la edad del tercer niño: ");
        edad3 = int.Parse(Console.ReadLine());

        int suma = edad1 + edad2 + edad3;

        double promedio = suma / 3.0;

        int maxEdad;
        if (edad1 >= edad2 && edad1 >= edad3)
        {
            maxEdad = edad1;
        }
        else if (edad2 >= edad1 && edad2 >= edad3)
        {
            maxEdad = edad2;
        }
        else
        {
            maxEdad = edad3;
        }

        int minEdad;
        if (edad1 <= edad2 && edad1 <= edad3)
        {
            minEdad = edad1;
        }
        else if (edad2 <= edad1 && edad2 <= edad3)
        {
            minEdad = edad2;
        }
        else
        {
            minEdad = edad3;
        }

        Console.WriteLine($"La suma de las edades es: {suma}");
        Console.WriteLine($"La edad promedio es: {promedio}");
        Console.WriteLine($"La edad máxima es: {maxEdad}");
        Console.WriteLine($"La edad mínima es: {minEdad}");
    }
}