﻿using System;
using Xamarin.Forms;

namespace TextStylesDemo
{
    public partial class MainNavigationPage : ContentPage
    {
        public MainNavigationPage()
        {
            InitializeComponent();
        }

        private async void ShowStyles(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StylesListPage());
        }

        private async void ShowSizes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextSizeListPage());
        }

        private async void ShowAttributes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AttributesListPage());
        }
    }
}
