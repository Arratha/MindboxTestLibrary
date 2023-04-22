using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MindboxTestLibrary.Tests
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void GetArea_3_Return28dot274334()
        {
            double radius = 3;

            double expected = 28.274334;


            Circle testCircle = new Circle(radius);

            double actual = testCircle.GetArea();


            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestMethod]
        public void GetArea_5_Return78dot539816()
        {
            double radius = 5;

            double expected = 78.539816;


            Circle testCircle = new Circle(radius);

            double actual = testCircle.GetArea();


            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
