using App1Xamarin.Models;
using App1Xamarin.Services;
using App1Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1Xamarin.ViewModels
{
	public class CatsViewModel : BaseViewModel
	{
		private ModelCats _modelCats;

		public CatsData catsData = new CatsData();


		public ObservableCollection<ModelCats> ItemCats { get; }

		public Command LoadCatsViewmodel { get; }
		public Command<ModelCats> ItemTapped { get; }

		public CatsViewModel()
		{
			Title = "Cats";
			ItemCats = new ObservableCollection<ModelCats>();
			LoadCatsViewmodel = new Command(async () => await ExecuteLoadItemsCommand()); ;
			ItemTapped = new Command<ModelCats>(OnItemSelected);
		}
		async Task ExecuteLoadItemsCommand()
		{
			IsBusy = true;

			try
			{
				ItemCats.Clear();

				var items = await catsData.GetAllCatsAsync(true);

				//var items = await CatsModel.GetAllCatsAsync(true);

				
				foreach (var item in items)
				{
					ItemCats.Add(item);
				}
			}
			catch (Exception)
			{
				Debug.WriteLine("errrorrrrr");
			}
			finally
			{
				IsBusy = false;
			}
		}

		public void OnAppearing()
		{
			IsBusy=true; 
			Selection = null;
		}

		public ModelCats Selection
		{
			get => _modelCats;
			set
			{
				SetProperty	(ref _modelCats, value);
				OnItemSelected(value);
			}
		}

		async void OnItemSelected(ModelCats item)
		{
			if (item == null)
				return;
			else
			{
				CatsDetailViewModel.modelCats = item;
				await Application.Current.MainPage.Navigation.PushAsync(new ItemDetailPage());
			}
			

		}
	}
}
