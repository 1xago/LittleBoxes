using LittleBoxes.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

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
                result += "parcel number = " + parcelNumber + " parcel cost = " + parcel.cost + "\n";
                parcelNumber++;
                totalValue += parcel.cost;
            }
            if (parcels.Any(parcel =>parcel.speedyChipping))
            {
                result += "speedy Shipping has been selected increasing the cost of the package by totalValue" + totalValue + "\n";
                totalValue += totalValue;
            }
            result += "total cost = " + totalValue + "\n";
            return result;
        }

    }
}