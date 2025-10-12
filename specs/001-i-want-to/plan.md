# Implementation Plan: Personal Resume Website

**Branch**: `001-i-want-to` | **Date**: 2025-10-12 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/001-i-want-to/spec.md`

**Note**: This template is filled in by the `/speckit.plan` command. See `.specify/templates/commands/plan.md` for the execution workflow.

## Summary

Create a professional single-page resume website for Joseph R. Pottschmidt that displays his qualifications, education, work history, and musical journey. The site will be built as a static ASP.NET Core application with Bootstrap styling, featuring smooth-scrolling navigation, light/dark theme toggle, and full responsive design. The technical approach leverages static site generation for optimal performance and hosting flexibility while maintaining modern UX standards.

## Technical Context

<!--
  ACTION REQUIRED: Replace the content in this section with the technical details
  for the project. The structure here is presented in advisory capacity to guide
  the iteration process.
-->

**Language/Version**: ASP.NET Core (latest LTS version)  
**Primary Dependencies**: Bootstrap 5.x, Razor Pages/Views  
**Storage**: Static files only (no databases)  
**Testing**: ASP.NET Core Test Framework  
**Target Platform**: Static site hosting (GitHub Pages, Netlify, CDN)
**Project Type**: Static site - determines source structure  
**Performance Goals**: <2s load time, 90+ Lighthouse score, <50KB JS bundle  
**Constraints**: No JavaScript frameworks, minimal custom CSS, static generation only  
**Scale/Scope**: Personal resume site with professional presentation

### Constitution Violations
<!-- Fill ONLY if Constitution Check has violations that must be justified -->

**Initial Check (Pre-Research):**

- [x] **Static Site Architecture**: ✅ Implementation uses static generation with ASP.NET Core and static file output
- [x] **Bootstrap-First Design**: ✅ Bootstrap 5.x is primary UI framework with minimal custom CSS as specified
- [x] **JavaScript Minimalism**: ✅ Minimal JavaScript usage limited to theme toggle and smooth scrolling
- [x] **ASP.NET Core Foundation**: ✅ ASP.NET Core with Razor Pages for static generation confirmed
- [x] **Performance Standards**: ✅ Targets <2s load time, 90+ Lighthouse score, <50KB JS bundle aligned
- [x] **Accessibility Standards**: ✅ WCAG 2.1 AA compliance plan and semantic HTML structure included
- [x] **Technology Compliance**: ✅ No prohibited technologies used (no JS frameworks, dynamic CMS, etc.)

**Post-Design Validation:**

- [x] **Static Site Architecture**: ✅ CONFIRMED - ASP.NET Core configured for static file generation, no server-side processing
- [x] **Bootstrap-First Design**: ✅ CONFIRMED - Bootstrap 5.3.x via CDN, minimal custom CSS in site.css only
- [x] **JavaScript Minimalism**: ✅ CONFIRMED - Only theme toggle (~20 lines) and scroll behavior, <50KB total
- [x] **ASP.NET Core Foundation**: ✅ CONFIRMED - Razor Pages with static publishing, no dynamic rendering
- [x] **Performance Standards**: ✅ CONFIRMED - Optimized assets, CDN delivery, performance budget enforced
- [x] **Accessibility Standards**: ✅ CONFIRMED - Semantic HTML, ARIA labels, keyboard navigation, contrast ratios
- [x] **Technology Compliance**: ✅ CONFIRMED - Pure Bootstrap/CSS/minimal JS, no frameworks or prohibited tech

### Gate Status: ✅ ALL CHECKS PASSED - Ready for implementation

## Project Structure

### Documentation (this feature)

```text
specs/[###-feature]/
├── plan.md              # This file (/speckit.plan command output)
├── research.md          # Phase 0 output (/speckit.plan command)
├── data-model.md        # Phase 1 output (/speckit.plan command)
├── quickstart.md        # Phase 1 output (/speckit.plan command)
├── contracts/           # Phase 1 output (/speckit.plan command)
└── tasks.md             # Phase 2 output (/speckit.tasks command - NOT created by /speckit.plan)
```

### Source Code (repository root)
<!--
  ACTION REQUIRED: Replace the placeholder tree below with the concrete layout
  for this feature. Delete unused options and expand the chosen structure with
  real paths (e.g., apps/admin, packages/something). The delivered plan must
  not include Option labels.
-->

```text
# ASP.NET Core Static Site Structure
├── Pages/               # Razor Pages for content generation
├── Views/               # Razor Views (if using MVC)
├── wwwroot/            # Static assets output
│   ├── css/            # Bootstrap + custom CSS
│   ├── js/             # Minimal JavaScript (if any)
│   └── images/         # Optimized images
├── Models/             # Data models for content
├── Services/           # Content generation services
├── Program.cs          # Application entry point
└── appsettings.json    # Configuration

tests/
├── Unit/               # Unit tests for services/models
├── Integration/        # Integration tests for page generation
└── Performance/        # Performance and accessibility tests
```

**Structure Decision**: ASP.NET Core static site structure selected for Joe's Resume Site.
This provides strong typing, excellent tooling, and static generation capabilities while
maintaining simplicity and performance requirements outlined in the constitution.

## Complexity Tracking

<!-- Fill ONLY if Constitution Check has violations that must be justified -->

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| [e.g., 4th project] | [current need] | [why 3 projects insufficient] |
| [e.g., Repository pattern] | [specific problem] | [why direct DB access insufficient] |
