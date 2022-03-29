using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valg_Page : ContentPage
    {
        Frame box;
        Frame box2;
        Frame box3;
        Label lbl;
        Button ON;
        Button OFF;
        Label lbl2;
        Label lbl3;
        Label lbl4;
        bool bl = false;
        public Valg_Page()
        {
            lbl = new Label
            {
                Text = "Valgusfoor",
                FontSize = Device.GetNamedSize(NamedSize.Subtitle, typeof(Label))
            };
            lbl3 = new Label()
            {
                Text = "Punane"
            };
            box = new Frame()
            {
                Content = lbl3,
                BindingContext="Punane",
                BackgroundColor = Color.Gray,
                CornerRadius = 1000,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            lbl2 = new Label()
            {
                Text="Kollane"
            };
            box2 = new Frame()
            {
                Content = lbl2,
                BackgroundColor = Color.Gray,
                CornerRadius = 1000,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            lbl4 = new Label()
            {
                Text = "Roheline"
            };
            box3 = new Frame()
            {
                Content = lbl4,
                BackgroundColor = Color.Gray,
                CornerRadius = 1000,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            ON = new Button()
            {
                Text="Sisse"
                
            };
            ON.Clicked += ON_Clicked;
            OFF = new Button()
            {
                Text = "Välja"
            };
            OFF.Clicked += OFF_Clicked;
            StackLayout st = new StackLayout
            {
                Children = { lbl,box,box2,box3,ON,OFF }
            };
            Content = st;
        }

        private async void OFF_Clicked(object sender, EventArgs e)
        {
            bl = false;
            box.BackgroundColor = Color.Gray;
            box2.BackgroundColor = Color.Gray;
            box3.BackgroundColor = Color.Gray;
        }

        private async void ON_Clicked(object sender, EventArgs e)
        {
            bl = true;
            while(bl)
            {
                box.BackgroundColor = Color.Red;
                await Task.Delay(1000);
                box.BackgroundColor = Color.Gray;
                box2.BackgroundColor = Color.Yellow;
                await Task.Delay(1000);
                box2.BackgroundColor = Color.Gray;
                await Task.Delay(1000);
                box3.BackgroundColor = Color.Green;
                await Task.Delay(1000);
                box3.BackgroundColor = Color.Gray;
                await Task.Delay(1000);
                box3.BackgroundColor = Color.Green;
                await Task.Delay(1000);
                box3.BackgroundColor = Color.Gray;
                await Task.Delay(1000);
                box3.BackgroundColor = Color.Green;
                await Task.Delay(1000);
                box3.BackgroundColor = Color.Gray;
                await Task.Delay(1000);

            }


        }
    }
}