// Дополнительные задачи.
//Задачи повышенной сложности:
//Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

int q = 1;

Dots(q);

void Dots(int q)
{
    int x1 = new Random().Next(1,10);
    int y1 = new Random().Next(1,10);
    Console.WriteLine($"a ({x1}, {y1})");
    int x2 = new Random().Next(1,10);
    int y2 = new Random().Next(1,10);
    Console.WriteLine($"b ({x2}, {y2})");
    int x3 = new Random().Next(1,10);
    int y3 = new Random().Next(1,10);
    Console.WriteLine($"c ({x3}, {y3})");
    double a = Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2));
    double b = Math.Sqrt(Math.Pow(x2,2) + Math.Pow(y2,2));
    double c = Math.Sqrt(Math.Pow(x3,2) + Math.Pow(y3,2));
    if (a < b)
    {
        Console.WriteLine("a");
    }
    else if (c < a)
    {
        Console.WriteLine("c");
    }
    else
    {
        Console.WriteLine("b");
    }
}