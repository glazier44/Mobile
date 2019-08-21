using Prism.Navigation;

namespace MobileApp.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public SettingsViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Settigns";
        }
    }
}
