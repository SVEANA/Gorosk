using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gorosk
{
    public partial class MainPage : ContentPage
    {
        Button Gor_btn, Aja_btn;
        // List<horosk> horosks;
        // string[] horoskTit;
        public MainPage()
        {
            Button Gor_btn = new Button
            {
                Text = "ГОРОСКОП",
                BackgroundColor = Color.Plum
            };
            Button Aja_btn = new Button
            {
                Text = "РАСПИСАНИЕ",
                BackgroundColor = Color.Coral
            };
            // horosks = horosk.Gethorosks();
            StackLayout st = new StackLayout
            {
                Children = { Gor_btn, Aja_btn, }
            };
            st.BackgroundColor = Color.Aqua;
            Content = st;
            Gor_btn.Clicked += Gor_btn_Clicked;
            Aja_btn.Clicked += Aja_btn_Clicked;
        }

        private async void Aja_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ajaplaan());
        }

        private async void Gor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GOROS());
        }
    }
}
