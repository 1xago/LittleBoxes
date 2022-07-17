// See https://aka.ms/new-console-template for more information
using LittleBoxes;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        var parcelCostCalculator = new LittleBoxes.Service.ParcelCostCalculator();
        var parcelPrinter = new LittleBoxes.Service.ParcelPrinter();

        Console.WriteLine("Hi");
 
        var parcelInformation1 = new List<int[]>();
        parcelInformation1.Add(new int[] { 1, 2, 3,1 });
        parcelInformation1.Add(new int[] { 1, 2, 9,1 });
        parcelInformation1.Add(new int[] { 1, 20, 3,1 });
        parcelInformation1.Add(new int[] { 1, 2, 300,1 });

        var parcelInformation2 = new List<int[]>();
        parcelInformation2.Add(new int[] { 1, 2, 3,1 });
        parcelInformation2.Add(new int[] { 1, 2, 9 ,1});
        parcelInformation2.Add(new int[] { 1, 20, 3 ,1});
        parcelInformation2.Add(new int[] { 1, 2, 300,1 });

        var parcelList = new List<Parcel>();

        foreach(var parcelInfo in parcelInformation1)
        {
            parcelList.Add(parcelCostCalculator.CalculateParcelCost(parcelInfo[0], parcelInfo[1], parcelInfo[2], parcelInfo[3],false));
        }
        var result = parcelPrinter.PrintParcels(parcelList);
        Console.WriteLine(result);
        Console.WriteLine("");

        parcelList = new List<Parcel>();

        foreach (var parcelInfo in parcelInformation2)
        {
            parcelList.Add(parcelCostCalculator.CalculateParcelCost(parcelInfo[0], parcelInfo[1], parcelInfo[2], parcelInfo[3], true));
        }

        result = parcelPrinter.PrintParcels(parcelList);
        Console.WriteLine(result);
        Console.WriteLine("");

   
    }

}