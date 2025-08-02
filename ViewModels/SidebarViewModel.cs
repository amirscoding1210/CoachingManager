using Coaching_Manager.ViewModels;
using CoachingCenterApp.Helpers;
using CoachingCenterApp.Services;
using CoachingCenterApp.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Collections.ObjectModel;
using System.Windows.Input;
using YourNamespace.Views.Students;

namespace Coaching_Manager.ViewModels
{
    public class SidebarViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public ObservableCollection<SidebarItem> MenuItems { get; }

        public SidebarViewModel(INavigationService navService)
        {
            _navigationService = navService;

            MenuItems = new ObservableCollection<SidebarItem>
            {
                new SidebarItem {
                    Title = "Dashboard",
                    Icon = PackIconKind.ViewDashboard,
                    Command = new RelayCommand((_) => navService.NavigateTo<DashboardViewModel>())
                },
                new SidebarItem {
                    Title = "Students",
                    Icon = PackIconKind.AccountGroup,
                    Children = new ObservableCollection<SidebarItem>
                    {
                        new SidebarItem {
                            Title = "All Students",
                            Command = new RelayCommand((_) => navService.NavigateTo<StudentListPage>())
                        },
                        new SidebarItem {
                            Title = "Add New Student",
                            Command = new RelayCommand((_) => navService.NavigateTo<StudentEditPage>())
                        }
                    }
                }
            };
        }
    }
}