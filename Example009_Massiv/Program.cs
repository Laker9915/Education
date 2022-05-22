Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;
int c = -a;

while (c < a)
{
    Console.WriteLine(c + ", ");
    c++;
}

Console.WriteLine(c);

