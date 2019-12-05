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
            shapeList = GetListOfShapes().ToList();
            OutputChoicesToUser();
            RunUserChoice();
        }

        private void OutputChoicesToUser()
        {
            for (int i = 0; i < shapeList.Count; ++i)
            {
                Console.WriteLine($"{i + 1}: {shapeList[i].GetType().Name}");
            }
        }

        private void RunUserChoice()
        {
            var chosenShapeIndex = InputOutput.CollectInt("desired shape") - 1;
            if (chosenShapeIndex < 0 || chosenShapeIndex > shapeList.Count)
            {
                Console.WriteLine("Invalid input - please try again.");
                RunUserChoice();
            }

            shapeList[chosenShapeIndex].Run();
        }

        /// <summary>
        /// Get all of the shapes within the program.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{Type}"/> of shapes.</returns>
        private List<Shape> GetListOfShapes()
        {
            var shapes = new List<Shape>();
            foreach (var shape in Assembly.GetExecutingAssembly().GetTypes().Where(t =>
                t.BaseType == typeof(NonVertexBasedShape2D) ||
                t.BaseType == typeof(NonVertexBasedShape3D) ||
                t.BaseType == typeof(VertexBasedShape2D) ||
                t.BaseType == typeof(VertexBasedShape3D)))
            {
                shapes.Add((Shape)Activator.CreateInstance(shape));
            }

            return shapes;
        }
    }
}
