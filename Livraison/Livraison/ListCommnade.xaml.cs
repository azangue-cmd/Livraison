using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Livraison
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCommnade : ContentPage
    {
        public ListCommnade()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}