using App1Xamarin.Models;
using App1Xamarin.Services;
using App1Xamarin.ViewModels;
using Firebase.Database.Query;
using Newtonsoft.Json;
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
	public partial class ressetPage : ContentPage
	{
		private string idlogin { get; set; }
		public NewUsers Users { get; set; }
		public ressetPage(string id)
		{
			InitializeComponent ();
			this.idlogin = id;	
		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			var list = await FireBase.getUserList();
			if (!string.IsNullOrEmpty(Password.Text))
			{
				if (Password.Text.Equals(CPassword.Text)) {

					var newList = list.Where(x=>x.Key.Equals(idlogin)).First();

					var json = JsonConvert.SerializeObject(new NewUsers {Email = newList.Value.Email, Username = newList.Value.Username, Password = Password.Text });
					
					await FireBase.fc.Child("Users").Child(idlogin).PutAsync(json);

					await DisplayAlert("Ok", "Password resset Succesfull", "ok");
					LoginSetting.DeleteFile();
					await Application.Current.MainPage.Navigation.PushAsync(new loginpage());
				}
				else
				{
					
					await DisplayAlert("Error", "Your password not equal to confirm passwod!", "ok");
				}
			}

			
			

			//await  Application.Current.MainPage.Navigation.PushAsync(new MainPage());
				 
		}
	}
}