// Дополнительные задачи.
//Задача 1. Рассчитать значение y при заданном x по формуле
//y = sin^2 x, при x > 0
//y = 1 - 2 sin x^2, при x >= 0

Console.Write("Введите градус: ");
int angle = Convert.ToInt32(Console.ReadLine());
double x = (angle * (Math.PI)) / 180;

Sine(x);

void Sine(double x)
{
    if (x > 0)
    {
        double y = Math.Pow(Math.Sin(x),2);
        Console.WriteLine(y);
    }
    else
    {
        double y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
        Console.WriteLine(y);
    }
}