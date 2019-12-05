using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Rectangle: VertexBasedShape2D
    {
        public override void Run()
        {
            length = InputOutput.CollectDouble("Please input length");
            width = InputOutput.CollectDouble("Please input width");
            CalcualteArea();
            CalculatePerimeter();
            OutputResaults();

        }
        private void CalcualteArea()
        {
            area = width * length;
        }

        private void CalculatePerimeter()
        {
            perimeter = 2 * (length + width);
        }

        private void OutputResaults()
        {
            Console.WriteLine("The area of the Rectangle is: " + area);
            Console.WriteLine("The periemter of the Rectangle is: " + perimeter);
        }


    }
}
