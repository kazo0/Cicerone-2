using Cicerone.Views;
using Xamarin.Forms;

namespace Cicerone.Views.Pages
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute("beerDetails", typeof(BeerDetailsPage));
		}
	}
}
