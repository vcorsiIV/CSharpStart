using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApplication
{
    class Rectangle
    {
        //Member Variables
        double length, width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;            
        }
        public double getArea()
        {
            return length * width;
        }
        public void Display()
        {
            WriteLine("Rectangle");
            WriteLine("The Length:\t\t{0}" , length);
            WriteLine("The Width:\t\t{0}" , width);
            WriteLine("The Area:\t\t{0}\n", getArea());
            ReadKey(true);
        }

    }

    class Square
    {
        //Member Variables
        double length, width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = length;
            
        }
        public double getArea()
        {
            return length * width;
        }
        public void Display()
        {
            WriteLine("Square:");
            WriteLine("The Length:\t\t{0}", length);
            WriteLine("The Width:\t\t{0}", width);
            WriteLine("The Area:\t\t{0}\n", getArea());
            ReadKey(true);
        }

    }

    class Triangle
    {
        //Member Variables
        double sideA, sideB, sideC;

        public void AcceptDetails()
        {
            sideA = 4.5;
            sideB = 3.5;
            sideC = 6.27;
        }
        public double getArea()
        {
            double s = (sideA+sideB+sideC)/2;

            return Math.Sqrt(s*(s-sideA)*(s-sideB)*(s-sideC));
        }
        public void Display()
        {
            WriteLine("Triangle:");
            WriteLine("The first side:\t\t{0}", sideA);
            WriteLine("The second side:\t{0}", sideB);
            WriteLine("The third side:\t\t{0}", sideC);
            WriteLine("The Area:\t\t{0}\n", getArea());
            ReadKey(true);
        }

    }

    class Octagon
    {
        //Member Variables
        double sideA;

        public void AcceptDetails()
        {
            sideA = 4.5;
        }
        public double getArea()
        {
            return (2*(1+Math.Sqrt(2))*Math.Pow(sideA, 2));
        }
        public void Display()
        {
            WriteLine("Octagon:");
            WriteLine("The one of the six sides:\t{0}", sideA);
            WriteLine("The Area:\t\t\t{0}\n", getArea());
            ReadKey(true);
        }

    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            WriteLine("Hit any key to view the next shape results\n");
            Rectangle r = new Rectangle();
            Triangle t = new Triangle();
            Square s = new Square();
            Octagon o = new Octagon();
            r.AcceptDetails();
            r.getArea();
            r.Display();

            t.AcceptDetails();
            t.getArea();
            t.Display();

            s.AcceptDetails();
            s.getArea();
            s.Display();

            o.AcceptDetails();
            o.getArea();
            o.Display();
        }
    }
}
