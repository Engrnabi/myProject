using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double Radious { set; get; }
        public double Diameter { set; get; }
        public double Perimeter { set; get; }
        public double  Area { set; get; }


        public double circleArea()
        {
            return Math.PI*Radious*Radious;
        }

         public double circlePerimeter()
        {
            return Math.PI*Radious*2;
        }
         public double circleDiameter()
        {
            return 2*Radious;
        }
    }
}
