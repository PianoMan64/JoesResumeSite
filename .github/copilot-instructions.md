# Joe's Resume Site Development Guidelines

Auto-generated from all feature plans. Last updated: 2025-10-12

## Active Technologies
- ASP.NET Core (latest LTS version) + Bootstrap 5.x, Razor Pages/Views (001-i-want-to)

## Project Structure
```
src/
tests/
```

## Commands
# Add commands for ASP.NET Core (latest LTS version)

## Code Style
ASP.NET Core (latest LTS version): Follow standard conventions

## Recent Changes (October 2025)
- 001-i-want-to: Added ASP.NET Core (latest LTS version) + Bootstrap 5.x, Razor Pages/Views
- Enhanced Navigation: Improved hamburger menu with 1200px breakpoint for better responsive behavior
- Card Layout Optimization: Implemented flexible grid system for perfect centering of odd-numbered cards (5 qualifications)
- Professional Polish: Added alternating section backgrounds, Inter font family, enhanced spacing
- Network Access: Configured cross-device testing capabilities
- Scroll Features: Added scroll-to-top button with smooth animations
- Theme Enhancement: Dual theme toggle system (mobile + desktop) with synchronized state
- Musical Journey: Combined multiple cards into single cohesive narrative
- Visual Hierarchy: Professional headshot display with responsive sizing and fallback

## Current Features
- Professional single-page resume layout with responsive design
- Smooth-scrolling navigation with hamburger menu (activates <1200px)
- Light/dark theme toggle with localStorage persistence
- Professional headshot with circular styling and placeholder support
- Scroll-to-top functionality appearing after 300px scroll
- Enhanced card layout system with perfect centering for odd items
- Alternating section backgrounds (gray/white pattern)
- Cross-device network access for testing and demonstration
- Professional spacing with 0.75rem gaps between navigation elements
- Touch-friendly mobile interface with improved accessibility

## Technical Details
- ASP.NET Core 8.0 LTS static site generation
- Bootstrap 5.3.x via CDN with minimal custom CSS (773+ lines)
- Inter font family via Google Fonts
- Custom CSS properties for theming
- Minimal JavaScript for theme toggle and smooth scrolling
- Flexbox-based card layout system for responsive behavior
- Network profiles for cross-device access (port 5209)

<!-- MANUAL ADDITIONS START -->
## Manual Configuration Changes
- Workspace Settings: GitLens disabled via workspace configuration (`gitlens.enabled: false`)
- Build Configuration: Solution-based build process using `Joe's Resume Site.sln`

## Manual Content Updates (ResumeContentService.cs)
- **Professional Profile**: Added headshot configuration with placeholder support
- **.NET Development Skills**: Expanded to include Visual Studio IDE, WinForms, LINQ, RESTful APIs, and Blazor
- **Database Technologies**: Added Oracle and Entity Framework to skill set
- **Professional Music Skills**: Added "Singer" to capabilities
- **Freelance Work**: Updated end date from "2019" to "Present" (ongoing work)
<!-- MANUAL ADDITIONS END -->