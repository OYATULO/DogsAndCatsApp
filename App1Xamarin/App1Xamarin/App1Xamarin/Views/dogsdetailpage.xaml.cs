using App1Xamarin.Models;
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
	public partial class dogsdetailpage : ContentPage
	{
		//public ModelCats _ModelDogs { get; set; }
		
		public dogsdetailpage()
		{
			InitializeComponent();
			BindingContext = DogsDetailviewModel.modelDogs;
		}
		private  void Button_Clicked(object sender, System.EventArgs e)
		{
			Console.WriteLine("ok");
		//	await Navigation.PushAsync(new BreadPage(_ModelDogs));

		}
	}
}