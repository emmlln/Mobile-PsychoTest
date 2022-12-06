using System;
using System.Collections.Generic;
using System.ComponentModel;
using PsychoTestApp.Models;
using PsychoTestApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoTestApp.Views
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