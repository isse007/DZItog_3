// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void PrintBackArray (int[] arr, int i)
{
    if (i<0)
    {
        return;
    }
    System.Console.WriteLine(arr[i]);
    PrintBackArray(arr, i-1);
}
int[] array = {5,7,9};
PrintBackArray (array,array.Length-1);

