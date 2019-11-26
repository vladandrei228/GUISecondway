using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUISecondway
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ContactList.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                Myframe.Navigate(typeof(Contact_List));
            }
            else if (ContactInfo.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                Myframe.Navigate(typeof(Contact_Info));
            }
            else if (ContactAdd.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                Myframe.Navigate(typeof(ContactAdd));
            }
            else if (Edit.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                Myframe.Navigate(typeof(Edit));
            }
            else if(Delete.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                Myframe.Navigate(typeof(Delete));
            }
            else if (Search.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                Myframe.Navigate(typeof(Search));
            }
            

        }


        private void BackButton_Click (object sender, RoutedEventArgs e)
        {
            if (Myframe.CanGoBack)
            {
                Myframe.GoBack();
                ContactList.IsSelected = true;
            }
        }
    }
}
