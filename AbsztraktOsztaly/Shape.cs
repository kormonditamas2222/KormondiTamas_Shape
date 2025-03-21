using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal abstract class Shape
    {
        bool isHoley;
        string color;

        public string Color { get { return color; } set { color = value; } }
        protected Shape(bool isHoley, string color) 
        {
            this.isHoley = isHoley;
            this.color = color;
        }
        protected Shape(string color) 
        {
            this.color = color;
            isHoley = false;
        }
        public void MakeHoley()
        {
            isHoley = true;
        }
        public abstract double Perimeter();
        public abstract double Area();
        public override string ToString() 
        {
            return $"{color} - {isHoley} : K: {Perimeter()} T: {Area()}";
        }
    }
}
