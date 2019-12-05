using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Square : VertexBasedShape2D
    {

        public override void Run()
        {
            length = InputOutput.CollectDouble("Please input the length");
            CalcualteArea();
            CalcualtePerimeter();
            OutputResaults();


        }

        private void CalcualteArea()
        {
            area = Math.Pow(length, 2);
        }
        private void CalcualtePerimeter()
        {
            perimeter = 4.0 * length;
        }
        private void OutputResaults()
        {
            Console.WriteLine("The area of the square is: " + area);
            Console.WriteLine("The Perimeter of the square is: " + perimeter);
        }

    }
}
