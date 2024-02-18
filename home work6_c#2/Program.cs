//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
int n = 42;

string Value(int n)
{
	string message;
	if (n % 21 == 0)
	{
		message = "bolunur";

    }
	else
	{
		message = "bolunmur";

    }
	return message;
}
string result = Value(n);
Console.WriteLine(result);
