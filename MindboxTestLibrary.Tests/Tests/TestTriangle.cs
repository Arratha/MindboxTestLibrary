using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MindboxTestLibrary.Tests
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void GetArea_2and3and4_Return2dot904738()
        {
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;

            double expected = 2.904738;


            Triangle testTriangle = new Triangle(sideA, sideB, sideC);

            double actual = testTriangle.GetArea();


            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestMethod]
        public void GetArea_3and4and5_Return6()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double expected = 6;


            Triangle testTriangle = new Triangle(sideA, sideB, sideC);

            double actual = testTriangle.GetArea();


            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestMethod]
        public void IsRight_3and4and5_ReturnTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            bool expected = true;


            Triangle testTriangle = new Triangle(sideA, sideB, sideC);

            bool actual = testTriangle.IsRight();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRight_3dot3and4dot4and5dot5_ReturnTrue()
        {
            double sideA = 3.3;
            double sideB = 4.4;
            double sideC = 5.5;

            bool expected = true;


            Triangle testTriangle = new Triangle(sideA, sideB, sideC);

            bool actual = testTriangle.IsRight();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRight_3and4and6_ReturnFalse()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;

            bool expected = false;


            Triangle testTriangle = new Triangle(sideA, sideB, sideC);

            bool actual = testTriangle.IsRight();

            Assert.AreEqual(expected, actual);
        }
    }
}
