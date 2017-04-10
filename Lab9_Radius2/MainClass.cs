using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Radius2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            bool run = true;

            while (run == true)
            {
                double radius = 0;

                try
                {
                    Console.WriteLine("Enter radius: ");
                    radius = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("That is not a vaild input");
                }

                Circle myCircle = new Circle(radius);

                myCircle.PrintArea();
                myCircle.PrintCircumference();

                ContinueClass go = new ContinueClass();
                run = ContinueClass.Continue();

            }
        }
    }
}
