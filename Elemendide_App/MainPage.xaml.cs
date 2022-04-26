using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            var scroll = new ScrollView();
            Content = scroll;

            /*Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.LightGreen,
            };*/

            /*Button Timer_btn = new Button()
            {
                Text = "Timer",
                BackgroundColor = Color.LightGreen,
            };
            Button cliker = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.LightGreen,
            };
            Button Date_btn = new Button()
            {
                Text = "Date/Time",
                BackgroundColor = Color.LightGreen,
            };
            Button SS_btn = new Button()
            {
                Text = "Stepper/Slider",
                BackgroundColor = Color.LightGreen,
            };*/
            Button Frame_btn = new Button()
            {
                Text = "Frame",
                BackgroundColor = Color.LightGreen,
            };
            Button Image_btn = new Button()
            {
                Text = "Image",
                BackgroundColor = Color.LightGreen,
            };
            Button Valg_btn = new Button()
            {
                Text = "Valgusfoor",
                BackgroundColor = Color.LightGreen,
            };
            Button RGB_btn = new Button()
            {
                Text = "RGB",
                BackgroundColor = Color.LightGreen,
            };
            Button TTT_btn = new Button()
            {
                Text = "TicTacToe",
                BackgroundColor = Color.LightGreen,
            };
            Button Cnt_btn = new Button()
            {
                Text = "CntPage",
                BackgroundColor = Color.LightGreen,
            };
            Button Maak_btn = new Button()
            {
                Text = "Maakonnad",
                BackgroundColor = Color.LightGreen,
            };
            Button List_btn = new Button()
            {
                Text = "ListView",
                BackgroundColor = Color.LightGreen,
            };
            StackLayout st = new StackLayout()
            {
                Children = { /*Ent_btn , Timer_btn , cliker , Date_btn , SS_btn,*/Frame_btn,Image_btn,Valg_btn,RGB_btn,TTT_btn,Cnt_btn,Maak_btn,List_btn }
            };

            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            //Ent_btn.Clicked += Ent_btn_Clicked;
            //Timer_btn.Clicked += Timer_btn_Clicked;
            //cliker.Clicked += Cliker_Clicked;
            //Date_btn.Clicked += Date_btn_Clicked;
            //SS_btn.Clicked += SS_btn_Clicked;
            Frame_btn.Clicked += Frame_btn_Clicked;
            Image_btn.Clicked += Image_btn_Clicked;
            Valg_btn.Clicked += Valg_btn_Clicked;
            RGB_btn.Clicked += RGB_btn_Clicked;
            TTT_btn.Clicked += TTT_btn_Clicked;
            Cnt_btn.Clicked += Cnt_btn_Clicked;
            Maak_btn.Clicked += Maak_btn_Clicked;
            List_btn.Clicked += List_btn_Clicked;
            
        }

        private async void List_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new List_Page());
        }

        private async void Maak_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maakond_page());
        }

        private async void Cnt_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CntPage());
        }

        private async void RGB_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RGB());
        }

        private async void TTT_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TTT_Page());
        }

        private async void Valg_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valg_Page());
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_Page());
        }

        private async void Frame_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }

        /*private async void SS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_page());
        }*/

        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Date_Time());
        }

        private async void Cliker_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new cliker());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ent_page());
        }
    }
    
}
