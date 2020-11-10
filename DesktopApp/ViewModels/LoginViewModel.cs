using System.ComponentModel;
using System.Windows.Input;


namespace DesktopApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            LoginButtonCommand = new Command.Command( Login );
        }

        public event PropertyChangedEventHandler PropertyChanged = ( sender, e ) => { };


        public void OnPropertyChanged( string name )
        {
            PropertyChanged( this, new PropertyChangedEventArgs( name ) );
        }


        public void Login()
        {
        }


        public void Logout()
        {
        }


        public void Register()
        {
        }

        public Command.Command LoginButtonCommand
        { get; }
    }
}
