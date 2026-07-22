# Code Murders — Project Plan

## Project Purpose

Code Murders is a story-driven software bug investigation game. The player
takes on the role of an investigator who must find the root cause of a bug
in a fictional software system by examining fake evidence: log entries,
Git commit history, and code snippets.

Beyond being a game, this project serves as a learning project for:
- ASP.NET Core MVC and C#
- Entity Framework Core and SQL Server
- Git and GitHub workflows
- AI-assisted software development practices

## Language and Content Standards

- All communication between the developer and the assistant is in Turkish.
- All plans, explanations, file changes, actions taken, and error
  descriptions are communicated in Turkish.
- The project itself (code and content) is entirely in English:
  - UI text, menus, buttons, case descriptions, tasks, and result messages
    are in English.
  - Class, entity, property, method, variable, controller, and view names
    are in English.
  - Logs, exception messages, commit messages, and code snippets are in
    English.
  - README and project documentation are in English.
- English content should be clear, simple, and suitable for an
  international portfolio project.

## Development Phases

**Phase 0 — Foundation**
- Clean ASP.NET Core MVC project skeleton (no EF Core, no SQL Server, no
  extra packages yet).
- Git repository setup and initial commit.

**Phase 1 — Static Case Display**
- Introduce EF Core and SQL Server.
- Create initial data model (Case, LogEntry, CommitEntry, CommitChange,
  CodeFile, AnswerOption).
- Seed data for the first case.
- Read-only pages: case detail, log list, commit history, code viewer.

**Phase 2 — Playability**
- Answer submission mechanism (AnswerOption selection).
- Result screen showing correct/incorrect outcome with explanation.

**Phase 3 — Content Expansion**
- Add employee messages (testimonies).
- Add fake database record browsing.
- Add additional cases (2-3 total).

**Phase 4 — User Experience**
- Basic player identity/session (no full authentication required).
- Progress tracking across cases.
- Visual polish with Bootstrap (log console style, code highlighting).

**Phase 5 — Optional Depth**
- Hint system, difficulty levels, branching suspects/outcomes.

## MVP Scope

See MVP_SCOPE.md for full details.

## First Case Summary

**Title:** "The Midnight Order Service Crash"

At 02:14 AM, the order creation service in a fictional e-commerce system
starts throwing repeated exceptions. Logs show a `NullReferenceException`,
but the exact cause is unclear. The player must review log entries, the
recent commit history, and the affected code file to identify the commit
that introduced the bug.

## First Case Solution Logic

The root cause is a removed null check in the order validation code. A
recent commit, framed as a "simplification" of the validation logic,
deletes the null check on the shipping address before order creation.
Orders created after this commit fail with a null reference exception
when the shipping address is missing.

The player must identify the correct commit (and/or code change) as the
cause of the bug by cross-referencing:
- The timestamp of the first failing log entry.
- The commit history around that timestamp.
- The code diff that removed the null check.

Other commits in the case act as red herrings (e.g., unrelated caching
changes, unrelated styling fixes).

## Initial Data Model

- **Case** — represents a single investigable bug scenario.
- **LogEntry** — a single log line belonging to a Case.
- **CommitEntry** — a single commit belonging to a Case.
- **CommitChange** — a file-level change belonging to a CommitEntry.
- **CodeFile** — the current state of a code file belonging to a Case.
- **AnswerOption** — a selectable answer (suspect commit/change) belonging
  to a Case, with a flag indicating correctness and an explanation.

Detailed relationships will be defined when EF Core is introduced in
Phase 1.

## Technical Decisions and Limitations

- Technology stack: ASP.NET Core MVC, C#, Entity Framework Core, SQL
  Server, Bootstrap, Git/GitHub.
- No authentication, user accounts, or player progress tracking in the
  MVP.
- No real Git repository simulation — commit data is stored as plain
  database records, not actual Git objects.
- No real-time features (e.g., SignalR) in the MVP.
- No procedural or AI-generated case content — all cases are hand-written.
- The first implementation step will only create a clean, working
  ASP.NET Core MVC project skeleton, with no EF Core, SQL Server,
  migrations, or additional packages installed at that stage.
