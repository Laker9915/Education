Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)
{
    int square = index*index;
    Console.Write($"{square} ");
    index++;
}
