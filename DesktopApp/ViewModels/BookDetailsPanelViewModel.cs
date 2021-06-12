using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Windows.Media;

namespace DesktopApp.ViewModels
{
    public class BookDetailsPanelViewModel : INotifyPropertyChanged
    {
        public BookDetailsPanelViewModel( Models.BookModel selectedBookToDisplay )
        {
            selectedBook = selectedBookToDisplay;
        }


        public string BookTitle
        {
            get => selectedBook.Name;
            set
            {
                OnPropertyChanged();
            }
        }

        public string BookAuthor
        {
            get => selectedBook.Author;
            set
            {
                OnPropertyChanged();
            }
        }

        public string BookUrl
        {
            get => selectedBook.Url;
            set
            {
                OnPropertyChanged();
            }
        }

        public string BookImageSource
        {
            get => selectedBook.Image;
            set
            {
                OnPropertyChanged();
            }
        }

        public string BookRating
        {
            get => $"{selectedBook.Rating} / 5";
            set
            {
                OnPropertyChanged();
            }
        }

        public Brush RatingColor
        {
            get => selectedBook.RatingColor;
        }

        public string BookPrize
        {
            get => $"{selectedBook.Prize/10} zł {selectedBook.Prize % 100} gr";
            set
            {
                OnPropertyChanged();
            }
        }

        public DateTime BookBuyDate
        {
            get => selectedBook.BuyingDate;
            set
            {
                OnPropertyChanged();
            }
        }

        public Command.Command SwitchToBooksScreenCommand
        { get; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );


        private Models.BookModel selectedBook;
    }
}
