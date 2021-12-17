using System;
using System.IO;
using OO3.Lottery_Functionality;
using System.Collections.Generic;

namespace OO3.IO_Functionality
{
    public static class FileSaver
    {
        const string path = @"D:\Temp\";
        public static void SaveCouponTxt(IList<ICoupon> coupons)
        {
            Directory.CreateDirectory(path + $"{DateTime.Now.ToString("dd-M-yyyy-mm")}");

            for (int i = 0; i < coupons.Count; i++)
            {
                StreamWriter writer = new StreamWriter(path + $"{DateTime.Now.ToString("dd-M-yyyy-mm")}\\LotteryCoupon{i + 1:0#}.txt");

                writer.WriteLine(coupons[i]);
                writer.Close();
            }
        }
    }
}
