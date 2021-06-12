using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;


namespace DesktopApp.ViewModels
{
    public class BooksScreenViewModel : INotifyPropertyChanged
    {
        public BooksScreenViewModel()
        {
        }

        public System.Collections.Generic.List<Models.BookModel> BooksList
        {
            get => new DAL.DatabaseContext().Books.ToList();
        }

        public UserControl BooksPanel
        {
            get => booksPanel;
            set
            {
                booksPanel = value;
                OnPropertyChanged();
            }
        }

        public int SelectedBookIndex
        {
            get => selectedBookIndex;
            set
            {
                selectedBookIndex = value;
                BooksPanel = new View.Screens.Books.BookDetailsPanel( BooksList[value] );
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        private UserControl booksPanel;
        private int selectedBookIndex;
    }
}
