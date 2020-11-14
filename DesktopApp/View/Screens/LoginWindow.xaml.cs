using System.Windows;


namespace DesktopApp.View.Screens
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new ViewModels.LoginViewModel();
        }
    }
}
