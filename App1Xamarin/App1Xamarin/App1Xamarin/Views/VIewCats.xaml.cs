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
	public partial class VIewCats : ContentPage
	{

		CatsViewModel _viewModel;
		public VIewCats()
		{
			InitializeComponent();

			BindingContext = _viewModel= new CatsViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.OnAppearing();
		}
	}
}