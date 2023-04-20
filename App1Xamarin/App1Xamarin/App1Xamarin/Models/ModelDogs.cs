using System;
using System.Collections.Generic;
using System.Text;

namespace App1Xamarin.Models
{
	public class ModelDogs
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }

		public List<Breads> ListBreads { get; set; }
	}


}
