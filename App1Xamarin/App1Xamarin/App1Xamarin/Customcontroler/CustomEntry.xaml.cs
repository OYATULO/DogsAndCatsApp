using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Xamarin.Customcontroler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomEntry : Grid
	{
		public CustomEntry ()
		{
			InitializeComponent ();
		}
	}
}