using System;
using System.Collections.Generic;
using System.Configuration;
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
        
        [TestCase(4,-2, 2)]
        [TestCase(-3, -12, -15)]
        [TestCase(8,22, 30)]
        public void Add_Test(int n1, int n2, int result)
        {

            //Act + Assert
            Assert.That(uut.Add(n1, n2), Is.EqualTo(result));
        }


        [Test]
        public void Add_4andNegative2_Result2()
        {
            //Act + Assert
            Assert.That(uut.Add(4, -2), Is.EqualTo(2));
        }

        [Test]
        public void Add_Negative3andNegative12_ResultNegative15()
        {
            Assert.That(uut.Add(-3, -12), Is.EqualTo(-15));
        }

        [Test]
        public void Add_8and22_Result30()
        {
            Assert.That(uut.Add(8, 22), Is.EqualTo(30));
        }

        //Multiply tests
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
        public void Multiply_Negative5andTwo_ResultNegative10()
        {
            Assert.That(uut.Multiply(-5, 2), Is.EqualTo(-10));
        }

        [Test]
        public void Multiply_Negative6andNegative3_Result18()
        {
            Assert.That(uut.Multiply(-6, -3), Is.EqualTo(18));
        }

        //Subtract tests
        [Test]
        public void Subtract_10and7_Result3()
        {
            Assert.That(uut.Subtract(10,7), Is.EqualTo(3));
        }

        [Test]
        public void Subtract_10andNegative7_Result17()
        {
            Assert.That(uut.Subtract(10, -7), Is.EqualTo(17));
        }

        [Test]
        public void Subtract_Negative4andNegative5_Result1()
        {
            Assert.That(uut.Subtract(-4, -5), Is.EqualTo(1));
        }


        //Division tests
       // [Test]
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

        //Power tests
        [Test]
        public void Power_Raise10ToPowerOf2_Return100()
        {
            Assert.That(uut.Power(10, 2), Is.EqualTo(100));
        }

        [Test]
        public void Power_Raise10ToPowerOfMinus2_ReturnZeroPoint01()
        {
            Assert.That(uut.Power(10, -2), Is.EqualTo(0.01));
        }

        [Test]
        public void Power_RaiseMinus10ToPowerOfMinus4_ReturnZeroPoint0001()
        {
            Assert.That(uut.Power(-10, -4), Is.EqualTo(0.0001));
        }

        //Accumulator tests
        [Test]
        public void Accumulator_InitialValue_ReturnZero()
        {
            Assert.That(uut.Power(-10, 2), Is.EqualTo(100));
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

        //Clear() tests
        [Test]
        public void Clear_ClearAccumulatorAfterAdd_ReturnZero()
        {
            uut.Add(3, 4);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_ClearAccumulatorAfterSubtract_ReturnZero()
        {
            uut.Subtract(2, 5);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_ClearAccumulator_ReturnZero()
        {
            uut.Clear();
            Assert.That(uut.Accumulator, Is.Zero);
        }
    }
}
    