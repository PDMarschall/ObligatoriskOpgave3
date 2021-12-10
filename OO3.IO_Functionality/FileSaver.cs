using System;
using System.IO;
using OO3.Lottery_Functionality.Abstract_Classes;
using OO3.Lottery_Functionality;

namespace OO3.IO_Functionality
{
    public static class FileSaver
    {
        const string path = @"C:\temp\";
        public static void SaveCoupon(ICoupon coupon, int iteration)
        {
            Directory.CreateDirectory(path + $"{DateTime.Today.ToShortDateString()}");

            StreamWriter writer = new StreamWriter(path + $"{DateTime.Today.ToShortDateString()}\\LotteryCoupon{iteration:0#}.txt");

            writer.WriteLine(coupon);
            writer.Close();
        }
    }
}
