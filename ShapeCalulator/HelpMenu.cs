using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    class HelpMenu
    {
        public void Run()
        {
            OutputHelp();
            GetUserInput();
        }

        private void OutputHelp()
        {
            Console.WriteLine("Help menu\n" +
                "====================" +
                "To use this application, select an option from the main menu and then follow the on-screen instructions.\n" +
                "For particular shapes, you will need the following information:\n" +
                "Vertex-based 2D: width, height\n" +
                "Vertex-based 3D: width, height, depth\n" +
                "Non-vertex-based 2D: radius\n" +
                "Non-vertex-based 3D: radius\n");
        }

        private void GetUserInput()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
