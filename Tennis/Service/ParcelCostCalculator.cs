using LittleBoxes.Constants;
using System;

namespace LittleBoxes.Service
{
    public class ParcelCostCalculator
    {
        public int CalculateParcelCost(Parcel parcel)
        {

            switch (Math.Max(parcel.x, Math.Max(parcel.y, parcel.z)))
            {
                case < Constants.Constants.SmallParcelMaxDimention:
                    return Constants.Constants.SmallParcelCost;
                case < Constants.Constants.MediumParcelMaxDimention:
                    return Constants.Constants.MediumParcelCost;
                case < Constants.Constants.LargeParcelMaxDimention:
                    return Constants.Constants.LargeParcelCost;
                default:
                    return Constants.Constants.XlParcelCost;
            }
        }

        public int CalculateParcelCost(int x, int y, int z)
        {
            return CalculateParcelCost(new Parcel(x, y, z));
        }
    }
}