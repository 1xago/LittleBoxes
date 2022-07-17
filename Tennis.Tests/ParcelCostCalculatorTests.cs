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
            new object[] {1, 2,3,1, LittleBoxes.Constants.Constants.SmallParcelCost},
            new object[] {1, 9,3,1, LittleBoxes.Constants.Constants.SmallParcelCost},
            new object[] {1, 2,6,2, LittleBoxes.Constants.Constants.SmallParcelCost + LittleBoxes.Constants.Constants.ExtraChargePerExtraWeight},
            new object[] {9, 2,9,3, LittleBoxes.Constants.Constants.SmallParcelCost+ LittleBoxes.Constants.Constants.ExtraChargePerExtraWeight *2},

            new object[] {10, 2,3,1, LittleBoxes.Constants.Constants.MediumParcelCost},
            new object[] {1, 19,3,2, LittleBoxes.Constants.Constants.MediumParcelCost},
            new object[] {1, 29,6,3, LittleBoxes.Constants.Constants.MediumParcelCost},
            new object[] {49, 2,49,4, LittleBoxes.Constants.Constants.MediumParcelCost+ LittleBoxes.Constants.Constants.ExtraChargePerExtraWeight},

                        new object[] {10, 2,51,1, LittleBoxes.Constants.Constants.LargeParcelCost},
            new object[] {1,50,3,1, LittleBoxes.Constants.Constants.LargeParcelCost},
            new object[] {1, 89,6,1, LittleBoxes.Constants.Constants.LargeParcelCost},
            new object[] {99, 2,99,1, LittleBoxes.Constants.Constants.LargeParcelCost},


            new object[] {10, 2,500,1, LittleBoxes.Constants.Constants.XlParcelCost},
            new object[] {1, 500,3,1, LittleBoxes.Constants.Constants.XlParcelCost},
            new object[] {500, 29,6,1, LittleBoxes.Constants.Constants.XlParcelCost},
            new object[] {100, 2,100,10, LittleBoxes.Constants.Constants.XlParcelCost},

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
        public void Tennis1Test(int x, int y, int z, int weight, int expected)
        {
            CheckAllScores(_parcelCostCalculator.CalculateParcelCost(x, y, z, weight).cost, expected);
        }


        private void CheckAllScores(int result, int expectedResult)
        {
            Assert.Equal(result, expectedResult);
        }
    }
}