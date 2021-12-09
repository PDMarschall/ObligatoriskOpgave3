using System.Windows;
using OO3.Lottery_Functionality;

namespace OO3.WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerateTickets("Joker");
        }

        private void cmdClick_NewTicket(object sender, RoutedEventArgs e)
        {
            GenerateTickets("Joker");
        }

        public void GenerateTickets(string ticketType)
        {
            ICoupon ticket = CouponFactory.GetCoupon(ticketType);
            MiddleBlock.Text = ticket.ToString();
        }
    }
}
