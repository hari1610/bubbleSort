using NUnit.Framework;
using BubbleSortApp;
using System;

namespace BubbleSortTest
{
    public class BubbleSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(Arrays))]
        public void GivenArrayOfInt_WhenSort_IsSorted(int[] input, int[] expected)
        {
            int[] intArraySorted = BubbleSort.Sort(input);
            Assert.That(intArraySorted, Is.EqualTo(expected));
        }

        [Test]
        public void GivenNullArrayOfInt_WhenSort_ThrowException()
        {
            int[] nullArray = null;
            Assert.That(() => BubbleSort.Sort(nullArray), Throws.TypeOf<ArgumentNullException>().With.Message.Contains("Input array was null"));
        }

        static object[] Arrays =
        {
            new object[] { new int[] { 3, 4, 1, 2, 6, 7, 9, 8, 13, 12, 10, 11, 5 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 } },
            new object[] { new int[] { -1, -5, -3, 0, 10, 5, 1, -3, -5 }, new int[] { -5, -5, -3, -3, -1, 0, 1, 5, 10 } }
        };
    }
}