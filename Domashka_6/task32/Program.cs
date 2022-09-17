//Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

// ( НЕОБЯЗАТЕЛЬНАЯ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!)

Console.Write("Введите строну а: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите строну b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите строну c: ");
        double c = double.Parse(Console.ReadLine());
        if ((a + b > c) && (b + c > a) && (a + c > b))
        {
            double p = (a + b + c) / 2;
            Console.WriteLine("Это треугольник");
            Console.WriteLine("Площадь треугольника: " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        else
        {
            Console.WriteLine("Это не треугольник");
        }
        Console.ReadKey();

