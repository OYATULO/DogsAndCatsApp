using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1Xamarin.Services
{
	public interface IDogsModel<T>
	{
		Task<T> GetDogsById(int id);
		Task<IEnumerable<T>> GetAllDogsAsync(bool forceRefresh = false);
	}
}
