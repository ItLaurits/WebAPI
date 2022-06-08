using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WeatherWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient client = APIHelper.ProvideClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task getWeather(object sender, RoutedEventArgs e)
        {
            var res = await WeatherAPI.getWeather(client, "");
            Console.WriteLine(res);
        }
    }
}
