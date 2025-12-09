using JoeResumeWebsite.Models;

namespace JoeResumeWebsite.Services;

public interface IResumeContentService
{
    ResumeData GetResumeData();
}

public class ResumeContentService : IResumeContentService
{
    public ResumeData GetResumeData()
    {
        return new ResumeData
        {
            Profile = GetProfessionalProfile(),
            Qualifications = GetQualifications(),
            Education = GetEducation(),
            WorkHistory = GetWorkHistory(),
            MusicalJourney = GetMusicalJourney(),
            NavigationSections = GetNavigationSections()
        };
    }

    private ProfessionalProfile GetProfessionalProfile()
    {
        return new ProfessionalProfile
        {
            Name = "Joseph R. Pottschmidt",
            Phone = "(360) 831-7131",
            Email = "joe@joepottschmidt.com",
            Website = "https://www.joepottschmidt.com",
            Address = new Address
            {
                Street = "308 SW 1st. St Apt #3",
                City = "Battle Ground",
                State = "WA",
                ZipCode = "98604"
            },
            Headshot = new HeadshotInfo
            {
                ImagePath = "/images/headshot.png", // Set to "/images/your-headshot.jpg" when you add your photo
                AltText = "Joseph R. Pottschmidt - Professional Headshot",
                PlaceholderText = "Professional Photo",
                ShowPlaceholder = false, // Set to false when you have an actual image
                ImageTitle = "Joseph R. Pottschmidt"
            }
        };
    }

    private List<Qualification> GetQualifications()
    {
        return new List<Qualification>
        {
            new Qualification
            {
                Category = "Microsoft Office",
                Skills = new List<string> { "Access", "Excel", "Outlook", "Word", "PowerPoint", "Visio" },
                YearsExperience = "25+ years",
                Description = "Advanced proficiency in all Microsoft Office applications with extensive experience in database design, spreadsheet automation, and presentation development."
            },
            new Qualification
            {
                Category = ".NET Development",
                Skills = new List<string> { "Visual Studio IDE","C#", "VB.NET", "Windows Services", "ASP.NET Web Forms", "ASP.NET MVC", "WPF", "WinForms", "LINQ" , "RESTful APIs", "Blazor"},
                YearsExperience = "15 years",
                Description = "Comprehensive experience in .NET ecosystem from desktop applications to web services and enterprise solutions."
            },
            new Qualification
            {
                Category = "Database Technologies",
                Skills = new List<string> { "SQL Server", "Oracle","SSRS", "T-SQL", "Database Design", "Performance Optimization", "Entity Framework" },
                YearsExperience = "15 years",
                Description = "Expert-level database development and reporting with focus on performance optimization and complex query design."
            },
            new Qualification
            {
                Category = "Business Intelligence",
                Skills = new List<string> { "Power BI", "SSRS", "Data Visualization", "Report Design", "Dashboard Development" },
                YearsExperience = "8 years",
                Description = "Specialized in creating compelling data visualizations and interactive dashboards for business decision-making."
            },
            new Qualification
            {
                Category = "Professional Music",
                Skills = new List<string> { "Piano Performance", "Music Theory", "Live Performance", "Studio Recording", "Music Arrangement", "Singer" },
                YearsExperience = "35+ years",
                Description = "Professional pianist with extensive performance experience across genres including classical, jazz, contemporary, and worship music."
            }
        };
    }

    private List<Education> GetEducation()
    {
        return new List<Education>
        {
            new Education
            {
                Institution = "ITT Technical Institute",
                Degree = "AA in Electronic Engineering Technology",
                Year = "1986",
                Location = "Seattle, WA"
            }
        };
    }

