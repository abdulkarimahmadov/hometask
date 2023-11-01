using System;

class Program
{
    static void ResizeArray(ref int[] array, int newSize)
    {
        int[] newArray = new int[newSize];

        for (int i = 0; i < newSize; i++)
        {
            if (i < array.Length)
            {
                newArray[i] = array[i];
            }
            else
            {
                break;
            }
        }

        array = newArray;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int newSize = 12;
        ResizeArray(ref array, newSize);

        Console.WriteLine("Resized array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
