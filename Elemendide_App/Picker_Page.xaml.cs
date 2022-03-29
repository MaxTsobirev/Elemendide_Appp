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
    public partial class Picker_Page : ContentPage
    {
        Picker picker;
        private Picker Picker;
        WebView webView;
        StackLayout st;
        string[] lehed = new string[1] { "tahvel.edu.ee" };
        public Picker_Page()
        {
            Picker = new Picker
            {
                Title = "Webilehed"
            };
            picker.Items.Add("TAhvel");
        }
    }
}