using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            Console.WriteLine("Enter the Value of Radious");
            aCircle.Radious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area=" + aCircle.circleArea() + "\n Perimeter=" + aCircle.circlePerimeter() +
                              "\n Diameter=" + aCircle.circleDiameter());
            Console.ReadKey();

        }
        

    }
}
