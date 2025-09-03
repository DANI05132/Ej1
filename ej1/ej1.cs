using System;

class Ej1
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"numeros[{i}] = {numeros[i]}");
        }
    }
}