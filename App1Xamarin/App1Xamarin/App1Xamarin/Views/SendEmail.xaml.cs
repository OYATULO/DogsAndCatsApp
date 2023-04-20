using Android.Provider;
using App1Xamarin.Models;
using App1Xamarin.Services;
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
	public partial class SendEmail : ContentPage
	{
		private string Idlogin;
		public SendEmail (string key)
		{
			InitializeComponent ();
			Idlogin = key;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			try
			{


				//FireBase fireBase = new FireBase();

				var list =  await FireBase.getUserList();
				//var getLogin = LoginSetting.getlogin();


				if (string.IsNullOrWhiteSpace(Email.Text) != true )
				{
					if (list.Any(x => x.Key.Equals(Idlogin) && x.Value.Email.Equals(Email.Text)))
					{
						int code = 1234;
						await DisplayAlert("Verification", $"this {code} send to your Email {Email.Text}", "ok");
						await Application.Current.MainPage.Navigation.PushAsync(new AddCode(Idlogin, code));
					}
				}
				else
				{
					await DisplayAlert("Verification", $"not Enter email", "ok");
				}
					
				
			   
				
			}
			catch (Exception)
			{

				throw;
			}
		//	await Application.Current.MainPage.Navigation.PushAsync(new AddCode());
		}
	}
}