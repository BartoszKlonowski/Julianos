using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;


namespace DesktopApp.ViewModels
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        public NavigationViewModel()
        {
            ToolsViewCommand = new Command.Command( SwitchToToolsView );
        }

        private void SwitchToToolsView()
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


        public ViewModels.Command.Command ToolsViewCommand
        { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        private UserControl appContent;
    }
}
