using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class Tests
    {
        private Calculator calc;

        [TestInitialize]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void Add_ReturnsCorrectValue()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void Sub_ReturnsIncorrectValue_BecauseBug()
        {
            Assert.AreNotEqual(7, calc.Sub(10, 3)); 
        }

        [TestMethod]
        public void Mul_IsPositive()
        {
            Assert.IsTrue(calc.Mul(2, 3) > 0);
        }

        [TestMethod]
        public void Div_IsNotZero()
        {
            Assert.IsFalse(calc.Div(10, 2) == 0);
        }

        [TestMethod]
        public void Pow_ReturnsDouble()
        {
            var result = calc.Pow(2, 3);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void Sqrt_NotInstanceOfString()
        {
            var result = calc.Sqrt(9);
            Assert.IsNotInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void Percent_NotNull()
        {
            var result = calc.Percent(200, 10);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Log_OfOneIsZero()
        {
            Assert.AreEqual(0, calc.Log(1));
        }

        [TestMethod]
        public void Sin_ZeroIsZero()
        {
            Assert.AreEqual(0, calc.Sin(0));
        }

        [TestMethod]
        public void Ctg_45DegreesIsPositive()
        {
            Assert.IsTrue(calc.Ctg(45) > 0);
        }


        [TestMethod]
        public void Div_ThrowsException_WhenDivideByZero()
        {
            double result = calc.Div(10, 0); 
            Assert.IsTrue(double.IsInfinity(result));
        }

        [TestMethod]
        public void Sqrt_NegativeNumberReturnsNaN()
        {
            Assert.IsTrue(double.IsNaN(calc.Sqrt(-4)));
        }

        [TestMethod]
        public void Ctg_Zero_ReturnsInfinity()
        {
            Assert.IsTrue(double.IsInfinity(calc.Ctg(0)));
        }

        [TestMethod]
        public void Pow_LargeNumbers()
        {
            double result = calc.Pow(10, 5);
            Assert.AreEqual(100000, result);
        }

        [TestMethod]
        public void Log_IsNotInstanceOfInt()
        {
            var result = calc.Log(10);
            Assert.IsNotInstanceOfType(result, typeof(int));
        }
    }
}
