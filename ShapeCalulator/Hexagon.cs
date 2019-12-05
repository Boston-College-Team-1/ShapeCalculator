using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Hexagon : VertexBasedShape2D
    {
        public override void Run()
        {
            Input();
            CalculateArea();
            CalculatePerimeter();
            Output();
        }
        void Input()
        {
            length = InputOutput.CollectDouble("Edge Length");
            
        }
        void CalculateArea() => area = ((3 * Math.Sqrt(3)) / 4) * Math.Pow(length, 2);
        void CalculatePerimeter() => perimeter = 6 * length;
        void Output()
        {
            InputOutput.OutputDouble("Area", area);
            InputOutput.OutputDouble("Perimeter", perimeter);
        }
    }
}
