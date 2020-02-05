using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator = CalculatorExercise.Calculator;

namespace Calculator.Test.Unit
{
  [TestFixture]
    public class CalculatorTest
    {
        private CalculatorExercise.Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalculatorExercise.Calculator();
        }
        [Test]
        public void AddPositiveWithNegative()
        {
            //Arrange
            var uut = new CalculatorExercise.Calculator();

            //Act + Assert
            Assert.That(uut.Add(3, -5), Is.EqualTo(-2));
        }

        [Test]
        public void Multiply_5and4_Result20()
        {
            var uut = new CalculatorExercise.Calculator();

            Assert.That(uut.Multiply(5, 4), Is.EqualTo(20));
        }

        [Test]
        public void Multiply_5and0_Result0()
        {
            var uut = new CalculatorExercise.Calculator();

            Assert.That(uut.Multiply(5, 0), Is.EqualTo(0));
        }

        [Test]
        public void SubtractTest()
        {
            Assert.That(uut.Subtract(10,7), Is.EqualTo(3));
        }

        [Test]
        public void Division_10and2_Return5()
        {
            Assert.That(uut.Divide(10,2), Is.EqualTo(5));
        }

        [Test]
        public void Division_10and0point1_Return100()
        {
            Assert.That(uut.Divide(10, 0.1), Is.EqualTo(100));
        }

        [Test]
        public void Division_10and0_ReturnException()
        {
            Assert.That(() => uut.Divide(10, 0), Throws.TypeOf< System.DivideByZeroException>());
        }

        [Test]
        public void Division_10and0point0_ReturnException()
        {
            Assert.That(() => uut.Divide(10, 0.0), Throws.TypeOf<System.DivideByZeroException>());
        }

        [Test]
        public void Power_Raise10ToPowerOf2_Return100()
        {
            Assert.That(uut.Power(10, 2), Is.EqualTo(100));
        }

        [Test]
        public void Power_Raise10ToPowerOfMinus2_Return0Point01()
        {
            Assert.That(uut.Power(10,-2), Is.EqualTo(0.01));
        }

        [Test]
        public void Power_RaiseMinus10ToPowerOf2_Return100()
        {
            Assert.That(uut.Power(-10, 2), Is.EqualTo(100));
        }


        [Test]
        public void Clear_ClearAccumulatorToZero_ReturnZero()
        {
            uut.Add(3, 4);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}
    