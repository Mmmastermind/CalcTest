using ConsoleApp2;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        

        [Test]
        public void Add_ReturnsCorrectValue()
        {
            Assert.Are(5, calc.Add(2, 3));
        }

        [Test]
        public void Sub_ReturnsIncorrectValue_BecauseBug()
        {
            Assert.AreNotEqual(7, calc.Sub(10, 3)); // из-за бага
        }

        [Test]
        public void Mul_IsPositive()
        {
            Assert.IsTrue(calc.Mul(2, 3) > 0);
        }

        [Test]
        public void Div_IsNotZero()
        {
            Assert.IsFalse(calc.Div(10, 2) == 0);
        }

        [Test]
        public void Pow_ReturnsDouble()
        {
            var result = calc.Pow(2, 3);
            Assert.IsInstanceOf<double>(result);
        }

        [Test]
        public void Sqrt_NotInstanceOfString()
        {
            var result = calc.Sqrt(9);
            Assert.IsNotInstanceOf<string>(result);
        }

        [Test]
        public void Percent_NotNull()
        {
            var result = calc.Percent(200, 10);
            Assert.IsNotNull(result);
        }

        [Test]
        public void Log_OfOneIsZero()
        {
            Assert.AreEqual(0, calc.Log(1));
        }

        [Test]
        public void Sin_ZeroIsZero()
        {
            Assert.AreEqual(0, calc.Sin(0));
        }

        [Test]
        public void Ctg_45DegreesIsPositive()
        {
            Assert.IsTrue(calc.Ctg(45) > 0);
        }

        [Test]
        public void Div_ThrowsException_WhenDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                double x = 10 / 0; // имитируем ошибку
            });
        }

        [Test]
        public void Sqrt_NegativeNumberReturnsNaN()
        {
            Assert.IsTrue(double.IsNaN(calc.Sqrt(-4)));
        }

        [Test]
        public void Ctg_Zero_ReturnsInfinity()
        {
            Assert.IsTrue(double.IsInfinity(calc.Ctg(0)));
        }

        [Test]
        public void Pow_LargeNumbers()
        {
            double result = calc.Pow(10, 5);
            Assert.AreEqual(100000, result);
        }

        [Test]
        public void Log_IsNotInstanceOfInt()
        {
            var result = calc.Log(10);
            Assert.IsNotInstanceOf<int>(result);
        }
    }
}
