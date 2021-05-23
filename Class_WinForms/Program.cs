using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Сircle(7.0);
            Console.WriteLine(circle.GetPerimetr());
            Console.WriteLine(circle.Draw());

            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetPerimetr());
            Console.WriteLine(triangle.Draw());

            var rectangle = new Rectangle(4, 5);
            Console.WriteLine(rectangle.GetPerimetr());
            Console.WriteLine(rectangle.Draw());

            var line = new Line(4);
            Console.WriteLine(line.GetPerimetr());
            Console.WriteLine(line.Draw());
        }
    }

    public class Сircle : Figure
    {
        private int diameter { get; set; }
        private double radius { get; set; }

        public Сircle(int diametr)
        {
            this.diameter = diametr;
            this.radius = diametr / 2;
            this.perimeter = diametr * Math.PI;
        }

        public Сircle(double radius)
        {
            this.diameter = (int)radius * 2;
            this.radius = diameter / 2;
            this.perimeter = diameter * Math.PI;
        }
    }

    public class Rectangle : Figure
    {
        private int side1 { get; set; }
        private int side2 { get; set; }

        public Rectangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;

            this.perimeter = (side1 + side2) * 2;
        }

    }
    public class Triangle : Figure
    {
        private int side1 { get; set; }
        private int side2 { get; set; }
        private int side3 { get; set; }

        public Triangle(int side1, int side2, int side3)
        {
            if (side1 + side2 > side3 && side1 + side3 > side2
                && side3 + side2 > side1)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;

                this.perimeter = side1 + side2 + side3;
            }
            else
                throw new Exception("Invalid sides length");
        }
    }

    public class Line : Figure
    {
        private int length { get; set; }

        public Line(int length)
        {
            this.length = length;
            this.perimeter = length;
        }
    }

    public abstract class Figure
    {
        protected double perimeter { get; set; }

        public double GetPerimetr()
        {
            return perimeter;
        }
        public string Draw()
        {
            return $"{this.GetType().Name}";
        }
    }
}
