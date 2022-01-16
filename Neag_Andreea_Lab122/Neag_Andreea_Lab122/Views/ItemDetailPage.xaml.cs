using Neag_Andreea_Lab122.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Neag_Andreea_Lab122.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}