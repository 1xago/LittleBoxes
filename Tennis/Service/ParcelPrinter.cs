using LittleBoxes.Constants;
using System;
using System.Collections.Generic;

namespace LittleBoxes.Service
{
    public class ParcelPrinter
    {
        public string PrintParcels(List<Parcel> parcels)
        {
            int parcelNumber = 0;
            int totalValue = 0;
            var result = "";
            foreach (var parcel in parcels)
            {
                result += "parcel number = " + parcelNumber + "parcel cost = " + parcel.cost + "\n";
                parcelNumber++;
                totalValue += parcel.cost;
            }

            result += "total value = " + totalValue + "\n";
            return result;
        }

    }
}