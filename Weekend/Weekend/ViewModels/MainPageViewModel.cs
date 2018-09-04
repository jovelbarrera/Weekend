using Prism.Navigation;

namespace Weekend.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public static INavigationService NavigationService;

		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Weekend";
			NavigationService = navigationService;
		}
	}
}
