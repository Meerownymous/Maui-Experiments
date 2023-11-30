using System;
namespace MauiPlay.Models
{
    /// <summary>
    /// Single Product.
    /// </summary>
	public sealed class Product
	{
        /// <summary>
        /// Single Product.
        /// </summary>
        public Product()
		{
			this.Title =
            this.Description =
            this.Brand =
            this.Category =
            this.Thumbnail = String.Empty;
            Images = new List<string>();
		}
		public int ID { get; set; }
		public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public double DiscountPecentage { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Thumbnail { get; set; }
        public IList<string> Images { get; set; }
    }
}

