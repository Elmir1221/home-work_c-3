//13)method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.

int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 9 };
int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 9 };
int sum = 0;
int sum2 = 0;

int SumOfArray(int[] array1,int[] array2)
{

    foreach(int elems in array1)
    {
        sum += elems;
    }
    foreach (var elems in array2)
    {
        sum2 += elems;
    }
    return (sum + sum2);
}
int result = SumOfArray(array1,array2);
Console.WriteLine(result);
