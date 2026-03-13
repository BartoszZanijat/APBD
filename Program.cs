using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Stats. Pending...");

        int[] dane = { 10, 20, 30, 40, 50 };
        double srednia = CalculateAverage(dane);
        Console.WriteLine($"Średnia z podanych liczb: {srednia}");
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