using System;

namespace Task_1
{
    class Rectangle
    {
        // Поля для опису довжин сторін прямокутника
        private double side1, side2;

        // Конструктор класу Rectangle
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод для обчислення площі прямокутника
        public double CalculateArea()
        {
            return side1 * side2;
        }

        // Метод для обчислення периметра прямокутника
        public double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        // Властивість для отримання площі
        public double Area
        {
            get { return CalculateArea(); }
        }

        // Властивість для отримання периметра
        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть першу сторону прямокутника: ");
            double side1 = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Введіть другу сторону прямокутника: ");
            double side2 = Convert.ToDouble(Console.ReadLine()); 

            // Створення об'єкта класу Rectangle
            Rectangle rectangle = new Rectangle(side1, side2);

            // Вивід результатів
            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        }
    }
}
