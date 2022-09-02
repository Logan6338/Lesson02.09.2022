Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

string s = string.Empty;

string FillStringInNumDiapazone (string c, int Num)
{
    c = "1 ";
    if (Num == 1)
    {
        return c;
    }

    else
    {
       c = FillStringInNumDiapazone(c, Num - 1) + $"{Convert.ToString(Num)} ";
    }
    return c;
}

string result = FillStringInNumDiapazone(s, N);

Console.WriteLine(result);
