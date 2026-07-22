# Code Murders — MVP Scope

## Purpose of This Document

This document defines the exact boundaries of the first playable version
(MVP) of Code Murders, so development stays focused and small.

## MVP Scope

The MVP includes exactly one playable case, "The Midnight Order Service
Crash," and the following pages/features:

- **Case Detail** — shows the case title, story description, and links to
  the available evidence.
- **Log List** — displays the fake log entries for the case.
- **Commit History** — displays the list of commits for the case, with
  author, message, timestamp, and changed files.
- **Commit/Code Detail** — displays the code changes (diff-like view) and
  the current state of the affected code file.
- **Answer Submission** — lets the player select which commit/change they
  believe caused the bug and submit their answer.
- **Result Screen** — shows whether the submitted answer was correct,
  along with an explanation of the actual root cause.

## Features Excluded From the MVP

The following are explicitly out of scope for the MVP and deferred to
later phases:

- Authentication, user accounts, or login.
- Player profile or progress tracking.
- Employee messages / testimonies.
- Fake database record browsing.
- Multiple cases (MVP has exactly one case).
- Hint system, difficulty levels, or branching outcomes.
- Real-time features (e.g., live log streaming via SignalR).
- Real Git repository simulation (actual `git log`/`git diff` execution).
- Procedural or AI-generated case content.
- Admin panel or case editor UI.

## First Case Summary

**Title:** "The Midnight Order Service Crash"

The order creation service starts failing at 02:14 AM with
`NullReferenceException` errors. The player investigates logs, commit
history, and code to find the cause.

## First Case Solution

The bug is caused by a commit that removed a null check on the shipping
address in the order validation code, framed as a "simplification." The
player must identify this commit as the correct answer. Other commits in
the case (e.g., an unrelated caching change, an unrelated styling fix)
serve as red herrings.

## Initial Data Model (Reference)

- Case
- LogEntry
- CommitEntry
- CommitChange
- CodeFile
- AnswerOption

Full schema and relationships will be defined during Phase 1, when EF
Core is introduced.

## Technical Decisions and Limitations for the MVP

- The first implementation step creates only a clean, working ASP.NET
  Core MVC project skeleton.
- No EF Core, SQL Server, migrations, or additional NuGet packages are
  installed at this stage.
- All case content (logs, commits, code) for the MVP can initially be
  hardcoded or provided via simple in-memory/seed data, since no database
  layer exists yet at the project-skeleton step.
- UI text and all project content are in English; all developer
  communication about this project is in Turkish.
