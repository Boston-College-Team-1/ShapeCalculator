using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    abstract class Cylinder: NonVertexBasedShape3D
    {
        public override void Run()
        {
            Input();
            CalculateSurfaceArea();
            CalculateVolume();
            Output();
        }
        void Input()
        {
            length = InputOutput.CollectDouble("Height");
            radius = InputOutput.CollectDouble("Radius");

        }
        void CalculateSurfaceArea() => surfaceArea = ((3 * Math.Sqrt(3)) / 4) * Math.Pow(length, 2);
        void CalculateVolume () => volume = 6 * length;
        void Output()
        {
            InputOutput.OutputDouble("Surface Area", surfaceArea);
            InputOutput.OutputDouble("Volume", volume);
        }
    }
}
