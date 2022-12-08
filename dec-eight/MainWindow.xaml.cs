using System.Windows;
using dec_eight.Views;

namespace dec_eight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new ElementBindingWindow();
            window.Show();
        }
    }
}