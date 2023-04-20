using App1Xamarin.Models;
using App1Xamarin.Services;
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
	public partial class AddCode : ContentPage
	{
		private string  idlogin { get; set; } 
		private int code { get; set; }
		public AddCode (string id,int code)
		{
			InitializeComponent ();
			this.idlogin = id;
			this.code = code;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			try
			{
				int newcode = Convert.ToInt32(string.Concat(txt1.Text, txt2.Text, txt3.Text, txt4.Text));

				

				if (newcode == code)
				{
					await Application.Current.MainPage.Navigation.PushAsync(new ressetPage(idlogin));
				}
				else {
					await DisplayAlert("Error", "Verification code incorrect !","ok");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}

		private void txt1_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (txt1.Text!="") {
				txt2.Focus();
			}
		}

		private void txt2_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (txt2.Text != "")
			{
				txt3.Focus();
			}
			if (string.IsNullOrEmpty(txt2.Text))
			{
				txt1.Focus();
			}
		}

		private void txt3_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (txt3.Text != "")
			{
				txt4.Focus();
			}
			if (string.IsNullOrEmpty(txt3.Text))
			{
				txt2.Focus();
			}
		}

		private void txt4_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(string.IsNullOrEmpty(txt4.Text))
			{
				txt3.Focus();
			}
		}
	}
}