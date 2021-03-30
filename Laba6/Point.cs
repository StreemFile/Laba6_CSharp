using System;
using System.ComponentModel;
using System.Text;

namespace Laba6
{
    public class Point
    {
        private int coordinateX;
        private int coordinateY;
        private string color;

        public Point()
        {
        }

        public Point(int coordinateX, int coordinateY, string color)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.color = color;
        }

        public Point(string color)
        {
            this.coordinateX = 0;
            this.coordinateY = 0;
            this.color = color;
        }

        public int CoordinateX
        {
            get => coordinateX;
            set => coordinateX = value;
        }

        public int CoordinateY
        {
            get => coordinateY;
            set => coordinateY = value;
        }

        public string Color => color;

        public void AddVector(int a, int b)
        {
            this.coordinateX += a;
            this.coordinateY += b;
        }

        public double FindDistance()
        {
            int decimalPlaces = 2;
            return Math.Round
            (
                Math.Sqrt
                (
                    Math.Pow(this.coordinateX, 2)
                    + Math.Pow(this.coordinateY, 2)
                ),
                decimalPlaces);
        }

        public override string ToString()
        {
            return "\nCoordinateX: " + coordinateX
                                     + "\nCoordinateY: " + coordinateY
                                     + "\nColor: " + color;
        }

        public string this[Int32 index]
        {
            get
            {
                switch (index)
                {
                    case 0: return coordinateX.ToString();
                    case 1: return coordinateY.ToString();
                    case 2: return color;
                    default:
                        throw new InvalidOperationException("invalid index");
                }
            }
        }

        public static Point operator ++(Point point)
        {
            point.coordinateX++;
            point.coordinateY++;
            return point;
        }

        public static Point operator +(Point point, int value)
        {
            point.coordinateX += value;
            point.coordinateY += value;
            return point;
        }

        public static Point operator --(Point point)
        {
            point.coordinateX--;
            point.coordinateY--;
            return point;
        }

        public static Point operator -(Point point, int value)
        {
            point.coordinateX -= value;
            point.coordinateY -= value;
            return point;
        }

        public static bool operator true(Point point)
        {
            return point.coordinateX == point.coordinateY;
        }

        public static bool operator false(Point point)
        {
            return point.coordinateX != point.coordinateY;
        }

        public static Point FromString(string body)
        {
            string[] array = body.Split(",");
            return new Point(Int32.Parse(array[0]),
                Int32.Parse(array[1]), 
                array[2]);
        }
    }
}