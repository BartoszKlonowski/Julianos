using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace DesktopApp.View.Resources.Utilities
{
    static class ContentControlExtensions
    {
        public static readonly DependencyProperty ContentChangedAnimationProperty = DependencyProperty.RegisterAttached
        (
            "ContentChangedAnimation", typeof( Storyboard ), typeof( ContentControlExtensions ), new PropertyMetadata( default( Storyboard ), ContentChangedAnimationPropertyChangedCallback )
        );


        public static void SetContentChangedAnimation( DependencyObject element, Storyboard value )
        {
            element.SetValue( ContentChangedAnimationProperty, value );
        }


        public static Storyboard GetContentChangedAnimation( DependencyObject element )
        {
            return (Storyboard)element.GetValue( ContentChangedAnimationProperty );
        }


        private static void ContentChangedAnimationPropertyChangedCallback( DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs )
        {
            if( dependencyObject is ContentControl contentControl )
            {
                var propertyDescriptor = DependencyPropertyDescriptor.FromProperty( ContentControl.ContentProperty, typeof( ContentControl ) );
                propertyDescriptor.AddValueChanged( contentControl, ContentChangedHandler );
            }
            else
                throw new Exception( "Can only be applied to a ContentControl" );
        }


        private static void ContentChangedHandler( object sender, EventArgs eventArgs ) => GetContentChangedAnimation( sender as FrameworkElement ).Begin( sender as FrameworkElement );
    }
}
