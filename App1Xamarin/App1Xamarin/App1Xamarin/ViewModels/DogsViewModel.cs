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
	public class DogsViewModel:BaseViewModel
	{
		private ModelDogs _modelCats;

		public DogsData dogsData = new DogsData();


		public ObservableCollection<ModelDogs> ItemDogs { get; }

		public Command LoadDogsViewmodel { get; }
		public Command<ModelDogs> ItemTapped { get; }

		public DogsViewModel()
		{
			Title = "Cats";
			ItemDogs = new ObservableCollection<ModelDogs>();
			LoadDogsViewmodel = new Command(async () => await ExecuteLoadItemsCommand()); ;
			ItemTapped = new Command<ModelDogs>(OnItemSelected);
		}
		async Task ExecuteLoadItemsCommand()
		{
			IsBusy = true;

			try
			{
				ItemDogs.Clear();

				var items = await dogsData.GetAllDogsAsync(true);

				//var items = await CatsModel.GetAllCatsAsync(true);


				foreach (var item in items)
				{
					ItemDogs.Add(item);
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
			IsBusy = true;
			Selection = null;
		}

		public ModelDogs Selection
		{
			get => _modelCats;
			set
			{
				SetProperty(ref _modelCats, value);
				OnItemSelected(value);
			}
		}

		async void OnItemSelected(ModelDogs item)
		{
			if (item == null)
				return;
			else
			{
				DogsDetailviewModel.modelDogs = item;
				await Application.Current.MainPage.Navigation.PushAsync(new dogsdetailpage());
			}


			
			//await Shell.Current.GoToAsync($"{nameof(dogsdetailpage)}?{nameof(DogsDetailviewModel.ItemId)}={item.Id}");

		}
	}
}
