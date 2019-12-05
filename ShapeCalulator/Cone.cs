using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Cone : NonVertexBasedShape3D
    {
        private double height = 0.0;

        private void CalculateSA() //Surface Area
        {
            surfaceArea = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
        }
        private void CalculateVolume() //Surface Area
        {
            volume = Math.PI * Math.Pow(radius, 2) * height / 3;
        }
        public override void Run()
        {
            radius = InputOutput.CollectDouble("radius");
            height = InputOutput.CollectDouble("height");
            CalculateSA();
            Console.WriteLine($"the surface area is {surfaceArea}");
            CalculateVolume();
            Console.WriteLine($"the Volume is {volume}");
        }
    }
}
