namespace JoeResumeWebsite.Models;

public class ResumeData
{
    public ProfessionalProfile Profile { get; set; } = new();
    public List<Qualification> Qualifications { get; set; } = new();
    public List<Education> Education { get; set; } = new();
    public List<WorkExperience> WorkHistory { get; set; } = new();
    public MusicalJourney MusicalJourney { get; set; } = new();
    public List<NavigationSection> NavigationSections { get; set; } = new();
}

public class ProfessionalProfile
{
    public string Name { get; set; } = "Joseph R. Pottschmidt";
    public string? Title { get; set; }
    public string Phone { get; set; } = "(360) 831-7131";
    public string Email { get; set; } = "joe@joepottschmidt.com";
    public Address Address { get; set; } = new();
    public string Website { get; set; } = "https://www.joepottschmidt.com";
    public string? Summary { get; set; }
}

public class Address
{
    public string Street { get; set; } = "308 SW 1st. St Apt #3";
    public string City { get; set; } = "Battle Ground";
    public string State { get; set; } = "WA";
    public string ZipCode { get; set; } = "98604";
    
    public string FullAddress => $"{Street}, {City}, {State} {ZipCode}";
}

public class Qualification
{
    public string Category { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
    public string YearsExperience { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class WorkExperience
{
    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string EndDate { get; set; } = string.Empty;
    public List<string> Responsibilities { get; set; } = new();
    public string? Location { get; set; }
    
    public string DateRange => $"{StartDate} - {EndDate}";
    public bool IsCurrent => EndDate.Equals("Present", StringComparison.OrdinalIgnoreCase);
}

public class Education
{
    public string Institution { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public string? Location { get; set; }
    public List<string>? Details { get; set; }
}

public class MusicalJourney
{
    public string Title { get; set; } = "My Musical Journey";
    public List<MusicalSection> Sections { get; set; } = new();
    public bool IsPersonalSection { get; set; } = true;
}

public class MusicalSection
{
    public string SectionTitle { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Order { get; set; }
}

public class NavigationSection
{
    public string SectionId { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public int Order { get; set; }
    public bool IsMobileVisible { get; set; } = true;
    public string? Icon { get; set; }
}

public class ThemeConfiguration
{
    public string CurrentTheme { get; set; } = "light";
    public string DefaultTheme { get; set; } = "light";
    public string StorageKey { get; set; } = "resume-theme-preference";
    public string ThemeToggleLocation { get; set; } = "header";
}