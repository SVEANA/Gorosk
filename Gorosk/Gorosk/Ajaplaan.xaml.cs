using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gorosk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajaplaan : ContentPage
    {
        public Ajaplaan() //мои мечты
        {
            string[] tas = new string[] { "Утро", "Завтрак", "Прогулка", "Чашка кофе!", "Книжка", "Обед", "Грядка", "Готовка", "Ужин", "Разговоры", "Душ", "Сон" };

            ListView list = new ListView();
            list.ItemsSource = tas;
            Content = new StackLayout { Children = { list } };
            list.ItemSelected += List_ItemSelected;
            

        }
        string vremja;

        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)
                {
                    vremja = "6:00";
                }
                else if (e.SelectedItemIndex == 1)
                {
                    vremja = "7:00";
                }
                else if (e.SelectedItemIndex == 2)
                {
                    vremja = "8:00";

                }

                else if (e.SelectedItemIndex == 3)
                {
                    vremja = "10:00";

                }

                else if (e.SelectedItemIndex == 4)
                {
                    vremja = "14:00";

                }

                else if (e.SelectedItemIndex == 5)
                {
                    vremja = "15:00";

                }

                else if (e.SelectedItemIndex == 6)
                {
                    vremja = "17:00";

                }
                else if (e.SelectedItemIndex == 7)
                {
                    vremja = "18:00";

                }

                else if (e.SelectedItemIndex == 8)
                {
                    vremja = "19:00";
                }
                else if (e.SelectedItemIndex == 9)
                {
                    vremja = "20:00";

                }

                else if (e.SelectedItemIndex == 10)
                {
                    vremja = "21:00";
                }
                else if (e.SelectedItemIndex == 11)
                {
                    vremja = "22:00";

                }

                else if (e.SelectedItemIndex == 12)
                {
                    vremja = "23:00";
                }
                await DisplayAlert(vremja, text, "Хорошо");
            }
        }
    }
}