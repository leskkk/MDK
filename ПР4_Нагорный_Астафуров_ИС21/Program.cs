using System;

class Program
{
    static void Main()
    {
        // Ввод начальных данных
        Console.Write("Введите начало отрезка a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конец отрезка b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        // Вывод заголовка таблицы
        Console.WriteLine(" x        | F(x)");
        Console.WriteLine("--------------------");

        // Вычисление и вывод значений функции
        try
        {
            ComputeFunctionValues(a, b, h);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void ComputeFunctionValues(double a, double b, double h)
    {
        for (double x = a; x <= b; x += h)
        {
            double fx = F(x);
            Console.WriteLine($"{x:F6} | {fx:F6}");
        }
    }

    static double F(double x)
    {
        double sinX = Math.Sin(x);
        double denominator = Math.Pow(sinX, 2) + 1;

        // Проверка на деление на ноль
        if (denominator == 0)
        {
            throw new DivideByZeroException("Деление на ноль в функции F(x).");
        }

        return Math.Pow(x, 2) / denominator;
    }
}