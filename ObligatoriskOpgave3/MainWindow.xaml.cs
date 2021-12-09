using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OO3.Lottery_Functionality.Coupon.Standard;
using OO3.Lottery_Functionality.Coupon.Joker;
using OO3.Lottery_Functionality.Coupon;

namespace OO3.WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LotteryCoupon coupon = new LotteryCoupon();
        public MainWindow()
        {
            InitializeComponent();            
            testblock.Text = coupon.ToString();
        }
    }
}
