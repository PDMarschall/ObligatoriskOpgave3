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
using OO3.Lottery_Functionality.LotteryTypes.Ticket;

namespace OO3.WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StandardTicket coupon = new StandardTicket();
        public MainWindow()
        {
            InitializeComponent();            
            MiddleBlock.Text = coupon.ToString();
        }
    }
}
