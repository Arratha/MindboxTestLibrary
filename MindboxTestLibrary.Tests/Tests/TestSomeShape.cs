using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MindboxTestLibrary.Tests
{
    [TestClass]
    public class TestSomeShape
    {
        [TestMethod]
        public void GetArea_3dot3_Circle_Return34dot211944()
        {
            double radius = 3.3;

            double expected = 34.211944;

            SomeShape testShape = new SomeShape();

            double actual = testShape.GetArea(radius);


            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestMethod]
        public void GetArea_7and8and9_Triangle_Return26dot832816()
        {
            double sideA = 7;
            double sideB = 8;
            double sideC = 9;

            double expected = 26.832816;

            SomeShape testShape = new SomeShape();

            double actual = testShape.GetArea(sideA, sideB, sideC);


            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}