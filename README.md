# Joseph R. Pottschmidt - Resume Website

A professional, responsive resume website built with ASP.NET Core and Bootstrap 5, featuring modern design elements and enhanced user experience.

## 🌟 Features

### Core Functionality
- **Single-page responsive layout** with smooth-scrolling navigation
- **Professional sections**: Qualifications, Education, Work History, Musical Journey
- **Light/Dark theme toggle** with persistent preferences
- **Professional headshot display** with elegant circular styling
- **Scroll-to-top button** for improved navigation
- **Mobile-optimized hamburger menu** that activates at 1200px breakpoint

### Recent Enhancements (October 2025)
- **Enhanced Navigation**: Improved hamburger menu with better spacing and responsive behavior
- **Card Layout Optimization**: Centered card layouts for odd-numbered items (5 qualification cards)
- **Visual Polish**: Alternating section backgrounds with enhanced contrast
- **Network Access**: Configured for cross-device testing on local network
- **Professional Styling**: Inter font family, custom CSS properties, and refined spacing

## 🚀 Quick Start

### Prerequisites
- .NET 8.0 LTS SDK
- Modern web browser
- Visual Studio Code or Visual Studio 2022

### Running the Application

```powershell
# Clone and navigate to project
cd "i:\Projects\Joe's Resume Site"

# Restore dependencies
dotnet restore

# Run locally
dotnet run

# Run for network access (cross-device testing)
dotnet run --launch-profile http-network
```

The site will be available at:
- **Local**: http://localhost:5209
- **Network**: http://0.0.0.0:5209 (for cross-device testing)

## 📱 Responsive Design

### Breakpoints
- **Mobile**: < 768px (stacked cards, bottom navigation)
- **Tablet**: 768px - 1199px (2-column cards, hamburger menu)
- **Desktop**: ≥ 1200px (full navigation, optimized layout)

### Navigation Behavior
- **Desktop (≥1200px)**: Horizontal navigation with pill-style links
- **Mobile/Tablet (<1200px)**: Hamburger menu with collapsible navigation
- **Spacing**: Enhanced padding (0.75rem 1.25rem) with 0.75rem gaps between elements

## 🎨 Design System

