using NUnit.Framework;

namespace Practices
{
    [TestFixture]
    public class CalculatorTests
    {
        public Calculator calculator;

        [Test]
        public void AdditionalMustReturnsNotNullValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(8, calculator.Additional(5, 3));
        }

        [Test]
        public void SubtractionMustReturnsNotNullValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(6, calculator.Subtraction(10, 4));
        }

        [Test]
        public void MiltiplicationMustReturnsNotNullValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(20, calculator.Miltiplication(4, 5));
        }

        [Test]
        public void DivisionMustReturnsNotNullValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(5, calculator.Division(20, 4));
        }
    }
}
