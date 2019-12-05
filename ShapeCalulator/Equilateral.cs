using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Equilateral: VertexBasedShape2D
    {
        private void CalculateArea()
        {
            area = (Math.Sqrt(3.0) / 4.0) * Math.Pow(length, 2.0);
        }
        private void CalculatePerimeter()
        {
            perimeter = 3.0 * length;
        }

        public override void Run()
        {
            length = InputOutput.CollectDouble("Please enter base of Cuboid");
            width = InputOutput.CollectDouble("Please enter side length of Cuboid");
            height = InputOutput.CollectDouble("Please enter height of Cuboid");
            CalculateArea();
            Console.WriteLine($"the surface area is {area}");
            CalculatePerimeter();
            Console.WriteLine($"the Volume is {perimeter}");
        }
    }
}
