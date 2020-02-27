using System.Configuration;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignDemo.Domain;

namespace MaterialDesignColors.WpfExample
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void GitHubButton_OnClick(object sender, RoutedEventArgs e)
        {
            Link.OpenInBrowser("https://github.com/pijnappel/Spectro-Nu-Designs");
        }

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
        {
            Link.OpenInBrowser("mailto://timo.pijnappel@ametek.com");
        }

      
    }
}
