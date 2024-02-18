// 6)Verilmish arrayin icindeki cut ededlerin sayini tapin.

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
int sum = 0;
int sum2 = 0;
int SumOfArray(int[] array, int[] array2)
{
	foreach (int elems in array)
	{
		sum += elems;
	}
	foreach ( int elems in array2)
	{
		sum2 += elems;
	}
	return (sum + sum2);
}
int result = SumOfArray(array, array2);
Console.WriteLine(result);
