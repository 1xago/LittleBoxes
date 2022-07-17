using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;


namespace Tennis.Tests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {1, 2,3, LittleBoxes.Constants.Constants.SmallParcelCost},
            new object[] {1, 9,3, LittleBoxes.Constants.Constants.SmallParcelCost},
            new object[] {1, 2,6, LittleBoxes.Constants.Constants.SmallParcelCost},
            new object[] {9, 2,9, LittleBoxes.Constants.Constants.SmallParcelCost},

            new object[] {10, 2,3, LittleBoxes.Constants.Constants.MediumParcelCost},
            new object[] {1, 19,3, LittleBoxes.Constants.Constants.MediumParcelCost},
            new object[] {1, 29,6, LittleBoxes.Constants.Constants.MediumParcelCost},
            new object[] {49, 2,49, LittleBoxes.Constants.Constants.MediumParcelCost},

                        new object[] {10, 2,51, LittleBoxes.Constants.Constants.LargeParcelCost},
            new object[] {1,50,3, LittleBoxes.Constants.Constants.LargeParcelCost},
            new object[] {1, 89,6, LittleBoxes.Constants.Constants.LargeParcelCost},
            new object[] {99, 2,99, LittleBoxes.Constants.Constants.LargeParcelCost},


            new object[] {10, 2,500, LittleBoxes.Constants.Constants.XlParcelCost},
            new object[] {1, 500,3, LittleBoxes.Constants.Constants.XlParcelCost},
            new object[] {500, 29,6, LittleBoxes.Constants.Constants.XlParcelCost},
            new object[] {100, 2,100, LittleBoxes.Constants.Constants.XlParcelCost},

        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


    }

    public class ParcelCostCalculatorTests
    {
        LittleBoxes.Service.ParcelCostCalculator _parcelCostCalculator;
        public ParcelCostCalculatorTests()
        {
            _parcelCostCalculator = new LittleBoxes.Service.ParcelCostCalculator();
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis1Test(int x, int y, int z, int expected)
        {
            CheckAllScores(_parcelCostCalculator.CalculateParcelCost(x, y, z), expected);
        }


        private void CheckAllScores(int result, int expectedResult)
        {
            Assert.Equal(result, expectedResult);
        }
    }
}