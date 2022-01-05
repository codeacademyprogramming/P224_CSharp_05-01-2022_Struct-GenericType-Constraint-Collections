using System;

namespace P224Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Student student = new Student();
            //Area area = new Area();

            Area area = new Area();
            area.Width = 5;
            area.Height = 10;
            area.SumArea();

            Area area1;
            area1.Height = 5;
            Console.WriteLine(area1.Height);
        }
    }

    class Student
    {
        public string Name;

        public Student()
        {

        }
    }

    struct Area
    {
        public double Height;
        public double Width { get; set; }
        public double Sum { get; set; }

        public Area(double height)
        {
            Height = height;
            Width = 0;
            Sum = Height * Width;
        }

        public double SumArea()
        {
            return Width * Height;
        }
    }
}
