using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Isosceles : VertexBasedShape2D
    {
        private void CalculateArea()
        {
            area = (height * length) / 2;
        }
        private void CalculatePerimeter()
        {
            perimeter = height + length + width;
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
