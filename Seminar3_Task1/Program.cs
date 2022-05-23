Console.WriteLine("Введите координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double katet1 = (x2 - x1) * (x2 - x1);
double katet2 = (y2 - y1) * (y2 - y1);
double sum = katet1 + katet2;
double distance = Gipotenusa(sum);

double Gipotenusa(double sum)
{
    return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками равно {distance}");
