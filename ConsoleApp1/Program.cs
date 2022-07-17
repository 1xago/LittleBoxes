// See https://aka.ms/new-console-template for more information
using LittleBoxes;
public class Program
{
    static void Main()
    {
        var parcelCostCalculator = new LittleBoxes.Service.ParcelCostCalculator();
        var parcelPrinter = new LittleBoxes.Service.ParcelPrinter();

        Console.WriteLine("Hi");
 
        var parcelInformation = new List<int[]>();
        parcelInformation.Add(new int[] { 1, 2, 3 });
        parcelInformation.Add(new int[] { 1, 2, 9 });
        parcelInformation.Add(new int[] { 1, 20, 3 });
        parcelInformation.Add(new int[] { 1, 2, 300 });

        var parcelList = new List<Parcel>();

        foreach(var parcelInfo in parcelInformation)
        {
            parcelList.Add(parcelCostCalculator.CalculateParcelCost(parcelInfo[0], parcelInfo[1], parcelInfo[2]));
        }

        var result = parcelPrinter.PrintParcels(parcelList);
        Console.WriteLine(result);
    }

}