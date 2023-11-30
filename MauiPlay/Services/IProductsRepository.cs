
using System;
using System.Collections.ObjectModel;
using MauiPlay.Models;

namespace MauiPlay.Services
{
	/// <summary>
	/// Source of products.
	/// </summary>
	public interface IProductRepository
	{
		Task<ObservableCollection<Product>> LoadProducts();
	}
}

