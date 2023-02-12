Console.WriteLine("Введите координаты первой точки A");
Console.Write("Введите x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки В");
Console.Write("Введите x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int xc2, int yc2, int zc1, int zc2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(xc1 - xc2, 2) + Math.Pow(yc1 - yc2, 2) + Math.Pow(zc1 - zc2, 2)), 2);
    return distance;
}
Console.WriteLine($"Растояние между точками {Distance(x1, y1, x2, y2, z1, z2)}");