﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Cicerone.Models;
using Cicerone.Views;
using Cicerone.Views.ViewModels;

namespace Cicerone.Views.Pages
{
	public partial class BeerSearchPage : ContentPage
	{
		BeerSearchViewModel viewModel;

		public BeerSearchPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new BeerSearchViewModel();
		}
	}
}