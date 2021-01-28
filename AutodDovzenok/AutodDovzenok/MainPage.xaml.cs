using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutodDovzenok
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MainPhoto.Source = ImageSource.FromFile("mainFoto.jpg");
            carList.ItemsSource = GetMenuItems();
            var homepage = typeof(View.buggati);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuItems()
        {
            var list = new List<MasterMenuItems>();

            list.Add(new MasterMenuItems()
            {
                Text = "Bugatti",
                Detail = "Все о Bugatti",
                ImagePath = "buggatiLogo.png",
                TargetPage = typeof(View.buggati)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Alfa Romeo",
                Detail = "Все о Alfa Romeo",
                ImagePath = "alfaromeoLogo.png",
                TargetPage = typeof(View.alfaRomeo)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Dodge",
                Detail = "Все о Dodge",
                ImagePath = "dodgeLogo.png",
                TargetPage = typeof(View.dodge)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Chevrolet",
                Detail = "Все о Chevrolet",
                ImagePath = "chevroletLogo.png",
                TargetPage = typeof(View.chevrolet)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mercedes-Benz",
                Detail = "Все о Mercedes-Benz",
                ImagePath = "mercedesLogo.png",
                TargetPage = typeof(View.mercedes)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volkswagen",
                Detail = "Все о Volkswagen",
                ImagePath = "VolkswagenLogo.png",
                TargetPage = typeof(View.Volkswagen)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Subaru",
                Detail = "Все о Subaru",
                ImagePath = "SubaruLogo.png",
                TargetPage = typeof(View.Subaru)
            });

            return list;
        }

        private void carList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = (MasterMenuItems)e.SelectedItem;
            Type selectedpage = selected.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
