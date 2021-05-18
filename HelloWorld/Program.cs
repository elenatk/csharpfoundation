﻿using System;

class Sorter
{
    public static void BubbleSort(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            for (int inner = index; inner < array.Length; inner++)
            {
                if (array[index] < array[inner])
                {
                    Swap(ref array[index], ref array[inner]);
                }
            }
        }
    }

    private static void Swap(ref int first, ref int second)
    {
        var temp = first;
        first = second;
        second = temp;
    }
}

class Program
{
    static void Main()
    {
        var values = new int[] { 1,2,4, 8, 10 };

        Console.Write("Not sorted:");
        foreach (var item in values)
        {
            Console.Write("{0},", item);
        }
        Console.WriteLine();

        Sorter.BubbleSort(values);

        Console.Write("Sorted:");
        foreach (var item in values)
        {
            Console.Write("{0},", item);
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}