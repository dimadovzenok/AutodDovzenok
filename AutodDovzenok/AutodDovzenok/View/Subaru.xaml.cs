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
    public partial class Subaru : ContentPage
    {
        public Subaru()
        {
            InitializeComponent();
        }

        private void modelSubaru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelSubaru.Items[modelSubaru.SelectedIndex] == "Forester")
            {
                PhotosSubaru.Source = "forester.jpg";
            }
            else if (modelSubaru.Items[modelSubaru.SelectedIndex] == "Outback")
            {
                PhotosSubaru.Source = "outback.jpg";
            }
        }
    }
}