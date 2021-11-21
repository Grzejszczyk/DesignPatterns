using System;

namespace FactoryMethod
{
    public class FactoryMethodProgram
    {
        static Report report;

        public static void Start()
        {
            Console.WriteLine("Hello FactoryMethod!");

            report = Initialize(ReportType.Purchase);
            Console.WriteLine("First factory method - purchaseOrderRaport:");
            report.CreateReport(new PurchaseData());
            Console.WriteLine("");

            report = Initialize(ReportType.Sale);
            Console.WriteLine("First factory method - SaleRaport:");
            report.CreateReport(new SaleData());
            Console.WriteLine("");

            Console.WriteLine("End of FactoryMethod demo.");
            Console.WriteLine("");
        }

        static Report Initialize(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.Purchase:
                    return new PurchaseReport();
                case ReportType.Sale:
                    return new SaleReport();
                default:
                    throw new Exception("Error!");
            }
        }
    }

    enum ReportType
    {
        Purchase,
        Sale
    }
}
