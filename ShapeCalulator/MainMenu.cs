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
            Console.WriteLine($"{shapeList.Count + 1}: Help");
            Console.WriteLine($"{shapeList.Count + 2}: Exit");
        }

        private void RunUserChoice()
        {
            var chosenShapeIndex = InputOutput.CollectInt("desired shape") - 1;
            if (chosenShapeIndex < 0 || chosenShapeIndex > shapeList.Count + 1)
            {
                Console.WriteLine("Invalid input - please try again.");
                RunUserChoice();
            }

            if (chosenShapeIndex == shapeList.Count)
            {
                HelpMenu helpMenu = new HelpMenu();
                helpMenu.Run();
            }
            else if (chosenShapeIndex == shapeList.Count + 1)
            {
                Environment.Exit(0);
            }
            else
            {
                shapeList[chosenShapeIndex].Run();
            }
        }


        /// <summary>
        /// Get all of the shapes within the program.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{Type}"/> of shapes.</returns>
        private List<Shape> GetListOfShapes()
        {
            var shapes = new List<Shape>();
            foreach (var shape in Assembly.GetExecutingAssembly().GetTypes().Where(t =>
                (t.BaseType == typeof(NonVertexBasedShape2D) ||
                t.BaseType == typeof(NonVertexBasedShape3D) ||
                t.BaseType == typeof(VertexBasedShape2D) ||
                t.BaseType == typeof(VertexBasedShape3D))
                && !t.IsAbstract))
            {
                shapes.Add((Shape)Activator.CreateInstance(shape));
            }

            return shapes;
        }
    }
}
