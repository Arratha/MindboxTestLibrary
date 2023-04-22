using System;


namespace MindboxTestLibrary
{
    public class SomeShape
    {
        public double GetArea(params double[] variables)
        {
            if (variables.Length == 1)
                return new Circle(variables[0]).GetArea();

            if (variables.Length == 3)
                return new Triangle(variables[0], variables[1], variables[2]).GetArea();

            throw new Exception("There is no figure with a given number of variables");
        }
    }
}