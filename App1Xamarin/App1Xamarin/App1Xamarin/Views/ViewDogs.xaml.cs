using App1Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewDogs : ContentPage
	{
		DogsViewModel _viewModel;

		public ViewDogs()
		{
			InitializeComponent();
			BindingContext = _viewModel = new DogsViewModel(); 
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.OnAppearing();
		}
	}
}