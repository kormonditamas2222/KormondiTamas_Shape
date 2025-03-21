using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        double radius;
        public Circle(bool isHoley, string color, double radius) : base(isHoley, color)
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return base.ToString() + " kör";
        }
    }
}
