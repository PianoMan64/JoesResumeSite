<!--
Sync Impact Report:
- Version change: new → 1.0.0
- Modified principles: N/A (initial creation)
- Added sections: All sections (initial creation)
- Removed sections: N/A
- Templates requiring updates: ✅ plan-template.md, ✅ spec-template.md, ✅ tasks-template.md
- Follow-up TODOs: Ratification date needs to be confirmed by project stakeholders
-->

# Joe's Resume Site Constitution

## Core Principles

### I. Static Site Architecture

The website MUST be implemented as a static site that generates pre-rendered HTML pages.
All content MUST be compile-time generated without requiring server-side processing for
content delivery. This ensures maximum performance, security, and deployment flexibility.

**Rationale**: Static sites provide better performance, enhanced security, simplified
deployment, and reduced hosting costs while meeting all requirements for a resume website.

### II. Bootstrap-First Design

All UI components and styling MUST use Bootstrap framework as the primary design system.
Custom CSS MUST be minimal and only used for specific branding requirements that cannot
be achieved through Bootstrap's utility classes and components.

**Rationale**: Bootstrap provides a consistent, responsive, and professional design
foundation that reduces development time and ensures cross-browser compatibility.

### III. JavaScript Minimalism

JavaScript usage MUST be avoided unless absolutely necessary for core functionality.
When JavaScript is required, it MUST be clearly justified, well-documented, and
implemented with progressive enhancement principles. No JavaScript frameworks or
SPAs are permitted.

**Rationale**: Minimal JavaScript ensures fast loading times, better SEO, improved
accessibility, and aligns with static site principles.

### IV. ASP.NET Core Foundation

The site MUST be built using ASP.NET Core as the underlying framework, utilizing
Razor Pages or MVC for static content generation. The framework MUST be configured
for static site generation rather than dynamic server-side rendering.

**Rationale**: ASP.NET Core provides robust tooling, strong typing, and excellent
performance while supporting static site generation patterns.

## Technology Stack Requirements

### Mandatory Technologies

- **Framework**: ASP.NET Core (latest LTS version)
- **UI Framework**: Bootstrap 5.x
- **Templating**: Razor Pages or Razor Views
- **Build Tool**: .NET CLI with static site generation
- **Styling**: Bootstrap utilities with minimal custom CSS

### Prohibited Technologies

- JavaScript frameworks (React, Vue, Angular, etc.)
- Client-side routing libraries
- Heavy JavaScript libraries (unless justified)
- Server-side databases for content storage
- Dynamic content management systems

### Deployment Requirements

- Static files only (HTML, CSS, JS, images)
- CDN-friendly asset structure
- No server-side runtime dependencies
- Support for GitHub Pages, Netlify, or similar static hosts

## Development Standards

### Performance Standards

- Page load time MUST be under 2 seconds on 3G connections
- Lighthouse Performance score MUST be 90+
- Total JavaScript bundle MUST be under 50KB (if any)
- Images MUST be optimized and properly sized

### Accessibility Standards

- MUST meet WCAG 2.1 AA compliance
- Semantic HTML structure required
- Proper heading hierarchy enforced
- Alt text required for all images
- Keyboard navigation support mandatory

### SEO Requirements

- Proper meta tags on all pages
- Structured data markup where applicable
- Clean, semantic URL structure
- Sitemap generation
- OpenGraph and Twitter Card support

## Governance

This constitution supersedes all other development practices and technical decisions.
All code reviews MUST verify compliance with these principles. Any deviation requires
explicit justification and documented approval.

### Amendment Process

Constitutional amendments require:

1. Written proposal with rationale
2. Impact assessment on existing codebase
3. Migration plan for breaking changes
4. Unanimous agreement from all contributors

### Compliance Review

All pull requests MUST include a constitution compliance checklist. Performance
and accessibility audits MUST be conducted before any major releases.

**Version**: 1.0.0 | **Ratified**: TODO(RATIFICATION_DATE): needs stakeholder confirmation | **Last Amended**: 2025-10-12