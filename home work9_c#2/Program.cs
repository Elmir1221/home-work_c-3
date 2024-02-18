//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin

using System.Diagnostics.CodeAnalysis;

int Number(int n, int m)
{
	int sum = 0;

	for (int i = n; i < m; i++)
	{
		if (i % 2 == 1)
 		{
			sum += i;	
		}
	}
	return sum;
}
int result = Number(13, 18) ;
Console.WriteLine(result);