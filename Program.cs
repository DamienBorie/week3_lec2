using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week3Example4
{
    interface IPolygon
    {
        string Name
        {
            get;
            set;
        }
        int NumOfSides
        {
            get;
        }
        void calculateArea(params int[] sides);
    }
    interface IColor
    {
        void getColor();
    }
    class Rectangle : IPolygon, IColor
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _numOfSides;
        public int NumOfSides
        {
            private set => _numOfSides = value;
            get => _numOfSides;
        }
        public void calculateArea(int[] sides)
        {
            int area = sides[0] * sides[1];
            Console.WriteLine("Area of Rectange: " + area);
        }
        public void getColor()
        {
            Console.WriteLine("Red Rectangle");
        }
        public Rectangle() => _numOfSides = 4;
    }
    class Triangle : IPolygon, IColor
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _numOfSides;
        public int NumOfSides
        {
            private set => _numOfSides = value;
            get => _numOfSides;
        }
        public void calculateArea(int[] sides)
        {
            var s = (sides[0] + sides[1] + sides[2]) / 2;
            double area = Math.Sqrt(s * (s - sides[0])*(s - sides[1])*(s - sides[2]));
            Console.WriteLine("Area of Triangle: " + area);
        }
        public void getColor()
        {
            Console.WriteLine("Green Triagle");
        }
        public Triangle() => _numOfSides = 3;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Name = "rectangle_1";
            r1.calculateArea(new int[] { 100, 200 });
            r1.getColor();
            
            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";
            t1.calculateArea(new int[] { 100, 150, 100 });
            t1.getColor();
            Console.ReadKey();
        }
    }
}
