using Coaching_Manager.ViewModels;
using System.Windows;

namespace Coaching_Manager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); // Initialize ViewModel
        }
    }
}