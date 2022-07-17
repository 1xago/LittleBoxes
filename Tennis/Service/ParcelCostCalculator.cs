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

                    parcel.cost = Constants.Constants.SmallParcelCost + CalculateWeightCost(Constants.Constants.SmallParcelWeighLimit,parcel.weight);
                    return parcel;
                case < Constants.Constants.MediumParcelMaxDimention:
                    parcel.cost = Constants.Constants.MediumParcelCost + CalculateWeightCost(Constants.Constants.MediumParcelWeighLimit, parcel.weight);
                    return parcel;
                case < Constants.Constants.LargeParcelMaxDimention:
                    parcel.cost = Constants.Constants.LargeParcelCost + CalculateWeightCost(Constants.Constants.LargeParcelWeighLimit, parcel.weight);
                    return parcel;
                default:
                    parcel.cost = Constants.Constants.XlParcelCost + CalculateWeightCost(Constants.Constants.XlParcelWeighLimit, parcel.weight); ;
                    return parcel;
            }
        }

        public int CalculateWeightCost(int limit, int weight)
        {
            if (limit > weight) { return 0; }
            return (weight - limit) * Constants.Constants.ExtraChargePerExtraWeight;
        
        }

        public Parcel CalculateParcelCost(int x, int y, int z, int weight, bool speedyShipping = false)
        {
            return CalculateParcelCost(new Parcel(x, y, z, weight, speedyShipping));
        }
    }
}