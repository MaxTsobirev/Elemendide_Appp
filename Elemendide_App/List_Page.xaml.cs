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
    public partial class List_Page : ContentPage
    {
        public List<Telefon> Telefons { get; set; }
        //public int List_ItemSelected { get; }

        ListView list;
        public List_Page()
        {
            Telefons = new List<Telefon>
            {
                new Telefon {Nimetus="iPhone 13 PRO Max",Tootja="Apple",Hind="1299"},
                new Telefon {Nimetus="iPhone 12 PRO",Tootja="Apple",Hind="1199"},
                new Telefon {Nimetus="iPhone 11 ",Tootja="Apple",Hind="699"},
                new Telefon {Nimetus="iPhone 22 PRO Max  Compact Mega Super Ultra Slim 4k 50TB 99LVL ",Tootja="Apple",Hind="1000000"},
            };
            list = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Telefons,
                ItemTemplate = new DataTemplate(() =>
                  {
                      Label nimetus = new Label { FontSize = 20 };
                      nimetus.SetBinding(Label.TextProperty, "Nimetus");

                      Label tootja = new Label();
                      tootja.SetBinding(Label.TextProperty, "Tootja");

                      Label hind = new Label();
                      hind.SetBinding(Label.TextProperty, "Hind");

                      return new ViewCell
                      {
                          View = new StackLayout
                          {
                              Padding = new Thickness(0, 5),
                              Orientation = StackOrientation.Vertical,
                              Children = { nimetus, tootja, hind }
                          }
                      };
                  })
            };
            this.Content = new StackLayout { Children = { list } };
        }

        
    }
}