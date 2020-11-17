namespace DesktopApp.Models
{
    public class UserSession
    {
        private UserSession()
        {
            userData = new UserModel();
        }


        public static UserSession Instance
        {
            get
            {
                if( instance is null )
                {
                    instance = new UserSession();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }


        public int ID
        {
            get => userData.ID;
            set
            {
                userData.ID = value;
            }
        }


        public string Login
        {
            get => userData.Login;
            set
            {
                userData.Login = value;
            }
        }


        public string Password
        {
            set
            {
                userData.Password = value;
            }
        }


        private UserModel userData;

        private static UserSession instance;
    }
}
