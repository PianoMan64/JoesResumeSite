# Quickstart Guide: Personal Resume Website

**Date**: 2025-10-12  
**Feature**: Personal Resume Website  
**Purpose**: Step-by-step guide for development and deployment

## Prerequisites

### Development Environment

- **.NET 8.0 LTS** or later
- **Visual Studio 2022** or **VS Code** with C# extension
- **Node.js** (for Bootstrap/CSS tooling)
- **Git** for version control

### Knowledge Requirements

- Basic ASP.NET Core development
- HTML/CSS fundamentals
- Bootstrap 5.x framework
- Basic JavaScript (minimal usage)

## Initial Setup

### 1. Create ASP.NET Core Project

```bash
# Create new ASP.NET Core project
dotnet new web -n JoeResumeWebsite
cd JoeResumeWebsite

# Add necessary packages
dotnet add package Microsoft.AspNetCore.StaticFiles
```

### 2. Configure for Static Site Generation

```csharp
// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure pipeline for static generation
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapFallbackToPage("/Index");

app.Run();
```

### 3. Project Structure Setup

```
JoeResumeWebsite/
├── Pages/
│   ├── Index.cshtml              # Main resume page
│   ├── Index.cshtml.cs           # Page model
│   └── Shared/
│       ├── _Layout.cshtml        # Base layout
│       └── _ViewImports.cshtml   # Global imports
├── wwwroot/
│   ├── css/
│   │   └── site.css              # Custom styles
│   ├── js/
│   │   └── site.js               # Minimal JavaScript
│   └── images/                   # Assets
├── Models/
│   ├── ResumeData.cs             # Content models
│   └── ThemeConfig.cs            # Theme configuration
└── Services/
    └── ContentService.cs         # Content organization
```

## Development Workflow

### Step 1: Setup Bootstrap Integration

**In _Layout.cshtml:**

```html
<!DOCTYPE html>
<html lang="en" data-bs-theme="light">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Joseph R. Pottschmidt - Resume</title>
    
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" 
          rel="stylesheet" 
          integrity="sha384-..." 
          crossorigin="anonymous">
    
    <!-- Custom CSS -->
    <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
</head>
<body>
    @RenderBody()
    
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" 
            integrity="sha384-..." 
            crossorigin="anonymous"></script>
    
    <!-- Custom JS -->
    <script src="~/js/site.js" asp-append-version="true"></script>
</body>
</html>
```

### Step 2: Create Content Models

**Models/ResumeData.cs:**

```csharp
public class ResumeData
{
    public ProfessionalProfile Profile { get; set; }
    public List<Qualification> Qualifications { get; set; }
    public List<Education> Education { get; set; }
    public List<WorkExperience> WorkHistory { get; set; }
    public MusicalJourney MusicalJourney { get; set; }
}

public class ProfessionalProfile
{
    public string Name => "Joseph R. Pottschmidt";
    public string Phone => "(360) 831-7131";
    public string Email => "joe@joepottschmidt.com";
    public string Website => "https://www.joepottschmidt.com";
    public Address Address { get; set; }
}

// Additional model classes...
```

### Step 3: Build Main Resume Page

**Pages/Index.cshtml:**

```html
@page
@model IndexModel
@{
    ViewData["Title"] = "Joseph R. Pottschmidt - Resume";
}

<!-- Header with Navigation -->
<header class="sticky-top bg-light border-bottom">
    <nav class="navbar navbar-expand-lg">
        <div class="container">
            <span class="navbar-brand h1">@Model.ResumeData.Profile.Name</span>
            
            <!-- Theme Toggle -->
            <button class="btn btn-outline-secondary theme-toggle" 
                    type="button" 
                    aria-label="Toggle theme">
                <i class="bi bi-sun-fill" id="theme-icon"></i>
            </button>
            
            <!-- Desktop Navigation -->
            <div class="navbar-nav ms-auto d-none d-md-flex">
                <a class="nav-link" href="#qualifications">Qualifications</a>
                <a class="nav-link" href="#education">Education</a>
                <a class="nav-link" href="#work-history">Work History</a>
                <a class="nav-link" href="#musical-journey">Musical Journey</a>
            </div>
        </div>
    </nav>
</header>

<!-- Main Content -->
<main class="container my-4">
    <!-- Professional Profile Section -->
    <section id="professional-profile" class="mb-5">
        <div class="row">
            <div class="col-md-8">
                <h1>@Model.ResumeData.Profile.Name</h1>
                <!-- Contact information display -->
            </div>
        </div>
    </section>
    
    <!-- Additional sections... -->
</main>

<!-- Mobile Bottom Navigation -->
<nav class="navbar fixed-bottom bg-light border-top d-md-none">
    <div class="container-fluid">
        <div class="row w-100 text-center">
            <div class="col-3">
                <a href="#qualifications" class="nav-link">
                    <i class="bi bi-award"></i>
                    <small class="d-block">Skills</small>
                </a>
            </div>
            <!-- Additional mobile nav items... -->
        </div>
    </div>
</nav>
```

