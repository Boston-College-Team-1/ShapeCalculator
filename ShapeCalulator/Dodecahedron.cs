using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Dodecahedron: VertexBasedShape3D
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
            length = InputOutput.CollectDouble("Edge Length");
        }
        void CalculateSurfaceArea() => surfaceArea = 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Math.Pow(length, 2);
        void CalculateVolume() => volume = (15 + 7 * Math.Sqrt(5) / 4) * Math.Pow(length, 3);
        void Output() 
        {
            InputOutput.OutputDouble("Volume", volume);
            InputOutput.OutputDouble("Surface Area", surfaceArea);
        }

    }
}
