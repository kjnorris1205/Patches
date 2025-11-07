using System;

namespace Patches.Models;

public class WorkDay
{
    public DateTime Date { get; set; }
    public TimeSpan TimeIn { get; set; }
    public TimeSpan TimeOut { get; set; }
    public TimeSpan LunchStart { get; set; }
    public TimeSpan LunchStop { get; set; }
}
