using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Patches.Models;

namespace Patches.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<WorkDayViewModel> WorkDays { get; }
        = new ObservableCollection<WorkDayViewModel>();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddWorkDayCommand))]
    private DateTime _newWorkDayDate;

    private bool CanAddWorkDay() => WorkDays.Count < 7;

    [RelayCommand(CanExecute = nameof(CanAddWorkDay))]
    private void AddWorkDay()
    {
        WorkDays.Add(new WorkDayViewModel()
        {
            Date = NewWorkDayDate
        });

        NewWorkDayDate = new DateTime();
    }
    
    [RelayCommand]
    private void RemoveWorkDay(WorkDayViewModel workDay)
    {
        WorkDays.Remove(workDay);
    }
}
