using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    abstract class Pentagon: VertexBasedShape2D
    {
        public override void Run()
        {
            Input();
            CalculateArea();
            Output();
        }
        void Input()
        {
            length = InputOutput.CollectDouble("Edge Length");
        }
        void CalculateArea() => area = 1 / 4 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)) * Math.Pow(length, 2);
        void Output()
        {
            InputOutput.OutputDouble("Area", area);
        }
    }

}
