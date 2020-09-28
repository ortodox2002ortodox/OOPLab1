using System;

namespace OOPLab1
{
    class Triangle
    {
        double a, b, c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public bool isTriangle 
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }

        }
        public Triangle(int a_, int b_, int c_)
        {
            isCorrect(a_, b_, c_);
            A = a_;
            B = b_;
            C = c_;
        }
        public void PrintSides()
        {
            Console.WriteLine("a is {0}, b is {1}, c is {2}", a, b, c);
        }
        public double Perimetr()
        {
            return a + b + c;    //P
        }
        public double Square()
        {
            return Math.Sqrt(halfper(this) * (halfper(this) - a) * (halfper(this) - b) * (halfper(this) - c));      // S   
        }
        static double halfper(Triangle Ob)
        {
            return Ob.Perimetr() / 2.0;     //p
        }
        static void isCorrect(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new Exception("Sides of triangle can` t be negative");
        }

        public static bool operator true(Triangle t)
        {
            return t.isTriangle;
        }
        public static bool operator false(Triangle t)
        {
            return t.isTriangle;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Triangle Ob = new Triangle(3, 4, 5);
                if (Ob)
                    Ob.PrintSides();
                else
                    throw new Exception("There is no triangle with such sides");
                Console.WriteLine("Perimetr={0}", Ob.Perimetr());
                Console.WriteLine("Sqaure={0}", Ob.Square());

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}