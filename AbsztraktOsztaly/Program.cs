using System.Globalization;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new(false, "red", 2, 3);
            Shape[] shapes = {rectangle, new Square(true, "white", 4, 4), new Circle(false, "rózsaszín", 8) };
            makeHoles(shapes);
            makeShapes(3, 3);
            makeShapes(5, 12);
            maxArea(shapes);
        }
        static void makeHoles(Shape[] shapes)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.Area() > shape.Perimeter())
                {
                    shape.MakeHoley();
                }
            }
        }
        static void makeShapes(double width, double height)
        {
            if (width == height)
            {
                Square newSquare = new(false, "piros", width, height);
            }
            else
            {
                Rectangle newRectangle = new(false, "sárga", width, height);
            }
        }
        static double maxArea(Shape[] shapes)
        {
            double max = 0;
            foreach (Shape shape in shapes)
            {
                if (shape.Area() > max)
                {
                    max = shape.Area();
                }
            }
            return max;
        }
    }
}
