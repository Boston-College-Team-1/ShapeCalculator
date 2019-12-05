using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Circle : NonVertexBasedShape2D
    {
        public override void Run()
        {
            radius = InputOutput.CollectDouble("Please input the radius");
            CalculateArea();
            CalculatePerimeter();
            OutputResault();
        }

        private void CalculateArea()
        {
            area = Math.PI * Math.Pow(radius, 2);
        }
        private void CalculatePerimeter()
        {
            perimeter = 2 * Math.PI * radius;
        }
        private void OutputResault()
        {
            Console.WriteLine("The area of the Circle is: " + area);
            Console.WriteLine("The Circumference of the Circle is: " + perimeter);
        }
    }
}
