using System;
using System.Windows.Input;


namespace DesktopApp.ViewModels.Command
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged = ( sender, e ) => { };


        public Command( Action action )
        {
            actionToExecute = action;
        }


        public bool CanExecute( object parameter ) => true;


        public void Execute( object parameter )
        {
            actionToExecute();
        }


        private Action actionToExecute;
    }
}
