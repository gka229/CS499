﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UKSmartParking
{
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent(); 
        }

        async void Handle_Activated(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Rules());

        }
    }
}
