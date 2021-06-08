using System.Windows.Controls;


namespace DesktopApp.View.Screens
{
    /// <summary>
    /// Interaction logic for BooksScreen.xaml
    /// </summary>
    public partial class BooksScreen : UserControl
    {
        public BooksScreen()
        {
            InitializeComponent();
            DataContext = new ViewModels.BooksScreenViewModel();
        }
    }
}