### Color Scheme
- **Light Theme**: Clean whites and subtle grays (#e9ecef for alternating sections)
- **Dark Theme**: Professional dark palette with blue accents
- **Primary Color**: #2563eb (professional blue)
- **Accent Colors**: Consistent throughout with proper contrast ratios

### Typography
- **Primary Font**: Inter (Google Fonts)
- **Fallback**: System font stack
- **Hierarchy**: Professional sizing with clear visual hierarchy

### Section Backgrounds
Alternating pattern for visual organization:
1. **Hero Section**: Gray background
2. **Qualifications**: Gray background (updated from white)
3. **Education**: White background
4. **Work History**: Gray background
5. **Musical Journey**: White background

## 🔧 Technical Architecture

### Project Structure

```text
├── Pages/
│   ├── Index.cshtml          # Main resume page
│   └── Shared/
│       └── _Layout.cshtml    # Layout with navigation
├── Services/
│   └── ResumeContentService.cs  # Resume data service
├── Models/
│   └── ResumeData.cs        # Data models
├── wwwroot/
│   ├── css/site.css         # Custom styles (773+ lines)
│   ├── js/site.js           # Theme toggle & navigation
│   └── images/              # Headshot and assets
└── Properties/
    └── launchSettings.json  # Network access configuration
```

### Key Features Implementation

#### Flexible Card Layout
- **CSS Flexbox**: Custom `.qualifications-grid` for perfect centering
- **Responsive Cards**: 5 qualification cards with automatic centering for odd items
- **Equal Heights**: All cards in a row match the tallest card's height

#### Enhanced Navigation
- **Hamburger Menu**: Bootstrap collapse with custom styling
- **Theme Toggle**: Dual buttons (mobile + desktop) with synchronized state
- **Smooth Scrolling**: JavaScript-powered section navigation
- **Active States**: Dynamic highlighting of current section

#### Professional Headshot
- **Responsive Sizing**: 200px desktop, 150px tablet, 120px mobile
- **Fallback Support**: Professional placeholder when no image available
- **Elegant Styling**: Circular frame with subtle hover effects

## 📊 Performance Metrics

### Lighthouse Targets
- **Performance**: 90+ score
- **Accessibility**: 90+ score (WCAG 2.1 AA compliance)
- **Load Time**: <2 seconds on 3G connections
- **JavaScript Bundle**: <50KB total

### Optimization Features
- **Static Generation**: ASP.NET Core static site
- **CDN Assets**: Bootstrap and fonts via CDN
- **Minimal JavaScript**: Theme toggle and smooth scrolling only
- **Optimized Images**: Responsive image sizing

## 🌐 Network Configuration

### Development Access

For cross-device testing, use the network launch profiles:

```bash
# HTTP access (recommended for development)
dotnet run --launch-profile http-network

# HTTPS access (requires certificate setup)
dotnet run --launch-profile https-network
```

### Launch Profile Configuration

```json
{
  "http-network": {
    "commandName": "Project",
    "dotnetRunMessages": true,
    "applicationUrl": "http://0.0.0.0:5209"
  },
  "https-network": {
    "commandName": "Project", 
    "dotnetRunMessages": true,
    "applicationUrl": "https://0.0.0.0:7079"
  }
}
```

Access from other devices on your network using your computer's IP address:
- **Primary**: `http://10.0.0.85:5209`
- **Alternative addresses**: Check `ipconfig` for your machine's IP

## 🎯 Professional Information

### Contact Details

- **Name**: Joseph R. Pottschmidt
- **Title**: Software Developer & Professional Musician
- **Phone**: (360) 831-7131
- **Email**: <joe@joepottschmidt.com>
- **Address**: 308 SW 1st. St Apt #3, Battle Ground, WA 98604
- **Website**: <https://www.joepottschmidt.com>

### Core Qualifications
- **Microsoft Office** (25+ years): Advanced proficiency across all applications
- **.NET Development** (15 years): C#, VB.NET, ASP.NET, Web Forms, MVC, WPF
- **Database Technologies** (15 years): SQL Server, SSRS, T-SQL, Performance Optimization
- **Business Intelligence** (8 years): Power BI, Data Visualization, Dashboard Development
- **Professional Music** (35+ years): Piano Performance, Music Theory, Live Performance

## 🎵 Unique Aspects

This resume showcases the unique combination of technical expertise and musical artistry that defines Joseph's professional identity. The **Musical Journey** section highlights three decades of professional piano performance, demonstrating creativity, discipline, and the ability to connect with audiences—skills that translate directly to software development and client relationships.

## 🛠 Recent Updates Log

### October 16, 2025

- ✅ **Navigation Enhancement**: Improved hamburger menu spacing and responsive behavior
- ✅ **Card Layout Fix**: Implemented flexible grid for perfect centering of odd-numbered cards
- ✅ **Section Backgrounds**: Updated qualifications section to gray background for consistency
- ✅ **Musical Journey**: Combined multiple cards into single cohesive narrative card
- ✅ **Theme Toggle**: Enhanced with dual-button support (mobile/desktop) and synchronized state
- ✅ **Network Access**: Configured for cross-device testing and development
- ✅ **Visual Polish**: Enhanced spacing, typography, and professional presentation
- ✅ **Headshot Integration**: Added professional photo display with responsive sizing
- ✅ **Scroll-to-Top**: Implemented smooth scroll-to-top functionality

## 📄 License

This project is a personal resume website for Joseph R. Pottschmidt. The code structure and styling approach may be used as reference, but personal content remains proprietary.

---

*Built with ❤️ using ASP.NET Core 8.0 LTS, Bootstrap 5.3.x, and attention to modern web standards.*