using System;
using System.Collections.Generic;
using CalculateService.Models;
using Xunit;

namespace CalculationTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculationTest()
        {

            var y = new List<int> { 1, 2, 3, 4, 5 };
            var x = new Calculation(y);
            x.Calculate();
            var ActualMean = 3;
            var ActualMode = 1;
            var ActualMedian = 3;

            Assert.Equal(x.Mean, ActualMean);
            Assert.Equal(x.Mode, ActualMode);
            Assert.Equal(x.Median, ActualMedian);
         }

      
    }
}
