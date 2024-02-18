//15)methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.
using System.Security.Cryptography;

int n = 10;
int sum = 0;

int Value(int n)
{ 
 for (int i = 0; i < n; i++)
 {
  if (i % 2 == 0) 
  {
     sum += i;
  }	
 }
    return sum;
}
int result = Value(n);
Console.WriteLine(result);