using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using KataSolutions;

namespace Tests.ArrayKatas
{
    public class Kata1Alternativ
    {
        //TODO skriv en metod som vänder på innehållet i arrayer, använd for-loop

        [Theory]
        [InlineData(new[] { 0, 1 }, new[] { 1, 0 })]
        [InlineData(new[] { 0, 1, 2, 3, 4 }, new[] { 4, 3, 2, 1, 0 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 5, 4, 3, 2, 1 })]
        public void ArrayReverserTest(int[] original, int[] expected)
        {
            int[] actual = Reverser.GetReverse(original);

            Assert.Equal(expected, actual);
        }
    }
}