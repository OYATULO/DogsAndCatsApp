using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App1Xamarin.Services
{
	public interface ICatsModel<T>
	{
		Task<T> GetCatsById(int id);
		Task<IEnumerable<T>> GetAllCatsAsync(bool forceRefresh = false);
	}
}
