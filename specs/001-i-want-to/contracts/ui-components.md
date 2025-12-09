# UI Component Contracts

**Date**: 2025-10-12  
**Feature**: Personal Resume Website  
**Purpose**: Define interface contracts for UI components and interactions

## Page Structure Contract

### Main Layout Interface

```typescript
interface MainLayout {
  header: HeaderComponent;
  navigation: NavigationComponent;
  content: ContentSection[];
  theme: ThemeConfiguration;
}

interface HeaderComponent {
  title: string; // "Joseph R. Pottschmidt"
  subtitle?: string; // Professional title
  themeToggle: ThemeToggleComponent;
}

interface ThemeToggleComponent {
  currentTheme: "light" | "dark";
  position: "header"; // Per specification
  onToggle: (theme: "light" | "dark") => void;
  ariaLabel: string;
}
```

### Navigation Contract

```typescript
interface NavigationComponent {
  desktop: DesktopNavigation;
  mobile: MobileNavigation;
  activeSection: string;
  onSectionChange: (sectionId: string) => void;
}

interface DesktopNavigation {
  type: "horizontal-bar";
  position: "sticky-top";
  items: NavigationItem[];
}

interface MobileNavigation {
  type: "bottom-tabs"; // Per specification clarification
  position: "fixed-bottom";
  items: NavigationItem[];
  iconSupport: boolean;
}

interface NavigationItem {
  id: string; // HTML anchor
  label: string; // Display text
  order: number; // Display order
  isActive: boolean; // Current section
  onClick: () => void; // Smooth scroll action
}
```

## Content Section Contracts

### Professional Profile Contract

```typescript
interface ProfessionalProfileSection {
  id: "professional-profile";
  title: "Contact Information";
  headshot: HeadshotComponent;
  contact: ContactInformation;
  summary?: string;
}

interface HeadshotComponent {
  imagePath?: string; // Optional path to professional photo
  altText: string; // "Joseph R. Pottschmidt - Professional Headshot"
  placeholderText: string; // "Professional Photo"
  showPlaceholder: boolean; // Display placeholder when no image
  imageTitle?: string; // Tooltip text
  
  styling: {
    shape: "circular";
    sizes: {
      desktop: "200px";
      tablet: "150px";
      mobile: "120px";
    };
    border: "4px solid primary-color";
    shadow: "elevated";
    hoverEffect: "subtle-lift";
  };
}

interface ContactInformation {
  name: "Joseph R. Pottschmidt";
  phone: "(360) 831-7131";
  email: "joe@joepottschmidt.com";
  address: {
    street: "308 SW 1st. St Apt #3";
    city: "Battle Ground";
    state: "WA";
    zip: "98604";
  };
  website: "https://www.joepottschmidt.com";
}
```

### Qualifications Contract

```typescript
interface QualificationsSection {
  id: "qualifications";
  title: "Qualifications";
  qualifications: QualificationItem[];
}

interface QualificationItem {
  category: string; // e.g., "Microsoft Office"
  skills: string[]; // e.g., ["Access", "Excel", "Word"]
  experience: string; // e.g., "25+ years"
  description?: string;
}
```

### Education Contract

```typescript
interface EducationSection {
  id: "education";
  title: "Education";
  education: EducationItem[];
}

interface EducationItem {
  institution: string;
  degree: string;
  year: string;
  location?: string;
  details?: string[];
}
```

### Work History Contract

```typescript
interface WorkHistorySection {
  id: "work-history";
  title: "Work History";
  positions: WorkExperience[];
}

interface WorkExperience {
  company: string;
  position: string;
  startDate: string;
  endDate: string; // "Present" for current
  responsibilities: string[];
  location?: string;
}
```

### Musical Journey Contract

```typescript
interface MusicalJourneySection {
  id: "musical-journey";
  title: "My Musical Journey";
  sections: MusicalSection[];
  isPersonalContent: true;
}

interface MusicalSection {
  title: string; // e.g., "Early Beginnings"
  content: string; // Narrative text
  order: number;
}
```

## Interaction Contracts

### Smooth Scrolling Contract

```typescript
interface SmoothScrollBehavior {
  trigger: "navigation-click" | "anchor-link";
  duration: "1s"; // Per success criteria
  easing: "ease-in-out";
  updateNavigation: boolean; // Highlight active section
  fallback: "instant"; // For browsers without smooth scroll
}

interface SectionObserver {
  method: "IntersectionObserver";
  threshold: 0.5; // 50% of section visible
  onSectionChange: (sectionId: string) => void;
  rootMargin: "0px 0px -50% 0px"; // Account for navigation height
}
```

### Theme Toggle Contract

```typescript
interface ThemeToggleContract {
  storageKey: "resume-theme-preference";
  defaultTheme: "light"; // Per specification
  persistence: "localStorage";
  transitionDuration: "0.3s";
  
  methods: {
    getCurrentTheme(): "light" | "dark";
    setTheme(theme: "light" | "dark"): void;
    toggleTheme(): void;
    persistPreference(theme: "light" | "dark"): void;
  };
  
  domImplementation: {
    attribute: "data-bs-theme"; // Bootstrap 5.x standard
    targetElement: "html"; // Document root
    buttonSelector: ".theme-toggle";
  };
}
```

### Responsive Behavior Contract

```typescript
interface ResponsiveContract {
  breakpoints: {
    mobile: "max-width: 767px";
    tablet: "768px - 991px";
    desktop: "min-width: 992px";
  };
  
  navigationBehavior: {
    mobile: "bottom-tabs";
    tablet: "horizontal-bar";
    desktop: "horizontal-bar";
  };
  
  contentLayout: {
    mobile: "single-column";
    tablet: "single-column-wider";
    desktop: "single-column-max-width";
  };
}
```

## Performance Contracts

### Loading Contract

```typescript
interface PerformanceContract {
  pageLoadTime: "< 3s"; // Per success criteria
  themeToggleResponse: "< 0.5s"; // Per success criteria
  scrollToSectionTime: "< 1s"; // Per success criteria
  lighthouseScore: "> 90"; // Per success criteria
  
  optimization: {
    images: "WebP with fallback";
    css: "minified + CDN";
    javascript: "< 50KB total"; // Per constitution
    fonts: "preload critical";
  };
}
```

### Accessibility Contract

```typescript
interface AccessibilityContract {
  standard: "WCAG 2.1 AA"; // Per constitution
  
  requirements: {
    semanticHTML: true;
    keyboardNavigation: true;
    screenReaderSupport: true;
    colorContrastRatio: "> 4.5:1";
    focusManagement: true;
    skipLinks: true;
  };
  
  implementation: {
    headingHierarchy: "h1 -> h2 -> h3 (logical)";
    altTexts: "all images";
    ariaLabels: "interactive elements";
    landmarks: "main, nav, aside, footer";
  };
}
```

## Static Generation Contract

### Build Output Contract

```typescript
interface StaticOutputContract {
  structure: {
    "/index.html": "Main resume page";
    "/css/": "Minified stylesheets";
    "/js/": "Minimal JavaScript";
    "/images/": "Optimized assets";
    "/favicon.ico": "Site icon";
  };
  
  requirements: {
    relativeUrls: true;
    noServerDependencies: true;
    cdnCompatible: true;
    cacheHeaders: "appropriate";
  };
  
  deployment: {
    githubPages: "supported";
    netlify: "supported";
    vercel: "supported";
    customDomain: "configurable";
  };
}
```
