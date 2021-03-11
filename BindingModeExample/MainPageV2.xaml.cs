using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingModeExample
{
    public partial class MainPageV2 : ContentPage
    {
        public MainPageV2()
        {
            FAQ1 faq = new FAQ1 { Question = "Who do Tal looks like?" };
            InitializeComponent();
            BindingContext = faq;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            FAQ1 f = (FAQ1)BindingContext;
            f.Answer = "STATIC";
        }

        

        private  async void Button_MOVE_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
