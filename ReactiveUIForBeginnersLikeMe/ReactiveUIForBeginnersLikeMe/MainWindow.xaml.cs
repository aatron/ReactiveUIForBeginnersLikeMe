using MahApps.Metro.Controls;

using ReactiveUIForBeginnersLikeMe.ViewModel;

namespace ReactiveUIForBeginnersLikeMe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
