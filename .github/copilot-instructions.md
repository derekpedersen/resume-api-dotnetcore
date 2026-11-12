# GitHub Copilot instructions

This repository is a small ASP.NET Core resume API. The root `AGENTS.md` file is the canonical project contract for repo-wide guidance.

## Repo-specific guidance

- Keep the app and tests aligned with the existing .NET project structure under `api/` and `tests/`.
- Use the commands in the root `Makefile` as the source of truth for validation and build flow.
- Prefer targeted, repo-appropriate changes; avoid unrelated refactors.

## Validation commands

Run these from the repository root:

- `make test`
- `make build`
- `make docker` when validating container behavior

## Important note

If a rule or workflow is not obvious here, follow the conventions in the root `AGENTS.md` and the existing project docs before making changes.
