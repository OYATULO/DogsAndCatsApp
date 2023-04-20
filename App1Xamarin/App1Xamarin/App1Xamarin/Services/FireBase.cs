using App1Xamarin.Models;
using App1Xamarin.Views;
using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1Xamarin.Services
{
    public  class FireBase
	{
		public readonly static string FirebaseUrl = "https://listusers-4c976-default-rtdb.firebaseio.com/";//from anydesk"https://mobileproject-e4c50-default-rtdb.firebaseio.com/";//"https://dotnetmaui-7a7bc-default-rtdb.firebaseio.com/";
		public readonly static string TokenFirebase = "sb96Bw7w6sjWUwrYeXRORpZamLMKdkkrLNjIDCN0";//from any "D8HgkBfGCxsEWwHAjyIyn7qL3sd1WlKzZzwcWPM4"; //"uXnpBI52g1G7U6mVA8yx5AEFj1QIy264svBXul4j";
		public readonly static FirebaseClient fc = new FirebaseClient(FirebaseUrl, new FirebaseOptions { AuthTokenAsyncFactory = () =>Task.FromResult(TokenFirebase) });
		public  string userKey { get; set; } = null;
		public static Login Logins { get; set; }

		public  FireBase() {

			//Destructor();
			
		}

		public static async Task<Login> GetLogin()
		{
			Logins =  JsonConvert.DeserializeObject<Login>(await fc.Child("Login").OnceAsJsonAsync());

			return Logins;
		}
		public async void Destructor()
		{
			await getUserList();
		}
		public static async Task<Users> getUser()
		{
			
		  return JsonConvert.DeserializeObject<Users>(await fc.Child("users").OnceAsJsonAsync());
		}
		public static async Task<Dictionary<string, NewUsers>> getUserList()
		{
			return JsonConvert.DeserializeObject<Dictionary<string,NewUsers>>(await fc.Child("Users").OnceAsJsonAsync());
		}

	}
}
