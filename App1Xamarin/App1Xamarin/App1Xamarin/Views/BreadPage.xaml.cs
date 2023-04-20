using App1Xamarin.Models;
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
	public partial class BreadPage : ContentPage
	{
		public BreadPage (ModelCats modelCats)
		{
			InitializeComponent ();
			this.BindingContext = modelCats;
			//Reset();
		}

		void Reset()
		{
			/*ChangeTextColor(5, Color.Gray);*/
		}

		void ChangeTextColor(int starcount, Color color)
		{
			/*for (int i = 1; i <= starcount; i++)
			{
				(FindByName($"star{i}") as Label).TextColor = color;
			}*/
		}
		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			/*Reset();
			Label clicked = sender as Label;
			ChangeTextColor(Convert.ToInt32(clicked.StyleId.Substring(4, 1)), Color.Yellow);*/
		}
	}
}