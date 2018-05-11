using NUnit.Framework;

namespace Task6.Tests
{
    using Test6.Solution;

    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            SequenceCalculate<int> sequence = new SequenceCalculate<int>();
            var result = sequence.ResultCalculate(10, 1, 1, FunctionsClass<int>.FirstSequenceFormula);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            SequenceCalculate<int> sequence = new SequenceCalculate<int>();
            var result = sequence.ResultCalculate(10, 1, 2, FunctionsClass<int>.SecondSequenceFormula);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            SequenceCalculate<double> sequence = new SequenceCalculate<double>();
            var result = sequence.ResultCalculate(10, 1, 2, FunctionsClass<double>.ThirdsSequenceFormula);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.0001);
            }

            //Assert.That(expected, Is.EqualTo(result));
        }
    }
}
