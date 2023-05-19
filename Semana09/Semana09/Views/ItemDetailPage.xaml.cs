using System.ComponentModel;
using Semana09.ViewModels;
using Xamarin.Forms;

namespace Semana09.Views
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