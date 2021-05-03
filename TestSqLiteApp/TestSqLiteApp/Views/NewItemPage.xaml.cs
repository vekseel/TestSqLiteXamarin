using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestSqLiteApp.Models;
using TestSqLiteApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSqLiteApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}