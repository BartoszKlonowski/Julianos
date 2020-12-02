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

            MinimizeButtonCommand = new Command( () => WindowState = WindowState.Minimized );
            CloseButtonCommand = new Command( () => Close() );

            DesktopApp.View.Screens.LoginWindow loginWindow = new View.Screens.LoginWindow();
            loginWindow.ShowDialog();
        }


        public ViewModels.LoginViewModel LoginScreen
        { get; set; }


        public Command MinimizeButtonCommand
        { get; set; }

        public Command CloseButtonCommand
        { get; set; }
    }
}
