# Implementation Tasks: Personal Resume Website

**Prerequisites**: Specification and implementation plan completed
**Organization**: Tasks are grouped by user story to enable independent implementation and testing

## Task Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3, US4)
- Include exact file paths in descriptions

## Path Conventions

- **ASP.NET Core Static Site**: `Pages/`, `Views/`, `wwwroot/`, `Models/`, `Services/` at repository root
- **Tests**: `tests/Unit/`, `tests/Integration/`, `tests/Performance/`

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [ ] T001 Create ASP.NET Core web project with static site generation configuration in repository root
- [ ] T002 [P] Add Bootstrap 5.3.x CDN integration to layout template in Views/Shared/_Layout.cshtml
- [ ] T003 [P] Configure wwwroot structure with css/, js/, and images/ directories for static assets
- [ ] T004 [P] Setup project for static file publishing with proper build configuration in JoeResumeWebsite.csproj
- [ ] T005 Create base Models/ResumeData.cs with static data structures for all content entities

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [ ] T006 Create Views/Shared/_Layout.cshtml with Bootstrap 5.x integration, semantic HTML structure, and theme toggle placement
- [ ] T007 [P] Implement Models/ProfessionalProfile.cs with complete contact information (phone, email, address, website)
- [ ] T008 [P] Implement Models/Qualification.cs with category, skills array, and years experience properties
- [ ] T009 [P] Implement Models/WorkExperience.cs with company, position, dates, and responsibilities array
- [ ] T010 [P] Implement Models/Education.cs with institution, degree, year, and location properties
- [ ] T011 [P] Implement Models/MusicalJourney.cs with sections array and narrative content structure
- [ ] T012 [P] Create Models/NavigationSection.cs with section IDs, display names, and mobile navigation configuration
- [ ] T013 Create wwwroot/css/site.css with minimal custom CSS and CSS variables for theme support
- [ ] T014 [P] Create wwwroot/js/theme-toggle.js with localStorage persistence and Bootstrap data-bs-theme attribute management
- [ ] T015 [P] Create wwwroot/js/smooth-scroll.js with Intersection Observer for active section highlighting
- [ ] T016 Setup Services/ResumeContentService.cs to populate all data models with Joe's resume content from Resume.md and My Musical Journey.md source files

**Checkpoint**: Foundation ready - user story implementation can now begin in parallel

---

## Phase 3: User Story 1 - Core Resume Viewing (Priority: P1) 🎯 MVP

**Goal**: Display Joe's complete professional information including qualifications, work history, and education in a clean, readable format

**Independent Test**: Visit website URL and verify all resume content (qualifications, work history, education) displays clearly on desktop and mobile

### Implementation for User Story 1

- [ ] T017 [P] [US1] Create Pages/Index.cshtml.cs PageModel with ResumeContentService injection and data binding
- [ ] T018 [US1] Implement Pages/Index.cshtml with complete resume layout using Bootstrap components and semantic HTML structure
- [ ] T019 [US1] Add professional profile section display with Joe's complete contact information (phone, email, address, website) in header area
- [ ] T020 [US1] Add qualifications section with category-based skill groupings and experience years display
- [ ] T021 [US1] Add education section with institution, degree, and graduation year in chronological format
- [ ] T022 [US1] Add work history section with company, position, dates, and detailed responsibilities in reverse chronological order
- [ ] T023 [US1] Add musical journey section with narrative content and subsection organization
- [ ] T024 [US1] Apply Bootstrap responsive grid system and typography for optimal readability across device sizes
- [ ] T025 [US1] Add proper heading hierarchy (h1-h6) and semantic structure for accessibility and SEO

**Checkpoint**: At this point, User Story 1 should be fully functional and testable independently

---

## Phase 4: User Story 2 - Section Navigation (Priority: P2)

**Goal**: Provide smooth-scrolling navigation links that jump to specific sections with visual indication of current section

**Independent Test**: Click navigation links and verify smooth scrolling to correct sections with active section highlighting in navigation

### Implementation for User Story 2

