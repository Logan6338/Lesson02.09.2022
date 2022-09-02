Console.WriteLine("Введите число А");
int inputNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень В");
int inputPow = Convert.ToInt32(Console.ReadLine());

int MathPow(int a, int Pow, int index = 1)
{
    int result = a;
    if (Pow == 0)
    {
        return 1;
    }

    else if (index < Pow)
    {
        result = result * MathPow(a, Pow, index + 1);
    }
    return result;
}

Console.WriteLine(MathPow(inputNum, inputPow));

/*

Второй вариант решения задачи

Console.Clear();
Console.WriteLine("Введите число А");
int inputNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень В");
int inputPow = Convert.ToInt32(Console.ReadLine());

int MathPow(int a, int Pow)
{
    int result = a;
    if (Pow > 0)
    {
        result = result * MathPow(a, Pow -1);
    }
    
    else
    {
        return 1;
    }
    return result;
}

Console.WriteLine(MathPow(inputNum, inputPow));
*/
