using NUnit.Framework;
using CalculatorExmple;

namespace Tests_Nunit
{
    [TestFixture]
    public class Testsi
    {

        [TestCase(3, 8, 11)]
        [TestCase(6, 8, 14)]
        [TestCase(9, 8, 17)]
        public void Addition_Tests(double a, double b, double c)

        {
            Assert.AreEqual(c, MyCalApp.Addition(a, b));

        }


        [TestCase(25, 8, 17)]
        [TestCase(-200, -8, -192)]
        [TestCase(-200, 6, -206)]
        public void Subtraction_Tests(double a, double b, double c)
        {
            Assert.AreEqual(c, MyCalApp.Subtraction(a, b));
        }

        [TestCase(5, 4, 20)]
        [TestCase(3, 6, 18)]
        [TestCase(7, 7, 49)]
        public void Multiplication_Test(double a, double b, double c)
        {

            Assert.AreEqual(c, MyCalApp.Multiplication(a, b));
        }

        [TestCase(45, 9, 5)]
        [TestCase(-90, 18, -5)]
        [TestCase(-30, -5, 6)]
        [TestCase(1, 3 , 1/3)]
        [TestCase(2, 1 , 2)]
        [TestCase(9, 3, 3)]
        public void Division_Test10(double a, double b, double c)
        {
            Assert.AreEqual(c, MyCalApp.Division(a, b));
        }


    }
}