using System;
using System.Collections.Generic;

namespace June2026.EFCoreAssignmentDB.AppDbContextModels;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? City { get; set; }

    public string? Major { get; set; }

    public decimal? Gpa { get; set; }
}
