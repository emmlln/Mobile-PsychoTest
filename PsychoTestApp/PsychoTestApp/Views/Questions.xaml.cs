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
    public partial class Questions : ContentPage
    {
        //public string quest;
        //public string choice;

        public string quest
        {
            get { return quest; }
            set
            {
                if (quest != value)
                {
                    quest = value;
                    OnPropertyChanged("Вопрос");
                }
            }
        }

        public string choice
        {
            get { return choice; }
            set
            {
                if (choice != value)
                {
                    choice = value;
                    OnPropertyChanged("Вариант ответа");
                }
            }
        }

        public Questions()
        {
            InitializeComponent();
            this.BindingContext = new TestInfo();
            Title = "Назад";
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndTestInfo());
        }
    }
}