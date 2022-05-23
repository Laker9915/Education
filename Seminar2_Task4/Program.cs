Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    string array = Convert.ToString(number);
    Console.WriteLine(array[2]);
}
else
    Console.WriteLine("Третьей цифры нет!");