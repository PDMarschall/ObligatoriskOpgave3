using System.Collections.Generic;
using System.Windows;
using OO3.Lottery_Functionality;
using OO3.IO_Functionality;

namespace OO3.WPF_UI
{
    public partial class MainWindow : Window
    {
        IList<ICoupon> coupons;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdClick_NewTicket(object sender, RoutedEventArgs e)
        {
            GenerateTickets(CouponTypeBox.Text);
        }

        private void cmdClick_Save(object sender, RoutedEventArgs e)
        {
            if (coupons != null)
                FileSaver.SaveCouponTxt(coupons);
        }

        public void GenerateTickets(string ticketType)
        {
            MiddleBlock.Text = "";
            coupons = new ICoupon[CouponAmountBox.SelectedIndex + 1];

            for (int i = 0; i < CouponAmountBox.SelectedIndex + 1; i++)
            {
                coupons[i] = CouponFactory.GetCoupon(ticketType);
            }

            foreach (ICoupon coupon in coupons)
            {
                MiddleBlock.Text += coupon;
            }
        }
    }
}
