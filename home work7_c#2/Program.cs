//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

int SumOfArray(int n, int m)
{
	int sum = 0;
	if (n % 2 == 0 && m % 2 == 0)
	{
		sum = n + m;
	}
	return sum;
}
int result = SumOfArray(8, 12);
Console.WriteLine(result);