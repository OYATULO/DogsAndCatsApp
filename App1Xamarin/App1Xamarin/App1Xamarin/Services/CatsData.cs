using App1Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1Xamarin.Services
{
	public class CatsData : ICatsModel<ModelCats>
	{
		readonly List<ModelCats> listCats;

		public CatsData()
		{
			listCats = new List<ModelCats>() {
				new ModelCats {
					Id =1,Title="cat1",Image="cat1",
					ListBreads= new List<Breads> {
						new Breads{Images="cat1",Title="New breads for this",Reiting ="1"},
						new Breads{Images="cat1",Title="New breads for this",Reiting ="1"},
						new Breads{Images="cat1",Title="New breads for this",Reiting ="1"},
					},
					ListFoods = new List<Foods>
					{
						new Foods{Image="cat1",Name="food 1"},
						new Foods{Image="cat1",Name="food 1"},
						new Foods{Image="cat1",Name="food 1"},
						new Foods{Image="cat1",Name="food 1"},
						new Foods{Image="cat1",Name="food 1"},
						new Foods{Image="cat1",Name="food 1"},
					}
				},
				
			}; 
		}


		public async Task<IEnumerable<ModelCats>> GetAllCatsAsync(bool forceRefresh = false)
		{
			return await Task.FromResult(listCats);
		}

		public async Task<ModelCats> GetCatsById(int id)
		{
			return await Task.FromResult(listCats.FirstOrDefault(x => x.Id == id));

		}
	}
}
