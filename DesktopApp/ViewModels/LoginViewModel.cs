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
            var user = dbContext.Users.Where( user => user.Login == loginText && user.Password == passwordText ).FirstOrDefault();
            if( user is null )
            {
                MessageBox.Show( "No such user exists - please check your credentials" );
                ClearCredentialTextBoxes();
            }
            else
            {
                InitUserSessionDataWithLoggedInUser( user );
                ClearCredentialTextBoxes();
                DialogResult = true;
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


        private void InitUserSessionDataWithLoggedInUser( Models.UserModel loggedInUser )
        {
            var userSession = Models.UserSession.Instance;
            userSession.ID = loggedInUser.ID;
            userSession.Login = loggedInUser.Login;
            userSession.Password = loggedInUser.Password;
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


        public bool? DialogResult
        {
            get => dialogResult;
            set
            {
                dialogResult = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( [CallerMemberName] string name = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( name ) );

        private bool? dialogResult;

        private string loginText;
        private string passwordText;
    }
}
