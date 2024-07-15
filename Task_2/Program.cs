// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// A(m,n)=n+1, если 𝑚=0
// A(m,n)=A(m−1,1), если 𝑚>0  и n=0
// A(m,n)=A(m−1,A(m,n−1)), если 𝑚>0 и 𝑛>0 

Console.WriteLine("input m=");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input n=");
int n = Convert.ToInt32(Console.ReadLine());

long result = (long)Akerman(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");

static long Akerman(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m> 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }

    else if (m> 0 && n> 0)
    {
        return Akerman(m-1, Akerman(m, n-1));
    }
    else
        {
            // В случае, если все условия не выполнены
            throw new ArgumentException("Invalid input for Ackerman function.");
        }

}



