using System;
using System.Collections.ObjectModel;

namespace MauiPlay.Models
{
	/// <summary>
	/// Collection of products.
	/// </summary>
	public sealed class Products
	{
		/// <summary>
		/// Collection of products.
		/// </summary>
		public Products()
		{ }

		public ObservableCollection<Product> products { get; set; }
		public int total { get; set; }
		public int skip { get; set; }
		public int limit { get; set; }
	}
}

