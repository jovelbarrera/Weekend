using Weekend.Models;
using Xamarin.Forms;

namespace Weekend.Views
{
	public partial class TripsPage : ContentPage
	{
		public TripsPage()
		{
			InitializeComponent();
		}

		private void ListViewItemTapped(object sender, ItemTappedEventArgs e)
		{
			//Hack for non selected menu-item
			if (e.Item == null)
				return;

			((ListView)sender).SelectedItem = null;
		}
	}
}

