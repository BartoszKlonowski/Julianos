using DesktopApp.ViewModels.Command;
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
            InitializeComponent();
            DataContext = this;

            DesktopApp.View.Screens.LoginWindow loginWindow = new View.Screens.LoginWindow();
            loginWindow.ShowDialog();
        }


        private void MinimizeIconClicked( object sender, RoutedEventArgs e )
        {
            WindowState = WindowState.Minimized;
        }


        public ViewModels.LoginViewModel LoginScreen
        { get; set; }


        public Command CloseButtonCommand
        { get; set; }
    }
}
