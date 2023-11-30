using System;
using System.Collections.ObjectModel;
using MauiPlay.Services;

namespace MauiPlay.Models
{
	/// <summary>
	/// All products from a remote source.
	/// </summary>
	public sealed class AllProducts
	{
		public ObservableCollection<Product> Products { get; set; } =
			new ObservableCollection<Product>();

        readonly IProductRepository ProductsRepository =
			new ProductsService();

		public AllProducts()
		{
			LoadProducts();
		}

		public async void LoadProducts()
		{
			ObservableCollection<Product> temp =
				await ProductsRepository.LoadProducts();

			for(int i=0;i<temp.Count;i++)
			{
				Products.Add(temp[i]);
			}
		}
	}
}

