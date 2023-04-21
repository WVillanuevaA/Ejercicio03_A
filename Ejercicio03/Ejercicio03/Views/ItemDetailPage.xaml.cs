using System.ComponentModel;
using Ejercicio03.ViewModels;
using Xamarin.Forms;

namespace Ejercicio03.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}