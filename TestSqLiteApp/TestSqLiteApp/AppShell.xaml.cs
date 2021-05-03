using System;
using System.Collections.Generic;
using TestSqLiteApp.ViewModels;
using TestSqLiteApp.Views;
using Xamarin.Forms;

namespace TestSqLiteApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
