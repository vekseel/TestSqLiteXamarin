using System.ComponentModel;
using TestSqLiteApp.ViewModels;
using Xamarin.Forms;

namespace TestSqLiteApp.Views
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