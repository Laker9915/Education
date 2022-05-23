double x1 = Coordinate("x", "A");
double x2 = Coordinate("y", "A");
double y1 = Coordinate("x", "B");
double y2 = Coordinate("y", "B");

double katet1 = (x2 - x1) * (x2 - x1);
double katet2 = (y2 - y1) * (y2 - y1);
double sum = katet1 + katet2;
double distance = Gipotenusa(sum);

double Gipotenusa(double sum)
{
    return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками равно {distance}");

double Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToDouble(Console.ReadLine());
}