- [ ] T026 [P] [US2] Create Views/Shared/_Navigation.cshtml partial with desktop horizontal navigation using Bootstrap nav components
- [ ] T027 [P] [US2] Add section anchor IDs (#qualifications, #education, #work-history, #musical-journey) to all content sections
- [ ] T028 [US2] Integrate smooth scrolling JavaScript with CSS scroll-behavior property and fallback support
- [ ] T029 [US2] Implement Intersection Observer API in wwwroot/js/smooth-scroll.js for active section detection
- [ ] T030 [US2] Add active state styling to navigation items with Bootstrap active classes
- [ ] T031 [US2] Configure navigation to sticky-top positioning for persistent access during scrolling
- [ ] T032 [US2] Test navigation functionality across all sections with proper active state transitions

**Checkpoint**: At this point, User Stories 1 AND 2 should both work independently

---

## Phase 5: User Story 3 - Mobile Experience (Priority: P2)

**Goal**: Ensure optimal mobile experience with bottom tab navigation and responsive layout adjustments

**Independent Test**: Access site on mobile devices and verify layout, readability, and bottom navigation tabs work smoothly

### Implementation for User Story 3

- [ ] T033 [P] [US3] Create Views/Shared/_MobileNavigation.cshtml partial with fixed-bottom Bootstrap nav tabs
- [ ] T034 [P] [US3] Add responsive navigation switching logic in _Layout.cshtml to show mobile nav on small screens
- [ ] T035 [US3] Configure mobile navigation with touch-friendly spacing and icon support for each section
- [ ] T036 [US3] Add mobile-specific CSS in wwwroot/css/site.css with proper media queries for responsive behavior
- [ ] T037 [US3] Optimize content layout for mobile with single-column Bootstrap grid and appropriate font sizing
- [ ] T038 [US3] Test mobile navigation functionality with touch gestures and bottom tab accessibility
- [ ] T039 [US3] Ensure all content sections remain readable without horizontal scrolling on 320px+ screen widths

**Checkpoint**: At this point, User Stories 1, 2, AND 3 should all work independently across devices

---

## Phase 6: User Story 4 - Theme Customization (Priority: P3)

**Goal**: Allow users to switch between light and dark themes with preference persistence

**Independent Test**: Toggle theme switch and verify all content maintains readability and visual appeal in both light and dark modes

### Implementation for User Story 4

- [ ] T040 [P] [US4] Create theme toggle button component in Views/Shared/_ThemeToggle.cshtml with proper ARIA labels
- [ ] T041 [P] [US4] Implement theme toggle JavaScript functionality in wwwroot/js/theme-toggle.js with Bootstrap data-bs-theme support
- [ ] T042 [US4] Add theme toggle to header navigation area with accessible button styling and icon support
- [ ] T043 [US4] Configure localStorage persistence for theme preference with "resume-theme-preference" key
- [ ] T044 [US4] Set default light theme and implement smooth transitions between theme states
- [ ] T045 [US4] Test color contrast ratios in both themes to ensure WCAG 2.1 AA compliance
- [ ] T046 [US4] Validate theme persistence across browser sessions and page reloads

**Checkpoint**: All user stories should now be independently functional with complete theme support

---

## Phase 7: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect multiple user stories

- [ ] T047 [P] Add favicon.ico and optimize meta tags for SEO in _Layout.cshtml head section
- [ ] T048 [P] Implement image optimization with WebP format and fallbacks for any profile or section images
- [ ] T049 [P] Add performance optimization with CSS and JavaScript minification in build pipeline
- [ ] T050 [P] Configure static site publishing with proper caching headers, relative URL support, and CDN-compatible asset structure
- [ ] T051 [P] Add structured data markup (JSON-LD) for improved SEO and search engine understanding
- [ ] T052 [P] Implement skip links for improved keyboard navigation accessibility
- [ ] T053 Validate complete site against Lighthouse performance, accessibility (90+ score), and SEO benchmarks with automated testing
- [ ] T054 Test deployment to static hosting platforms (GitHub Pages, Netlify) with custom domain support
- [ ] T055 Run final validation against quickstart.md scenarios and success criteria checklist

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational (CRITICAL - blocks all stories)
3. Complete Phase 3: User Story 1
4. **STOP and VALIDATE**: Test User Story 1 independently
5. Deploy/demo if ready

### Incremental Delivery

1. Complete Setup + Foundational → Foundation ready
2. Add User Story 1 → Test independently → Deploy/Demo (MVP!)
3. Add User Story 2 → Test independently → Deploy/Demo  
4. Add User Story 3 → Test independently → Deploy/Demo
5. Add User Story 4 → Test independently → Deploy/Demo
6. Each story adds value without breaking previous stories

### Parallel Team Strategy

With multiple developers:

1. Team completes Setup + Foundational together
2. Once Foundational is done:
   - Developer A: User Story 1 (Core Resume Viewing)
   - Developer B: User Story 2 (Section Navigation)
   - Developer C: User Story 3 (Mobile Experience)
   - Developer D: User Story 4 (Theme Customization)
3. Stories complete and integrate independently

---

## Notes

- **Total Tasks**: 55 tasks (T001-T055)
- **16 parallel tasks** marked with [P] for concurrent execution
- Each user story should be independently completable and testable
- Focus on constitution compliance: static generation, Bootstrap-first, JavaScript minimalism
- Ensure WCAG 2.1 AA accessibility standards throughout implementation