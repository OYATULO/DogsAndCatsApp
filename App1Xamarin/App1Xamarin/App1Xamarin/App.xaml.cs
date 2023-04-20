using App1Xamarin.Services;
using App1Xamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			//DependencyService.Register<CatsData>();
			//DependencyService.Register<DogsData>();
			MainPage =  new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
