using System.ComponentModel;
using PsychoTestApp.ViewModels;
using Xamarin.Forms;

namespace PsychoTestApp.Views
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