using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShapeCalulator
{
    public class MainMenu
    {
        private List<Shape> shapeList;
        public void Run()
        {
            OutputChoicesToUser();
            RunUserChoice();
        }

        private void OutputChoicesToUser()
        {
            var shapeList = GetListOfShapes().ToList();
            for (int i = 0; i < shapeList.Count; ++i)
            {
                Console.WriteLine($"{i + 1}: {shapeList[i].Name}");
            }
        }

        private void RunUserChoice()
        {
            var chosenShapeIndex = InputOutput.CollectInt("a shape") - 1;
            if (chosenShapeIndex < 0 || chosenShapeIndex > shape)
        }

        /// <summary>
        /// Get all of the shapes within the program.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{Type}"/> of shapes.</returns>
        private IEnumerable<Type> GetListOfShapes()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => 
                t.BaseType == typeof(NonVertexBasedShape2D) || 
                t.BaseType == typeof(NonVertexBasedShape3D) || 
                t.BaseType == typeof(VertexBasedShape2D) || 
                t.BaseType == typeof(VertexBasedShape3D));
        }
    }
}
