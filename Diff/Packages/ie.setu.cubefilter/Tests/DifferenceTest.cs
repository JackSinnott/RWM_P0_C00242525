using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;

namespace Tests
{
    public class DifferenceTest
    {
        [Test]
        public void DifferenceSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = Diff.Difference(input);
            int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
