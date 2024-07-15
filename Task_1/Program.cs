// Задайте значения M и N. Напишите программу, 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

        Console.WriteLine("input M:");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("input N:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"M={M}, N={N}");
        Console.WriteLine($"Natural numbers from {M} to {N}:");

       
            PrintNumbers(M, N);
        

    static void PrintNumbers(int start, int end)
    {
        Console.WriteLine(start);
        
        if (start == end)
            return;

        if (start < end)
        {
            PrintNumbers(start + 1, end);
        }
        else
        {
            PrintNumbers(start - 1, end);
        }
    }
