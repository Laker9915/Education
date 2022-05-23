Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (ostatok(numberA, numberB) != 0)
{
    Console.Write("Остаток: ");
    Console.WriteLine(ostatok(numberA, numberB));
}

else
{
    Console.Write("Ответ: ");
    Console.WriteLine(numberA / numberB);
}
int ostatok(int numberA, int numberB)
{
    return numberA % numberB;
}