// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] arr={1,2,3,4,5};

PrintArrReversed(arr, arr.Length-1);

static void PrintArrReversed(int[] arr, int index)
{
    if(index<0)
    {
       return;  
    }
   

    Console.WriteLine(arr[index]);
    PrintArrReversed(arr, index-1);
}
