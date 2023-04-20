using App1Xamarin.Models;
using App1Xamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage, IQueryAttributable
	{
		public string idlogin { get; set; }
		//FireBase fireBase = new FireBase();

		public void ApplyQueryAttributes(IDictionary<string, string> query)
		{
			idlogin = HttpUtility.UrlEncode(query["idlogin"]);
		}
		public MainPage()
		{
			//FireBase fireBase = new FireBase();
			InitializeComponent();
			/*if (fireBase.userKey == null)
			{
				Shell.Current.GoToAsync($"//{nameof(loginpage)}");
			}*/


			//this.BindingContext = users();

		}

		/*public async Task<NewUsers> users()
		{
			var data = await FireBase.getUserList();

			var newlist = data.Where(x=>x.Key.Equals(idlogin)).First();


			return new NewUsers { Username = newlist.Value.Username,Email=newlist.Value.Email,Password=null} ;
		}*/

		private async void OpenAccssesories(object sender, EventArgs e)
		{   
			await Application.Current.MainPage.Navigation.PushAsync(new AccssesoiesPage());
			//await Navigation.PushModalAsync(new AccssesoiesPage());
		}
		private async void ressetBnt(object sender,EventArgs e)
		{
			await Application.Current.MainPage.Navigation.PushAsync(new SendEmail(idlogin));
		}

		
	}
}