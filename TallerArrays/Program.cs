using System;
using System.Numerics;
{
    static void Main()
    {
        int tamañoVector, encontrarNumero, ubicacion = 51;

        Console.WriteLine("¿Cuál es el tamaño del vector?");
        tamañoVector = int.Parse(Console.ReadLine());

        int[] array = new int[tamañoVector];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1,50);
        }

        Console.WriteLine("¿Cuál es el número a buscar en el vector?");
        encontrarNumero = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == encontrarNumero)
            {
                ubicacion = i; break;
            }
        }

        if (ubicacion == 51)
        {
            Console.WriteLine($"El número {encontrarNumero} no existe en el vector");
        }
        else
        {
            Console.WriteLine($"El {encontrarNumero} se encuentra actualmente en el vector y esta en la posición {ubicacion}");
        }
    }
}