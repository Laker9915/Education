Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int check = a * a;
if (check == b)
{
    Console.WriteLine("Верно!");
}
else
{
    Console.WriteLine("Увы, неверно:(");
}