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
    public partial class RGB : ContentPage
    {

        Label lb1, lb2, lb3;
        BoxView bv;
        Frame fr;
        Slider sld1, sld2, sld3;
        public RGB()
        {
            bv = new BoxView
            {
                BackgroundColor = Color.Black
            };
            lb1 = new Label
            {
                TextColor = Color.Black,
                FontSize = 18,
                FontFamily = "Arial",
                Text = "Red",
                HorizontalOptions = LayoutOptions.Center,
            };
            sld1 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 30,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Blue

            };
            lb1 = new Label
            {
                TextColor = Color.Black,
                FontSize = 18,
                FontFamily = "Arial",
                Text = "Red " + Convert.ToInt32(sld1.Value).ToString(),
                HorizontalOptions = LayoutOptions.Center,
            };

            sld2 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 30,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Blue

            };
            lb2 = new Label
            {
                TextColor = Color.Black,
                FontSize = 18,
                FontFamily = "Arial",
                Text = "Green " + Convert.ToInt32(sld2.Value).ToString(),
                HorizontalOptions = LayoutOptions.Center,
            };
            sld3 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 30,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,

                ThumbColor = Color.Blue

            };

            lb3 = new Label
            {
                TextColor = Color.Black,
                FontSize = 18,
                FontFamily = "Comic Sans MS",
                Text = "Blue " + Convert.ToInt32(sld3.Value).ToString(),
                HorizontalOptions = LayoutOptions.Center,
            };
            fr = new Frame
            {
                Content = bv,
                BorderColor = Color.White,
                CornerRadius = 20,
                VerticalOptions = LayoutOptions.FillAndExpand

            };
            sld1.ValueChanged += Sld1_ValueChanged;
            sld2.ValueChanged += Sld1_ValueChanged;
            sld3.ValueChanged += Sld1_ValueChanged;
            TapGestureRecognizer tap = new TapGestureRecognizer();
            bv.GestureRecognizers.Add(tap);
            tap.Tapped += Tap_Tapped;
            
            StackLayout st = new StackLayout
            {
                Children = { fr, sld1, lb1, sld2, lb2, sld3, lb3}
            };
            Content = st;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Random r = new Random();
            sld1.Value = r.NextDouble() * 225;
            sld2.Value = r.NextDouble() * 225;
            sld3.Value = r.NextDouble() * 225;

            bv.Color = Color.FromRgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 225));
        }

        private void Sld1_ValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (sender == sld1)
            {
                lb1.Text = String.Format("Red = {0:X2}", (int)args.NewValue);
            }
            else if (sender == sld2)
            {
                lb2.Text = String.Format("Green = {0:X2}", (int)args.NewValue);

            }
            else if (sender == sld3)
            {
                lb3.Text = String.Format("Blue = {0:X2}", (int)args.NewValue);
            }
            bv.Color = Color.FromRgb((int)sld1.Value, (int)sld2.Value, (int)sld3.Value);
        }
    }
}