using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingModeExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            FAQ faq = new FAQ { Question = "Who do Tal looks like?" };
            InitializeComponent();
            BindingContext = faq;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            FAQ f = (FAQ)BindingContext;
            f.Answer = "STATIC";
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
