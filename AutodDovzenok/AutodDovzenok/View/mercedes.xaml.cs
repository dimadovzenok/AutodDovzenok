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
    public partial class mercedes : ContentPage
    {
        public mercedes()
        {
            InitializeComponent();
        }

        private void modelMercedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelMercedes.Items[modelMercedes.SelectedIndex] == "Mercedes-AMG GT 4")
            {
                PhotosMercedes.Source = "Mercedes-AMGGT4.jpg";
            }
            else if (modelMercedes.Items[modelMercedes.SelectedIndex] == "CLS купе")
            {
                PhotosMercedes.Source = "CLSkupeMercedes.jpg";
            }
        }
    }
}