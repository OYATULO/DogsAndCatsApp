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
	public partial class FoodsPage : ContentPage
	{
		public FoodsPage (ModelCats modelCats)
		{
			InitializeComponent ();

			this.BindingContext = modelCats;
		}
	}
}