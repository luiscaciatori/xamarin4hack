using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin4HackApp
{
	public class MainPageAbstract : ContentPage
	{
		public MainPageAbstract()
		{
			Content = new StackLayout {
				Children = {
					new Xamarin.Forms.Label { Text = "INFORMAÇÕES" }
				}
			};
		}
	}
}
