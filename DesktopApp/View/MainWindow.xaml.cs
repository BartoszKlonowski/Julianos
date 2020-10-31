using System.Windows;


namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new ViewModels.LoginViewModel();
            InitializeComponent();
        }


        private void MinimizeIconClicked( object sender, RoutedEventArgs e )
        {
            WindowState = WindowState.Minimized;
        }


        private void CloseIconClicked( object sender, RoutedEventArgs e )
        {
            Close();
        }
    }
}
