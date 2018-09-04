using Prism.Navigation;
using Prism.Services;
using Weekend.Models;

namespace Weekend.ViewModels
{
	public class TripDetailPageViewModel : ViewModelBase
	{
		private Trip _trip;
		public Trip Trip
		{
			get { return _trip; }
			set { SetProperty(ref _trip, value); }
		}

		public TripDetailPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
			: base(navigationService)
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
			var trip = parameters["trip"] as Trip;
			Title = trip.Name;
			Trip = trip;
		}
	}
}
