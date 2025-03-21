using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Shape
    {
        double height;
        double width;

        public virtual double Height { get => height; set => height = value; }
        public virtual double Width { get => width; set => width = value; }

        public Rectangle(bool isHoley, string color, double height, double width) : base(isHoley, color) 
        {
            this.height = height;
            this.width = width;
        }
        public override double Perimeter()
        {
            return 2 * (height + width);
        }

        public override double Area()
        {
            return height * width;
        }

        public override string ToString()
        {
            return base.ToString() + " - téglalap";
        }
    }
}
