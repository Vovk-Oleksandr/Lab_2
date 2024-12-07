using System;

namespace Task_2
{
    class Point
    {
        // Поля для координат і назви точки
        public double X { get; }
        public double Y { get; }
        public string Name { get; }

        // Конструктор для ініціалізації полів точки
        public Point(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }

    class Figure
    {
        private Point[] points; // масив точок
        public string Name { get; }

        // Конструктор для створення багатокутника (приймає 3-5 точок)
        public Figure(string name, params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
                throw new ArgumentException("Багатокутник повинен мати від 3 до 5 точок.");

            this.points = points;
            Name = name;
        }

        // Метод для обчислення довжини сторони між двома точками
        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Метод для обчислення периметра багатокутника
        public void CalculatePerimeter()
        {
            double perimeter = 0;

            // Перебір точок для обчислення сумарної довжини сторін
            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length]; 
                perimeter += GetSideLength(current, next);
            }

            Console.WriteLine($"Периметр багатокутника {Name}: {perimeter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення точок (можна змінити, щоб додати ще точки для багатокутника)
            Point A = new Point(2, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");

            // Створення багатокутника на основі точок
            Figure triangle = new Figure("Трикутник", A, B, C);

            triangle.CalculatePerimeter();
        }
    }
}
