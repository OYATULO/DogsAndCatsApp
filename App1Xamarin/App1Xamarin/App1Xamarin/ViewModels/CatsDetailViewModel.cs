using App1Xamarin.Models;
using App1Xamarin.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace App1Xamarin.ViewModels
{
	//[QueryProperty(nameof(ItemId),nameof(ItemId))]
	public class CatsDetailViewModel
	{
	 	public static ModelCats modelCats { get; set; }

		public CatsDetailViewModel(ModelCats _modelCats)
		{
			modelCats = _modelCats;
		}

	


		/*private int Id { get; set; }


		public string Title
		{
			get => title;
			set => SetProperty(ref title, value);
		}
		public string Image
		{
			get => image;
			set => SetProperty(ref image, value);
		}

		public int ItemId
		{
			get { return itemId; } set { itemId = value; loadItemID(value); }
		}

		public async void loadItemID(int itemId)
		{
			try
			{
				var item = await data.GetCatsById(itemId);
				Id = item.Id;
				title = item.Title;
				image = item.Image;	
			}
			catch (Exception)
			{
				Debug.WriteLine("Failed to load Item");
			}
		}*/

	}
}