    private List<WorkExperience> GetWorkHistory()
    {
        return new List<WorkExperience>
        {
            new WorkExperience
            {
                Company = "Panther Systems Northwest, LLC",
                Position = "Software Developer / Report Designer",
                StartDate = "1/1/2020",
                EndDate = "Present",
                Location = "Vancouver, WA",
                Responsibilities = new List<string>
                {
                    "Design and develop reports using SSRS for business intelligence and operational reporting",
                    "Design and develop reports using Power BI for executive dashboards and data visualization",
                    "Create and maintain C# applications for data processing and business automation",
                    "Develop VB.NET solutions for legacy system integration and modernization",
                    "Design and implement SQL Server databases with optimized performance and scalability",
                    "Build Windows Services for automated data processing and system integration",
                    "Collaborate with stakeholders to gather requirements and deliver technical solutions",
                    "Maintain and enhance existing applications with focus on performance and reliability"
                }
            },
            new WorkExperience
            {
                Company = "Freelance Software Development",
                Position = "Independent Developer",
                StartDate = "2015",
                EndDate = "Present",
                Responsibilities = new List<string>
                {
                    "Developed custom software solutions for small to medium businesses",
                    "Created database-driven applications using .NET technologies",
                    "Provided technical consulting and system architecture design",
                    "Delivered training and support for implemented solutions"
                }
            },
            new WorkExperience
            {
                Company = "Various Churches and Venues",
                Position = "Professional Pianist / Music Director",
                StartDate = "1985",
                EndDate = "Present",
                Responsibilities = new List<string>
                {
                    "Provide professional piano accompaniment for worship services and special events",
                    "Lead music ministries with focus on contemporary and traditional worship styles",
                    "Perform at weddings, corporate events, and private functions",
                    "Collaborate with vocalists and instrumentalists for live performances",
                    "Arrange and adapt music for various ensemble configurations"
                }
            }
        };
    }

    private MusicalJourney GetMusicalJourney()
    {
        return new MusicalJourney
        {
            Title = "My Musical Journey",
            Sections = new List<MusicalSection>
            {
                new MusicalSection
                {
                    SectionTitle = "Early Beginnings",
                    Content = "My love for music began at age 6 when I first touched the piano keys. What started as childhood curiosity quickly blossomed into a lifelong passion that would shape both my personal and professional journey.",
                    Order = 1
                },
                new MusicalSection
                {
                    SectionTitle = "Formal Training",
                    Content = "Through dedicated study and formal training, I developed a strong foundation in music theory, classical technique, and performance skills. This education provided the technical framework that supports my versatility across musical genres today.",
                    Order = 2
                },
                new MusicalSection
                {
                    SectionTitle = "Professional Performance",
                    Content = "For over three decades, I've had the privilege of sharing music professionally across diverse settings - from intimate wedding ceremonies to large church congregations, from corporate events to personal celebrations. Each performance teaches me something new about connecting with audiences through music.",
                    Order = 3
                },
                new MusicalSection
                {
                    SectionTitle = "Music and Technology",
                    Content = "My background in technology has enhanced my musical abilities, allowing me to integrate digital tools for recording, arrangement, and performance. This unique combination of technical and artistic skills helps me bridge traditional musicianship with modern possibilities.",
                    Order = 4
                },
                new MusicalSection
                {
                    SectionTitle = "Continuing the Journey",
                    Content = "Music remains a central part of who I am, continuing to inspire creativity in all aspects of my life. Whether accompanying a vocalist, leading a congregation, or simply playing for personal enjoyment, the piano continues to be my favorite form of expression and connection with others.",
                    Order = 5
                }
            }
        };
    }

    private List<NavigationSection> GetNavigationSections()
    {
        return new List<NavigationSection>
        {
            new NavigationSection
            {
                SectionId = "qualifications",
                DisplayName = "Qualifications",
                Order = 1,
                IsMobileVisible = true,
                Icon = "bi-award"
            },
            new NavigationSection
            {
                SectionId = "education",
                DisplayName = "Education",
                Order = 2,
                IsMobileVisible = true,
                Icon = "bi-mortarboard"
            },
            new NavigationSection
            {
                SectionId = "work-history",
                DisplayName = "Work History",
                Order = 3,
                IsMobileVisible = true,
                Icon = "bi-briefcase"
            },
            new NavigationSection
            {
                SectionId = "musical-journey",
                DisplayName = "Musical Journey",
                Order = 4,
                IsMobileVisible = true,
                Icon = "bi-music-note"
            }
        };
    }
}