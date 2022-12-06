using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestInfo : ContentPage
    {
        public TestInfo()
        {
            InitializeComponent();
            this.BindingContext = new AboutPage();
            Title = "Назад";
        }

        private async void OnQuestionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Questions());
        }

    }
}