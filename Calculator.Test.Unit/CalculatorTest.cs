using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
            //Act + Assert
            Assert.That(uut.Add(3, -5), Is.EqualTo(-2));
        }

        [Test]
        public void Multiply_5and4_Result20()
        {
            Assert.That(uut.Multiply(5, 4), Is.EqualTo(20));
        }

        [Test]
        public void Multiply_5and0_Result0()
        {
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
        public void Accumulator_InitialValue_ReturnZero()
        {
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Accumulator_Addition_Return5()
        {
            //Act
            uut.Add(2, 3);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void Accumulator_Subtraction_Return5()
        {
            uut.Subtract(10, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void Accumulator_Multiplication_Return25()
        {
            uut.Multiply(5, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(25));
        }
    }
}
    