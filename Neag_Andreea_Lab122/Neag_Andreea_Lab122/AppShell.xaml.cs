using Neag_Andreea_Lab122.ViewModels;
using Neag_Andreea_Lab122.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Neag_Andreea_Lab122
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
