using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List_Page : ContentPage
    {
        public ObservableCollection<Country> Countrys { get; set; }
        Label lbl_list;
        ListView List;
        Button lisa, kustuta;
        Entry en;
        public List_Page()
        {
            Countrys = new ObservableCollection<Country>
            {
                new Country {Nimetus="Eesti", Stolica="Tallinn",Naselenie="1.3m", Pilt="iphone12.jpg"},
                new Country {Nimetus="Sweden", Stolica="Stockholm",Naselenie="10.3m", Pilt="iphone11.png"}
            };
            lbl_list = new Label
            {
                Text = "Riikide loetelu",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            List = new ListView
            {
                SeparatorColor = Color.AliceBlue,
                Header = "Riik",
                Footer = DateTime.Now.ToString("T"),

                HasUnevenRows = true,
                ItemsSource = Countrys,
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell { TextColor = Color.Black, DetailColor = Color.Black };
                    imageCell.SetBinding(ImageCell.TextProperty, "Strana");
                    Binding companyBinding = new Binding { Path = "Stolica", StringFormat = " {0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, companyBinding);
                    Binding a = new Binding { Path = "Naselenie", StringFormat = "Naselenie: {0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, a);
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "Pilt");
                    return imageCell;

                })
            };
            lisa = new Button { Text = "Lisa riik" };
            kustuta = new Button { Text = "Kustuta riik" };
            List.ItemTapped += List_ItemTapped;
            kustuta.Clicked += Kustuta_Clicked;
            lisa.Clicked += Lisa_Clicked;
            this.Content = new StackLayout { Children = { lbl_list, List, lisa, kustuta } };
        }
        public List<string> Uris;

        private async void Lisa_Clicked(object sender, EventArgs e)
        {

            string site = await DisplayPromptAsync("Dobavit stranu", "Kirjuta", keyboard: Keyboard.Text);

            string site2 = await DisplayPromptAsync("Stolica?", "Kirjuta", keyboard: Keyboard.Text);

            string site3 = await DisplayPromptAsync("Naselenie?", "Kirjuta", keyboard: Keyboard.Numeric);

            string site4 = await DisplayPromptAsync("Flag?", "Kirjuta", keyboard: Keyboard.Text);

            Countrys.Add(item: new Country { Nimetus = site, Stolica = site2, Naselenie = site3, Pilt = site4 });

        }

        private void Kustuta_Clicked(object sender, EventArgs e)
        {
            Country country = List.SelectedItem as Country;
            if (country != null)
            {
                Countrys.Remove(country);
                List.SelectedItem = null;
            }
        }

        private async void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Country selectedPhone = e.Item as Country;
            if (selectedPhone != null)
                await DisplayAlert("Riik", $"{selectedPhone.Stolica}-{selectedPhone.Nimetus}", "OK");
        }


    }
}