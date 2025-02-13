using System;

public class Triangle
{
    public static bool Exists(int a, int b, int c)
    {
        return a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
    }

    public static bool IsRightTriangle(int a, int b, int c)
    {
        if (!Exists(a, b, c))
        {
            throw new ArgumentException("Треугольник с такими сторонами не существует");
        }
        int[] sides = { a, b, c };
        Array.Sort(sides); // Гарантируем, что гипотенуза будет последним элементом
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    public static void Main()
    {
        Console.WriteLine("Задачи на if. Вариант 11");

        Console.Write("Введите сторону a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите сторону b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите сторону c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Вы ввели стороны треугольника {a}, {b}, {c}");

        if (Exists(a, b, c))
        {
            Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");

            if (IsRightTriangle(a, b, c))
            {
                Console.WriteLine("Треугольник является прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным");
            }
        }
        else
        {
            Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");
        }
    }
}
