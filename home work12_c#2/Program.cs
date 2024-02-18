//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

string Number(int n)
{
    if (n < 2)
    {
        return "ne sade ne murekkebdir";
    }

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return "murekkebdir";
        }
    }

    return "sadedir";
}

string result = Number(5);
Console.WriteLine(result);
