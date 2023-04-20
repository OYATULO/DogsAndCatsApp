using App1Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1Xamarin.Services
{
	public class DogsData:IDogsModel<ModelDogs>
	{
		readonly List<ModelDogs> listCats;

		public DogsData()
		{
			listCats = new List<ModelDogs>() {
				new ModelDogs {Id =1,Title="dog1",Image="dog1",
					ListBreads= new List<Breads> {
						new Breads{Images="dog1",Title="New breads for this",Reiting ="1"},
						new Breads{Images="dog1",Title="New breads for this",Reiting ="1"},
						new Breads{Images="dog1",Title="New breads for this",Reiting ="1"},
					}
				},

			};
		}


		public async Task<IEnumerable<ModelDogs>> GetAllDogsAsync(bool forceRefresh = false)
		{
			return await Task.FromResult(listCats);
		}

		public async Task<ModelDogs> GetDogsById(int id)
		{
			return await Task.FromResult(listCats.FirstOrDefault(x => x.Id == id));

		}
	}
}
