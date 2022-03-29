using AudioPlayEx;
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
    public partial class TTT_Page : ContentPage
    {

        Grid grid2X1, grid3X3;
        Image b;
        Button uus_mang;
        public bool esimene;
        int tulemus = -1;
        int[,] Tulemused = new int[3, 3];
        private Button pravila;
        private object positions;

        public TTT_Page()
        {
            DependencyService.Get<IAudio>().PlayAudioFile("lift.mp3");
            grid2X1 = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                RowDefinitions =
                {

                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                },
                ColumnDefinitions =
                {

                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
            };

            Uus_mang();
            uus_mang = new Button()
            {
                Text = "Uus mäng"
            };
            grid2X1.Children.Add(uus_mang, 0, 1);
            uus_mang.Clicked += Uus_mang_Clicked;

            pravila = new Button()
            {
                Text = "Määrused"
            };
            grid2X1.Children.Add(pravila, 0, 2);
            pravila.Clicked += Pravila_Clicked;

            Content = grid2X1;
        }

        private async void Pravila_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Määrused", "Mängijad panevad kordamööda väljaku vabadele lahtritele 3×3 märke. Võidab see, kes seab esimesena 3 tükki vertikaalselt, horisontaalselt või diagonaalselt ritta. Esimese käigu teeb mängija, kes paneb ristid.", "OK");
        }

        public async void Kes_on_esimene()
        {
            string esimene_valik = await DisplayPromptAsync("Kes on esimene?", "Tee valiku Rist-1 või Null-2", initialValue: "1", maxLength: 1, keyboard: Keyboard.Numeric);
            if (esimene_valik=="1")
            {
                esimene = true;
            }
            else
            {
                esimene = false;
            }
        }
        private void Uus_mang_Clicked(object sender, EventArgs e)
        { 
            Uus_mang();
        }
        
        public async void Uus_mang()
        {
            bool uus =await DisplayAlert("Uus mäng", "Kas tõesti tahad uus mäng?", "Tahan küll!", "Ei taha!");
            if (uus)
            {
                Kes_on_esimene();
                Tulemused = new int[3, 3];
                tulemus = 0;
                grid3X3 = new Grid
                {
                    BackgroundColor = Color.Black,
                    RowDefinitions =
                {

                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                    ColumnDefinitions =
                {
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }

                }
                };
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        b = new Image { BackgroundColor = Color.White };
                        grid3X3.Children.Add(b, j, i);
                        TapGestureRecognizer tap = new TapGestureRecognizer();
                        tap.Tapped += Tap_Tapped;
                        b.GestureRecognizers.Add(tap);
                    }
                }
                grid2X1.Children.Add(grid3X3, 0, 0);
            }
            
        }       

        
        public int Kontroll()
        {
            if (Tulemused[0,0]==1 && Tulemused[1,0]==1 && Tulemused[2,0]==1 || Tulemused[0, 1] == 1 && Tulemused[1, 1] == 1 && Tulemused[2, 1] == 1 || Tulemused[0, 2] == 1 && Tulemused[1, 2] == 1 && Tulemused[2, 2] == 1)
            {
                tulemus = 1;
            }
            else if (Tulemused[0, 0] == 1 && Tulemused[0, 1] == 1 && Tulemused[0,2] == 1 || Tulemused[1, 0] == 1 && Tulemused[1, 1] == 1 && Tulemused[1, 2] == 1 || Tulemused[2, 0] == 1 && Tulemused[2, 1] == 1 && Tulemused[2, 2] == 1)
            {
                tulemus = 1;
            }
            else if (Tulemused[0, 0] == 1 && Tulemused[1, 1] == 1 && Tulemused[2, 2] == 1 || Tulemused[0, 2] == 1 && Tulemused[1, 1] == 1 && Tulemused[2, 0] == 1)
            {
                tulemus = 1;
            }
            else if (Tulemused[0, 0] == 2 && Tulemused[1, 0] == 2 && Tulemused[2, 0] == 2 || Tulemused[0, 1] == 2 && Tulemused[1, 1] == 2 && Tulemused[2, 1] == 2 || Tulemused[0, 2] == 2 && Tulemused[1, 2] == 2 && Tulemused[2, 2] == 2)
            {
                tulemus = 2;
            }
            else if (Tulemused[0, 0] == 2 && Tulemused[0, 1] == 2 && Tulemused[0, 2] == 2 || Tulemused[1, 0] == 2 && Tulemused[1, 1] == 2 && Tulemused[1, 2] == 2 || Tulemused[2, 0] == 2 && Tulemused[2, 1] == 2 && Tulemused[2, 2] == 2)
            {
                tulemus = 2;
            }
            else if (Tulemused[0, 0] == 2 && Tulemused[1, 1] == 2 && Tulemused[2, 2] == 2 || Tulemused[0, 2] == 2 && Tulemused[1, 1] == 2 && Tulemused[2, 0] == 2)
            {
                tulemus = 2;
            }
            else if (checkTie())
            {
                tulemus = 3;
            }
            return tulemus;
        }
        private bool checkTie()
        {
            for (int i = 0; i < Tulemused.GetLength(0); i++)
            {
                for (int j = 0; j < Tulemused.GetLength(1); j++)
                {
                    if (Tulemused[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void Lopp()
        {
            tulemus = Kontroll();
            if (tulemus==1)
            {
                DisplayAlert("Võit", "Esimine on võitja!","Ok");
            }
            else if (tulemus==2)
            {
                DisplayAlert("Võit", "Teine on võitja!", "Ok");
            }
            else if (tulemus == 3)
            {
                DisplayAlert("Draw", "Draw", "Ok");
                uus_mang.IsEnabled = true;
            }
        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
            var b = (Image)sender;
            var r = Grid.GetRow(b);
            var c = Grid.GetColumn(b);
            if (esimene==true)
            {
                b = new Image { Source=ImageSource.FromFile("krest.png") };
                esimene = false;
                Tulemused[r, c] = 1;
            }
            else
            {
                b = new Image { Source = ImageSource.FromFile("nol.png") };
                esimene = true;
                Tulemused[r, c] = 2;
            }
            grid3X3.Children.Add(b,c,r);
            Lopp();

        }
    }
}