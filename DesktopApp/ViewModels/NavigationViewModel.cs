using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;


namespace DesktopApp.ViewModels
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        public NavigationViewModel()
        {
            View1 = new Command.Command( SetView1 );
            View2 = new Command.Command( SetView2 );
        }


        private void SetView1()
        {
            AppContent = new View.Screens.AppContent();
        }

        private void SetView2()
        {
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

        public ViewModels.Command.Command View1
        { get; }

        public ViewModels.Command.Command View2
        { get; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        private UserControl appContent;
    }
}
