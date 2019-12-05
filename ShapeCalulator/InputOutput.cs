using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalulator
{
    static class InputOutput
    {
        public static void OutputDouble(string variableName, double variableValue)
        {
            Console.WriteLine($"{variableName}: {variableValue}");
        }

        public static double CollectDouble(string variableName)
        {
            Console.WriteLine($"Please enter the {variableName}: ");
            if (!double.TryParse(Console.ReadLine(), out double result))
            {
                Console.WriteLine("Invalid input - please try again");
                CollectDouble(variableName);
            }
            return result;
        }
    }
}
