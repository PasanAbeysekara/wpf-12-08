using System.Windows;
using dec_eight.ViewModels;

namespace dec_eight.Views
{
    public partial class ModelBindingWindow : Window
    {
        public ModelBindingWindow()
        {
            DataContext = new ModelBindingVm();
            InitializeComponent();
        }
    }
}