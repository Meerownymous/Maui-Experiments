using System.ComponentModel;
using MauiPlay.Models;

namespace MauiPlay.Views;

[QueryProperty(nameof(Product), "product")]
public partial class ProductDetails : ContentPage, IQueryAttributable, INotifyPropertyChanged
{
	public Product product { get; private set; }

	public ProductDetails()
	{
		InitializeComponent();
		BindingContext = this;
		Console.WriteLine($"product inside details:{product}BINDINGCONTEXT::{BindingContext}");
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
		product = query["product"] as Product;
		OnPropertyChanged("product");
    }
}
