using System.Windows.Controls;


namespace DesktopApp.View.Screens.Books
{
    /// <summary>
    /// Interaction logic for BookDetailsPanel.xaml
    /// </summary>
    public partial class BookDetailsPanel : UserControl
    {
        public BookDetailsPanel( Models.BookModel selectedBookToDisplay )
        {
            InitializeComponent();
            DataContext = new ViewModels.BookDetailsPanelViewModel( selectedBookToDisplay );
        }
    }
}
