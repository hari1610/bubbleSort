using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSortApp;
using NUnit.Framework;

namespace BubbleSortTest
{
    public class SortArrayMergeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[]{ 1, 2, 3 },new int[] { 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void WhenTwoArrayIsGivenShouldReturnThemMerged(int[] array1, int[] array2, int[] expected )
        {
            var output = SortArrayMerge.MergeArray(array1, array2);
            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 3,5 }, new int[] { 4, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7,8 })]
        public void WhenTwoArrayIsGivenShouldReturnThemMergedInSortedOrder(int[] array1, int[] array2, int[] expected)
        {
            var output = SortArrayMerge.MergeArray(array1, array2);
            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(new int[] {}, new int[] { 4, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void WhenOneArrayIsEmptyShouldThrowException(int[] array1, int[] array2, int[] expected)
        {
            
            Assert.That(()=> SortArrayMerge.MergeArray(array1, array2), Throws.TypeOf<ArgumentException>().With.Message.Contains("One of the string is empty"));
            
        }
    }
}
