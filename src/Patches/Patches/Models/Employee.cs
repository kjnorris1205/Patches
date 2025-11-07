using System;

namespace Patches.Models;

public class Employee
{
    public string? Name { get; set; }
    public string? JobTitle { get; set; }
    public decimal PayRate { get; set; }
    public Paycheck[]? Paychecks { get; set; }
}
