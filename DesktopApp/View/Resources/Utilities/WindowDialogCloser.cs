using System.Windows;


namespace DesktopApp.View.Resources.Utilities
{
    /// <summary>
    /// Implementation of DialogResult as a DependencyProperty so it can be directly bound between the View and ViewModel
    /// Full credits goes to the author of this implementation: Joe White
    /// Please see the full article about this idea and implementation: https://blog.excastle.com/2010/07/25/mvvm-and-dialogresult-with-no-code-behind/
    /// </summary>
    public static class WindowDialogCloser
    {
        public static readonly DependencyProperty DialogResultProperty =
            DependencyProperty.RegisterAttached(
                "DialogResult",
                typeof( bool? ),
                typeof( WindowDialogCloser ),
                new PropertyMetadata( DialogResultChanged ) );


        private static void DialogResultChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e )
        {
            var window = d as Window;
            if( window != null )
                window.DialogResult = e.NewValue as bool?;
        }


        public static void SetDialogResult( Window target, bool? value )
        {
            target.SetValue( DialogResultProperty, value );
        }
    }
}
