using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //I created these here because I couldn't find a way to have Visual Studio create them for me. 
    struct LineSegment
    {
        Point StartPoint { get; set; }
        Point EndPoint { get; set; }
        Point MidPoint { get; }
        double Slope { get; }        
        double Length { get; }

        public LineSegment(Point s, Point e)
        {
            StartPoint = s;
            EndPoint = e;
            MidPoint = new Point((StartPoint.X + EndPoint.X) / 2, (StartPoint.Y + EndPoint.Y) / 2);
            Slope = (EndPoint.Y - StartPoint.Y) / (EndPoint.X - StartPoint.X);
            Length = Math.Sqrt(((EndPoint.X - StartPoint.X) * (EndPoint.X - StartPoint.X)) + ((EndPoint.Y - StartPoint.Y) * (EndPoint.Y - StartPoint.Y)));

        }
        public string ToString()
        {
            return $"{StartPoint}, {EndPoint}";
        }
    }
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double xVal, double yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
