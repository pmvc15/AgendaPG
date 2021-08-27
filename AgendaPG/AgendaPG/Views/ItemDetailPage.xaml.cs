using AgendaPG.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AgendaPG.Views
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