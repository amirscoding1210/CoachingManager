using CoachingCenterApp.Helpers;  // Your RelayCommand
using CoachingCenterApp.ViewModels;  // Your BaseViewModel
using System.Windows.Input;

namespace Coaching_Manager.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private bool _isSidebarCollapsed;
        public bool IsSidebarCollapsed
        {
            get => _isSidebarCollapsed;
            set
            {
                if (_isSidebarCollapsed != value)
                {
                    _isSidebarCollapsed = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ToggleSidebarCommand { get; }

        public MainViewModel()
        {
            ToggleSidebarCommand = new RelayCommand(_ => ToggleSidebar());
        }

        private void ToggleSidebar() => IsSidebarCollapsed = !IsSidebarCollapsed;
    }
}