﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class Dodecahedron: VertexBasedShape3D
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
        void CalculateArea() => area
        void Output() 
        {

            InputOutput.OutputDouble("Surface Area", surfaceArea);
        }

    }
}