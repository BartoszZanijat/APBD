using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Stats. Pending...");
    }
    static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int suma = 0;
        foreach (int liczba in values)
        {
            suma += liczba;
        }
        return (double)suma / values.Length;
    }
}