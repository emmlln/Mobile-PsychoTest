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
    public partial class EndTestInfo : ContentPage
    {
        public EndTestInfo()
        {
            InitializeComponent();
            this.BindingContext = new Questions();
        }


    }
}