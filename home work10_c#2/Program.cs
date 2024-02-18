//  5)Verilmish arrayin icindeki tek ededlerin cemini tapin.

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

int SumOfArray(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 1)
		{
			sum += array[i];
		}

	}
	return sum;
}
int result = SumOfArray(array);

Console.WriteLine(result);

