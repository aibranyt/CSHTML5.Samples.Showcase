﻿using PreviewOnWinRT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CSHTML5.Samples.Showcase
{
    public partial class ChildWindow_Demo : UserControl
    {
        public ChildWindow_Demo()
        {
            this.InitializeComponent();
        }


        private void ButtonTestChildWindow_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWnd = new LoginWindow();
            loginWnd.Closed += new EventHandler(loginWnd_Closed);
            loginWnd.Show();
        }

        void loginWnd_Closed(object sender, EventArgs e)
        {
            LoginWindow lw = (LoginWindow)sender;
            if (lw.DialogResult == true && lw.NameBox.Text != string.Empty)
            {
                this.TextBlockForTestingChildWindow.Text = "Hello " + lw.NameBox.Text;
            }
            else if (lw.DialogResult == false)
            {
                this.TextBlockForTestingChildWindow.Text = "Login canceled.";
            }
        }
    }
}