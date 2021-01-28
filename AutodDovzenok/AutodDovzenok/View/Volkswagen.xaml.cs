using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutodDovzenok.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Volkswagen : ContentPage
    {
        public Volkswagen()
        {
            InitializeComponent();
        }

        private void modelVolkswagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelVolkswagen.Items[modelVolkswagen.SelectedIndex] == "Passat")
            {
                PhotosVolkswagen.Source = "passat.jpg";
            }
            else if (modelVolkswagen.Items[modelVolkswagen.SelectedIndex] == "T-Roc")
            {
                PhotosVolkswagen.Source = "t-roc.jpg";
            }
        }
    }
}