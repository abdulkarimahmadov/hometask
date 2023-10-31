using System;

class Program
{
    static double KvadratiHesabla(double number)
    {
        double square = number * number;
        return square;
    }

    static void Main()
    {
        double number = 10.0;
        double result = KvadratiHesabla(number);

        Console.WriteLine($"Kvadrat {number} is {result}");
    }
}
