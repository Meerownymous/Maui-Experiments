﻿using MauiPlay.Views;

namespace MauiPlay;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("ProductDetails", typeof(ProductDetails));
    }
}

