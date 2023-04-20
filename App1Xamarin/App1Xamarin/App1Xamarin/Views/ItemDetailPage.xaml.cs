using App1Xamarin.Models;
using App1Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
		public ModelCats _ModelCats { get; set; }
		public ItemDetailPage()
		{
			InitializeComponent();

			_ModelCats = CatsDetailViewModel.modelCats;
			BindingContext = _ModelCats;
		}

		private async void Button_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new BreadPage(_ModelCats)) ;
			
        }

		private async void Button_Clicked_1(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new FoodsPage(_ModelCats));
		}
	}
}