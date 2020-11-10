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
            LoginScreen = new ViewModels.LoginViewModel();
            CloseButtonCommand = new Command( Close );
            DataContext = this;
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
