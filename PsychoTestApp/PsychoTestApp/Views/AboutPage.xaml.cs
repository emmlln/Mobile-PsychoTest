using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace PsychoTestApp.Views

{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        //Grid grid = new Grid { };

        //TapGestureRecognizer tap = new TapGestureRecognizer { NumberOfTapsRequired = 1 };

        //tap.Tapped += Navigation;
        //grid.GestureRecognizer.Add(tap);



        private async void OnTestClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestInfo());
        }
    }
}