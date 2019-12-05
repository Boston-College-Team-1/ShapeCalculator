using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Cuboid : VertexBasedShape3D
    {
        private void CalculateSA()
        {
            surfaceArea = (length * width + width * height + height * length) * 2;
        }
        private void CalculateVolume()
        {
            volume = length * width * height;
        }
        public override void Run()
        {
            length = InputOutput.CollectDouble("cuboid");
            width = InputOutput.CollectDouble("cuboid");
            height = InputOutput.CollectDouble("cuboid");
            CalculateSA();
            Console.WriteLine($"the surface area is {surfaceArea}");
            CalculateVolume();
            Console.WriteLine($"the Volume is {volume}");
        }
    }
}
