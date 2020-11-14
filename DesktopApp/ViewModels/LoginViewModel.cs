using DesktopApp.DAL;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Runtime.CompilerServices;


namespace DesktopApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            LoginCommand = new ViewModels.Command.Command( Login );
            RegisterCommand = new ViewModels.Command.Command( Register );
            CloseButtonCommand = new ViewModels.Command.Command( Shutdown );
        }


        public string LoginText
        {
            get => loginText;
            set
            {
                loginText = value;
                OnPropertyChanged();
            }
        }

        public string PasswordText
        {
            get => passwordText;
            set
            {
                passwordText = value;
                OnPropertyChanged();
            }
        }


        private void Login()
        {
            DatabaseContext dbContext = new DatabaseContext();
            if( dbContext.Users.Any( user => user.Login == loginText && user.Password == passwordText ) )
            {
                ClearCredentialTextBoxes();
            }
            else
            {
                MessageBox.Show( "No such user exists - please check your credentials" );
                ClearCredentialTextBoxes();
            }
        }


        private void Register()
        {
            var dbContext = new DatabaseContext();
            if( dbContext.Users.Any( user => user.Login == loginText ) )
            {
                MessageBox.Show( $"User with login {loginText} already exists" );
            }
            else
            {
                AddNewUser();
            }
        }


        private void Shutdown()
        {
            Application.Current.Shutdown();
        }


        private void ClearCredentialTextBoxes()
        {
            LoginText = "";
            PasswordText = "";
        }


        private void AddNewUser()
        {
            var dbContext = new DatabaseContext();
            dbContext.Users.Add( new Models.UserModel() { Login = loginText, Password = passwordText } );
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show( "User correctly registered!" );
            }
            catch( Exception e )
            {
                MessageBox.Show( e.Message );
            }
            finally
            {
                ClearCredentialTextBoxes();
            }
        }


        public ViewModels.Command.Command LoginCommand
        { get; }

        public ViewModels.Command.Command RegisterCommand
        { get; }

        public ViewModels.Command.Command CloseButtonCommand
        { get; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );


        private string loginText;
        private string passwordText;
    }
}
