using LittleBoxes.Constants;
using System;

namespace LittleBoxes.Service
{
    public class ParcelCostCalculator
    {
        public Parcel CalculateParcelCost(Parcel parcel)
        {

            switch (Math.Max(parcel.x, Math.Max(parcel.y, parcel.z)))
            {
                case < Constants.Constants.SmallParcelMaxDimention:
                    parcel.cost = Constants.Constants.SmallParcelCost;
                    return parcel;
                case < Constants.Constants.MediumParcelMaxDimention:
                    parcel.cost = Constants.Constants.MediumParcelCost;
                    return parcel;
                case < Constants.Constants.LargeParcelMaxDimention:
                    parcel.cost = Constants.Constants.LargeParcelCost;
                    return parcel;
                default:
                    parcel.cost = Constants.Constants.XlParcelCost;
                    return parcel;
            }
        }

        public Parcel CalculateParcelCost(int x, int y, int z,bool speedyShipping)
        {
            return CalculateParcelCost(new Parcel(x, y, z, speedyShipping));
        }
    }
}