﻿using System.Diagnostics.Contracts;
using System.Reflection.Metadata;

namespace Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
        }
        public class Shape
        {
            public const double PI = Math.PI;
            protected double _x, _y;
            public Shape() { }
            public Shape(double x, double y)
            { _x = x; _y = y; }
            public virtual double Area() { return _x * _y; }
        }
        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0) { }
            public override double Area() { return PI * _x * _x; }
        }
        public class Sphere: Shape
        {
            public Sphere(double r) : base(r, 0) { }
            public override double Area() { return 4 * PI * _x * _x; }
        }
        public class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h) { }
            public override double Area() { return 2 * PI * _x * _x + 2 * PI * _x * _y; }
        }


    }
}