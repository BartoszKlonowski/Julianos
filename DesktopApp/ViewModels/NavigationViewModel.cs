using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;


namespace DesktopApp.ViewModels
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        public NavigationViewModel()
        {
            SwitchToBooksScreenCommand = new Command.Command( () => AppContent = new View.Screens.BooksScreen() );
        }


        public UserControl AppContent
        {
            get => appContent;
            set
            {
                appContent = value;
                OnPropertyChanged();
            }
        }


        public Command.Command SwitchToBooksScreenCommand
        { get; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        private UserControl appContent;
    }
}
