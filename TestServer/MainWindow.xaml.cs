using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using LotteryMachineService;




namespace TestServer
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceHost serviceHost;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            serviceHost = new ServiceHost(typeof(MemberService));
            serviceHost.Open();
            StartButton.IsEnabled = false;
            EndButton.IsEnabled = true;
            ServerStatusLabel.Content = "Server is working";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            serviceHost.Close();
            EndButton.IsEnabled = false;
            StartButton.IsEnabled = true;
            ServerStatusLabel.Content = "";
        }
    }
}
