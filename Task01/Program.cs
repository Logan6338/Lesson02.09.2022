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

/*
System.Console.WriteLine("Введие число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();

void PrintNumbers(int num,int index=1){
    System.Console.Write($" {index}");
    if(index<num){
        PrintNumbers(num,index +1);
    }
}
PrintNumbers(number);
*/
