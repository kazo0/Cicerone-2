﻿using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Cicerone.Views.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "About";

			OpenWebCommand = new Command(() => Launcher.OpenAsync("https://xamarin.com/platform"));
		}

		public ICommand OpenWebCommand { get; }
	}
}