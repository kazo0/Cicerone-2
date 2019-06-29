using Cicerone.Views;
using Xamarin.Forms;

namespace Cicerone
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
