// Models/SidebarItem.cs
using CoachingCenterApp.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Collections.ObjectModel;
using System.Windows.Input;

public class SidebarItem : BaseViewModel
{
    public string Title { get; set; } = string.Empty;
    public PackIconKind Icon { get; set; }
    public ICommand Command { get; set; } = null!; 
    public ObservableCollection<SidebarItem> Children { get; set; } = new();
    public bool IsExpanded { get; set; }
    public bool IsSelected { get; set; }
}