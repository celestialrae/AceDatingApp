using AceDatingApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AceDatingApp.Views
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