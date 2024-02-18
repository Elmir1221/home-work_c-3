//11)temp qebul eden method yazirsiz. Return type olan method olmalidir. Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.

static string Temp(int temperatur)
{
    string message;
    if (temperatur == 20)
    {
        message = "mulaim";
    }
    else if (temperatur > 20)
    {
        message = "istidir";
    }
    else 
    {
        message = "soyuqdur";    
    }
    return message;
}
string result = Temp(0);
Console.WriteLine(result);
