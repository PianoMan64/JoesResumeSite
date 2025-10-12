# Research: Personal Resume Website

**Date**: 2025-10-12  
**Feature**: Personal Resume Website  
**Purpose**: Resolve technical decisions and validate implementation approaches

## ASP.NET Core Static Site Generation

**Decision**: Use ASP.NET Core with static site generation for resume website

**Rationale**: 
- ASP.NET Core provides robust development experience with strong typing
- Static site generation aligns with constitution requirements for performance and hosting
- Razor Pages/Views offer excellent templating for structured content
- Built-in development server supports rapid iteration
- Publish to static files enables deployment to any static hosting platform

**Alternatives considered**:
- Pure HTML/CSS: Rejected due to maintenance complexity and lack of templating
- Jekyll/Hugo: Rejected to maintain .NET ecosystem consistency per constitution
- Blazor WASM: Rejected due to JavaScript framework restriction in constitution

**Implementation approach**: Configure ASP.NET Core for static file generation using custom middleware or build process

## Bootstrap 5.x Integration Strategy

**Decision**: Use Bootstrap 5.3.x with minimal custom CSS for styling

**Rationale**:
- Latest stable Bootstrap version provides modern components and utilities
- Extensive responsive grid system handles mobile requirements
- Built-in dark mode support simplifies theme toggle implementation
- Large ecosystem of professional themes and components
- Excellent documentation and community support

**Alternatives considered**:
- Tailwind CSS: Rejected to maintain Bootstrap-first constitution principle
- Custom CSS framework: Rejected due to development time and maintenance overhead
- Material Design: Rejected due to complexity and framework dependencies

**Implementation approach**: Include Bootstrap via CDN for optimal performance, use data-bs-theme attribute for theme switching

## Theme Toggle Implementation

**Decision**: Use CSS custom properties with Bootstrap's built-in dark mode support

**Rationale**:
- Bootstrap 5.3+ includes native dark mode with data-bs-theme attribute
- CSS custom properties provide smooth transitions between themes
- localStorage preserves user preference across sessions
- Minimal JavaScript required (aligns with constitution)
- Accessible implementation with proper ARIA labels

**Alternatives considered**:
- CSS class switching: More complex implementation without Bootstrap benefits
- Separate stylesheets: Increases bundle size and loading complexity
- JavaScript theme framework: Violates constitution's JavaScript minimalism principle

**Implementation approach**: Toggle data-bs-theme attribute on document root, store preference in localStorage

## Smooth Scrolling Navigation

**Decision**: Use CSS scroll-behavior with JavaScript enhancement for section highlighting

**Rationale**:
- CSS scroll-behavior provides native smooth scrolling in modern browsers
- JavaScript enhancement adds active section highlighting without heavy frameworks
- Intersection Observer API efficiently tracks section visibility
- Progressive enhancement ensures functionality without JavaScript
- Minimal code footprint aligns with performance targets

**Alternatives considered**:
- Pure CSS-only: Limited functionality for active section highlighting
- jQuery/animation library: Violates JavaScript minimalism principle
- Manual scroll calculation: Complex implementation with browser compatibility issues

**Implementation approach**: CSS scroll-behavior property with Intersection Observer for active states

## Mobile Navigation Strategy

**Decision**: Implement bottom tab navigation for mobile devices using Bootstrap components

**Rationale**:
- Bottom navigation provides thumb-friendly access on mobile devices
- Bootstrap nav components provide responsive foundation
- Sticky positioning ensures always-visible navigation
- Consistent with mobile app conventions for improved UX
- Accessibility support through proper ARIA implementation

**Alternatives considered**:
- Hamburger menu: Standard but requires additional clicks for access
- Horizontal scroll menu: Poor UX on small screens with limited real estate
- Floating action button: Unconventional for resume sites

**Implementation approach**: Bootstrap fixed-bottom nav with custom CSS for mobile media queries

## Performance Optimization Strategy

**Decision**: Implement comprehensive performance optimization for <2s load time target

**Rationale**:
- Image optimization reduces largest contentful paint
- CSS/JS minification decreases transfer size
- Bootstrap CDN provides global edge caching
- Static generation eliminates server processing time
- Lighthouse metrics validation ensures measurable performance

**Techniques to implement**:
- WebP image format with fallbacks
- CSS and JavaScript minification
- Bootstrap CDN with integrity hashes
- Preload critical resources
- Optimize font loading strategies

**Implementation approach**: Build pipeline with optimization tools, performance budget enforcement

## Accessibility Implementation

**Decision**: Implement WCAG 2.1 AA compliance through semantic HTML and Bootstrap accessibility features

**Rationale**:
- Semantic HTML provides screen reader compatibility
- Bootstrap components include built-in accessibility features
- Color contrast ratios meet AA standards in both themes
- Keyboard navigation support ensures inclusive access
- Skip links improve navigation efficiency

**Implementation approach**:
- Semantic HTML5 structure with proper heading hierarchy
- ARIA labels for interactive elements
- Focus management for theme toggle and navigation
- Color contrast validation for both light and dark themes
- Screen reader testing during development

## Static Hosting Strategy

**Decision**: Configure for multiple static hosting platforms (GitHub Pages, Netlify, Vercel)

**Rationale**:
- Multiple deployment options provide flexibility
- Static files work universally across hosting platforms
- CDN distribution improves global performance
- Cost-effective hosting for personal resume site
- Easy domain configuration and SSL support

**Implementation approach**: Generate clean static files with relative paths, include deployment configurations for major platforms
