
using App1Xamarin.Models;
using App1Xamarin.Services;
using App1Xamarin.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Javax.Security.Auth.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class loginpage : ContentPage
	{
		
		private Users LocalUsers;
		//public  readonly static string TokenFirebase = "4Y8lEvDFjQuYKcFo285FWE0xs9VUb6MaR0dtUeyg";
		Login newlogin = new Login();
		public loginpage()
		{
			InitializeComponent();
			Setting();

		}
		public async void Setting()
		{
			if (!File.Exists(LoginSetting.getFolder()))
				return;
			else
			{
				var data = LoginSetting.getlogin();
				if (!string.IsNullOrEmpty(data.idlogin))
					await Shell.Current.GoToAsync($"//{nameof(MainPage)}?idlogin={data.idlogin}", true);
			}


		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			
			try
			{
				//LocalUsers = await FireBase.getUser();

				var data = await FireBase.getUserList();

				if (string.IsNullOrEmpty(email.Text) && string.IsNullOrEmpty(password.Text))
				{
					await DisplayAlert("No enter !", "hello", "ok");
				}
				else
				{
					if (data.Any(x => x.Value.Email.Equals(email.Text) && x.Value.Password.Equals(password.Text)))
					{
						var  newitems = data.Where(x => x.Value.Email.Equals(email.Text) && x.Value.Password.Equals(password.Text));
						//save to json files
						foreach (var item in newitems)
						{
							newlogin.idlogin = item.Key;
							newlogin.email = item.Value.Email;
							newlogin.username= item.Value.Username;
						}

						//File.Create(LoginSetting.getFolder());
						if (File.Exists(LoginSetting.getFolder()))
							LoginSetting.DeleteFile();
						else
							 LoginSetting.AfterCraeteFile(newlogin);

						await Shell.Current.GoToAsync($"//{nameof(MainPage)}?idlogin={newlogin.idlogin}", true);
					}
					else
						await DisplayAlert("Error", "Email or password are not equal", "ok");
				}

				//await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
			}
			catch (Exception ex)
			{
				await DisplayAlert(ex.Message, "Error", "ok");
			}

        }

		private async void Update(object sender ,EventArgs e)
		{
		
			var json = JsonConvert.SerializeObject(new Users { Id=LocalUsers.Id,Username=LocalUsers.Username, Email = email.Text,Password=password.Text});
			await FireBase.fc.Child("users").PutAsync(json);
		}

	}




	

}