using App1Xamarin.Models;
using App1Xamarin.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace App1Xamarin.ViewModels
{
	public class LoginSetting
	{
			public static Login getlogin()
			{

						using (StreamReader st = new StreamReader(getFolder()))
						{
							var json = st.ReadToEnd();
							var items = JsonConvert.DeserializeObject<Login>(json);
							return items;
						}
			}

			public static void UpdateLogin(Login login)
			{
				using (StreamWriter sw = new StreamWriter(getFolder()))
				{	

					var items = JsonConvert.SerializeObject(login);
				
				}
			}

		public static void AfterCraeteFile(Login login)
		{

			using (FileStream fs = new FileStream(getFolder(),FileMode.CreateNew))
			{
				using (StreamWriter sw = new StreamWriter(fs))
				{
					var items = JsonConvert.SerializeObject(login);

					sw.WriteLine(items);
					sw.Close();
				}
			}

			
				
			//File.WriteAllText(getFolder(), items);
		
		}

		public static void DeleteFile()
		{
			if (File.Exists(getFolder()))
			{
				File.Delete(getFolder());
			}
		}

		public static string  getFolder()
		{
			/*var assembly = typeof(loginpage).GetTypeInfo().Assembly;
			Stream str = assembly.GetManifestResourceStream("App1Xamarin.login.json");
			Path.GetFullPath(Environment.CurrentDirectory);*/

			string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "login.json");

			return filepath;
		}
	}
}
