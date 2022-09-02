Console.WriteLine("Введите число N");
string inputString = Console.ReadLine();
char[] arr = inputString.ToCharArray();

int NumLenght = arr.Length;

int FillSumNum(char[] array, int IntIndex)
{
    int Sum = 0;

    if (IntIndex == 0)
    {
        Sum = (array[IntIndex] - '0');
        
        return Sum;
    }
    else
    {

        Sum = (arr[IntIndex]-'0') + FillSumNum(arr, IntIndex - 1);
        
    }
    return Sum;
}

int result = FillSumNum(arr, NumLenght - 1);
Console.WriteLine(result);
