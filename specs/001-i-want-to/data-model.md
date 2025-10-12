# Data Model: Personal Resume Website

**Date**: 2025-10-12  
**Feature**: Personal Resume Website  
**Purpose**: Define data structures and entities for resume content

## Content Entities

### Professional Profile

**Purpose**: Core identity and contact information

**Properties**:
- `Name`: string (required) - Full professional name "Joseph R. Pottschmidt"
- `Title`: string (optional) - Professional title/position
- `Phone`: string (required) - "(360) 831-7131"
- `Email`: string (required) - "joe@joepottschmidt.com"  
- `Address`: Address (required) - Full postal address
- `Website`: string (required) - "https://www.joepottschmidt.com"
- `Summary`: string (optional) - Professional summary/bio

**Address Sub-entity**:
- `Street`: string - "308 SW 1st. St Apt #3"
- `City`: string - "Battle Ground"  
- `State`: string - "WA"
- `ZipCode`: string - "98604"

**Validation Rules**:
- Email must be valid format
- Phone must be valid US format
- Website must be valid URL
- All contact fields are required for complete professional presentation

### Qualification

**Purpose**: Individual skill or expertise area

**Properties**:
- `Category`: string (required) - Technology domain (e.g., "Microsoft Office", ".NET Development")
- `Skills`: string[] (required) - Specific skills within category
- `YearsExperience`: string (required) - Experience duration (e.g., "25+ years", "15 years")
- `Description`: string (optional) - Additional context about expertise

**Validation Rules**:
- At least one skill required per qualification
- Years experience must be specified
- Categories should be unique

**Sample Data Structure**:
```
- Category: "Microsoft Office", Skills: ["Access", "Excel", "Outlook", "Word", "PowerPoint", "Visio"], Years: "25+ years"
- Category: ".NET Development", Skills: ["C#", "VB.NET", "Windows Services", "ASP.NET Web Forms", "ASP.NET MVC", "WPF"], Years: "15 years"
```

### Work Experience

**Purpose**: Employment history entry

**Properties**:
- `Company`: string (required) - Employer name
- `Position`: string (required) - Job title
- `StartDate`: string (required) - Start date (format: "MM/YYYY" or "MM/DD/YYYY")
- `EndDate`: string (required) - End date or "Present"
- `Responsibilities`: string[] (required) - List of job responsibilities and achievements
- `Location`: string (optional) - Work location if relevant

**Validation Rules**:
- Company and position are required
- Start date must be before end date (except "Present")
- At least one responsibility required
- Chronological ordering (most recent first)

**Sample Data Structure**:
```
- Company: "Panther Systems Northwest, LLC", Position: "Software Developer / Report Designer"
  StartDate: "1/1/2020", EndDate: "Present"
  Responsibilities: ["Design and develop reports using SSRS", "Design and develop reports using Power BI", ...]
```

### Education

**Purpose**: Academic background and certifications

**Properties**:
- `Institution`: string (required) - School/organization name
- `Degree`: string (required) - Degree type and field
- `Year`: string (required) - Graduation year or completion date
- `Location`: string (optional) - Institution location
- `Details`: string[] (optional) - Additional details or honors

**Validation Rules**:
- Institution and degree are required
- Year must be valid date format

**Sample Data Structure**:
```
- Institution: "ITT Technical Institute", Degree: "AA in Electronic Engineering Technology", Year: "1986"
```

### Musical Journey Section

**Purpose**: Personal narrative about musical background

**Properties**:
- `Title`: string (required) - Section title "My Musical Journey"
- `Sections`: MusicalSection[] (required) - Chronological sections of musical story
- `IsPersonalSection`: boolean - true (distinguishes from professional content)

**MusicalSection Sub-entity**:
- `SectionTitle`: string (required) - Subsection title (e.g., "Early Beginnings")
- `Content`: string (required) - Narrative content
- `Order`: number (required) - Display order

**Validation Rules**:
- At least one section required
- Sections must have unique titles
- Order must be sequential

### Navigation Section

**Purpose**: Site navigation configuration

**Properties**:
- `SectionId`: string (required) - HTML anchor ID
- `DisplayName`: string (required) - User-visible label
- `Order`: number (required) - Navigation order
- `IsMobileVisible`: boolean (required) - Show in mobile bottom navigation
- `Icon`: string (optional) - Icon class for mobile navigation

**Validation Rules**:
- Section IDs must be unique and valid HTML anchors
- Order must be sequential
- Display names should be concise for mobile

**Navigation Structure**:
```
1. Qualifications (#qualifications)
2. Education (#education)  
3. Work History (#work-history)
4. Musical Journey (#musical-journey)
```

### Theme Configuration

**Purpose**: User interface theme settings

**Properties**:
- `CurrentTheme`: string (required) - "light" | "dark"
- `DefaultTheme`: string (required) - "light" (per specification)
- `StorageKey`: string (required) - "resume-theme-preference"
- `ThemeToggleLocation`: string (required) - "header"

**Validation Rules**:
- Theme values must be "light" or "dark"
- Storage key must be valid localStorage key format

## Data Relationships

### Content Hierarchy
```
Professional Profile (1:1 with site)
├── Qualifications (1:many)
├── Education (1:many) 
├── Work Experience (1:many)
└── Musical Journey (1:1)
    └── Musical Sections (1:many)
```

### Navigation Mapping
```
Navigation Sections → Content Sections (1:1 mapping)
Theme Configuration → Global UI State (1:1)
```

## Data Sources

### Static Content Files
- Resume data: From Resume.md attachment
- Musical journey: From My Musical Journey.md attachment  
- Contact info: From Contact Info.md attachment

### Runtime Data
- Theme preference: Browser localStorage
- Active section: Calculated from scroll position
- Navigation state: Derived from current section

## Content Management Strategy

**Approach**: Static data embedded in Razor models during build time

**Benefits**:
- No runtime database dependencies
- Type-safe content access
- Easy version control of content changes
- Fast loading with pre-generated HTML

**Content Update Process**:
1. Modify source data in models/constants
2. Rebuild static site
3. Deploy updated static files
4. No database migrations or runtime updates needed
