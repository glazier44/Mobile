using Prism.Commands;
using Prism.Navigation;

namespace MobileApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
            _navigationService = navigationService;
        }

        public DelegateCommand NavigateToSpeakPageCommand { get; private set; }
        private void NavigateToSpeakPage()
        {
            _navigationService.NavigateAsync("Settings");
        }
    }
}
