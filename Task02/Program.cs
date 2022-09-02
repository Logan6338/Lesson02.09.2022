Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int M = Convert.ToInt32(Console.ReadLine());

string s = string.Empty;

string FillStringInNumDiapazone (string c, int Num, int FromNum)
{
    c = $"{Convert.ToString(FromNum)} ";
    if (Num == FromNum)
    {
        return c;
    }

    else
    {
       c = FillStringInNumDiapazone(c, Num - 1, FromNum) + $"{Convert.ToString(Num)} ";
    }
    return c;
}

string result = FillStringInNumDiapazone(s, N, M);

Console.WriteLine(result);
