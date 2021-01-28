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
    public partial class chevrolet : ContentPage
    {
        public chevrolet()
        {
            InitializeComponent();
        }

        private void modelChevrolet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelChevrolet.Items[modelChevrolet.SelectedIndex] == "Chevrolet Camaro")
            {
                PhotosChevrolet.Source = "chevroletCamaro.jpg";
            }
            else if (modelChevrolet.Items[modelChevrolet.SelectedIndex] == "Chevrolet Corvette")
            {
                PhotosChevrolet.Source = "chevroletCorvette.jpg";
            }
        }
    }
}