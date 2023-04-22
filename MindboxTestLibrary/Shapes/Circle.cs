using System;


namespace MindboxTestLibrary
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius { get => _radius; }

        public Circle(double radius)
        {
            if (!IsPossible(radius))
                throw new Exception("Circle is not possible");

            _radius = radius;
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(_radius, 2);

            return area;
        }

        private bool IsPossible(double radius)
        {
            if (radius <= 0)
                return false;

            return true;
        }
    }
}
