Console.WriteLine("Введите координату первой точки X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки Z");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки Y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки Z");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x1 - x2;
int B = y1 - y2;
int C = z1 - z2;


double length = Math.Sqrt(A * A + B * B + C * C);

Console.WriteLine(length);