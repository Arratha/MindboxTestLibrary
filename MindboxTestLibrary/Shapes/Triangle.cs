using System;
using System.Linq;


namespace MindboxTestLibrary
{
    public class Triangle : IShape
    {
        private double[] _sides;
        public double[] Sides { get => _sides; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            double[] temp = new double[] { sideA, sideB, sideC };

            if (!IsPossible(temp))
                throw new Exception("Triangle is not possible");

            _sides = temp;
        }

        public double GetArea()
        {
            double p = _sides.Sum() / 2;
            double area = Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));

            return area;
        }

        public bool IsRight()
        {
            int hypotenuseIndex = Array.IndexOf(_sides, _sides.Max());

            double hypotenuse = _sides[hypotenuseIndex];
            double[] cathetus = _sides.Where((x, i) => i != hypotenuseIndex).ToArray();

            if (Math.Pow(hypotenuse, 2) == Math.Pow(cathetus[0], 2) + Math.Pow(cathetus[1], 2))
                return true;

            return false;
        }

        private bool IsPossible(double[] sides)
        {
            if (sides.Any(x => x <= 0))
                return false;

            if (sides.Max() >= sides.Sum() / 2.0)
                return false;

            return true;
        }
    }
}