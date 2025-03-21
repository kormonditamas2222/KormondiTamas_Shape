﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square : Rectangle
    {
        public double Height { get => Width; set => Height = value; }
        public double Width { get => Height; set => Width = value; }
        public Square(bool isHoley, string color, int height, int width) : base(isHoley, color, height, width)
        {
        }

        public override string ToString()
        {
            return "Négyzet " + base.ToString();
        }
    }
}
