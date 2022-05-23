int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int DeleteSecond(int number)
{
    int first = number / 100;
    int second = number % 10;
    int result = first * 10 + second;
    return result;
}

int result = DeleteSecond(number);
Console.WriteLine(result);
