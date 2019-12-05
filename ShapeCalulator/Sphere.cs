using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Sphere : NonVertexBasedShape3D
    {
        public override void Run()
        {
            radius = InputOutput.CollectDouble("Please input the radius");
            CalcualteVolume();
            CalculateSurfaceArea();
            OutputResault();
        }

        private void CalcualteVolume()
        {
            volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3.0);
        }
        private void CalculateSurfaceArea()
        {
            surfaceArea = 4.0 * Math.PI * Math.Pow(radius, 2.0);
        }

        private void OutputResault()
        {
            Console.WriteLine("The volume of the Sphere is: " + volume);
            Console.WriteLine("The Surface Area of the Sphere is: " +surfaceArea);
        }
    }
}
