using System;

namespace mkr
{
    interface IShape
    {
        string sizeFigure { get; }
        string Type();
        string Area();
    }

    class Square : IShape
    {
        protected double r { get; set; }
        public Square(double r)
        {
            this.r = r;
        }
        public string sizeFigure
        {
            get
            {
                return $"Довжина сторони: {r}";
            }
        }
        public string Area()
        {
            double s = r * r;
            return $"Площа = {s.ToString("F")}";
        }
        public string Type()
        {
            return "Тип: квадрат";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square[] rectangle = { new Square(8.25), new Square(3), new Square(12) };
            foreach (Square str in rectangle)
            {
                Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Area()}\n");
            }
        }
    }
}