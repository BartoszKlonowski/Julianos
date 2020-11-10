using DesktopApp.ViewModels;
using System.Windows.Controls;


namespace DesktopApp.View.Screens
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = this;
            Login = new LoginViewModel();
        }

        public LoginViewModel Login
        { get; set; }
    }
}