### Step 4: Implement Theme Toggle

**wwwroot/js/site.js:**

```javascript
// Theme management
const THEME_STORAGE_KEY = 'resume-theme-preference';
const DEFAULT_THEME = 'light';

function getCurrentTheme() {
    return localStorage.getItem(THEME_STORAGE_KEY) || DEFAULT_THEME;
}

function setTheme(theme) {
    document.documentElement.setAttribute('data-bs-theme', theme);
    localStorage.setItem(THEME_STORAGE_KEY, theme);
    updateThemeIcon(theme);
}

function toggleTheme() {
    const currentTheme = getCurrentTheme();
    const newTheme = currentTheme === 'light' ? 'dark' : 'light';
    setTheme(newTheme);
}

// Initialize theme on page load
document.addEventListener('DOMContentLoaded', function() {
    setTheme(getCurrentTheme());
    
    // Theme toggle button
    const themeToggle = document.querySelector('.theme-toggle');
    if (themeToggle) {
        themeToggle.addEventListener('click', toggleTheme);
    }
});
```

### Step 5: Add Smooth Scrolling

**wwwroot/css/site.css:**

```css
/* Smooth scrolling */
html {
    scroll-behavior: smooth;
}

/* Navigation styles */
.navbar-nav .nav-link.active {
    color: var(--bs-primary) !important;
    font-weight: 600;
}

/* Mobile navigation */
@media (max-width: 767px) {
    body {
        padding-bottom: 80px; /* Account for fixed bottom nav */
    }
    
    .fixed-bottom .nav-link {
        padding: 0.5rem;
        font-size: 0.875rem;
    }
}

/* Theme transition */
* {
    transition: background-color 0.3s ease, color 0.3s ease, border-color 0.3s ease;
}
```

## Testing Checklist

### Functional Testing

- [ ] **Page Load**: All content renders correctly
- [ ] **Navigation**: Smooth scrolling to all sections works
- [ ] **Theme Toggle**: Light/dark theme switching functions
- [ ] **Mobile**: Bottom navigation works on mobile devices
- [ ] **Responsive**: Layout adapts to different screen sizes
- [ ] **Performance**: Page loads under 3 seconds

### Accessibility Testing

- [ ] **Keyboard Navigation**: All interactive elements accessible via keyboard
- [ ] **Screen Reader**: Content properly announced by screen readers
- [ ] **Color Contrast**: Both themes meet WCAG 2.1 AA standards
- [ ] **Semantic HTML**: Proper heading hierarchy and landmarks
- [ ] **Focus Management**: Clear focus indicators throughout

### Cross-Browser Testing

- [ ] **Chrome**: All features work correctly
- [ ] **Firefox**: Smooth scrolling and theme toggle functional
- [ ] **Safari**: iOS compatibility verified
- [ ] **Edge**: Theme persistence works

## Static Site Generation

### Build for Production

```bash
# Build optimized version
dotnet publish -c Release -o ./publish

# The publish folder contains static files ready for deployment
```

### Deployment Options

#### GitHub Pages

```bash
# Copy publish/wwwroot contents to gh-pages branch
# Configure GitHub Pages to serve from gh-pages branch
```

#### Netlify

```bash
# Connect GitHub repository to Netlify
# Set build command: dotnet publish -c Release
# Set publish directory: publish/wwwroot
```

#### Custom Server

```bash
# Copy contents of publish/wwwroot to web server
# Configure server to serve static files
# Set up HTTPS and appropriate caching headers
```

## Performance Optimization

### Image Optimization

- Use WebP format with fallbacks
- Optimize images for different screen densities
- Implement lazy loading for below-the-fold content

### CSS/JS Optimization

- Minify custom CSS and JavaScript
- Use Bootstrap CDN for optimal caching
- Implement critical CSS inlining

### Monitoring

- Use Lighthouse for performance auditing
- Set up Core Web Vitals monitoring
- Test on various devices and connection speeds

## Troubleshooting

### Common Issues

**Theme not persisting**: Check localStorage support and correct storage key
**Smooth scrolling not working**: Verify CSS `scroll-behavior` support
**Mobile navigation issues**: Check Bootstrap responsive utilities
**Performance problems**: Audit assets and optimize images

### Debug Tools

- Browser Developer Tools
- Lighthouse performance audits
- WAVE accessibility checker
- Bootstrap documentation and examples
