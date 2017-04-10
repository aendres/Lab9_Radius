using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Radius2
{
    class Circle
    {
        private double radius;
        private const double pi = Math.PI;
        private double circumference;
        private double area;

        //put constructor as early as possible in the code
        public Circle(double radius)
        {
            SetRadius(radius);

        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            circumference = 2 * pi * radius;
            return circumference;
        }

        public void PrintCircumference()
        {
            double cir = GetCircumference();
            Console.WriteLine("The circumference is: " + cir);
        }

        public double GetArea()
        {
            area = pi * (radius * radius);
            return area;
        }

        public void PrintArea()
        {
            double ar = GetArea();
            Console.WriteLine("The area is: " + ar);
        }
    }
}
