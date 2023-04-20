using App1Xamarin.Services;
using App1Xamarin.ViewModels;
using App1Xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App1Xamarin
{
	public partial class AppShell : Shell
	{
		
		public  AppShell()
		{
			InitializeComponent();
			


			//	Shell.Current.GoToAsync("loginpage");
			//Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		}

	}
}
