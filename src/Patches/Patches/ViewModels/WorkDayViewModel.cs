using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Patches.Models;

namespace Patches.ViewModels;

public partial class WorkDayViewModel : ViewModelBase
{
    [ObservableProperty]
    private DateTime _date;

    [ObservableProperty]
    private TimeSpan _timeIn;

    [ObservableProperty]
    private TimeSpan _timeOut;

    [ObservableProperty]
    private TimeSpan _lunchStart;

    [ObservableProperty]
    private TimeSpan _lunchStop;

    public WorkDayViewModel()
    {
        // empty
    }

    public WorkDayViewModel(WorkDay workDay)
    {
        Date = workDay.Date;
        TimeIn = workDay.TimeIn;
        TimeOut = workDay.TimeOut;
        LunchStart = workDay.LunchStart;
        LunchStop = workDay.LunchStop;
    }

    public WorkDay GetWorkDay()
    {
        return new WorkDay()
        {
            Date = this.Date,
            TimeIn = this.TimeIn,
            TimeOut = this.TimeOut,
            LunchStart = this.LunchStart,
            LunchStop = this.LunchStop
        };
    }
}
