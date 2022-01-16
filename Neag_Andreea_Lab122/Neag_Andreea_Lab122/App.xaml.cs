using Neag_Andreea_Lab122.Services;
using Neag_Andreea_Lab122.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Neag_Andreea_Lab122.Data;

namespace Neag_Andreea_Lab122
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
           Database = new ShoppingListDatabase(new RestService());
           MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
